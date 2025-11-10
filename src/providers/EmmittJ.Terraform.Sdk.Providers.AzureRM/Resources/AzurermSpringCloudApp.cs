using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_persistent_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppCustomPersistentDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    [TerraformPropertyName("mount_options")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? MountOptions { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    [TerraformPropertyName("mount_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MountPath { get; set; }

    /// <summary>
    /// The read_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("read_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReadOnlyEnabled { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformPropertyName("share_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShareName { get; set; }

    /// <summary>
    /// The storage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageName is required")]
    [TerraformPropertyName("storage_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppIdentityBlock : ITerraformBlock
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
/// Block type for ingress_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppIngressSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The backend_protocol attribute.
    /// </summary>
    [TerraformPropertyName("backend_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackendProtocol { get; set; }

    /// <summary>
    /// The read_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("read_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The send_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("send_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SendTimeoutInSeconds { get; set; }

    /// <summary>
    /// The session_affinity attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SessionAffinity { get; set; }

    /// <summary>
    /// The session_cookie_max_age attribute.
    /// </summary>
    [TerraformPropertyName("session_cookie_max_age")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SessionCookieMaxAge { get; set; }

}

/// <summary>
/// Block type for persistent_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudAppPersistentDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformPropertyName("mount_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MountPath { get; set; }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    [TerraformPropertyName("size_in_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SizeInGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_spring_cloud_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudApp : TerraformResource
{
    public AzurermSpringCloudApp(string name) : base("azurerm_spring_cloud_app", name)
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    [TerraformPropertyName("addon_json")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddonJson { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "addon_json");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    [TerraformPropertyName("is_public")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsPublic { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicEndpointEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceName { get; set; }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TlsEnabled { get; set; }

    /// <summary>
    /// Block for custom_persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_persistent_disk")]
    public TerraformList<TerraformBlock<AzurermSpringCloudAppCustomPersistentDiskBlock>>? CustomPersistentDisk { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermSpringCloudAppIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for ingress_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressSettings block(s) allowed")]
    [TerraformPropertyName("ingress_settings")]
    public TerraformList<TerraformBlock<AzurermSpringCloudAppIngressSettingsBlock>>? IngressSettings { get; set; } = new();

    /// <summary>
    /// Block for persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentDisk block(s) allowed")]
    [TerraformPropertyName("persistent_disk")]
    public TerraformList<TerraformBlock<AzurermSpringCloudAppPersistentDiskBlock>>? PersistentDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudAppTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
