using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for long_term_retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The immutable_backups_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImmutableBackupsEnabled
    {
        set => SetProperty("immutable_backups_enabled", value);
    }

    /// <summary>
    /// The monthly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? MonthlyRetention
    {
        set => SetProperty("monthly_retention", value);
    }

    /// <summary>
    /// The week_of_year attribute.
    /// </summary>
    public TerraformProperty<double>? WeekOfYear
    {
        set => SetProperty("week_of_year", value);
    }

    /// <summary>
    /// The weekly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyRetention
    {
        set => SetProperty("weekly_retention", value);
    }

    /// <summary>
    /// The yearly_retention attribute.
    /// </summary>
    public TerraformProperty<string>? YearlyRetention
    {
        set => SetProperty("yearly_retention", value);
    }

}

/// <summary>
/// Block type for point_in_time_restore in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedDatabasePointInTimeRestoreBlock : TerraformBlock
{
    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestorePointInTime is required")]
    public required TerraformProperty<string> RestorePointInTime
    {
        set => SetProperty("restore_point_in_time", value);
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
public class AzurermMssqlManagedDatabaseTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_managed_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedDatabase : TerraformResource
{
    public AzurermMssqlManagedDatabase(string name) : base("azurerm_mssql_managed_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("managed_instance_id");
        SetOutput("name");
        SetOutput("short_term_retention_days");
        SetOutput("tags");
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
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformProperty<string> ManagedInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_instance_id");
        set => SetProperty("managed_instance_id", value);
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
    /// The short_term_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> ShortTermRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("short_term_retention_days");
        set => SetProperty("short_term_retention_days", value);
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
    /// Block for long_term_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermRetentionPolicy block(s) allowed")]
    public List<AzurermMssqlManagedDatabaseLongTermRetentionPolicyBlock>? LongTermRetentionPolicy
    {
        set => SetProperty("long_term_retention_policy", value);
    }

    /// <summary>
    /// Block for point_in_time_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRestore block(s) allowed")]
    public List<AzurermMssqlManagedDatabasePointInTimeRestoreBlock>? PointInTimeRestore
    {
        set => SetProperty("point_in_time_restore", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedDatabaseTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
