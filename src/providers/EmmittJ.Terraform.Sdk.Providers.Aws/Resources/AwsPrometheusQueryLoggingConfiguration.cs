using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in AwsPrometheusQueryLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusQueryLoggingConfigurationDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusQueryLoggingConfigurationDestinationBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsPrometheusQueryLoggingConfigurationDestinationBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusQueryLoggingConfigurationDestinationBlockFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsPrometheusQueryLoggingConfigurationDestinationBlockFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsPrometheusQueryLoggingConfigurationDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusQueryLoggingConfigurationDestinationBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

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
/// Block type for filters in AwsPrometheusQueryLoggingConfigurationDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusQueryLoggingConfigurationDestinationBlockFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The qsp_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QspThreshold is required")]
    public required TerraformValue<double> QspThreshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("qsp_threshold");
        set => SetArgument("qsp_threshold", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsPrometheusQueryLoggingConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsPrometheusQueryLoggingConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_prometheus_query_logging_configuration Terraform resource.
/// Manages a aws_prometheus_query_logging_configuration resource.
/// </summary>
public partial class AwsPrometheusQueryLoggingConfiguration(string name) : TerraformResource("aws_prometheus_query_logging_configuration", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusQueryLoggingConfigurationDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<AwsPrometheusQueryLoggingConfigurationDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsPrometheusQueryLoggingConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsPrometheusQueryLoggingConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
