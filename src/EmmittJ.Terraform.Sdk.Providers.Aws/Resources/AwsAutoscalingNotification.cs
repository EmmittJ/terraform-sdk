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
    public TerraformProperty<HashSet<string>>? GroupNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("group_names");
        set => this.WithProperty("group_names", value);
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
    /// The notifications attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Notifications
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("notifications");
        set => this.WithProperty("notifications", value);
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
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => this.WithProperty("topic_arn", value);
    }

}
