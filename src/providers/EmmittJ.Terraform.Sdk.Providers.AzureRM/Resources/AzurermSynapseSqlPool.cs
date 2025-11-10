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
        set => SetProperty("point_in_time", value);
    }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    public required TerraformProperty<string> SourceDatabaseId
    {
        set => SetProperty("source_database_id", value);
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
/// Manages a azurerm_synapse_sql_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSynapseSqlPool : TerraformResource
{
    public AzurermSynapseSqlPool(string name) : base("azurerm_synapse_sql_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("collation");
        SetOutput("create_mode");
        SetOutput("data_encrypted");
        SetOutput("geo_backup_policy_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("recovery_database_id");
        SetOutput("sku_name");
        SetOutput("storage_account_type");
        SetOutput("synapse_workspace_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string> Collation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collation");
        set => SetProperty("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string> CreateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_mode");
        set => SetProperty("create_mode", value);
    }

    /// <summary>
    /// The data_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> DataEncrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("data_encrypted");
        set => SetProperty("data_encrypted", value);
    }

    /// <summary>
    /// The geo_backup_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GeoBackupPolicyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("geo_backup_policy_enabled");
        set => SetProperty("geo_backup_policy_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The recovery_database_id attribute.
    /// </summary>
    public TerraformProperty<string> RecoveryDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_database_id");
        set => SetProperty("recovery_database_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_type");
        set => SetProperty("storage_account_type", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synapse_workspace_id");
        set => SetProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    public List<AzurermSynapseSqlPoolRestoreBlock>? Restore
    {
        set => SetProperty("restore", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
