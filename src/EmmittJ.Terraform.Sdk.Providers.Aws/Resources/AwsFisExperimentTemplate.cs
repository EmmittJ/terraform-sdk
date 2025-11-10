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
        get => GetProperty<TerraformProperty<string>>("action_id");
        set => WithProperty("action_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? StartAfter
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("start_after");
        set => WithProperty("start_after", value);
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
        get => GetProperty<TerraformProperty<string>>("account_targeting");
        set => WithProperty("account_targeting", value);
    }

    /// <summary>
    /// The empty_target_resolution_mode attribute.
    /// </summary>
    public TerraformProperty<string>? EmptyTargetResolutionMode
    {
        get => GetProperty<TerraformProperty<string>>("empty_target_resolution_mode");
        set => WithProperty("empty_target_resolution_mode", value);
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
        get => GetProperty<TerraformProperty<string>>("post_experiment_duration");
        set => WithProperty("post_experiment_duration", value);
    }

    /// <summary>
    /// The pre_experiment_duration attribute.
    /// </summary>
    public TerraformProperty<string>? PreExperimentDuration
    {
        get => GetProperty<TerraformProperty<string>>("pre_experiment_duration");
        set => WithProperty("pre_experiment_duration", value);
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
        get => GetProperty<TerraformProperty<double>>("log_schema_version");
        set => WithProperty("log_schema_version", value);
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
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_arns");
        set => WithProperty("resource_arns", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

    /// <summary>
    /// The selection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionMode is required")]
    public required TerraformProperty<string> SelectionMode
    {
        get => GetProperty<TerraformProperty<string>>("selection_mode");
        set => WithProperty("selection_mode", value);
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
/// Manages a aws_fis_experiment_template resource.
/// </summary>
public class AwsFisExperimentTemplate : TerraformResource
{
    public AwsFisExperimentTemplate(string name) : base("aws_fis_experiment_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public HashSet<AwsFisExperimentTemplateActionBlock>? Action
    {
        get => GetProperty<HashSet<AwsFisExperimentTemplateActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for experiment_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentOptions block(s) allowed")]
    public List<AwsFisExperimentTemplateExperimentOptionsBlock>? ExperimentOptions
    {
        get => GetProperty<List<AwsFisExperimentTemplateExperimentOptionsBlock>>("experiment_options");
        set => this.WithProperty("experiment_options", value);
    }

    /// <summary>
    /// Block for experiment_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentReportConfiguration block(s) allowed")]
    public List<AwsFisExperimentTemplateExperimentReportConfigurationBlock>? ExperimentReportConfiguration
    {
        get => GetProperty<List<AwsFisExperimentTemplateExperimentReportConfigurationBlock>>("experiment_report_configuration");
        set => this.WithProperty("experiment_report_configuration", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public List<AwsFisExperimentTemplateLogConfigurationBlock>? LogConfiguration
    {
        get => GetProperty<List<AwsFisExperimentTemplateLogConfigurationBlock>>("log_configuration");
        set => this.WithProperty("log_configuration", value);
    }

    /// <summary>
    /// Block for stop_condition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StopCondition block(s) required")]
    public HashSet<AwsFisExperimentTemplateStopConditionBlock>? StopCondition
    {
        get => GetProperty<HashSet<AwsFisExperimentTemplateStopConditionBlock>>("stop_condition");
        set => this.WithProperty("stop_condition", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsFisExperimentTemplateTargetBlock>? Target
    {
        get => GetProperty<HashSet<AwsFisExperimentTemplateTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFisExperimentTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFisExperimentTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
