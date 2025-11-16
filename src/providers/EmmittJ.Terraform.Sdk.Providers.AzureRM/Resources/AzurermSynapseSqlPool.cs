using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for restore in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseSqlPoolRestoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore";

    /// <summary>
    /// The point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    public required TerraformValue<string> PointInTime
    {
        get => new TerraformReference<string>(this, "point_in_time");
        set => SetArgument("point_in_time", value);
    }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    public required TerraformValue<string> SourceDatabaseId
    {
        get => new TerraformReference<string>(this, "source_database_id");
        set => SetArgument("source_database_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_synapse_sql_pool Terraform resource.
/// Manages a azurerm_synapse_sql_pool resource.
/// </summary>
public partial class AzurermSynapseSqlPool(string name) : TerraformResource("azurerm_synapse_sql_pool", name)
{
    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The data_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? DataEncrypted
    {
        get => new TerraformReference<bool>(this, "data_encrypted");
        set => SetArgument("data_encrypted", value);
    }

    /// <summary>
    /// The geo_backup_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GeoBackupPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "geo_backup_policy_enabled");
        set => SetArgument("geo_backup_policy_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_database_id attribute.
    /// </summary>
    public TerraformValue<string>? RecoveryDatabaseId
    {
        get => new TerraformReference<string>(this, "recovery_database_id");
        set => SetArgument("recovery_database_id", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformValue<string> SynapseWorkspaceId
    {
        get => new TerraformReference<string>(this, "synapse_workspace_id");
        set => SetArgument("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Restore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restore block(s) allowed")]
    public TerraformList<AzurermSynapseSqlPoolRestoreBlock>? Restore
    {
        get => GetArgument<TerraformList<AzurermSynapseSqlPoolRestoreBlock>>("restore");
        set => SetArgument("restore", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseSqlPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseSqlPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
