using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for notification in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerConnectedRegistryNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    public TerraformProperty<string>? Digest
    {
        set => SetProperty("digest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        set => SetProperty("tag", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerConnectedRegistryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_container_connected_registry resource.
/// </summary>
public class AzurermContainerConnectedRegistry : TerraformResource
{
    public AzurermContainerConnectedRegistry(string name) : base("azurerm_container_connected_registry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("audit_log_enabled");
        SetOutput("client_token_ids");
        SetOutput("container_registry_id");
        SetOutput("id");
        SetOutput("log_level");
        SetOutput("mode");
        SetOutput("name");
        SetOutput("parent_registry_id");
        SetOutput("sync_message_ttl");
        SetOutput("sync_schedule");
        SetOutput("sync_token_id");
        SetOutput("sync_window");
    }

    /// <summary>
    /// The audit_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AuditLogEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("audit_log_enabled");
        set => SetProperty("audit_log_enabled", value);
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> ClientTokenIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("client_token_ids");
        set => SetProperty("client_token_ids", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformProperty<string> ContainerRegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_registry_id");
        set => SetProperty("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformProperty<string> LogLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_level");
        set => SetProperty("log_level", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    public TerraformProperty<string> ParentRegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_registry_id");
        set => SetProperty("parent_registry_id", value);
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    public TerraformProperty<string> SyncMessageTtl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sync_message_ttl");
        set => SetProperty("sync_message_ttl", value);
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    public TerraformProperty<string> SyncSchedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sync_schedule");
        set => SetProperty("sync_schedule", value);
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyncTokenId is required")]
    public required TerraformProperty<string> SyncTokenId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sync_token_id");
        set => SetProperty("sync_token_id", value);
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    public TerraformProperty<string> SyncWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sync_window");
        set => SetProperty("sync_window", value);
    }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerConnectedRegistryNotificationBlock>? Notification
    {
        set => SetProperty("notification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerConnectedRegistryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
