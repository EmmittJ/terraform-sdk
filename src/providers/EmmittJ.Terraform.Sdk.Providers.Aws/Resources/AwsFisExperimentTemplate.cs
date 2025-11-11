using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateActionBlock
{
    /// <summary>
    /// The action_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    [TerraformPropertyName("action_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ActionId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    [TerraformPropertyName("start_after")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? StartAfter { get; set; }

}

/// <summary>
/// Block type for experiment_options in .
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentOptionsBlock
{
    /// <summary>
    /// The account_targeting attribute.
    /// </summary>
    [TerraformPropertyName("account_targeting")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountTargeting { get; set; }

    /// <summary>
    /// The empty_target_resolution_mode attribute.
    /// </summary>
    [TerraformPropertyName("empty_target_resolution_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmptyTargetResolutionMode { get; set; }

}

/// <summary>
/// Block type for experiment_report_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlock
{
    /// <summary>
    /// The post_experiment_duration attribute.
    /// </summary>
    [TerraformPropertyName("post_experiment_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PostExperimentDuration { get; set; }

    /// <summary>
    /// The pre_experiment_duration attribute.
    /// </summary>
    [TerraformPropertyName("pre_experiment_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreExperimentDuration { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateLogConfigurationBlock
{
    /// <summary>
    /// The log_schema_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogSchemaVersion is required")]
    [TerraformPropertyName("log_schema_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> LogSchemaVersion { get; set; }

}

/// <summary>
/// Block type for stop_condition in .
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateStopConditionBlock
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateTargetBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    [TerraformPropertyName("resource_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ResourceArns { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformPropertyName("resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The selection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionMode is required")]
    [TerraformPropertyName("selection_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SelectionMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFisExperimentTemplateTimeoutsBlock
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
/// Manages a aws_fis_experiment_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFisExperimentTemplate : TerraformResource
{
    public AwsFisExperimentTemplate(string name) : base("aws_fis_experiment_template", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

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
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [TerraformPropertyName("action")]
    public TerraformSet<TerraformBlock<AwsFisExperimentTemplateActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for experiment_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentOptions block(s) allowed")]
    [TerraformPropertyName("experiment_options")]
    public TerraformList<TerraformBlock<AwsFisExperimentTemplateExperimentOptionsBlock>>? ExperimentOptions { get; set; }

    /// <summary>
    /// Block for experiment_report_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentReportConfiguration block(s) allowed")]
    [TerraformPropertyName("experiment_report_configuration")]
    public TerraformList<TerraformBlock<AwsFisExperimentTemplateExperimentReportConfigurationBlock>>? ExperimentReportConfiguration { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformPropertyName("log_configuration")]
    public TerraformList<TerraformBlock<AwsFisExperimentTemplateLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// Block for stop_condition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopCondition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StopCondition block(s) required")]
    [TerraformPropertyName("stop_condition")]
    public TerraformSet<TerraformBlock<AwsFisExperimentTemplateStopConditionBlock>>? StopCondition { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("target")]
    public TerraformSet<TerraformBlock<AwsFisExperimentTemplateTargetBlock>>? Target { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFisExperimentTemplateTimeoutsBlock>? Timeouts { get; set; }

}
