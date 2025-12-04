using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsFisExperimentTemplate.
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    public required TerraformValue<string> ActionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_id");
        set => SetArgument("action_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    public TerraformSet<string>? StartAfter
    {
        get => GetArgument<TerraformSet<string>>("start_after");
        set => SetArgument("start_after", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFisExperimentTemplateActionBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsFisExperimentTemplateActionBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateActionBlockTargetBlock>? Target
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateActionBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for parameter in AwsFisExperimentTemplateActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateActionBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for target in AwsFisExperimentTemplateActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateActionBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for experiment_options in AwsFisExperimentTemplate.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "experiment_options";

    /// <summary>
    /// The account_targeting attribute.
    /// </summary>
    public TerraformValue<string>? AccountTargeting
    {
        get => GetArgument<TerraformValue<string>>("account_targeting");
        set => SetArgument("account_targeting", value);
    }

    /// <summary>
    /// The empty_target_resolution_mode attribute.
    /// </summary>
    public TerraformValue<string>? EmptyTargetResolutionMode
    {
        get => GetArgument<TerraformValue<string>>("empty_target_resolution_mode");
        set => SetArgument("empty_target_resolution_mode", value);
    }

}


/// <summary>
/// Block type for experiment_report_configuration in AwsFisExperimentTemplate.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "experiment_report_configuration";

    /// <summary>
    /// The post_experiment_duration attribute.
    /// </summary>
    public TerraformValue<string>? PostExperimentDuration
    {
        get => GetArgument<TerraformValue<string>>("post_experiment_duration");
        set => SetArgument("post_experiment_duration", value);
    }

    /// <summary>
    /// The pre_experiment_duration attribute.
    /// </summary>
    public TerraformValue<string>? PreExperimentDuration
    {
        get => GetArgument<TerraformValue<string>>("pre_experiment_duration");
        set => SetArgument("pre_experiment_duration", value);
    }

    /// <summary>
    /// DataSources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlock>? DataSources
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlock>>("data_sources");
        set => SetArgument("data_sources", value);
    }

    /// <summary>
    /// Outputs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Outputs block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlock>? Outputs
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlock>>("outputs");
        set => SetArgument("outputs", value);
    }

}

/// <summary>
/// Block type for data_sources in AwsFisExperimentTemplateExperimentReportConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_sources";

    /// <summary>
    /// CloudwatchDashboard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlockCloudwatchDashboardBlock>? CloudwatchDashboard
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlockCloudwatchDashboardBlock>>("cloudwatch_dashboard");
        set => SetArgument("cloudwatch_dashboard", value);
    }

}

/// <summary>
/// Block type for cloudwatch_dashboard in AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlockDataSourcesBlockCloudwatchDashboardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_dashboard";

    /// <summary>
    /// The dashboard_arn attribute.
    /// </summary>
    public TerraformValue<string>? DashboardArn
    {
        get => GetArgument<TerraformValue<string>>("dashboard_arn");
        set => SetArgument("dashboard_arn", value);
    }

}

/// <summary>
/// Block type for outputs in AwsFisExperimentTemplateExperimentReportConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outputs";

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateExperimentReportConfigurationBlockOutputsBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for log_configuration in AwsFisExperimentTemplate.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configuration";

    /// <summary>
    /// The log_schema_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogSchemaVersion is required")]
    public required TerraformValue<double> LogSchemaVersion
    {
        get => GetRequiredArgument<TerraformValue<double>>("log_schema_version");
        set => SetArgument("log_schema_version", value);
    }

    /// <summary>
    /// CloudwatchLogsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogsConfiguration block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateLogConfigurationBlockCloudwatchLogsConfigurationBlock>? CloudwatchLogsConfiguration
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateLogConfigurationBlockCloudwatchLogsConfigurationBlock>>("cloudwatch_logs_configuration");
        set => SetArgument("cloudwatch_logs_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateLogConfigurationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateLogConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs_configuration in AwsFisExperimentTemplateLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateLogConfigurationBlockCloudwatchLogsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs_configuration";

    /// <summary>
    /// The log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArn is required")]
    public required TerraformValue<string> LogGroupArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_group_arn");
        set => SetArgument("log_group_arn", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsFisExperimentTemplateLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateLogConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for stop_condition in AwsFisExperimentTemplate.
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateStopConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stop_condition";

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for target in AwsFisExperimentTemplate.
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public TerraformSet<string>? ResourceArns
    {
        get => GetArgument<TerraformSet<string>>("resource_arns");
        set => SetArgument("resource_arns", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The selection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionMode is required")]
    public required TerraformValue<string> SelectionMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("selection_mode");
        set => SetArgument("selection_mode", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFisExperimentTemplateTargetBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateTargetBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// ResourceTag block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 ResourceTag block(s) allowed")]
    public TerraformSet<AwsFisExperimentTemplateTargetBlockResourceTagBlock>? ResourceTag
    {
        get => GetArgument<TerraformSet<AwsFisExperimentTemplateTargetBlockResourceTagBlock>>("resource_tag");
        set => SetArgument("resource_tag", value);
    }

}

/// <summary>
/// Block type for filter in AwsFisExperimentTemplateTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsFisExperimentTemplateTargetBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for resource_tag in AwsFisExperimentTemplateTargetBlock.
/// Nesting mode: set
/// </summary>
public class AwsFisExperimentTemplateTargetBlockResourceTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_tag";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFisExperimentTemplate.
/// Nesting mode: single
/// </summary>
public class AwsFisExperimentTemplateTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fis_experiment_template Terraform resource.
/// Manages a aws_fis_experiment_template resource.
/// </summary>
public partial class AwsFisExperimentTemplate(string name) : TerraformResource("aws_fis_experiment_template", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// Action block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public required TerraformSet<AwsFisExperimentTemplateActionBlock> Action
    {
        get => GetRequiredArgument<TerraformSet<AwsFisExperimentTemplateActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// ExperimentOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentOptions block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateExperimentOptionsBlock>? ExperimentOptions
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateExperimentOptionsBlock>>("experiment_options");
        set => SetArgument("experiment_options", value);
    }

    /// <summary>
    /// ExperimentReportConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExperimentReportConfiguration block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlock>? ExperimentReportConfiguration
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateExperimentReportConfigurationBlock>>("experiment_report_configuration");
        set => SetArgument("experiment_report_configuration", value);
    }

    /// <summary>
    /// LogConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public TerraformList<AwsFisExperimentTemplateLogConfigurationBlock>? LogConfiguration
    {
        get => GetArgument<TerraformList<AwsFisExperimentTemplateLogConfigurationBlock>>("log_configuration");
        set => SetArgument("log_configuration", value);
    }

    /// <summary>
    /// StopCondition block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopCondition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StopCondition block(s) required")]
    public required TerraformSet<AwsFisExperimentTemplateStopConditionBlock> StopCondition
    {
        get => GetRequiredArgument<TerraformSet<AwsFisExperimentTemplateStopConditionBlock>>("stop_condition");
        set => SetArgument("stop_condition", value);
    }

    /// <summary>
    /// Target block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFisExperimentTemplateTargetBlock>? Target
    {
        get => GetArgument<TerraformSet<AwsFisExperimentTemplateTargetBlock>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFisExperimentTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFisExperimentTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
