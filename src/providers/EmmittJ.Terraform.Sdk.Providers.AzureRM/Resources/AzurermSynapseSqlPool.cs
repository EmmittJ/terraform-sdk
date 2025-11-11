using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseSqlPoolRestoreBlock : TerraformBlockBase
{
    /// <summary>
    /// The point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    [TerraformProperty("point_in_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PointInTime { get; set; }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    [TerraformProperty("source_database_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceDatabaseId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseSqlPoolTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_synapse_sql_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSynapseSqlPool : TerraformResource
{
    public AzurermSynapseSqlPool(string name) : base("azurerm_synapse_sql_pool", name)
    {
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformProperty("collation")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Collation { get; set; }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformProperty("create_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateMode { get; set; }

    /// <summary>
    /// The data_encrypted attribute.
    /// </summary>
    [TerraformProperty("data_encrypted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DataEncrypted { get; set; }

    /// <summary>
    /// The geo_backup_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("geo_backup_policy_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GeoBackupPolicyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recovery_database_id attribute.
    /// </summary>
    [TerraformProperty("recovery_database_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecoveryDatabaseId { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformProperty("storage_account_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    [TerraformProperty("synapse_workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SynapseWorkspaceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    [TerraformProperty("restore")]
    public TerraformList<TerraformBlock<AzurermSynapseSqlPoolRestoreBlock>>? Restore { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSynapseSqlPoolTimeoutsBlock>? Timeouts { get; set; }

}
