using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_filter in AwsCloudwatchMetricStream.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamExcludeFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_filter";

    /// <summary>
    /// The metric_names attribute.
    /// </summary>
    public TerraformSet<string>? MetricNames
    {
        get => GetArgument<TerraformSet<string>>("metric_names");
        set => SetArgument("metric_names", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for include_filter in AwsCloudwatchMetricStream.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamIncludeFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_filter";

    /// <summary>
    /// The metric_names attribute.
    /// </summary>
    public TerraformSet<string>? MetricNames
    {
        get => GetArgument<TerraformSet<string>>("metric_names");
        set => SetArgument("metric_names", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for statistics_configuration in AwsCloudwatchMetricStream.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamStatisticsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "statistics_configuration";

    /// <summary>
    /// The additional_statistics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalStatistics is required")]
    public required TerraformSet<string> AdditionalStatistics
    {
        get => GetRequiredArgument<TerraformSet<string>>("additional_statistics");
        set => SetArgument("additional_statistics", value);
    }

    /// <summary>
    /// IncludeMetric block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludeMetric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncludeMetric block(s) required")]
    public required TerraformSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlockIncludeMetricBlock> IncludeMetric
    {
        get => GetRequiredArgument<TerraformSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlockIncludeMetricBlock>>("include_metric");
        set => SetArgument("include_metric", value);
    }

}

/// <summary>
/// Block type for include_metric in AwsCloudwatchMetricStreamStatisticsConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamStatisticsConfigurationBlockIncludeMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCloudwatchMetricStream.
/// Nesting mode: single
/// </summary>
public class AwsCloudwatchMetricStreamTimeoutsBlock : TerraformBlock
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
/// Represents a aws_cloudwatch_metric_stream Terraform resource.
/// Manages a aws_cloudwatch_metric_stream resource.
/// </summary>
public partial class AwsCloudwatchMetricStream(string name) : TerraformResource("aws_cloudwatch_metric_stream", name)
{
    /// <summary>
    /// The firehose_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirehoseArn is required")]
    public required TerraformValue<string> FirehoseArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("firehose_arn");
        set => SetArgument("firehose_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_linked_accounts_metrics attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeLinkedAccountsMetrics
    {
        get => GetArgument<TerraformValue<bool>>("include_linked_accounts_metrics");
        set => SetArgument("include_linked_accounts_metrics", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputFormat is required")]
    public required TerraformValue<string> OutputFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => CreateReference("creation_date");

    /// <summary>
    /// The last_update_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdateDate
        => CreateReference("last_update_date");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// ExcludeFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudwatchMetricStreamExcludeFilterBlock>? ExcludeFilter
    {
        get => GetArgument<TerraformSet<AwsCloudwatchMetricStreamExcludeFilterBlock>>("exclude_filter");
        set => SetArgument("exclude_filter", value);
    }

    /// <summary>
    /// IncludeFilter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudwatchMetricStreamIncludeFilterBlock>? IncludeFilter
    {
        get => GetArgument<TerraformSet<AwsCloudwatchMetricStreamIncludeFilterBlock>>("include_filter");
        set => SetArgument("include_filter", value);
    }

    /// <summary>
    /// StatisticsConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlock>? StatisticsConfiguration
    {
        get => GetArgument<TerraformSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlock>>("statistics_configuration");
        set => SetArgument("statistics_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudwatchMetricStreamTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudwatchMetricStreamTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
