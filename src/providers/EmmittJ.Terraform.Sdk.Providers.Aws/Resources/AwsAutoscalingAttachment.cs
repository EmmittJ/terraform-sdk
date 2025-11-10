using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_attachment resource.
/// </summary>
public class AwsAutoscalingAttachment : TerraformResource
{
    public AwsAutoscalingAttachment(string name) : base("aws_autoscaling_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("autoscaling_group_name");
        SetOutput("elb");
        SetOutput("id");
        SetOutput("lb_target_group_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformProperty<string> AutoscalingGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autoscaling_group_name");
        set => SetProperty("autoscaling_group_name", value);
    }

    /// <summary>
    /// The elb attribute.
    /// </summary>
    public TerraformProperty<string> Elb
    {
        get => GetRequiredOutput<TerraformProperty<string>>("elb");
        set => SetProperty("elb", value);
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
    /// The lb_target_group_arn attribute.
    /// </summary>
    public TerraformProperty<string> LbTargetGroupArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lb_target_group_arn");
        set => SetProperty("lb_target_group_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
