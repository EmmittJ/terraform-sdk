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
    public TerraformLiteralProperty<bool>? AuditLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("audit_log_enabled");
        set => this.WithProperty("audit_log_enabled", value);
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ClientTokenIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("client_token_ids");
        set => this.WithProperty("client_token_ids", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_level");
        set => this.WithProperty("log_level", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_registry_id");
        set => this.WithProperty("parent_registry_id", value);
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SyncMessageTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_message_ttl");
        set => this.WithProperty("sync_message_ttl", value);
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SyncSchedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_schedule");
        set => this.WithProperty("sync_schedule", value);
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SyncTokenId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_token_id");
        set => this.WithProperty("sync_token_id", value);
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SyncWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_window");
        set => this.WithProperty("sync_window", value);
    }

}
