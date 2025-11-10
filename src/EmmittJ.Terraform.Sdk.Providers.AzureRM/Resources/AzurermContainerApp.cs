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
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => WithProperty("app_id", value);
    }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    public TerraformProperty<double>? AppPort
    {
        get => GetProperty<TerraformProperty<double>>("app_port");
        set => WithProperty("app_port", value);
    }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    public TerraformProperty<string>? AppProtocol
    {
        get => GetProperty<TerraformProperty<string>>("app_protocol");
        set => WithProperty("app_protocol", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<bool>>("allow_insecure_connections");
        set => WithProperty("allow_insecure_connections", value);
    }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_mode");
        set => WithProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public List<TerraformProperty<object>>? CustomDomain
    {
        get => GetProperty<List<TerraformProperty<object>>>("custom_domain");
        set => WithProperty("custom_domain", value);
    }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    public TerraformProperty<double>? ExposedPort
    {
        get => GetProperty<TerraformProperty<double>>("exposed_port");
        set => WithProperty("exposed_port", value);
    }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    public TerraformProperty<bool>? ExternalEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("external_enabled");
        set => WithProperty("external_enabled", value);
    }

    /// <summary>
    /// The FQDN of the ingress.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        get => GetProperty<TerraformProperty<string>>("fqdn");
        set => WithProperty("fqdn", value);
    }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    public required TerraformProperty<double> TargetPort
    {
        get => GetProperty<TerraformProperty<double>>("target_port");
        set => WithProperty("target_port", value);
    }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    public TerraformProperty<string>? Transport
    {
        get => GetProperty<TerraformProperty<string>>("transport");
        set => WithProperty("transport", value);
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
        get => GetProperty<TerraformProperty<string>>("identity");
        set => WithProperty("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    public TerraformProperty<string>? PasswordSecretName
    {
        get => GetProperty<TerraformProperty<string>>("password_secret_name");
        set => WithProperty("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        get => GetProperty<TerraformProperty<string>>("server");
        set => WithProperty("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetProperty<TerraformProperty<string>>("identity");
        set => WithProperty("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<TerraformProperty<double>>("max_replicas");
        set => WithProperty("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    public TerraformProperty<double>? MinReplicas
    {
        get => GetProperty<TerraformProperty<double>>("min_replicas");
        set => WithProperty("min_replicas", value);
    }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    public TerraformProperty<string>? RevisionSuffix
    {
        get => GetProperty<TerraformProperty<string>>("revision_suffix");
        set => WithProperty("revision_suffix", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    public TerraformProperty<double>? TerminationGracePeriodSeconds
    {
        get => GetProperty<TerraformProperty<double>>("termination_grace_period_seconds");
        set => WithProperty("termination_grace_period_seconds", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_container_app resource.
/// </summary>
public class AzurermContainerApp : TerraformResource
{
    public AzurermContainerApp(string name) : base("azurerm_container_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("latest_revision_fqdn");
        this.DeclareOutput("latest_revision_name");
        this.DeclareOutput("location");
        this.DeclareOutput("outbound_ip_addresses");
    }

    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformProperty<double>? MaxInactiveRevisions
    {
        get => GetProperty<TerraformProperty<double>>("max_inactive_revisions");
        set => this.WithProperty("max_inactive_revisions", value);
    }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    public required TerraformProperty<string> RevisionMode
    {
        get => GetProperty<TerraformProperty<string>>("revision_mode");
        set => this.WithProperty("revision_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadProfileName
    {
        get => GetProperty<TerraformProperty<string>>("workload_profile_name");
        set => this.WithProperty("workload_profile_name", value);
    }

    /// <summary>
    /// Block for dapr.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    public List<AzurermContainerAppDaprBlock>? Dapr
    {
        get => GetProperty<List<AzurermContainerAppDaprBlock>>("dapr");
        set => this.WithProperty("dapr", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerAppIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerAppIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    public List<AzurermContainerAppIngressBlock>? Ingress
    {
        get => GetProperty<List<AzurermContainerAppIngressBlock>>("ingress");
        set => this.WithProperty("ingress", value);
    }

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerAppRegistryBlock>? Registry
    {
        get => GetProperty<List<AzurermContainerAppRegistryBlock>>("registry");
        set => this.WithProperty("registry", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppSecretBlock>? Secret
    {
        get => GetProperty<HashSet<AzurermContainerAppSecretBlock>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public List<AzurermContainerAppTemplateBlock>? Template
    {
        get => GetProperty<List<AzurermContainerAppTemplateBlock>>("template");
        set => this.WithProperty("template", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
