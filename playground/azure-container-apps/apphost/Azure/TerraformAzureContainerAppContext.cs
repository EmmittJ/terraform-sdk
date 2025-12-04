// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;
using Microsoft.Extensions.Logging;

namespace TerraformPlayground.AppHost.Azure;

/// <summary>
/// Context for the Terraform Azure Container App Environment that manages container app creation.
/// </summary>
internal sealed class TerraformAzureContainerAppEnvironmentContext(
    ILogger logger,
    DistributedApplicationExecutionContext executionContext,
    TerraformAzureContainerAppEnvironmentResource environment,
    IServiceProvider serviceProvider)
{
    private readonly Dictionary<IResource, TerraformAzureContainerAppContext> _containerApps = new();

    public ILogger Logger => logger;
    public DistributedApplicationExecutionContext ExecutionContext => executionContext;
    public TerraformAzureContainerAppEnvironmentResource Environment => environment;
    public IServiceProvider ServiceProvider => serviceProvider;

    public TerraformAzureContainerAppContext GetContainerAppContext(IResource resource)
    {
        if (!_containerApps.TryGetValue(resource, out var context))
        {
            throw new InvalidOperationException($"Container app context not found for resource {resource.Name}.");
        }

        return context;
    }

    public async Task ProcessResourceAsync(IResource resource, CancellationToken cancellationToken)
    {
        if (!_containerApps.TryGetValue(resource, out var context))
        {
            _containerApps[resource] = context = new TerraformAzureContainerAppContext(resource, this);
            await context.ProcessResourceAsync(cancellationToken).ConfigureAwait(false);
        }

        // Add customization annotation that builds the container app
        // The TerraformInfrastructure subscriber will create the TerraformProvisioningResource
        resource.Annotations.Add(new TerraformCustomizationAnnotation(infra =>
        {
            context.BuildContainerApp(infra);
        }));
    }
}

/// <summary>
/// Simple resolved endpoint info for container apps.
/// </summary>
internal sealed record ResolvedEndpointInfo(
    EndpointAnnotation Endpoint,
    int? TargetPort,
    int? ExposedPort);

/// <summary>
/// Context for building a single container app from an Aspire resource.
/// Extends <see cref="TerraformComputeResourceContext"/> for common processing functionality.
/// </summary>
internal sealed class TerraformAzureContainerAppContext : TerraformComputeResourceContext
{
    private readonly TerraformAzureContainerAppEnvironmentContext _environmentContext;

    // Endpoint state after processing
    private (int? Port, bool Http2, bool External)? _httpIngress;
    private readonly List<int> _additionalPorts = [];

    private record struct EndpointMapping(string Scheme, string Host, int Port, int? TargetPort, bool IsHttpIngress, bool External);
    private readonly Dictionary<string, EndpointMapping> _endpointMapping = [];

    public TerraformAzureContainerAppContext(IResource resource, TerraformAzureContainerAppEnvironmentContext environmentContext)
        : base(resource, environmentContext.ExecutionContext)
    {
        _environmentContext = environmentContext;
    }

    protected override void ProcessEndpoints()
    {
        // Get endpoints from the resource
        if (!Resource.TryGetEndpoints(out var endpoints))
        {
            return;
        }

        var endpointList = endpoints.ToList();
        if (endpointList.Count == 0)
        {
            return;
        }

        // Validate schemes using base class helper
        ValidateEndpointSchemes(endpointList, "http", "https", "tcp");

        // Resolve endpoint ports - simplified version
        var resolvedEndpoints = endpointList.Select(endpoint =>
        {
            var targetPort = endpoint.TargetPort ?? endpoint.Port ?? (Resource is ProjectResource ? 8080 : 80);
            var exposedPort = endpoint.Port ?? targetPort;
            return new ResolvedEndpointInfo(endpoint, targetPort, exposedPort);
        }).ToList();

        // Group resolved endpoints by target port (aka destinations)
        var endpointsByTargetPort = resolvedEndpoints
            .Select((resolved, index) => (resolved, index))
            .GroupBy(x => x.resolved.TargetPort)
            .Select(g => new
            {
                Port = g.Key,
                ResolvedEndpoints = g.Select(x => x.resolved).ToArray(),
                External = g.Any(x => x.resolved.Endpoint.IsExternal),
                IsHttpOnly = g.All(x => x.resolved.Endpoint.UriScheme is "http" or "https"),
                AnyH2 = g.Any(x => x.resolved.Endpoint.Transport is "http2"),
                UniqueSchemes = g.Select(x => x.resolved.Endpoint.UriScheme).Distinct().ToArray(),
                Index = g.Min(x => x.index)
            })
            .ToList();

        // Failure cases

        // Multiple external endpoints are not supported
        if (endpointsByTargetPort.Count(g => g.External) > 1)
        {
            throw new NotSupportedException("Multiple external endpoints are not supported");
        }

        // Any external non-http endpoints are not supported
        if (endpointsByTargetPort.Any(g => g.External && !g.IsHttpOnly))
        {
            throw new NotSupportedException("External non-HTTP(s) endpoints are not supported");
        }

        // Don't allow mixing http and tcp endpoints
        static bool Compatible(string[] schemes) =>
            schemes.All(s => s is "http" or "https") || schemes.All(s => s is "tcp");

        if (endpointsByTargetPort.Any(g => !Compatible(g.UniqueSchemes)))
        {
            throw new NotSupportedException("HTTP(s) and TCP endpoints cannot be mixed");
        }

        // Get all http only groups
        var httpOnlyEndpoints = endpointsByTargetPort.Where(g => g.IsHttpOnly).OrderBy(g => g.Index).ToArray();

        // Do we only have one?
        var httpIngress = httpOnlyEndpoints.Length == 1 ? httpOnlyEndpoints[0] : null;

        if (httpIngress is null)
        {
            // We have more than one, prefer external one
            var externalHttp = httpOnlyEndpoints.Where(g => g.External).ToArray();

            if (externalHttp.Length == 1)
            {
                httpIngress = externalHttp[0];
            }
            else if (httpOnlyEndpoints.Length > 0)
            {
                httpIngress = httpOnlyEndpoints[0];
            }
        }

        if (httpIngress is not null)
        {
            // Remove from list
            endpointsByTargetPort.Remove(httpIngress);

            var targetPort = httpIngress.Port ?? (Resource is ProjectResource ? 8080 : 80);

            _httpIngress = (targetPort, httpIngress.AnyH2, httpIngress.External);

            foreach (var resolved in httpIngress.ResolvedEndpoints)
            {
                var endpoint = resolved.Endpoint;

                if (endpoint.UriScheme is "http" && endpoint.Port is not null and not 80)
                {
                    throw new NotSupportedException($"The endpoint '{endpoint.Name}' is an http endpoint and must use port 80");
                }

                if (endpoint.UriScheme is "https" && endpoint.Port is not null and not 443)
                {
                    throw new NotSupportedException($"The endpoint '{endpoint.Name}' is an https endpoint and must use port 443");
                }

                // For the http ingress port is always 80 or 443
                var port = endpoint.UriScheme is "http" ? 80 : 443;

                _endpointMapping[endpoint.Name] = new(endpoint.UriScheme, NormalizedName, port, targetPort, true, httpIngress.External);
            }
        }

        if (endpointsByTargetPort.Count > 5)
        {
            _environmentContext.Logger.LogWarning("More than 5 additional ports are not supported. See https://learn.microsoft.com/azure/container-apps/ingress-overview#tcp for more details.");
        }

        foreach (var g in endpointsByTargetPort)
        {
            if (g.Port is null)
            {
                throw new NotSupportedException("Container port is required for all endpoints");
            }

            _additionalPorts.Add(g.Port.Value);

            foreach (var resolved in g.ResolvedEndpoints)
            {
                var endpoint = resolved.Endpoint;
                _endpointMapping[endpoint.Name] = new(endpoint.UriScheme, NormalizedName, resolved.ExposedPort ?? g.Port.Value, g.Port.Value, false, g.External);
            }
        }
    }

    public void BuildContainerApp(TerraformProvisioningResource infra)
    {

        // Get variables from the environment
        var containerEnvIdVar = infra.AddVariable("container_env_id");
        var managedIdentityIdVar = infra.AddVariable("managed_identity_id");
        var resourceGroupVar = infra.AddVariable("resource_group_name");
        var containerImageVar = infra.ContainerImage;
        var registryEndpointVar = infra.RegistryEndpoint;

        // Common tags
        var tags = new TerraformMap<string>
        {
            ["Environment"] = "Development",
            ["ManagedBy"] = "Aspire-Terraform"
        };

        // Build template first (required for AzurermContainerApp)
        var container = new AzurermContainerAppTemplateBlockContainerBlock
        {
            Name = NormalizedName,
            Image = containerImageVar.AsReference(),
            Cpu = 0.25,
            Memory = "0.5Gi"
        };

        // Add environment variables
        foreach (var (key, value) in EnvironmentVariables)
        {
            var envValue = ProcessEnvironmentValue(value, infra);

            container.Env ??= [];
            container.Env.Add(new AzurermContainerAppTemplateBlockContainerBlockEnvBlock
            {
                Name = key,
                Value = envValue
            });
        }

        // Set entrypoint if container resource (using base class helper)
        if (GetContainerEntrypoint() is { } entrypoint)
        {
            container.Command = [entrypoint];
        }

        // Add args - build list first, then assign (the property getter returns a new lazy list)
        if (Args.Count > 0)
        {
            var argsList = new TerraformList<string>();
            foreach (var arg in Args)
            {
                var argValue = ProcessEnvironmentValue(arg, infra);
                argsList.Add(argValue);
            }
            container.Args = argsList;
        }

        var template = new AzurermContainerAppTemplateBlock
        {
            MinReplicas = GetReplicaCount(),
            MaxReplicas = 3,
            Container = [container]
        };

        // Add scale rules
        template.HttpScaleRule =
        [
            new AzurermContainerAppTemplateBlockHttpScaleRuleBlock
            {
                Name = "http-scale",
                ConcurrentRequests = "100"
            }
        ];

        // Build container app with template
        var containerApp = new AzurermContainerApp(NormalizedName)
        {
            Name = NormalizedName,
            ResourceGroupName = resourceGroupVar.AsReference(),
            ContainerAppEnvironmentId = containerEnvIdVar.AsReference(),
            RevisionMode = "Single",
            Tags = tags,
            Template = [template],
            Identity =
            [
                new AzurermContainerAppIdentityBlock
                {
                    Type = "UserAssigned",
                    IdentityIds = [managedIdentityIdVar.AsReference()]
                }
            ],
            Registry =
            [
                new AzurermContainerAppRegistryBlock
                {
                    Server = registryEndpointVar.AsReference(),
                    Identity = managedIdentityIdVar.AsReference()
                }
            ]
        };

        // Add ingress if we have http endpoints
        if (_httpIngress is { } ingress)
        {
            containerApp.Ingress =
            [
                new AzurermContainerAppIngressBlock
                {
                    TargetPort = ingress.Port ?? 8080,
                    ExternalEnabled = ingress.External,
                    Transport = ingress.Http2 ? "http2" : "auto",
                    TrafficWeight =
                    [
                        new AzurermContainerAppIngressBlockTrafficWeightBlock
                        {
                            LatestRevision = true,
                            Percentage = 100
                        }
                    ]
                }
            ];
        }

        infra.Add(containerApp);

        // Apply customization annotations
        if (Resource.TryGetAnnotationsOfType<TerraformAzureContainerAppCustomizationAnnotation>(out var customizations))
        {
            foreach (var customization in customizations)
            {
                customization.Configure(infra, containerApp);
            }
        }

        // Add endpoint outputs
        foreach (var (endpointName, mapping) in _endpointMapping)
        {
            if (mapping.IsHttpIngress)
            {
                var fqdn = containerApp.Ingress.Index(0, m => m.Fqdn);
                var scheme = mapping.Scheme;
                infra.AddOutput($"{endpointName}{TerraformProvisioningResource.EndpointOutputNameSuffix}", Tf.Interpolate($"{scheme}://{fqdn}"));
            }
        }
    }

    /// <summary>
    /// Processes environment values, handling self-referencing endpoints locally
    /// and delegating external references to the SDK's <see cref="TerraformProvisioningResource.ResolveValueProvider"/>.
    /// </summary>
    private TerraformValue<string> ProcessEnvironmentValue(object value, TerraformProvisioningResource infra)
    {
        // Handle self-referencing endpoints locally (Azure-specific logic for _endpointMapping)
        if (TryResolveSelfEndpoint(value, out var resolved))
        {
            return resolved;
        }

        // Delegate everything else to SDK's resolver
        return infra.ResolveValueProvider(value);
    }

    /// <summary>
    /// Attempts to resolve a value as a self-referencing endpoint (endpoint on this resource).
    /// </summary>
    private bool TryResolveSelfEndpoint(object value, out TerraformValue<string> result)
    {
        result = default!;

        return value switch
        {
            EndpointReference ep when TryResolveSelfEndpointReference(ep, out result) => true,
            EndpointReferenceExpression epExpr when TryResolveSelfEndpointReferenceExpression(epExpr, out result) => true,
            _ => false
        };
    }

    private bool TryResolveSelfEndpointReference(EndpointReference ep, out TerraformValue<string> result)
    {
        result = default!;

        // Only handle self endpoints
        if (ep.Resource != Resource || !_endpointMapping.TryGetValue(ep.EndpointName, out var mapping) || !mapping.IsHttpIngress)
        {
            return false;
        }

        result = $"{mapping.Scheme}://{mapping.Host}";
        return true;
    }

    private bool TryResolveSelfEndpointReferenceExpression(EndpointReferenceExpression epExpr, out TerraformValue<string> result)
    {
        result = default!;
        var ep = epExpr.Endpoint;

        // Only handle self endpoints
        if (ep.Resource != Resource || !_endpointMapping.TryGetValue(ep.EndpointName, out var mapping))
        {
            return false;
        }

        result = epExpr.Property switch
        {
            EndpointProperty.Url => $"{mapping.Scheme}://{mapping.Host}:{mapping.Port}",
            EndpointProperty.Host or EndpointProperty.IPV4Host => mapping.Host,
            EndpointProperty.Port => mapping.Port.ToString(),
            EndpointProperty.TargetPort => mapping.TargetPort?.ToString() ?? "8080",
            EndpointProperty.Scheme => mapping.Scheme,
            _ => throw new NotSupportedException($"Endpoint property {epExpr.Property} is not supported")
        };
        return true;
    }
}
