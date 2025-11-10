using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSqlPoolRestoreBlock : TerraformBlock
{
    /// <summary>
    /// The point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    public required TerraformProperty<string> PointInTime
    {
        get => GetProperty<TerraformProperty<string>>("point_in_time");
        set => WithProperty("point_in_time", value);
    }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    public required TerraformProperty<string> SourceDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("source_database_id");
        set => WithProperty("source_database_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Collation
    {
        get => GetProperty<TerraformProperty<string>>("collation");
        set => this.WithProperty("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The data_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? DataEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("data_encrypted");
        set => this.WithProperty("data_encrypted", value);
    }

    /// <summary>
    /// The geo_backup_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GeoBackupPolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("geo_backup_policy_enabled");
        set => this.WithProperty("geo_backup_policy_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_database_id");
        set => this.WithProperty("recovery_database_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    public List<AzurermSynapseSqlPoolRestoreBlock>? Restore
    {
        get => GetProperty<List<AzurermSynapseSqlPoolRestoreBlock>>("restore");
        set => this.WithProperty("restore", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSynapseSqlPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
