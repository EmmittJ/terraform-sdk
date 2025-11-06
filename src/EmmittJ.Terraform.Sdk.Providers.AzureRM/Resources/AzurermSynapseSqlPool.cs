using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_sql_pool resource.
/// </summary>
public class AzurermSynapseSqlPool : TerraformResource
{
    public AzurermSynapseSqlPool(string name) : base("azurerm_synapse_sql_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public string? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation")?.Value;
        set => this.WithProperty("collation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public string? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode")?.Value;
        set => this.WithProperty("create_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_encrypted attribute.
    /// </summary>
    public bool? DataEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_encrypted")?.Value;
        set => this.WithProperty("data_encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The geo_backup_policy_enabled attribute.
    /// </summary>
    public bool? GeoBackupPolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("geo_backup_policy_enabled")?.Value;
        set => this.WithProperty("geo_backup_policy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_database_id attribute.
    /// </summary>
    public string? RecoveryDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_database_id")?.Value;
        set => this.WithProperty("recovery_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public string? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type")?.Value;
        set => this.WithProperty("storage_account_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public string? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id")?.Value;
        set => this.WithProperty("synapse_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
