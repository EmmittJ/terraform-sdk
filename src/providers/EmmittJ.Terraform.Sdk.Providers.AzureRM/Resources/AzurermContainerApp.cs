using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dapr in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppDaprBlock : ITerraformBlock
{
    /// <summary>
    /// The Dapr Application Identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    [TerraformPropertyName("app_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AppPort { get; set; }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    [TerraformPropertyName("app_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppProtocol { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlock : ITerraformBlock
{
    /// <summary>
    /// Should this ingress allow insecure connections?
    /// </summary>
    [TerraformPropertyName("allow_insecure_connections")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowInsecureConnections { get; set; }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateMode { get; set; }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomDomain => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "custom_domain");

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    [TerraformPropertyName("exposed_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ExposedPort { get; set; }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    [TerraformPropertyName("external_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExternalEnabled { get; set; }

    /// <summary>
    /// The FQDN of the ingress.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>("", "fqdn");

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    [TerraformPropertyName("target_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TargetPort { get; set; }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    [TerraformPropertyName("transport")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Transport { get; set; }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppRegistryBlock : ITerraformBlock
{
    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [TerraformPropertyName("identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [TerraformPropertyName("password_secret_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformPropertyName("server")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppSecretBlock : ITerraformBlock
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Identity { get; set; }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum number of replicas for this container.
    /// </summary>
    [TerraformPropertyName("max_replicas")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxReplicas { get; set; }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    [TerraformPropertyName("min_replicas")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinReplicas { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    [TerraformPropertyName("revision_suffix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RevisionSuffix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "revision_suffix");

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [TerraformPropertyName("termination_grace_period_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TerminationGracePeriodSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("container_app_environment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformPropertyName("max_inactive_revisions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxInactiveRevisions { get; set; }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    [TerraformPropertyName("revision_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RevisionMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("workload_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkloadProfileName { get; set; }

    /// <summary>
    /// Block for dapr.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    [TerraformPropertyName("dapr")]
    public TerraformList<TerraformBlock<AzurermContainerAppDaprBlock>>? Dapr { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermContainerAppIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    [TerraformPropertyName("ingress")]
    public TerraformList<TerraformBlock<AzurermContainerAppIngressBlock>>? Ingress { get; set; } = new();

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("registry")]
    public TerraformList<TerraformBlock<AzurermContainerAppRegistryBlock>>? Registry { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformSet<TerraformBlock<AzurermContainerAppSecretBlock>>? Secret { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformPropertyName("template")]
    public TerraformList<TerraformBlock<AzurermContainerAppTemplateBlock>>? Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    [TerraformPropertyName("latest_revision_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestRevisionFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_revision_fqdn");

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformPropertyName("latest_revision_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestRevisionName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_revision_name");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_ip_addresses");

}
