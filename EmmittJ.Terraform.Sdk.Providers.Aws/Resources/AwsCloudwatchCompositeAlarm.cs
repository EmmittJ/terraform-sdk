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
    public bool? ActionsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("actions_enabled")?.Value;
        set => this.WithProperty("actions_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public HashSet<string>? AlarmActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("alarm_actions")?.Value;
        set => this.WithProperty("alarm_actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public string? AlarmDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_description")?.Value;
        set => this.WithProperty("alarm_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    public string? AlarmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_name")?.Value;
        set => this.WithProperty("alarm_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    public string? AlarmRule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_rule")?.Value;
        set => this.WithProperty("alarm_rule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public HashSet<string>? InsufficientDataActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("insufficient_data_actions")?.Value;
        set => this.WithProperty("insufficient_data_actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public HashSet<string>? OkActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ok_actions")?.Value;
        set => this.WithProperty("ok_actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
