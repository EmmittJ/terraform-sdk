using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for dapr in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppDaprBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dapr";

    /// <summary>
    /// The Dapr Application Identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformArgument("app_id")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    [TerraformArgument("app_port")]
    public TerraformValue<double>? AppPort
    {
        get => new TerraformReference<double>(this, "app_port");
        set => SetArgument("app_port", value);
    }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    [TerraformArgument("app_protocol")]
    public TerraformValue<string>? AppProtocol
    {
        get => new TerraformReference<string>(this, "app_protocol");
        set => SetArgument("app_protocol", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress";

    /// <summary>
    /// Should this ingress allow insecure connections?
    /// </summary>
    [TerraformArgument("allow_insecure_connections")]
    public TerraformValue<bool>? AllowInsecureConnections
    {
        get => new TerraformReference<bool>(this, "allow_insecure_connections");
        set => SetArgument("allow_insecure_connections", value);
    }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    [TerraformArgument("client_certificate_mode")]
    public TerraformValue<string>? ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }


    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    [TerraformArgument("exposed_port")]
    public TerraformValue<double>? ExposedPort
    {
        get => new TerraformReference<double>(this, "exposed_port");
        set => SetArgument("exposed_port", value);
    }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    [TerraformArgument("external_enabled")]
    public TerraformValue<bool>? ExternalEnabled
    {
        get => new TerraformReference<bool>(this, "external_enabled");
        set => SetArgument("external_enabled", value);
    }


    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    [TerraformArgument("target_port")]
    public required TerraformValue<double> TargetPort
    {
        get => new TerraformReference<double>(this, "target_port");
        set => SetArgument("target_port", value);
    }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    [TerraformArgument("transport")]
    public TerraformValue<string>? Transport
    {
        get => new TerraformReference<string>(this, "transport");
        set => SetArgument("transport", value);
    }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry";

    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [TerraformArgument("password_secret_name")]
    public TerraformValue<string>? PasswordSecretName
    {
        get => new TerraformReference<string>(this, "password_secret_name");
        set => SetArgument("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformArgument("server")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    [TerraformArgument("username")]
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformArgument("value")]
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// The maximum number of replicas for this container.
    /// </summary>
    [TerraformArgument("max_replicas")]
    public TerraformValue<double>? MaxReplicas
    {
        get => new TerraformReference<double>(this, "max_replicas");
        set => SetArgument("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    [TerraformArgument("min_replicas")]
    public TerraformValue<double>? MinReplicas
    {
        get => new TerraformReference<double>(this, "min_replicas");
        set => SetArgument("min_replicas", value);
    }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    [TerraformArgument("revision_suffix")]
    public TerraformValue<string> RevisionSuffix
    {
        get => new TerraformReference<string>(this, "revision_suffix");
        set => SetArgument("revision_suffix", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [TerraformArgument("termination_grace_period_seconds")]
    public TerraformValue<double>? TerminationGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "termination_grace_period_seconds");
        set => SetArgument("termination_grace_period_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_container_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerApp : TerraformResource
{
    public AzurermContainerApp(string name) : base("azurerm_container_app", name)
    {
    }

    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformArgument("container_app_environment_id")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformArgument("max_inactive_revisions")]
    public TerraformValue<double>? MaxInactiveRevisions
    {
        get => new TerraformReference<double>(this, "max_inactive_revisions");
        set => SetArgument("max_inactive_revisions", value);
    }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    [TerraformArgument("revision_mode")]
    public required TerraformValue<string> RevisionMode
    {
        get => new TerraformReference<string>(this, "revision_mode");
        set => SetArgument("revision_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformArgument("workload_profile_name")]
    public TerraformValue<string>? WorkloadProfileName
    {
        get => new TerraformReference<string>(this, "workload_profile_name");
        set => SetArgument("workload_profile_name", value);
    }

    /// <summary>
    /// Block for dapr.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    [TerraformArgument("dapr")]
    public TerraformList<AzurermContainerAppDaprBlock> Dapr { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermContainerAppIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    [TerraformArgument("ingress")]
    public TerraformList<AzurermContainerAppIngressBlock> Ingress { get; set; } = new();

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("registry")]
    public TerraformList<AzurermContainerAppRegistryBlock> Registry { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("secret")]
    public TerraformSet<AzurermContainerAppSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformArgument("template")]
    public required TerraformList<AzurermContainerAppTemplateBlock> Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformArgument("custom_domain_verification_id")]
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    [TerraformArgument("latest_revision_fqdn")]
    public TerraformValue<string> LatestRevisionFqdn
    {
        get => new TerraformReference<string>(this, "latest_revision_fqdn");
    }

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformArgument("latest_revision_name")]
    public TerraformValue<string> LatestRevisionName
    {
        get => new TerraformReference<string>(this, "latest_revision_name");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("outbound_ip_addresses")]
    public TerraformList<string> OutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_addresses").ResolveNodes(ctx));
    }

}
