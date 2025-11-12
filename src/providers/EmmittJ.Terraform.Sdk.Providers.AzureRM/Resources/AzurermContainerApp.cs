using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dapr in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppDaprBlock() : TerraformBlock("dapr")
{
    /// <summary>
    /// The Dapr Application Identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    [TerraformProperty("app_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AppPort { get; set; }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    [TerraformProperty("app_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AppProtocol { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppIngressBlock() : TerraformBlock("ingress")
{
    /// <summary>
    /// Should this ingress allow insecure connections?
    /// </summary>
    [TerraformProperty("allow_insecure_connections")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowInsecureConnections { get; set; }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertificateMode { get; set; }


    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    [TerraformProperty("exposed_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ExposedPort { get; set; }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    [TerraformProperty("external_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExternalEnabled { get; set; }


    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    [TerraformProperty("target_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TargetPort { get; set; }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    [TerraformProperty("transport")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Transport { get; set; }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppRegistryBlock() : TerraformBlock("registry")
{
    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [TerraformProperty("identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [TerraformProperty("password_secret_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformProperty("server")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public partial class AzurermContainerAppSecretBlock() : TerraformBlock("secret")
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformProperty("identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Identity { get; set; }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppTemplateBlock() : TerraformBlock("template")
{
    /// <summary>
    /// The maximum number of replicas for this container.
    /// </summary>
    [TerraformProperty("max_replicas")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxReplicas { get; set; }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    [TerraformProperty("min_replicas")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinReplicas { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    [TerraformProperty("revision_suffix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RevisionSuffix { get; set; }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [TerraformProperty("termination_grace_period_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TerminationGracePeriodSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerApp : TerraformResource
{
    public AzurermContainerApp(string name) : base("azurerm_container_app", name)
    {
    }

    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformProperty("max_inactive_revisions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxInactiveRevisions { get; set; }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    [TerraformProperty("revision_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RevisionMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformProperty("workload_profile_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkloadProfileName { get; set; }

    /// <summary>
    /// Block for dapr.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    [TerraformProperty("dapr")]
    public TerraformList<AzurermContainerAppDaprBlock> Dapr { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermContainerAppIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    [TerraformProperty("ingress")]
    public TerraformList<AzurermContainerAppIngressBlock> Ingress { get; set; } = new();

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("registry")]
    public TerraformList<AzurermContainerAppRegistryBlock> Registry { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("secret")]
    public TerraformSet<AzurermContainerAppSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformProperty("template")]
    public required TerraformList<AzurermContainerAppTemplateBlock> Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermContainerAppTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    [TerraformProperty("latest_revision_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestRevisionFqdn { get; }

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformProperty("latest_revision_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestRevisionName { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundIpAddresses { get; }

}
