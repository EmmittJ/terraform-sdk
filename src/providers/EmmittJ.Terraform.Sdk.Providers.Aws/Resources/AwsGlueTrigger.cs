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
        set => SetProperty("arguments", value);
    }

    /// <summary>
    /// The crawler_name attribute.
    /// </summary>
    public TerraformProperty<string>? CrawlerName
    {
        set => SetProperty("crawler_name", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformProperty<string>? JobName
    {
        set => SetProperty("job_name", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityConfiguration
    {
        set => SetProperty("security_configuration", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        set => SetProperty("timeout", value);
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
        set => SetProperty("batch_size", value);
    }

    /// <summary>
    /// The batch_window attribute.
    /// </summary>
    public TerraformProperty<double>? BatchWindow
    {
        set => SetProperty("batch_window", value);
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
        set => SetProperty("logical", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("state");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("schedule");
        SetOutput("start_on_creation");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
        SetOutput("workflow_name");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The schedule attribute.
    /// </summary>
    public TerraformProperty<string> Schedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule");
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The start_on_creation attribute.
    /// </summary>
    public TerraformProperty<bool> StartOnCreation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_on_creation");
        set => SetProperty("start_on_creation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The workflow_name attribute.
    /// </summary>
    public TerraformProperty<string> WorkflowName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workflow_name");
        set => SetProperty("workflow_name", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    public List<AwsGlueTriggerActionsBlock>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// Block for event_batching_condition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueTriggerEventBatchingConditionBlock>? EventBatchingCondition
    {
        set => SetProperty("event_batching_condition", value);
    }

    /// <summary>
    /// Block for predicate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predicate block(s) allowed")]
    public List<AwsGlueTriggerPredicateBlock>? Predicate
    {
        set => SetProperty("predicate", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlueTriggerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
