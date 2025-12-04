using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_report_configuration in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_report_configuration";

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlockS3ConfigurationBlock : TerraformBlock
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
    /// The encryption_option attribute.
    /// </summary>
    public TerraformValue<string> EncryptionOption
    {
        get => GetArgument<TerraformValue<string>>("encryption_option") ?? AsReference("encryption_option");
        set => SetArgument("encryption_option", value);
    }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ObjectKeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("object_key_prefix");
        set => SetArgument("object_key_prefix", value);
    }

}


/// <summary>
/// Block type for last_run_summary in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "last_run_summary";

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
        => AsReference("failure_reason");

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    public TerraformValue<string> InvocationTime
        => AsReference("invocation_time");

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    public TerraformValue<string> RunStatus
        => AsReference("run_status");

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    public TerraformValue<string> TriggerTime
        => AsReference("trigger_time");

    /// <summary>
    /// ErrorReportLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlock>? ErrorReportLocation
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlock>>("error_report_location");
        set => SetArgument("error_report_location", value);
    }

    /// <summary>
    /// ExecutionStats block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockExecutionStatsBlock>? ExecutionStats
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockExecutionStatsBlock>>("execution_stats");
        set => SetArgument("execution_stats", value);
    }

    /// <summary>
    /// QueryInsightsResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlock>? QueryInsightsResponse
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlock>>("query_insights_response");
        set => SetArgument("query_insights_response", value);
    }

}

/// <summary>
/// Block type for error_report_location in AwsTimestreamqueryScheduledQueryLastRunSummaryBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_report_location";

    /// <summary>
    /// S3ReportLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlockS3ReportLocationBlock>? S3ReportLocation
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlockS3ReportLocationBlock>>("s3_report_location");
        set => SetArgument("s3_report_location", value);
    }

}

/// <summary>
/// Block type for s3_report_location in AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockErrorReportLocationBlockS3ReportLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_report_location";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string> BucketName
        => AsReference("bucket_name");

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    public TerraformValue<string> ObjectKey
        => AsReference("object_key");

}

/// <summary>
/// Block type for execution_stats in AwsTimestreamqueryScheduledQueryLastRunSummaryBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockExecutionStatsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_stats";

    /// <summary>
    /// The bytes_metered attribute.
    /// </summary>
    public TerraformValue<double> BytesMetered
        => AsReference("bytes_metered");

    /// <summary>
    /// The cumulative_bytes_scanned attribute.
    /// </summary>
    public TerraformValue<double> CumulativeBytesScanned
        => AsReference("cumulative_bytes_scanned");

    /// <summary>
    /// The data_writes attribute.
    /// </summary>
    public TerraformValue<double> DataWrites
        => AsReference("data_writes");

    /// <summary>
    /// The execution_time_in_millis attribute.
    /// </summary>
    public TerraformValue<double> ExecutionTimeInMillis
        => AsReference("execution_time_in_millis");

    /// <summary>
    /// The query_result_rows attribute.
    /// </summary>
    public TerraformValue<double> QueryResultRows
        => AsReference("query_result_rows");

    /// <summary>
    /// The records_ingested attribute.
    /// </summary>
    public TerraformValue<double> RecordsIngested
        => AsReference("records_ingested");

}

/// <summary>
/// Block type for query_insights_response in AwsTimestreamqueryScheduledQueryLastRunSummaryBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_insights_response";

    /// <summary>
    /// The output_bytes attribute.
    /// </summary>
    public TerraformValue<double> OutputBytes
        => AsReference("output_bytes");

    /// <summary>
    /// The output_rows attribute.
    /// </summary>
    public TerraformValue<double> OutputRows
        => AsReference("output_rows");

    /// <summary>
    /// The query_table_count attribute.
    /// </summary>
    public TerraformValue<double> QueryTableCount
        => AsReference("query_table_count");

    /// <summary>
    /// QuerySpatialCoverage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock>? QuerySpatialCoverage
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock>>("query_spatial_coverage");
        set => SetArgument("query_spatial_coverage", value);
    }

    /// <summary>
    /// QueryTemporalRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlock>? QueryTemporalRange
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlock>>("query_temporal_range");
        set => SetArgument("query_temporal_range", value);
    }

}

/// <summary>
/// Block type for query_spatial_coverage in AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_spatial_coverage";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

}

/// <summary>
/// Block type for max in AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQuerySpatialCoverageBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformList<string> PartitionKey
        => AsReference("partition_key");

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformValue<string> TableArn
        => AsReference("table_arn");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double> Value
        => AsReference("value");

}

/// <summary>
/// Block type for query_temporal_range in AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_temporal_range";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

}

/// <summary>
/// Block type for max in AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryLastRunSummaryBlockQueryInsightsResponseBlockQueryTemporalRangeBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformValue<string> TableArn
        => AsReference("table_arn");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double> Value
        => AsReference("value");

}


/// <summary>
/// Block type for notification_configuration in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_configuration";

    /// <summary>
    /// SnsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlockSnsConfigurationBlock>? SnsConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlockSnsConfigurationBlock>>("sns_configuration");
        set => SetArgument("sns_configuration", value);
    }

}

/// <summary>
/// Block type for sns_configuration in AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryNotificationConfigurationBlockSnsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns_configuration";

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Block type for recently_failed_runs in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recently_failed_runs";

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
        => AsReference("failure_reason");

    /// <summary>
    /// The invocation_time attribute.
    /// </summary>
    public TerraformValue<string> InvocationTime
        => AsReference("invocation_time");

    /// <summary>
    /// The run_status attribute.
    /// </summary>
    public TerraformValue<string> RunStatus
        => AsReference("run_status");

    /// <summary>
    /// The trigger_time attribute.
    /// </summary>
    public TerraformValue<string> TriggerTime
        => AsReference("trigger_time");

    /// <summary>
    /// ErrorReportLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlock>? ErrorReportLocation
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlock>>("error_report_location");
        set => SetArgument("error_report_location", value);
    }

    /// <summary>
    /// ExecutionStats block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockExecutionStatsBlock>? ExecutionStats
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockExecutionStatsBlock>>("execution_stats");
        set => SetArgument("execution_stats", value);
    }

    /// <summary>
    /// QueryInsightsResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlock>? QueryInsightsResponse
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlock>>("query_insights_response");
        set => SetArgument("query_insights_response", value);
    }

}

/// <summary>
/// Block type for error_report_location in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_report_location";

    /// <summary>
    /// S3ReportLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlockS3ReportLocationBlock>? S3ReportLocation
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlockS3ReportLocationBlock>>("s3_report_location");
        set => SetArgument("s3_report_location", value);
    }

}

/// <summary>
/// Block type for s3_report_location in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockErrorReportLocationBlockS3ReportLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_report_location";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string> BucketName
        => AsReference("bucket_name");

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    public TerraformValue<string> ObjectKey
        => AsReference("object_key");

}

/// <summary>
/// Block type for execution_stats in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockExecutionStatsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_stats";

    /// <summary>
    /// The bytes_metered attribute.
    /// </summary>
    public TerraformValue<double> BytesMetered
        => AsReference("bytes_metered");

    /// <summary>
    /// The cumulative_bytes_scanned attribute.
    /// </summary>
    public TerraformValue<double> CumulativeBytesScanned
        => AsReference("cumulative_bytes_scanned");

    /// <summary>
    /// The data_writes attribute.
    /// </summary>
    public TerraformValue<double> DataWrites
        => AsReference("data_writes");

    /// <summary>
    /// The execution_time_in_millis attribute.
    /// </summary>
    public TerraformValue<double> ExecutionTimeInMillis
        => AsReference("execution_time_in_millis");

    /// <summary>
    /// The query_result_rows attribute.
    /// </summary>
    public TerraformValue<double> QueryResultRows
        => AsReference("query_result_rows");

    /// <summary>
    /// The records_ingested attribute.
    /// </summary>
    public TerraformValue<double> RecordsIngested
        => AsReference("records_ingested");

}

/// <summary>
/// Block type for query_insights_response in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_insights_response";

    /// <summary>
    /// The output_bytes attribute.
    /// </summary>
    public TerraformValue<double> OutputBytes
        => AsReference("output_bytes");

    /// <summary>
    /// The output_rows attribute.
    /// </summary>
    public TerraformValue<double> OutputRows
        => AsReference("output_rows");

    /// <summary>
    /// The query_table_count attribute.
    /// </summary>
    public TerraformValue<double> QueryTableCount
        => AsReference("query_table_count");

    /// <summary>
    /// QuerySpatialCoverage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock>? QuerySpatialCoverage
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock>>("query_spatial_coverage");
        set => SetArgument("query_spatial_coverage", value);
    }

    /// <summary>
    /// QueryTemporalRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlock>? QueryTemporalRange
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlock>>("query_temporal_range");
        set => SetArgument("query_temporal_range", value);
    }

}

/// <summary>
/// Block type for query_spatial_coverage in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_spatial_coverage";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

}

/// <summary>
/// Block type for max in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQuerySpatialCoverageBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformList<string> PartitionKey
        => AsReference("partition_key");

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformValue<string> TableArn
        => AsReference("table_arn");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double> Value
        => AsReference("value");

}

/// <summary>
/// Block type for query_temporal_range in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_temporal_range";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

}

/// <summary>
/// Block type for max in AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlockQueryInsightsResponseBlockQueryTemporalRangeBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformValue<string> TableArn
        => AsReference("table_arn");

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double> Value
        => AsReference("value");

}


/// <summary>
/// Block type for schedule_configuration in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_configuration";

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

}


/// <summary>
/// Block type for target_configuration in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_configuration";

    /// <summary>
    /// TimestreamConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlock>? TimestreamConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlock>>("timestream_configuration");
        set => SetArgument("timestream_configuration", value);
    }

}

/// <summary>
/// Block type for timestream_configuration in AwsTimestreamqueryScheduledQueryTargetConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestream_configuration";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The measure_name_column attribute.
    /// </summary>
    public TerraformValue<string>? MeasureNameColumn
    {
        get => GetArgument<TerraformValue<string>>("measure_name_column");
        set => SetArgument("measure_name_column", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The time_column attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeColumn is required")]
    public required TerraformValue<string> TimeColumn
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_column");
        set => SetArgument("time_column", value);
    }

    /// <summary>
    /// DimensionMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockDimensionMappingBlock>? DimensionMapping
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockDimensionMappingBlock>>("dimension_mapping");
        set => SetArgument("dimension_mapping", value);
    }

    /// <summary>
    /// MixedMeasureMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlock>? MixedMeasureMapping
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlock>>("mixed_measure_mapping");
        set => SetArgument("mixed_measure_mapping", value);
    }

    /// <summary>
    /// MultiMeasureMappings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlock>? MultiMeasureMappings
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlock>>("multi_measure_mappings");
        set => SetArgument("multi_measure_mappings", value);
    }

}

/// <summary>
/// Block type for dimension_mapping in AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockDimensionMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension_mapping";

    /// <summary>
    /// The dimension_value_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionValueType is required")]
    public required TerraformValue<string> DimensionValueType
    {
        get => GetRequiredArgument<TerraformValue<string>>("dimension_value_type");
        set => SetArgument("dimension_value_type", value);
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

}

/// <summary>
/// Block type for mixed_measure_mapping in AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mixed_measure_mapping";

    /// <summary>
    /// The measure_name attribute.
    /// </summary>
    public TerraformValue<string>? MeasureName
    {
        get => GetArgument<TerraformValue<string>>("measure_name");
        set => SetArgument("measure_name", value);
    }

    /// <summary>
    /// The measure_value_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeasureValueType is required")]
    public required TerraformValue<string> MeasureValueType
    {
        get => GetRequiredArgument<TerraformValue<string>>("measure_value_type");
        set => SetArgument("measure_value_type", value);
    }

    /// <summary>
    /// The source_column attribute.
    /// </summary>
    public TerraformValue<string>? SourceColumn
    {
        get => GetArgument<TerraformValue<string>>("source_column");
        set => SetArgument("source_column", value);
    }

    /// <summary>
    /// The target_measure_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetMeasureName
    {
        get => GetArgument<TerraformValue<string>>("target_measure_name");
        set => SetArgument("target_measure_name", value);
    }

    /// <summary>
    /// MultiMeasureAttributeMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlockMultiMeasureAttributeMappingBlock>? MultiMeasureAttributeMapping
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlockMultiMeasureAttributeMappingBlock>>("multi_measure_attribute_mapping");
        set => SetArgument("multi_measure_attribute_mapping", value);
    }

}

/// <summary>
/// Block type for multi_measure_attribute_mapping in AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMixedMeasureMappingBlockMultiMeasureAttributeMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_measure_attribute_mapping";

    /// <summary>
    /// The measure_value_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeasureValueType is required")]
    public required TerraformValue<string> MeasureValueType
    {
        get => GetRequiredArgument<TerraformValue<string>>("measure_value_type");
        set => SetArgument("measure_value_type", value);
    }

    /// <summary>
    /// The source_column attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceColumn is required")]
    public required TerraformValue<string> SourceColumn
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_column");
        set => SetArgument("source_column", value);
    }

    /// <summary>
    /// The target_multi_measure_attribute_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetMultiMeasureAttributeName
    {
        get => GetArgument<TerraformValue<string>>("target_multi_measure_attribute_name");
        set => SetArgument("target_multi_measure_attribute_name", value);
    }

}

/// <summary>
/// Block type for multi_measure_mappings in AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_measure_mappings";

    /// <summary>
    /// The target_multi_measure_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetMultiMeasureName
    {
        get => GetArgument<TerraformValue<string>>("target_multi_measure_name");
        set => SetArgument("target_multi_measure_name", value);
    }

    /// <summary>
    /// MultiMeasureAttributeMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlockMultiMeasureAttributeMappingBlock>? MultiMeasureAttributeMapping
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlockMultiMeasureAttributeMappingBlock>>("multi_measure_attribute_mapping");
        set => SetArgument("multi_measure_attribute_mapping", value);
    }

}

/// <summary>
/// Block type for multi_measure_attribute_mapping in AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamqueryScheduledQueryTargetConfigurationBlockTimestreamConfigurationBlockMultiMeasureMappingsBlockMultiMeasureAttributeMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_measure_attribute_mapping";

    /// <summary>
    /// The measure_value_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeasureValueType is required")]
    public required TerraformValue<string> MeasureValueType
    {
        get => GetRequiredArgument<TerraformValue<string>>("measure_value_type");
        set => SetArgument("measure_value_type", value);
    }

    /// <summary>
    /// The source_column attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceColumn is required")]
    public required TerraformValue<string> SourceColumn
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_column");
        set => SetArgument("source_column", value);
    }

    /// <summary>
    /// The target_multi_measure_attribute_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetMultiMeasureAttributeName
    {
        get => GetArgument<TerraformValue<string>>("target_multi_measure_attribute_name");
        set => SetArgument("target_multi_measure_attribute_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsTimestreamqueryScheduledQuery.
/// Nesting mode: single
/// </summary>
public class AwsTimestreamqueryScheduledQueryTimeoutsBlock : TerraformBlock
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
/// Represents a aws_timestreamquery_scheduled_query Terraform resource.
/// Manages a aws_timestreamquery_scheduled_query resource.
/// </summary>
public partial class AwsTimestreamqueryScheduledQuery(string name) : TerraformResource("aws_timestreamquery_scheduled_query", name)
{
    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformValue<string> QueryString
    {
        get => GetRequiredArgument<TerraformValue<string>>("query_string");
        set => SetArgument("query_string", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The next_invocation_time attribute.
    /// </summary>
    public TerraformValue<string> NextInvocationTime
        => AsReference("next_invocation_time");

    /// <summary>
    /// The previous_invocation_time attribute.
    /// </summary>
    public TerraformValue<string> PreviousInvocationTime
        => AsReference("previous_invocation_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// ErrorReportConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>? ErrorReportConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryErrorReportConfigurationBlock>>("error_report_configuration");
        set => SetArgument("error_report_configuration", value);
    }

    /// <summary>
    /// LastRunSummary block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>? LastRunSummary
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryLastRunSummaryBlock>>("last_run_summary");
        set => SetArgument("last_run_summary", value);
    }

    /// <summary>
    /// NotificationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>? NotificationConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryNotificationConfigurationBlock>>("notification_configuration");
        set => SetArgument("notification_configuration", value);
    }

    /// <summary>
    /// RecentlyFailedRuns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>? RecentlyFailedRuns
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryRecentlyFailedRunsBlock>>("recently_failed_runs");
        set => SetArgument("recently_failed_runs", value);
    }

    /// <summary>
    /// ScheduleConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>? ScheduleConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryScheduleConfigurationBlock>>("schedule_configuration");
        set => SetArgument("schedule_configuration", value);
    }

    /// <summary>
    /// TargetConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>? TargetConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreamqueryScheduledQueryTargetConfigurationBlock>>("target_configuration");
        set => SetArgument("target_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsTimestreamqueryScheduledQueryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsTimestreamqueryScheduledQueryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
