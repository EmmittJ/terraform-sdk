using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAutoscalingTrafficSourceAttachmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Block type for traffic_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingTrafficSourceAttachmentTrafficSourceBlock() : TerraformBlock("traffic_source")
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_autoscaling_traffic_source_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAutoscalingTrafficSourceAttachment : TerraformResource
{
    public AwsAutoscalingTrafficSourceAttachment(string name) : base("aws_autoscaling_traffic_source_attachment", name)
    {
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformProperty("autoscaling_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsAutoscalingTrafficSourceAttachmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for traffic_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficSource block(s) allowed")]
    [TerraformProperty("traffic_source")]
    public TerraformList<AwsAutoscalingTrafficSourceAttachmentTrafficSourceBlock> TrafficSource { get; set; } = new();

}
