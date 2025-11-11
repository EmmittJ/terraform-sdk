using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudformationStackTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack resource.
/// </summary>
public partial class AwsCloudformationStack : TerraformResource
{
    public AwsCloudformationStack(string name) : base("aws_cloudformation_stack", name)
    {
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformProperty("capabilities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Capabilities { get; set; }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    [TerraformProperty("disable_rollback")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableRollback { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformProperty("notification_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NotificationArns { get; set; }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    [TerraformProperty("on_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnFailure { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Parameters { get; set; }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    [TerraformProperty("policy_body")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PolicyBody { get; set; }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    [TerraformProperty("policy_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformProperty("template_body")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateBody { get; set; }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformProperty("template_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateUrl { get; set; }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInMinutes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsCloudformationStackTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformProperty("outputs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Outputs { get; }

}
