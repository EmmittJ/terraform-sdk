using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformArgument("digest")]
    public TerraformValue<string>? Digest
    {
        get => new TerraformReference<string>(this, "digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformArgument("tag")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("audit_log_enabled")]
    public TerraformValue<bool>? AuditLogEnabled
    {
        get => new TerraformReference<bool>(this, "audit_log_enabled");
        set => SetArgument("audit_log_enabled", value);
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    [TerraformArgument("client_token_ids")]
    public TerraformList<string>? ClientTokenIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "client_token_ids").ResolveNodes(ctx));
        set => SetArgument("client_token_ids", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformArgument("container_registry_id")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformArgument("log_level")]
    public TerraformValue<string>? LogLevel
    {
        get => new TerraformReference<string>(this, "log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    [TerraformArgument("parent_registry_id")]
    public TerraformValue<string>? ParentRegistryId
    {
        get => new TerraformReference<string>(this, "parent_registry_id");
        set => SetArgument("parent_registry_id", value);
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    [TerraformArgument("sync_message_ttl")]
    public TerraformValue<string>? SyncMessageTtl
    {
        get => new TerraformReference<string>(this, "sync_message_ttl");
        set => SetArgument("sync_message_ttl", value);
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    [TerraformArgument("sync_schedule")]
    public TerraformValue<string>? SyncSchedule
    {
        get => new TerraformReference<string>(this, "sync_schedule");
        set => SetArgument("sync_schedule", value);
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyncTokenId is required")]
    [TerraformArgument("sync_token_id")]
    public required TerraformValue<string> SyncTokenId
    {
        get => new TerraformReference<string>(this, "sync_token_id");
        set => SetArgument("sync_token_id", value);
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    [TerraformArgument("sync_window")]
    public TerraformValue<string>? SyncWindow
    {
        get => new TerraformReference<string>(this, "sync_window");
        set => SetArgument("sync_window", value);
    }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("notification")]
    public TerraformList<AzurermContainerConnectedRegistryNotificationBlock> Notification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerConnectedRegistryTimeoutsBlock Timeouts { get; set; } = new();

}
