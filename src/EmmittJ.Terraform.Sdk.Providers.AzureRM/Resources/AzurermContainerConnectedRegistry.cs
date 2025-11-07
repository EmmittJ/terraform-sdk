using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The audit_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AuditLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("audit_log_enabled");
        set => this.WithProperty("audit_log_enabled", value);
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ClientTokenIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("client_token_ids");
        set => this.WithProperty("client_token_ids", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformProperty<string>? LogLevel
    {
        get => GetProperty<TerraformProperty<string>>("log_level");
        set => this.WithProperty("log_level", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("parent_registry_id");
        set => this.WithProperty("parent_registry_id", value);
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? SyncMessageTtl
    {
        get => GetProperty<TerraformProperty<string>>("sync_message_ttl");
        set => this.WithProperty("sync_message_ttl", value);
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    public TerraformProperty<string>? SyncSchedule
    {
        get => GetProperty<TerraformProperty<string>>("sync_schedule");
        set => this.WithProperty("sync_schedule", value);
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    public TerraformProperty<string>? SyncTokenId
    {
        get => GetProperty<TerraformProperty<string>>("sync_token_id");
        set => this.WithProperty("sync_token_id", value);
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    public TerraformProperty<string>? SyncWindow
    {
        get => GetProperty<TerraformProperty<string>>("sync_window");
        set => this.WithProperty("sync_window", value);
    }

}
