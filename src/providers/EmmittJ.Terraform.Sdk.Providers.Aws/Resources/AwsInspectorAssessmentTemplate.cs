using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_subscription in .
/// Nesting mode: set
/// </summary>
public partial class AwsInspectorAssessmentTemplateEventSubscriptionBlock() : TerraformBlock("event_subscription")
{
    /// <summary>
    /// The event attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Event is required")]
    [TerraformProperty("event")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Event { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformProperty("topic_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_inspector_assessment_template resource.
/// </summary>
public partial class AwsInspectorAssessmentTemplate : TerraformResource
{
    public AwsInspectorAssessmentTemplate(string name) : base("aws_inspector_assessment_template", name)
    {
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Duration { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rules_package_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesPackageArns is required")]
    [TerraformProperty("rules_package_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> RulesPackageArns { get; set; }

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
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformProperty("target_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetArn { get; set; }

    /// <summary>
    /// Block for event_subscription.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("event_subscription")]
    public TerraformSet<AwsInspectorAssessmentTemplateEventSubscriptionBlock> EventSubscription { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
