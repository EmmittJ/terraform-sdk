using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_autoscaling_notification Terraform resource.
/// Manages a aws_autoscaling_notification resource.
/// </summary>
public partial class AwsAutoscalingNotification(string name) : TerraformResource("aws_autoscaling_notification", name)
{
    /// <summary>
    /// The group_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupNames is required")]
    public required TerraformSet<string> GroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "group_names").ResolveNodes(ctx));
        set => SetArgument("group_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notifications is required")]
    public required TerraformSet<string> Notifications
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "notifications").ResolveNodes(ctx));
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => new TerraformReference<string>(this, "topic_arn");
        set => SetArgument("topic_arn", value);
    }

}
