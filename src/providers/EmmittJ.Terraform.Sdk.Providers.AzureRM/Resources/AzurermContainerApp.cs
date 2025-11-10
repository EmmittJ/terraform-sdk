using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dapr in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppDaprBlock : TerraformBlock
{
    /// <summary>
    /// The Dapr Application Identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    public TerraformProperty<double>? AppPort
    {
        set => SetProperty("app_port", value);
    }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    public TerraformProperty<string>? AppProtocol
    {
        set => SetProperty("app_protocol", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlock : TerraformBlock
{
    /// <summary>
    /// Should this ingress allow insecure connections?
    /// </summary>
    public TerraformProperty<bool>? AllowInsecureConnections
    {
        set => SetProperty("allow_insecure_connections", value);
    }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        set => SetProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public List<TerraformProperty<object>>? CustomDomain
    {
        set => SetProperty("custom_domain", value);
    }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    public TerraformProperty<double>? ExposedPort
    {
        set => SetProperty("exposed_port", value);
    }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    public TerraformProperty<bool>? ExternalEnabled
    {
        set => SetProperty("external_enabled", value);
    }

    /// <summary>
    /// The FQDN of the ingress.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        set => SetProperty("fqdn", value);
    }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    public required TerraformProperty<double> TargetPort
    {
        set => SetProperty("target_port", value);
    }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    public TerraformProperty<string>? Transport
    {
        set => SetProperty("transport", value);
    }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppRegistryBlock : TerraformBlock
{
    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    public TerraformProperty<string>? PasswordSecretName
    {
        set => SetProperty("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        set => SetProperty("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppSecretBlock : TerraformBlock
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of replicas for this container.
    /// </summary>
    public TerraformProperty<double>? MaxReplicas
    {
        set => SetProperty("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    public TerraformProperty<double>? MinReplicas
    {
        set => SetProperty("min_replicas", value);
    }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    public TerraformProperty<string>? RevisionSuffix
    {
        set => SetProperty("revision_suffix", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    public TerraformProperty<double>? TerminationGracePeriodSeconds
    {
        set => SetProperty("termination_grace_period_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_domain_verification_id");
        SetOutput("latest_revision_fqdn");
        SetOutput("latest_revision_name");
        SetOutput("location");
        SetOutput("outbound_ip_addresses");
        SetOutput("container_app_environment_id");
        SetOutput("id");
        SetOutput("max_inactive_revisions");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("revision_mode");
        SetOutput("tags");
        SetOutput("workload_profile_name");
    }

    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_app_environment_id");
        set => SetProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformProperty<double> MaxInactiveRevisions
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_inactive_revisions");
        set => SetProperty("max_inactive_revisions", value);
    }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    public required TerraformProperty<string> RevisionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("revision_mode");
        set => SetProperty("revision_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformProperty<string> WorkloadProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload_profile_name");
        set => SetProperty("workload_profile_name", value);
    }

    /// <summary>
    /// Block for dapr.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    public List<AzurermContainerAppDaprBlock>? Dapr
    {
        set => SetProperty("dapr", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerAppIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    public List<AzurermContainerAppIngressBlock>? Ingress
    {
        set => SetProperty("ingress", value);
    }

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerAppRegistryBlock>? Registry
    {
        set => SetProperty("registry", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppSecretBlock>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public List<AzurermContainerAppTemplateBlock>? Template
    {
        set => SetProperty("template", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    public TerraformExpression LatestRevisionFqdn => this["latest_revision_fqdn"];

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    public TerraformExpression LatestRevisionName => this["latest_revision_name"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

}
