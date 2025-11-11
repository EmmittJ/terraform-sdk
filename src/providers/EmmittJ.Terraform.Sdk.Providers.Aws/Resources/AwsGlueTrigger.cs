using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerActionsBlock
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformPropertyName("arguments")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Arguments { get; set; }

    /// <summary>
    /// The crawler_name attribute.
    /// </summary>
    [TerraformPropertyName("crawler_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CrawlerName { get; set; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [TerraformPropertyName("job_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JobName { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Timeout { get; set; }

}

/// <summary>
/// Block type for event_batching_condition in .
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerEventBatchingConditionBlock
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchSize is required")]
    [TerraformPropertyName("batch_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> BatchSize { get; set; }

    /// <summary>
    /// The batch_window attribute.
    /// </summary>
    [TerraformPropertyName("batch_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BatchWindow { get; set; }

}

/// <summary>
/// Block type for predicate in .
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerPredicateBlock
{
    /// <summary>
    /// The logical attribute.
    /// </summary>
    [TerraformPropertyName("logical")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Logical { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlueTriggerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_glue_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueTrigger : TerraformResource
{
    public AwsGlueTrigger(string name) : base("aws_glue_trigger", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The start_on_creation attribute.
    /// </summary>
    [TerraformPropertyName("start_on_creation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StartOnCreation { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The workflow_name attribute.
    /// </summary>
    [TerraformPropertyName("workflow_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkflowName { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [TerraformPropertyName("actions")]
    public TerraformList<TerraformBlock<AwsGlueTriggerActionsBlock>>? Actions { get; set; }

    /// <summary>
    /// Block for event_batching_condition.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_batching_condition")]
    public TerraformList<TerraformBlock<AwsGlueTriggerEventBatchingConditionBlock>>? EventBatchingCondition { get; set; }

    /// <summary>
    /// Block for predicate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predicate block(s) allowed")]
    [TerraformPropertyName("predicate")]
    public TerraformList<TerraformBlock<AwsGlueTriggerPredicateBlock>>? Predicate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGlueTriggerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
