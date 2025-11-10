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
        SetOutput("group_names");
        SetOutput("id");
        SetOutput("notifications");
        SetOutput("region");
        SetOutput("topic_arn");
    }

    /// <summary>
    /// The group_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupNames is required")]
    public HashSet<TerraformProperty<string>> GroupNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("group_names");
        set => SetProperty("group_names", value);
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
    /// The notifications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notifications is required")]
    public HashSet<TerraformProperty<string>> Notifications
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("notifications");
        set => SetProperty("notifications", value);
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
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_arn");
        set => SetProperty("topic_arn", value);
    }

}
