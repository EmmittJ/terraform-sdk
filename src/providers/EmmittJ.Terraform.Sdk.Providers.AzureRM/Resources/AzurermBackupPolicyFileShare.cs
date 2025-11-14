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
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [TerraformArgument("time")]
    public TerraformValue<string>? Time
    {
        get => new TerraformReference<string>(this, "time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for retention_daily in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionDailyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_daily";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformArgument("count")]
    public required TerraformValue<double> Count
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

}

/// <summary>
/// Block type for retention_monthly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_monthly";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformArgument("count")]
    public required TerraformValue<double> Count
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [TerraformArgument("days")]
    public TerraformSet<double>? Days
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "days").ResolveNodes(ctx));
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    [TerraformArgument("include_last_days")]
    public TerraformValue<bool>? IncludeLastDays
    {
        get => new TerraformReference<bool>(this, "include_last_days");
        set => SetArgument("include_last_days", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformArgument("weekdays")]
    public TerraformSet<string>? Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    [TerraformArgument("weeks")]
    public TerraformSet<string>? Weeks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weeks").ResolveNodes(ctx));
        set => SetArgument("weeks", value);
    }

}

/// <summary>
/// Block type for retention_weekly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionWeeklyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_weekly";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformArgument("count")]
    public required TerraformValue<double> Count
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weekdays is required")]
    [TerraformArgument("weekdays")]
    public required TerraformSet<string> Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

}

/// <summary>
/// Block type for retention_yearly in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyFileShareRetentionYearlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_yearly";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformArgument("count")]
    public required TerraformValue<double> Count
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [TerraformArgument("days")]
    public TerraformSet<double>? Days
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "days").ResolveNodes(ctx));
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The include_last_days attribute.
    /// </summary>
    [TerraformArgument("include_last_days")]
    public TerraformValue<bool>? IncludeLastDays
    {
        get => new TerraformReference<bool>(this, "include_last_days");
        set => SetArgument("include_last_days", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Months is required")]
    [TerraformArgument("months")]
    public required TerraformSet<string> Months
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "months").ResolveNodes(ctx));
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The weekdays attribute.
    /// </summary>
    [TerraformArgument("weekdays")]
    public TerraformSet<string>? Weekdays
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weekdays").ResolveNodes(ctx));
        set => SetArgument("weekdays", value);
    }

    /// <summary>
    /// The weeks attribute.
    /// </summary>
    [TerraformArgument("weeks")]
    public TerraformSet<string>? Weeks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "weeks").ResolveNodes(ctx));
        set => SetArgument("weeks", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyFileShareTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_backup_policy_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBackupPolicyFileShare : TerraformResource
{
    public AzurermBackupPolicyFileShare(string name) : base("azurerm_backup_policy_file_share", name)
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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformArgument("recovery_vault_name")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => new TerraformReference<string>(this, "recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformArgument("timezone")]
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformArgument("backup")]
    public required TerraformList<AzurermBackupPolicyFileShareBackupBlock> Backup { get; set; } = new();

    /// <summary>
    /// Block for retention_daily.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionDaily is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionDaily block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionDaily block(s) allowed")]
    [TerraformArgument("retention_daily")]
    public required TerraformList<AzurermBackupPolicyFileShareRetentionDailyBlock> RetentionDaily { get; set; } = new();

    /// <summary>
    /// Block for retention_monthly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionMonthly block(s) allowed")]
    [TerraformArgument("retention_monthly")]
    public TerraformList<AzurermBackupPolicyFileShareRetentionMonthlyBlock> RetentionMonthly { get; set; } = new();

    /// <summary>
    /// Block for retention_weekly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionWeekly block(s) allowed")]
    [TerraformArgument("retention_weekly")]
    public TerraformList<AzurermBackupPolicyFileShareRetentionWeeklyBlock> RetentionWeekly { get; set; } = new();

    /// <summary>
    /// Block for retention_yearly.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionYearly block(s) allowed")]
    [TerraformArgument("retention_yearly")]
    public TerraformList<AzurermBackupPolicyFileShareRetentionYearlyBlock> RetentionYearly { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBackupPolicyFileShareTimeoutsBlock Timeouts { get; set; } = new();

}
