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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
