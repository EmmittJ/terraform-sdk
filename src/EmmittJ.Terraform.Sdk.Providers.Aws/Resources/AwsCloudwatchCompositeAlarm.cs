using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions_suppressor in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchCompositeAlarmActionsSuppressorBlock : TerraformBlock
{
    /// <summary>
    /// The alarm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alarm is required")]
    public required TerraformProperty<string> Alarm
    {
        get => GetProperty<TerraformProperty<string>>("alarm");
        set => WithProperty("alarm", value);
    }

    /// <summary>
    /// The extension_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionPeriod is required")]
    public required TerraformProperty<double> ExtensionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("extension_period");
        set => WithProperty("extension_period", value);
    }

    /// <summary>
    /// The wait_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriod is required")]
    public required TerraformProperty<double> WaitPeriod
    {
        get => GetProperty<TerraformProperty<double>>("wait_period");
        set => WithProperty("wait_period", value);
    }

}

/// <summary>
/// Manages a aws_cloudwatch_composite_alarm resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchCompositeAlarm : TerraformResource
{
    public AwsCloudwatchCompositeAlarm(string name) : base("aws_cloudwatch_composite_alarm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ActionsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("actions_enabled");
        set => this.WithProperty("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AlarmActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("alarm_actions");
        set => this.WithProperty("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformProperty<string>? AlarmDescription
    {
        get => GetProperty<TerraformProperty<string>>("alarm_description");
        set => this.WithProperty("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformProperty<string> AlarmName
    {
        get => GetProperty<TerraformProperty<string>>("alarm_name");
        set => this.WithProperty("alarm_name", value);
    }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmRule is required")]
    public required TerraformProperty<string> AlarmRule
    {
        get => GetProperty<TerraformProperty<string>>("alarm_rule");
        set => this.WithProperty("alarm_rule", value);
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
    /// The insufficient_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InsufficientDataActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("insufficient_data_actions");
        set => this.WithProperty("insufficient_data_actions", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OkActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ok_actions");
        set => this.WithProperty("ok_actions", value);
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
    /// Block for actions_suppressor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionsSuppressor block(s) allowed")]
    public List<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>? ActionsSuppressor
    {
        get => GetProperty<List<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>>("actions_suppressor");
        set => this.WithProperty("actions_suppressor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
