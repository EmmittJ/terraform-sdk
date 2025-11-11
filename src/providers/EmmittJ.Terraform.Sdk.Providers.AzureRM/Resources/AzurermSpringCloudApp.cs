using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_persistent_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudAppCustomPersistentDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    [TerraformProperty("mount_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? MountOptions { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    [TerraformProperty("mount_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MountPath { get; set; }

    /// <summary>
    /// The read_only_enabled attribute.
    /// </summary>
    [TerraformProperty("read_only_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReadOnlyEnabled { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformProperty("share_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// The storage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageName is required")]
    [TerraformProperty("storage_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudAppIdentityBlock : TerraformBlockBase
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
/// Block type for ingress_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudAppIngressSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The backend_protocol attribute.
    /// </summary>
    [TerraformProperty("backend_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackendProtocol { get; set; }

    /// <summary>
    /// The read_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("read_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The send_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("send_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SendTimeoutInSeconds { get; set; }

    /// <summary>
    /// The session_affinity attribute.
    /// </summary>
    [TerraformProperty("session_affinity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SessionAffinity { get; set; }

    /// <summary>
    /// The session_cookie_max_age attribute.
    /// </summary>
    [TerraformProperty("session_cookie_max_age")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SessionCookieMaxAge { get; set; }

}

/// <summary>
/// Block type for persistent_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudAppPersistentDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformProperty("mount_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MountPath { get; set; }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    [TerraformProperty("size_in_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SizeInGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudAppTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_spring_cloud_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudApp : TerraformResource
{
    public AzurermSpringCloudApp(string name) : base("azurerm_spring_cloud_app", name)
    {
    }

    /// <summary>
    /// The addon_json attribute.
    /// </summary>
    [TerraformProperty("addon_json")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddonJson { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    [TerraformProperty("is_public")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsPublic { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("public_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicEndpointEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TlsEnabled { get; set; }

    /// <summary>
    /// Block for custom_persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_persistent_disk")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudAppCustomPersistentDiskBlock>>? CustomPersistentDisk { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudAppIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for ingress_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressSettings block(s) allowed")]
    [TerraformProperty("ingress_settings")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudAppIngressSettingsBlock>>? IngressSettings { get; set; }

    /// <summary>
    /// Block for persistent_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentDisk block(s) allowed")]
    [TerraformProperty("persistent_disk")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudAppPersistentDiskBlock>>? PersistentDisk { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSpringCloudAppTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
