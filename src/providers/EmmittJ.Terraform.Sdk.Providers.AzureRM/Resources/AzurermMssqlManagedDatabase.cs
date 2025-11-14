using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for long_term_retention_policy in .
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
    [TerraformArgument("immutable_backups_enabled")]
    public TerraformValue<bool>? ImmutableBackupsEnabled
    {
        get => new TerraformReference<bool>(this, "immutable_backups_enabled");
        set => SetArgument("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    [TerraformArgument("monthly_retention")]
    public TerraformValue<string> MonthlyRetention
    {
        get => new TerraformReference<string>(this, "monthly_retention");
        set => SetArgument("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    [TerraformArgument("week_of_year")]
    public TerraformValue<double> WeekOfYear
    {
        get => new TerraformReference<double>(this, "week_of_year");
        set => SetArgument("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    [TerraformArgument("weekly_retention")]
    public TerraformValue<string> WeeklyRetention
    {
        get => new TerraformReference<string>(this, "weekly_retention");
        set => SetArgument("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    [TerraformArgument("yearly_retention")]
    public TerraformValue<string> YearlyRetention
    {
        get => new TerraformReference<string>(this, "yearly_retention");
        set => SetArgument("yearly_retention", value);
    }

}

/// <summary>
/// Block type for point_in_time_restore in .
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
    [TerraformArgument("restore_point_in_time")]
    public required TerraformValue<string> RestorePointInTime
    {
        get => new TerraformReference<string>(this, "restore_point_in_time");
        set => SetArgument("restore_point_in_time", value);
    }

    /// <summary>
    /// The source_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatabaseId is required")]
    [TerraformArgument("source_database_id")]
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
public class AzurermMssqlManagedDatabaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_managed_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedDatabase : TerraformResource
{
    public AzurermMssqlManagedDatabase(string name) : base("azurerm_mssql_managed_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformArgument("managed_instance_id")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformArgument("short_term_retention_days")]
    public TerraformValue<double>? ShortTermRetentionDays
    {
        get => new TerraformReference<double>(this, "short_term_retention_days");
        set => SetArgument("short_term_retention_days", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    [TerraformArgument("long_term_retention_policy")]
    public TerraformList<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock> LongTermRetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for point_in_time_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestore block(s) allowed")]
    [TerraformArgument("point_in_time_restore")]
    public TerraformList<AzurermMssqlManagedDatabasePointInTimeRestoreBlock> PointInTimeRestore { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedDatabaseTimeoutsBlock Timeouts { get; set; } = new();

}
