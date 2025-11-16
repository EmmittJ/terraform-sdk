using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for notification in .
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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    public TerraformValue<string>? Digest
    {
        get => new TerraformReference<string>(this, "digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "audit_log_enabled");
        set => SetArgument("audit_log_enabled", value);
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    public TerraformList<string>? ClientTokenIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "client_token_ids").ResolveNodes(ctx));
        set => SetArgument("client_token_ids", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string>? LogLevel
    {
        get => new TerraformReference<string>(this, "log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    public TerraformValue<string>? ParentRegistryId
    {
        get => new TerraformReference<string>(this, "parent_registry_id");
        set => SetArgument("parent_registry_id", value);
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    public TerraformValue<string>? SyncMessageTtl
    {
        get => new TerraformReference<string>(this, "sync_message_ttl");
        set => SetArgument("sync_message_ttl", value);
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    public TerraformValue<string>? SyncSchedule
    {
        get => new TerraformReference<string>(this, "sync_schedule");
        set => SetArgument("sync_schedule", value);
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyncTokenId is required")]
    public required TerraformValue<string> SyncTokenId
    {
        get => new TerraformReference<string>(this, "sync_token_id");
        set => SetArgument("sync_token_id", value);
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    public TerraformValue<string>? SyncWindow
    {
        get => new TerraformReference<string>(this, "sync_window");
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
