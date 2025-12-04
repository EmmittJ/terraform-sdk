using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for notification in AzurermContainerConnectedRegistry.
/// Nesting mode: list
/// </summary>
public class AzurermContainerConnectedRegistryNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    public TerraformValue<string>? Digest
    {
        get => GetArgument<TerraformValue<string>>("digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermContainerConnectedRegistry.
/// Nesting mode: single
/// </summary>
public class AzurermContainerConnectedRegistryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_container_connected_registry Terraform resource.
/// Manages a azurerm_container_connected_registry resource.
/// </summary>
public partial class AzurermContainerConnectedRegistry(string name) : TerraformResource("azurerm_container_connected_registry", name)
{
    /// <summary>
    /// The audit_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AuditLogEnabled
    {
        get => GetArgument<TerraformValue<bool>>("audit_log_enabled");
        set => SetArgument("audit_log_enabled", value);
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    public TerraformList<string>? ClientTokenIds
    {
        get => GetArgument<TerraformList<string>>("client_token_ids");
        set => SetArgument("client_token_ids", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => GetArgument<TerraformValue<string>>("container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string>? LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    public TerraformValue<string>? ParentRegistryId
    {
        get => GetArgument<TerraformValue<string>>("parent_registry_id");
        set => SetArgument("parent_registry_id", value);
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    public TerraformValue<string>? SyncMessageTtl
    {
        get => GetArgument<TerraformValue<string>>("sync_message_ttl");
        set => SetArgument("sync_message_ttl", value);
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    public TerraformValue<string>? SyncSchedule
    {
        get => GetArgument<TerraformValue<string>>("sync_schedule");
        set => SetArgument("sync_schedule", value);
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyncTokenId is required")]
    public required TerraformValue<string> SyncTokenId
    {
        get => GetArgument<TerraformValue<string>>("sync_token_id");
        set => SetArgument("sync_token_id", value);
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    public TerraformValue<string>? SyncWindow
    {
        get => GetArgument<TerraformValue<string>>("sync_window");
        set => SetArgument("sync_window", value);
    }

    /// <summary>
    /// Notification block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerConnectedRegistryNotificationBlock>? Notification
    {
        get => GetArgument<TerraformList<AzurermContainerConnectedRegistryNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerConnectedRegistryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerConnectedRegistryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
