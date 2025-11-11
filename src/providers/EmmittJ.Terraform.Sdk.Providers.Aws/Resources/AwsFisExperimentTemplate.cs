using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public partial class AwsFisExperimentTemplateActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The action_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    [TerraformProperty("action_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ActionId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    [TerraformProperty("start_after")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? StartAfter { get; set; }

}

/// <summary>
/// Block type for experiment_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsFisExperimentTemplateExperimentOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_targeting attribute.
    /// </summary>
    [TerraformProperty("account_targeting")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountTargeting { get; set; }

    /// <summary>
    /// The empty_target_resolution_mode attribute.
    /// </summary>
    [TerraformProperty("empty_target_resolution_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmptyTargetResolutionMode { get; set; }

}

/// <summary>
/// Block type for experiment_report_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFisExperimentTemplateExperimentReportConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The post_experiment_duration attribute.
    /// </summary>
    [TerraformProperty("post_experiment_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostExperimentDuration { get; set; }

    /// <summary>
    /// The pre_experiment_duration attribute.
    /// </summary>
    [TerraformProperty("pre_experiment_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreExperimentDuration { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFisExperimentTemplateLogConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The log_schema_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogSchemaVersion is required")]
    [TerraformProperty("log_schema_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> LogSchemaVersion { get; set; }

}

/// <summary>
/// Block type for stop_condition in .
/// Nesting mode: set
/// </summary>
public partial class AwsFisExperimentTemplateStopConditionBlock : TerraformBlockBase
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: set
/// </summary>
public partial class AwsFisExperimentTemplateTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    [TerraformProperty("resource_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ResourceArns { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The selection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionMode is required")]
    [TerraformProperty("selection_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SelectionMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFisExperimentTemplateTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_fis_experiment_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFisExperimentTemplate : TerraformResource
{
    public AwsFisExperimentTemplate(string name) : base("aws_fis_experiment_template", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

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
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [TerraformProperty("action")]
    public partial TerraformSet<TerraformBlock<AwsFisExperimentTemplateActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for experiment_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentOptions block(s) allowed")]
    [TerraformProperty("experiment_options")]
    public partial TerraformList<TerraformBlock<AwsFisExperimentTemplateExperimentOptionsBlock>>? ExperimentOptions { get; set; }

    /// <summary>
    /// Block for experiment_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentReportConfiguration block(s) allowed")]
    [TerraformProperty("experiment_report_configuration")]
    public partial TerraformList<TerraformBlock<AwsFisExperimentTemplateExperimentReportConfigurationBlock>>? ExperimentReportConfiguration { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformProperty("log_configuration")]
    public partial TerraformList<TerraformBlock<AwsFisExperimentTemplateLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// Block for stop_condition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopCondition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StopCondition block(s) required")]
    [TerraformProperty("stop_condition")]
    public partial TerraformSet<TerraformBlock<AwsFisExperimentTemplateStopConditionBlock>>? StopCondition { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("target")]
    public partial TerraformSet<TerraformBlock<AwsFisExperimentTemplateTargetBlock>>? Target { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsFisExperimentTemplateTimeoutsBlock>? Timeouts { get; set; }

}
