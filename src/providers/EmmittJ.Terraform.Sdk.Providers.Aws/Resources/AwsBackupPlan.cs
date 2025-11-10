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
        set => SetProperty("backup_options", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        set => SetProperty("resource_type", value);
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
        set => SetProperty("completion_window", value);
    }

    /// <summary>
    /// The enable_continuous_backup attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableContinuousBackup
    {
        set => SetProperty("enable_continuous_backup", value);
    }

    /// <summary>
    /// The recovery_point_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RecoveryPointTags
    {
        set => SetProperty("recovery_point_tags", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        set => SetProperty("rule_name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpressionTimezone
    {
        set => SetProperty("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_window attribute.
    /// </summary>
    public TerraformProperty<double>? StartWindow
    {
        set => SetProperty("start_window", value);
    }

    /// <summary>
    /// The target_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVaultName is required")]
    public required TerraformProperty<string> TargetVaultName
    {
        set => SetProperty("target_vault_name", value);
    }

}

/// <summary>
/// Manages a aws_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBackupPlan : TerraformResource
{
    public AwsBackupPlan(string name) : base("aws_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for advanced_backup_setting.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBackupPlanAdvancedBackupSettingBlock>? AdvancedBackupSetting
    {
        set => SetProperty("advanced_backup_setting", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public HashSet<AwsBackupPlanRuleBlock>? Rule
    {
        set => SetProperty("rule", value);
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
