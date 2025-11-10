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
        set => SetProperty("alarm", value);
    }

    /// <summary>
    /// The extension_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionPeriod is required")]
    public required TerraformProperty<double> ExtensionPeriod
    {
        set => SetProperty("extension_period", value);
    }

    /// <summary>
    /// The wait_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriod is required")]
    public required TerraformProperty<double> WaitPeriod
    {
        set => SetProperty("wait_period", value);
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
        SetOutput("arn");
        SetOutput("actions_enabled");
        SetOutput("alarm_actions");
        SetOutput("alarm_description");
        SetOutput("alarm_name");
        SetOutput("alarm_rule");
        SetOutput("id");
        SetOutput("insufficient_data_actions");
        SetOutput("ok_actions");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ActionsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("actions_enabled");
        set => SetProperty("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AlarmActions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("alarm_actions");
        set => SetProperty("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformProperty<string> AlarmDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alarm_description");
        set => SetProperty("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformProperty<string> AlarmName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alarm_name");
        set => SetProperty("alarm_name", value);
    }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmRule is required")]
    public required TerraformProperty<string> AlarmRule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alarm_rule");
        set => SetProperty("alarm_rule", value);
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
    /// The insufficient_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> InsufficientDataActions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("insufficient_data_actions");
        set => SetProperty("insufficient_data_actions", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> OkActions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ok_actions");
        set => SetProperty("ok_actions", value);
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
    /// Block for actions_suppressor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionsSuppressor block(s) allowed")]
    public List<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>? ActionsSuppressor
    {
        set => SetProperty("actions_suppressor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
