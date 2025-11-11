using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_attachment resource.
/// </summary>
public partial class AwsAutoscalingAttachment : TerraformResource
{
    public AwsAutoscalingAttachment(string name) : base("aws_autoscaling_attachment", name)
    {
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformProperty("autoscaling_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The elb attribute.
    /// </summary>
    [TerraformProperty("elb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Elb { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lb_target_group_arn attribute.
    /// </summary>
    [TerraformProperty("lb_target_group_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LbTargetGroupArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
