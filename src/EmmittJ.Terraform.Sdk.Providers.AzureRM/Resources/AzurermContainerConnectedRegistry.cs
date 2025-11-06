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
    public bool? AuditLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("audit_log_enabled")?.Value;
        set => this.WithProperty("audit_log_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_token_ids attribute.
    /// </summary>
    public List<string>? ClientTokenIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("client_token_ids")?.Value;
        set => this.WithProperty("client_token_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public string? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id")?.Value;
        set => this.WithProperty("container_registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public string? LogLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_level")?.Value;
        set => this.WithProperty("log_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_registry_id attribute.
    /// </summary>
    public string? ParentRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_registry_id")?.Value;
        set => this.WithProperty("parent_registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sync_message_ttl attribute.
    /// </summary>
    public string? SyncMessageTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_message_ttl")?.Value;
        set => this.WithProperty("sync_message_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sync_schedule attribute.
    /// </summary>
    public string? SyncSchedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_schedule")?.Value;
        set => this.WithProperty("sync_schedule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sync_token_id attribute.
    /// </summary>
    public string? SyncTokenId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_token_id")?.Value;
        set => this.WithProperty("sync_token_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sync_window attribute.
    /// </summary>
    public string? SyncWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sync_window")?.Value;
        set => this.WithProperty("sync_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
