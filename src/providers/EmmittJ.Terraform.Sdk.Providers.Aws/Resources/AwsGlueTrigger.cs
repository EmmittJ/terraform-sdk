using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in AwsGlueTrigger.
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public TerraformMap<string>? Arguments
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "arguments").ResolveNodes(ctx));
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The crawler_name attribute.
    /// </summary>
    public TerraformValue<string>? CrawlerName
    {
        get => new TerraformReference<string>(this, "crawler_name");
        set => SetArgument("crawler_name", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformValue<string>? JobName
    {
        get => new TerraformReference<string>(this, "job_name");
        set => SetArgument("job_name", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformValue<string>? SecurityConfiguration
    {
        get => new TerraformReference<string>(this, "security_configuration");
        set => SetArgument("security_configuration", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// NotificationProperty block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    public TerraformList<AwsGlueTriggerActionsBlockNotificationPropertyBlock>? NotificationProperty
    {
        get => GetArgument<TerraformList<AwsGlueTriggerActionsBlockNotificationPropertyBlock>>("notification_property");
        set => SetArgument("notification_property", value);
    }

}

/// <summary>
/// Block type for notification_property in AwsGlueTriggerActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerActionsBlockNotificationPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_property";

    /// <summary>
    /// The notify_delay_after attribute.
    /// </summary>
    public TerraformValue<double>? NotifyDelayAfter
    {
        get => new TerraformReference<double>(this, "notify_delay_after");
        set => SetArgument("notify_delay_after", value);
    }

}


/// <summary>
/// Block type for event_batching_condition in AwsGlueTrigger.
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerEventBatchingConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_batching_condition";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchSize is required")]
    public required TerraformValue<double> BatchSize
    {
        get => new TerraformReference<double>(this, "batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The batch_window attribute.
    /// </summary>
    public TerraformValue<double>? BatchWindow
    {
        get => new TerraformReference<double>(this, "batch_window");
        set => SetArgument("batch_window", value);
    }

}


/// <summary>
/// Block type for predicate in AwsGlueTrigger.
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerPredicateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predicate";

    /// <summary>
    /// The logical attribute.
    /// </summary>
    public TerraformValue<string>? Logical
    {
        get => new TerraformReference<string>(this, "logical");
        set => SetArgument("logical", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    public required TerraformList<AwsGlueTriggerPredicateBlockConditionsBlock> Conditions
    {
        get => GetRequiredArgument<TerraformList<AwsGlueTriggerPredicateBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in AwsGlueTriggerPredicateBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerPredicateBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// The crawl_state attribute.
    /// </summary>
    public TerraformValue<string>? CrawlState
    {
        get => new TerraformReference<string>(this, "crawl_state");
        set => SetArgument("crawl_state", value);
    }

    /// <summary>
    /// The crawler_name attribute.
    /// </summary>
    public TerraformValue<string>? CrawlerName
    {
        get => new TerraformReference<string>(this, "crawler_name");
        set => SetArgument("crawler_name", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformValue<string>? JobName
    {
        get => new TerraformReference<string>(this, "job_name");
        set => SetArgument("job_name", value);
    }

    /// <summary>
    /// The logical_operator attribute.
    /// </summary>
    public TerraformValue<string>? LogicalOperator
    {
        get => new TerraformReference<string>(this, "logical_operator");
        set => SetArgument("logical_operator", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGlueTrigger.
/// Nesting mode: single
/// </summary>
public class AwsGlueTriggerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_glue_trigger Terraform resource.
/// Manages a aws_glue_trigger resource.
/// </summary>
public partial class AwsGlueTrigger(string name) : TerraformResource("aws_glue_trigger", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The schedule attribute.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The start_on_creation attribute.
    /// </summary>
    public TerraformValue<bool>? StartOnCreation
    {
        get => new TerraformReference<bool>(this, "start_on_creation");
        set => SetArgument("start_on_creation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The workflow_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkflowName
    {
        get => new TerraformReference<string>(this, "workflow_name");
        set => SetArgument("workflow_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Actions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    public required TerraformList<AwsGlueTriggerActionsBlock> Actions
    {
        get => GetRequiredArgument<TerraformList<AwsGlueTriggerActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// EventBatchingCondition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueTriggerEventBatchingConditionBlock>? EventBatchingCondition
    {
        get => GetArgument<TerraformList<AwsGlueTriggerEventBatchingConditionBlock>>("event_batching_condition");
        set => SetArgument("event_batching_condition", value);
    }

    /// <summary>
    /// Predicate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predicate block(s) allowed")]
    public TerraformList<AwsGlueTriggerPredicateBlock>? Predicate
    {
        get => GetArgument<TerraformList<AwsGlueTriggerPredicateBlock>>("predicate");
        set => SetArgument("predicate", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGlueTriggerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGlueTriggerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
