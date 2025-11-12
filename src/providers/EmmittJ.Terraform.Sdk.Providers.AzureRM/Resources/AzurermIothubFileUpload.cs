using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIothubFileUploadTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_iothub_file_upload resource.
/// </summary>
public partial class AzurermIothubFileUpload : TerraformResource
{
    public AzurermIothubFileUpload(string name) : base("azurerm_iothub_file_upload", name)
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformProperty("connection_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionString { get; set; }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformProperty("identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityId { get; set; }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformProperty("iothub_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IothubId { get; set; }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformProperty("lock_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformProperty("max_delivery_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxDeliveryCount { get; set; }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    [TerraformProperty("notifications_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NotificationsEnabled { get; set; }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    [TerraformProperty("sas_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SasTtl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermIothubFileUploadTimeoutsBlock Timeouts { get; set; } = new();

}
