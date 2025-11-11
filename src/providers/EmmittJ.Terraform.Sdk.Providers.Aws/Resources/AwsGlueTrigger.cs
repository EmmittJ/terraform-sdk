using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueTriggerActionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformProperty("arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Arguments { get; set; }

    /// <summary>
    /// The crawler_name attribute.
    /// </summary>
    [TerraformProperty("crawler_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CrawlerName { get; set; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [TerraformProperty("job_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JobName { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformProperty("security_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Timeout { get; set; }

}

/// <summary>
/// Block type for event_batching_condition in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueTriggerEventBatchingConditionBlock : TerraformBlockBase
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchSize is required")]
    [TerraformProperty("batch_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BatchSize { get; set; }

    /// <summary>
    /// The batch_window attribute.
    /// </summary>
    [TerraformProperty("batch_window")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BatchWindow { get; set; }

}

/// <summary>
/// Block type for predicate in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueTriggerPredicateBlock : TerraformBlockBase
{
    /// <summary>
    /// The logical attribute.
    /// </summary>
    [TerraformProperty("logical")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Logical { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGlueTriggerTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_glue_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueTrigger : TerraformResource
{
    public AwsGlueTrigger(string name) : base("aws_glue_trigger", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

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
    /// The schedule attribute.
    /// </summary>
    [TerraformProperty("schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The start_on_creation attribute.
    /// </summary>
    [TerraformProperty("start_on_creation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartOnCreation { get; set; }

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The workflow_name attribute.
    /// </summary>
    [TerraformProperty("workflow_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkflowName { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [TerraformProperty("actions")]
    public partial TerraformList<TerraformBlock<AwsGlueTriggerActionsBlock>>? Actions { get; set; }

    /// <summary>
    /// Block for event_batching_condition.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_batching_condition")]
    public partial TerraformList<TerraformBlock<AwsGlueTriggerEventBatchingConditionBlock>>? EventBatchingCondition { get; set; }

    /// <summary>
    /// Block for predicate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predicate block(s) allowed")]
    [TerraformProperty("predicate")]
    public partial TerraformList<TerraformBlock<AwsGlueTriggerPredicateBlock>>? Predicate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsGlueTriggerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
