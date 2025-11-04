using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_notification resource.
/// </summary>
public class AwsAutoscalingNotification : TerraformResource
{
    public AwsAutoscalingNotification(string name) : base("aws_autoscaling_notification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_names attribute.
    /// </summary>
    public HashSet<string>? GroupNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("group_names")?.Value;
        set => this.WithProperty("group_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The notifications attribute.
    /// </summary>
    public HashSet<string>? Notifications
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("notifications")?.Value;
        set => this.WithProperty("notifications", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public string? TopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_arn")?.Value;
        set => this.WithProperty("topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
