using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for notification in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerConnectedRegistryNotificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformProperty("digest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Digest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tag { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerConnectedRegistryTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_container_connected_registry resource.
/// </summary>
public partial class AzurermContainerConnectedRegistry : TerraformResource
{
    public AzurermContainerConnectedRegistry(string name) : base("azurerm_container_connected_registry", name)
    {
    }

    /// <summary>
    /// The audit_log_enabled attribute.
    /// </summary>
    [TerraformProperty("audit_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AuditLogEnabled { get; set; }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    [TerraformProperty("client_token_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ClientTokenIds { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformProperty("container_registry_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerRegistryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformProperty("log_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogLevel { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    [TerraformProperty("parent_registry_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParentRegistryId { get; set; }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    [TerraformProperty("sync_message_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SyncMessageTtl { get; set; }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    [TerraformProperty("sync_schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SyncSchedule { get; set; }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyncTokenId is required")]
    [TerraformProperty("sync_token_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SyncTokenId { get; set; }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    [TerraformProperty("sync_window")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SyncWindow { get; set; }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("notification")]
    public partial TerraformList<TerraformBlock<AzurermContainerConnectedRegistryNotificationBlock>>? Notification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerConnectedRegistryTimeoutsBlock>? Timeouts { get; set; }

}
