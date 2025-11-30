using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for long_term_retention_policy in AzurermMssqlManagedDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "long_term_retention_policy";

    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ImmutableBackupsEnabled
    {
        get => new TerraformReference<bool>(this, "immutable_backups_enabled");
        set => SetArgument("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    public TerraformValue<string> MonthlyRetention
    {
        get => new TerraformReference<string>(this, "monthly_retention");
        set => SetArgument("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    public TerraformValue<double> WeekOfYear
    {
        get => new TerraformReference<double>(this, "week_of_year");
        set => SetArgument("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    public TerraformValue<string> WeeklyRetention
    {
        get => new TerraformReference<string>(this, "weekly_retention");
        set => SetArgument("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    public TerraformValue<string> YearlyRetention
    {
        get => new TerraformReference<string>(this, "yearly_retention");
        set => SetArgument("yearly_retention", value);
    }

}


/// <summary>
/// Block type for point_in_time_restore in AzurermMssqlManagedDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabasePointInTimeRestoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "point_in_time_restore";

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestorePointInTime is required")]
    public required TerraformValue<string> RestorePointInTime
    {
        get => new TerraformReference<string>(this, "restore_point_in_time");
        set => SetArgument("restore_point_in_time", value);
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
/// Block type for timeouts in AzurermMssqlManagedDatabase.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedDatabaseTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_managed_database Terraform resource.
/// Manages a azurerm_mssql_managed_database resource.
/// </summary>
public partial class AzurermMssqlManagedDatabase(string name) : TerraformResource("azurerm_mssql_managed_database", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
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
    /// The short_term_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? ShortTermRetentionDays
    {
        get => new TerraformReference<double>(this, "short_term_retention_days");
        set => SetArgument("short_term_retention_days", value);
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
    /// LongTermRetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    public TerraformList<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock>? LongTermRetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock>>("long_term_retention_policy");
        set => SetArgument("long_term_retention_policy", value);
    }

    /// <summary>
    /// PointInTimeRestore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestore block(s) allowed")]
    public TerraformList<AzurermMssqlManagedDatabasePointInTimeRestoreBlock>? PointInTimeRestore
    {
        get => GetArgument<TerraformList<AzurermMssqlManagedDatabasePointInTimeRestoreBlock>>("point_in_time_restore");
        set => SetArgument("point_in_time_restore", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedDatabaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedDatabaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
