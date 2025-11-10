using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateActionBlock : TerraformBlock
{
    /// <summary>
    /// The action_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    public required TerraformProperty<string> ActionId
    {
        set => SetProperty("action_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? StartAfter
    {
        set => SetProperty("start_after", value);
    }

}

/// <summary>
/// Block type for experiment_options in .
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The account_targeting attribute.
    /// </summary>
    public TerraformProperty<string>? AccountTargeting
    {
        set => SetProperty("account_targeting", value);
    }

    /// <summary>
    /// The empty_target_resolution_mode attribute.
    /// </summary>
    public TerraformProperty<string>? EmptyTargetResolutionMode
    {
        set => SetProperty("empty_target_resolution_mode", value);
    }

}

/// <summary>
/// Block type for experiment_report_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The post_experiment_duration attribute.
    /// </summary>
    public TerraformProperty<string>? PostExperimentDuration
    {
        set => SetProperty("post_experiment_duration", value);
    }

    /// <summary>
    /// The pre_experiment_duration attribute.
    /// </summary>
    public TerraformProperty<string>? PreExperimentDuration
    {
        set => SetProperty("pre_experiment_duration", value);
    }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The log_schema_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogSchemaVersion is required")]
    public required TerraformProperty<double> LogSchemaVersion
    {
        set => SetProperty("log_schema_version", value);
    }

}

/// <summary>
/// Block type for stop_condition in .
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateStopConditionBlock : TerraformBlock
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateTargetBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceArns
    {
        set => SetProperty("resource_arns", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The selection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionMode is required")]
    public required TerraformProperty<string> SelectionMode
    {
        set => SetProperty("selection_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFisExperimentTemplateTimeoutsBlock : TerraformBlock
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
/// Manages a aws_fis_experiment_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFisExperimentTemplate : TerraformResource
{
    public AwsFisExperimentTemplate(string name) : base("aws_fis_experiment_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("id");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
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
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public HashSet<AwsFisExperimentTemplateActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for experiment_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentOptions block(s) allowed")]
    public List<AwsFisExperimentTemplateExperimentOptionsBlock>? ExperimentOptions
    {
        set => SetProperty("experiment_options", value);
    }

    /// <summary>
    /// Block for experiment_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentReportConfiguration block(s) allowed")]
    public List<AwsFisExperimentTemplateExperimentReportConfigurationBlock>? ExperimentReportConfiguration
    {
        set => SetProperty("experiment_report_configuration", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public List<AwsFisExperimentTemplateLogConfigurationBlock>? LogConfiguration
    {
        set => SetProperty("log_configuration", value);
    }

    /// <summary>
    /// Block for stop_condition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopCondition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StopCondition block(s) required")]
    public HashSet<AwsFisExperimentTemplateStopConditionBlock>? StopCondition
    {
        set => SetProperty("stop_condition", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsFisExperimentTemplateTargetBlock>? Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFisExperimentTemplateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
