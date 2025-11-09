using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_composite_alarm resource.
/// </summary>
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
    public TerraformProperty<HashSet<string>>? AlarmActions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("alarm_actions");
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
    public TerraformProperty<string>? AlarmName
    {
        get => GetProperty<TerraformProperty<string>>("alarm_name");
        set => this.WithProperty("alarm_name", value);
    }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    public TerraformProperty<string>? AlarmRule
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
    public TerraformProperty<HashSet<string>>? InsufficientDataActions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("insufficient_data_actions");
        set => this.WithProperty("insufficient_data_actions", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? OkActions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("ok_actions");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
