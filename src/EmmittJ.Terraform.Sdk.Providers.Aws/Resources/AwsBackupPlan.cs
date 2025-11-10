using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_backup_setting in .
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanAdvancedBackupSettingBlock : TerraformBlock
{
    /// <summary>
    /// The backup_options attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupOptions is required")]
    public Dictionary<string, TerraformProperty<string>>? BackupOptions
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("backup_options");
        set => WithProperty("backup_options", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsBackupPlanRuleBlock : TerraformBlock
{
    /// <summary>
    /// The completion_window attribute.
    /// </summary>
    public TerraformProperty<double>? CompletionWindow
    {
        get => GetProperty<TerraformProperty<double>>("completion_window");
        set => WithProperty("completion_window", value);
    }

    /// <summary>
    /// The enable_continuous_backup attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableContinuousBackup
    {
        get => GetProperty<TerraformProperty<bool>>("enable_continuous_backup");
        set => WithProperty("enable_continuous_backup", value);
    }

    /// <summary>
    /// The recovery_point_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RecoveryPointTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("recovery_point_tags");
        set => WithProperty("recovery_point_tags", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => WithProperty("rule_name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => WithProperty("schedule", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpressionTimezone
    {
        get => GetProperty<TerraformProperty<string>>("schedule_expression_timezone");
        set => WithProperty("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window attribute.
    /// </summary>
    public TerraformProperty<double>? StartWindow
    {
        get => GetProperty<TerraformProperty<double>>("start_window");
        set => WithProperty("start_window", value);
    }

    /// <summary>
    /// The target_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVaultName is required")]
    public required TerraformProperty<string> TargetVaultName
    {
        get => GetProperty<TerraformProperty<string>>("target_vault_name");
        set => WithProperty("target_vault_name", value);
    }

}

/// <summary>
/// Manages a aws_backup_plan resource.
/// </summary>
public class AwsBackupPlan : TerraformResource
{
    public AwsBackupPlan(string name) : base("aws_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("version");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for advanced_backup_setting.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBackupPlanAdvancedBackupSettingBlock>? AdvancedBackupSetting
    {
        get => GetProperty<HashSet<AwsBackupPlanAdvancedBackupSettingBlock>>("advanced_backup_setting");
        set => this.WithProperty("advanced_backup_setting", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public HashSet<AwsBackupPlanRuleBlock>? Rule
    {
        get => GetProperty<HashSet<AwsBackupPlanRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
