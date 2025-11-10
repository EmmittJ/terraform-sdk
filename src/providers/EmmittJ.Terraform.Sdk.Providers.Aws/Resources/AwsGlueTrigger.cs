using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerActionsBlock : TerraformBlock
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Arguments
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("arguments");
        set => WithProperty("arguments", value);
    }

    /// <summary>
    /// The crawler_name attribute.
    /// </summary>
    public TerraformProperty<string>? CrawlerName
    {
        get => GetProperty<TerraformProperty<string>>("crawler_name");
        set => WithProperty("crawler_name", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformProperty<string>? JobName
    {
        get => GetProperty<TerraformProperty<string>>("job_name");
        set => WithProperty("job_name", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("security_configuration");
        set => WithProperty("security_configuration", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for event_batching_condition in .
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerEventBatchingConditionBlock : TerraformBlock
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchSize is required")]
    public required TerraformProperty<double> BatchSize
    {
        get => GetRequiredProperty<TerraformProperty<double>>("batch_size");
        set => WithProperty("batch_size", value);
    }

    /// <summary>
    /// The batch_window attribute.
    /// </summary>
    public TerraformProperty<double>? BatchWindow
    {
        get => GetProperty<TerraformProperty<double>>("batch_window");
        set => WithProperty("batch_window", value);
    }

}

/// <summary>
/// Block type for predicate in .
/// Nesting mode: list
/// </summary>
public class AwsGlueTriggerPredicateBlock : TerraformBlock
{
    /// <summary>
    /// The logical attribute.
    /// </summary>
    public TerraformProperty<string>? Logical
    {
        get => GetProperty<TerraformProperty<string>>("logical");
        set => WithProperty("logical", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlueTriggerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_glue_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueTrigger : TerraformResource
{
    public AwsGlueTrigger(string name) : base("aws_glue_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// The start_on_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? StartOnCreation
    {
        get => GetProperty<TerraformProperty<bool>>("start_on_creation");
        set => this.WithProperty("start_on_creation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The workflow_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkflowName
    {
        get => GetProperty<TerraformProperty<string>>("workflow_name");
        set => this.WithProperty("workflow_name", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    public List<AwsGlueTriggerActionsBlock>? Actions
    {
        get => GetProperty<List<AwsGlueTriggerActionsBlock>>("actions");
        set => this.WithProperty("actions", value);
    }

    /// <summary>
    /// Block for event_batching_condition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueTriggerEventBatchingConditionBlock>? EventBatchingCondition
    {
        get => GetProperty<List<AwsGlueTriggerEventBatchingConditionBlock>>("event_batching_condition");
        set => this.WithProperty("event_batching_condition", value);
    }

    /// <summary>
    /// Block for predicate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predicate block(s) allowed")]
    public List<AwsGlueTriggerPredicateBlock>? Predicate
    {
        get => GetProperty<List<AwsGlueTriggerPredicateBlock>>("predicate");
        set => this.WithProperty("predicate", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlueTriggerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGlueTriggerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
