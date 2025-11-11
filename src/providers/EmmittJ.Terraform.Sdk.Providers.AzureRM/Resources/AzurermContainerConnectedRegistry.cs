using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for notification in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerConnectedRegistryNotificationBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformPropertyName("digest")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Digest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tag { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerConnectedRegistryTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_connected_registry resource.
/// </summary>
public class AzurermContainerConnectedRegistry : TerraformResource
{
    public AzurermContainerConnectedRegistry(string name) : base("azurerm_container_connected_registry", name)
    {
    }

    /// <summary>
    /// The audit_log_enabled attribute.
    /// </summary>
    [TerraformPropertyName("audit_log_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AuditLogEnabled { get; set; }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    [TerraformPropertyName("client_token_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ClientTokenIds { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformPropertyName("container_registry_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerRegistryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformPropertyName("log_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogLevel { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParentRegistryId { get; set; }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    [TerraformPropertyName("sync_message_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SyncMessageTtl { get; set; }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    [TerraformPropertyName("sync_schedule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SyncSchedule { get; set; }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyncTokenId is required")]
    [TerraformPropertyName("sync_token_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SyncTokenId { get; set; }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    [TerraformPropertyName("sync_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SyncWindow { get; set; }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("notification")]
    public TerraformList<TerraformBlock<AzurermContainerConnectedRegistryNotificationBlock>>? Notification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerConnectedRegistryTimeoutsBlock>? Timeouts { get; set; }

}
