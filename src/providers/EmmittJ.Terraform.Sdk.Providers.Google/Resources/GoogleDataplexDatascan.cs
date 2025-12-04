using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data in GoogleDataplexDatascan.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data";

    /// <summary>
    /// The Dataplex entity that represents the data source(e.g. BigQuery table) for Datascan.
    /// </summary>
    public TerraformValue<string>? Entity
    {
        get => GetArgument<TerraformValue<string>>("entity");
        set => SetArgument("entity", value);
    }

    /// <summary>
    /// The service-qualified full resource name of the cloud resource for a DataScan job to scan against. The field could be:
    /// Cloud Storage bucket (//storage.googleapis.com/projects/PROJECT_ID/buckets/BUCKET_ID) for DataDiscoveryScan OR BigQuery table of type &amp;quot;TABLE&amp;quot; (/bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID) for DataProfileScan/DataQualityScan.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

}


/// <summary>
/// Block type for data_discovery_spec in GoogleDataplexDatascan.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_discovery_spec";

    /// <summary>
    /// BigqueryPublishingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryPublishingConfig block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockBigqueryPublishingConfigBlock>? BigqueryPublishingConfig
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockBigqueryPublishingConfigBlock>>("bigquery_publishing_config");
        set => SetArgument("bigquery_publishing_config", value);
    }

    /// <summary>
    /// StorageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlock>? StorageConfig
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlock>>("storage_config");
        set => SetArgument("storage_config", value);
    }

}

/// <summary>
/// Block type for bigquery_publishing_config in GoogleDataplexDatascanDataDiscoverySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlockBigqueryPublishingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_publishing_config";

    /// <summary>
    /// The BigQuery connection used to create BigLake tables. Must be in the form &#39;projects/{projectId}/locations/{locationId}/connections/{connection_id}&#39;.
    /// </summary>
    public TerraformValue<string>? ConnectionAttribute
    {
        get => GetArgument<TerraformValue<string>>("connection");
        set => SetArgument("connection", value);
    }

    /// <summary>
    /// The location of the BigQuery dataset to publish BigLake external or non-BigLake external tables to.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project of the BigQuery dataset to publish BigLake external or non-BigLake external tables to. If not specified, the project of the Cloud Storage bucket will be used. The format is &amp;quot;projects/{project_id_or_number}&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Determines whether to publish discovered tables as BigLake external tables or non-BigLake external tables. Possible values: [&amp;quot;TABLE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;EXTERNAL&amp;quot;, &amp;quot;BIGLAKE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TableType
    {
        get => GetArgument<TerraformValue<string>>("table_type");
        set => SetArgument("table_type", value);
    }

}

/// <summary>
/// Block type for storage_config in GoogleDataplexDatascanDataDiscoverySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_config";

    /// <summary>
    /// Defines the data to exclude during discovery. Provide a list of patterns that identify the data to exclude. For Cloud Storage bucket assets, these patterns are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these patterns are interpreted as patterns to match table names.
    /// </summary>
    public TerraformList<string>? ExcludePatterns
    {
        get => GetArgument<TerraformList<string>>("exclude_patterns");
        set => SetArgument("exclude_patterns", value);
    }

    /// <summary>
    /// Defines the data to include during discovery when only a subset of the data should be considered. Provide a list of patterns that identify the data to include. For Cloud Storage bucket assets, these patterns are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these patterns are interpreted as patterns to match table names.
    /// </summary>
    public TerraformList<string>? IncludePatterns
    {
        get => GetArgument<TerraformList<string>>("include_patterns");
        set => SetArgument("include_patterns", value);
    }

    /// <summary>
    /// CsvOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlockCsvOptionsBlock>? CsvOptions
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlockCsvOptionsBlock>>("csv_options");
        set => SetArgument("csv_options", value);
    }

    /// <summary>
    /// JsonOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonOptions block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlockJsonOptionsBlock>? JsonOptions
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlockJsonOptionsBlock>>("json_options");
        set => SetArgument("json_options", value);
    }

}

/// <summary>
/// Block type for csv_options in GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlockCsvOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_options";

    /// <summary>
    /// The delimiter that is used to separate values. The default is &#39;,&#39; (comma).
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => GetArgument<TerraformValue<string>>("delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The character encoding of the data. The default is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The number of rows to interpret as header rows that should be skipped when reading data rows.
    /// </summary>
    public TerraformValue<double>? HeaderRows
    {
        get => GetArgument<TerraformValue<double>>("header_rows");
        set => SetArgument("header_rows", value);
    }

    /// <summary>
    /// The character used to quote column values. Accepts &#39;&amp;quot;&#39; (double quotation mark) or &#39;&#39;&#39; (single quotation mark). If unspecified, defaults to &#39;&amp;quot;&#39; (double quotation mark).
    /// </summary>
    public TerraformValue<string>? Quote
    {
        get => GetArgument<TerraformValue<string>>("quote");
        set => SetArgument("quote", value);
    }

    /// <summary>
    /// Whether to disable the inference of data types for CSV data. If true, all columns are registered as strings.
    /// </summary>
    public TerraformValue<bool>? TypeInferenceDisabled
    {
        get => GetArgument<TerraformValue<bool>>("type_inference_disabled");
        set => SetArgument("type_inference_disabled", value);
    }

}

/// <summary>
/// Block type for json_options in GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlockStorageConfigBlockJsonOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_options";

    /// <summary>
    /// The character encoding of the data. The default is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// Whether to disable the inference of data types for JSON data. If true, all columns are registered as their primitive types (strings, number, or boolean).
    /// </summary>
    public TerraformValue<bool>? TypeInferenceDisabled
    {
        get => GetArgument<TerraformValue<bool>>("type_inference_disabled");
        set => SetArgument("type_inference_disabled", value);
    }

}


/// <summary>
/// Block type for data_profile_spec in GoogleDataplexDatascan.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_profile_spec";

    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    public TerraformValue<string>? RowFilter
    {
        get => GetArgument<TerraformValue<string>>("row_filter");
        set => SetArgument("row_filter", value);
    }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    public TerraformValue<double>? SamplingPercent
    {
        get => GetArgument<TerraformValue<double>>("sampling_percent");
        set => SetArgument("sampling_percent", value);
    }

    /// <summary>
    /// ExcludeFields block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeFields block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataProfileSpecBlockExcludeFieldsBlock>? ExcludeFields
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataProfileSpecBlockExcludeFieldsBlock>>("exclude_fields");
        set => SetArgument("exclude_fields", value);
    }

    /// <summary>
    /// IncludeFields block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeFields block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataProfileSpecBlockIncludeFieldsBlock>? IncludeFields
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataProfileSpecBlockIncludeFieldsBlock>>("include_fields");
        set => SetArgument("include_fields", value);
    }

    /// <summary>
    /// PostScanActions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostScanActions block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlock>? PostScanActions
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlock>>("post_scan_actions");
        set => SetArgument("post_scan_actions", value);
    }

}

/// <summary>
/// Block type for exclude_fields in GoogleDataplexDatascanDataProfileSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlockExcludeFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_fields";

    /// <summary>
    /// Expected input is a list of fully qualified names of fields as in the schema.
    /// Only top-level field names for nested fields are supported.
    /// For instance, if &#39;x&#39; is of nested field type, listing &#39;x&#39; is supported but &#39;x.y.z&#39; is not supported. Here &#39;y&#39; and &#39;y.z&#39; are nested fields of &#39;x&#39;.
    /// </summary>
    public TerraformList<string>? FieldNames
    {
        get => GetArgument<TerraformList<string>>("field_names");
        set => SetArgument("field_names", value);
    }

}

/// <summary>
/// Block type for include_fields in GoogleDataplexDatascanDataProfileSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlockIncludeFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_fields";

    /// <summary>
    /// Expected input is a list of fully qualified names of fields as in the schema.
    /// Only top-level field names for nested fields are supported.
    /// For instance, if &#39;x&#39; is of nested field type, listing &#39;x&#39; is supported but &#39;x.y.z&#39; is not supported. Here &#39;y&#39; and &#39;y.z&#39; are nested fields of &#39;x&#39;.
    /// </summary>
    public TerraformList<string>? FieldNames
    {
        get => GetArgument<TerraformList<string>>("field_names");
        set => SetArgument("field_names", value);
    }

}

/// <summary>
/// Block type for post_scan_actions in GoogleDataplexDatascanDataProfileSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_scan_actions";

    /// <summary>
    /// BigqueryExport block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryExport block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlockBigqueryExportBlock>? BigqueryExport
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlockBigqueryExportBlock>>("bigquery_export");
        set => SetArgument("bigquery_export", value);
    }

}

/// <summary>
/// Block type for bigquery_export in GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlockPostScanActionsBlockBigqueryExportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_export";

    /// <summary>
    /// The BigQuery table to export DataProfileScan results to.
    /// Format://bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID
    /// </summary>
    public TerraformValue<string>? ResultsTable
    {
        get => GetArgument<TerraformValue<string>>("results_table");
        set => SetArgument("results_table", value);
    }

}


/// <summary>
/// Block type for data_quality_spec in GoogleDataplexDatascan.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_quality_spec";

    /// <summary>
    /// If set, the latest DataScan job result will be published to Dataplex Catalog.
    /// </summary>
    public TerraformValue<bool>? CatalogPublishingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("catalog_publishing_enabled");
        set => SetArgument("catalog_publishing_enabled", value);
    }

    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    public TerraformValue<string>? RowFilter
    {
        get => GetArgument<TerraformValue<string>>("row_filter");
        set => SetArgument("row_filter", value);
    }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    public TerraformValue<double>? SamplingPercent
    {
        get => GetArgument<TerraformValue<double>>("sampling_percent");
        set => SetArgument("sampling_percent", value);
    }

    /// <summary>
    /// PostScanActions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostScanActions block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlock>? PostScanActions
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlock>>("post_scan_actions");
        set => SetArgument("post_scan_actions", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlock>? Rules
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for post_scan_actions in GoogleDataplexDatascanDataQualitySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_scan_actions";

    /// <summary>
    /// BigqueryExport block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryExport block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockBigqueryExportBlock>? BigqueryExport
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockBigqueryExportBlock>>("bigquery_export");
        set => SetArgument("bigquery_export", value);
    }

    /// <summary>
    /// NotificationReport block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationReport block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock>? NotificationReport
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock>>("notification_report");
        set => SetArgument("notification_report", value);
    }

}

/// <summary>
/// Block type for bigquery_export in GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockBigqueryExportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_export";

    /// <summary>
    /// The BigQuery table to export DataQualityScan results to.
    /// Format://bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID
    /// </summary>
    public TerraformValue<string>? ResultsTable
    {
        get => GetArgument<TerraformValue<string>>("results_table");
        set => SetArgument("results_table", value);
    }

}

/// <summary>
/// Block type for notification_report in GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_report";

    /// <summary>
    /// JobEndTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobEndTrigger block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockJobEndTriggerBlock>? JobEndTrigger
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockJobEndTriggerBlock>>("job_end_trigger");
        set => SetArgument("job_end_trigger", value);
    }

    /// <summary>
    /// JobFailureTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobFailureTrigger block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockJobFailureTriggerBlock>? JobFailureTrigger
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockJobFailureTriggerBlock>>("job_failure_trigger");
        set => SetArgument("job_failure_trigger", value);
    }

    /// <summary>
    /// Recipients block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Recipients is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Recipients block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Recipients block(s) allowed")]
    public required TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockRecipientsBlock> Recipients
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockRecipientsBlock>>("recipients");
        set => SetArgument("recipients", value);
    }

    /// <summary>
    /// ScoreThresholdTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScoreThresholdTrigger block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockScoreThresholdTriggerBlock>? ScoreThresholdTrigger
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockScoreThresholdTriggerBlock>>("score_threshold_trigger");
        set => SetArgument("score_threshold_trigger", value);
    }

}

/// <summary>
/// Block type for job_end_trigger in GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockJobEndTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_end_trigger";

}

/// <summary>
/// Block type for job_failure_trigger in GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockJobFailureTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_failure_trigger";

}

/// <summary>
/// Block type for recipients in GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockRecipientsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recipients";

    /// <summary>
    /// The email recipients who will receive the DataQualityScan results report.
    /// </summary>
    public TerraformList<string>? Emails
    {
        get => GetArgument<TerraformList<string>>("emails");
        set => SetArgument("emails", value);
    }

}

/// <summary>
/// Block type for score_threshold_trigger in GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockPostScanActionsBlockNotificationReportBlockScoreThresholdTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "score_threshold_trigger";

    /// <summary>
    /// The score range is in [0,100].
    /// </summary>
    public TerraformValue<double>? ScoreThreshold
    {
        get => GetArgument<TerraformValue<double>>("score_threshold");
        set => SetArgument("score_threshold", value);
    }

}

/// <summary>
/// Block type for rules in GoogleDataplexDatascanDataQualitySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The unnested column which this rule is evaluated against.
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// Description of the rule.
    /// The maximum length is 1,024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The dimension name a rule belongs to. Custom dimension name is supported with all uppercase letters and maximum length of 30 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dimension is required")]
    public required TerraformValue<string> Dimension
    {
        get => GetArgument<TerraformValue<string>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Rows with null values will automatically fail a rule, unless ignoreNull is true. In that case, such null rows are trivially considered passing. Only applicable to ColumnMap rules.
    /// </summary>
    public TerraformValue<bool>? IgnoreNull
    {
        get => GetArgument<TerraformValue<bool>>("ignore_null");
        set => SetArgument("ignore_null", value);
    }

    /// <summary>
    /// A mutable name for the rule.
    /// The name must contain only letters (a-z, A-Z), numbers (0-9), or hyphens (-).
    /// The maximum length is 63 characters.
    /// Must start with a letter.
    /// Must end with a number or a letter.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Whether the Rule is active or suspended. Default = false.
    /// </summary>
    public TerraformValue<bool>? Suspended
    {
        get => GetArgument<TerraformValue<bool>>("suspended");
        set => SetArgument("suspended", value);
    }

    /// <summary>
    /// The minimum ratio of passing_rows / total_rows required to pass this rule, with a range of [0.0, 1.0]. 0 indicates default value (i.e. 1.0).
    /// </summary>
    public TerraformValue<double>? Threshold
    {
        get => GetArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// NonNullExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NonNullExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockNonNullExpectationBlock>? NonNullExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockNonNullExpectationBlock>>("non_null_expectation");
        set => SetArgument("non_null_expectation", value);
    }

    /// <summary>
    /// RangeExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangeExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRangeExpectationBlock>? RangeExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRangeExpectationBlock>>("range_expectation");
        set => SetArgument("range_expectation", value);
    }

    /// <summary>
    /// RegexExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegexExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRegexExpectationBlock>? RegexExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRegexExpectationBlock>>("regex_expectation");
        set => SetArgument("regex_expectation", value);
    }

    /// <summary>
    /// RowConditionExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowConditionExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRowConditionExpectationBlock>? RowConditionExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRowConditionExpectationBlock>>("row_condition_expectation");
        set => SetArgument("row_condition_expectation", value);
    }

    /// <summary>
    /// SetExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SetExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockSetExpectationBlock>? SetExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockSetExpectationBlock>>("set_expectation");
        set => SetArgument("set_expectation", value);
    }

    /// <summary>
    /// SqlAssertion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlAssertion block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockSqlAssertionBlock>? SqlAssertion
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockSqlAssertionBlock>>("sql_assertion");
        set => SetArgument("sql_assertion", value);
    }

    /// <summary>
    /// StatisticRangeExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StatisticRangeExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockStatisticRangeExpectationBlock>? StatisticRangeExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockStatisticRangeExpectationBlock>>("statistic_range_expectation");
        set => SetArgument("statistic_range_expectation", value);
    }

    /// <summary>
    /// TableConditionExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableConditionExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockTableConditionExpectationBlock>? TableConditionExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockTableConditionExpectationBlock>>("table_condition_expectation");
        set => SetArgument("table_condition_expectation", value);
    }

    /// <summary>
    /// UniquenessExpectation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UniquenessExpectation block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockUniquenessExpectationBlock>? UniquenessExpectation
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlockRulesBlockUniquenessExpectationBlock>>("uniqueness_expectation");
        set => SetArgument("uniqueness_expectation", value);
    }

}

/// <summary>
/// Block type for non_null_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockNonNullExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "non_null_expectation";

}

/// <summary>
/// Block type for range_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRangeExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range_expectation";

    /// <summary>
    /// The maximum column value allowed for a row to pass this validation. At least one of minValue and maxValue need to be provided.
    /// </summary>
    public TerraformValue<string>? MaxValue
    {
        get => GetArgument<TerraformValue<string>>("max_value");
        set => SetArgument("max_value", value);
    }

    /// <summary>
    /// The minimum column value allowed for a row to pass this validation. At least one of minValue and maxValue need to be provided.
    /// </summary>
    public TerraformValue<string>? MinValue
    {
        get => GetArgument<TerraformValue<string>>("min_value");
        set => SetArgument("min_value", value);
    }

    /// <summary>
    /// Whether each value needs to be strictly lesser than (&#39;&amp;lt;&#39;) the maximum, or if equality is allowed.
    /// Only relevant if a maxValue has been defined. Default = false.
    /// </summary>
    public TerraformValue<bool>? StrictMaxEnabled
    {
        get => GetArgument<TerraformValue<bool>>("strict_max_enabled");
        set => SetArgument("strict_max_enabled", value);
    }

    /// <summary>
    /// Whether each value needs to be strictly greater than (&#39;&amp;gt;&#39;) the minimum, or if equality is allowed.
    /// Only relevant if a minValue has been defined. Default = false.
    /// </summary>
    public TerraformValue<bool>? StrictMinEnabled
    {
        get => GetArgument<TerraformValue<bool>>("strict_min_enabled");
        set => SetArgument("strict_min_enabled", value);
    }

}

/// <summary>
/// Block type for regex_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRegexExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex_expectation";

    /// <summary>
    /// A regular expression the column value is expected to match.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regex is required")]
    public required TerraformValue<string> Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

}

/// <summary>
/// Block type for row_condition_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockRowConditionExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "row_condition_expectation";

    /// <summary>
    /// The SQL expression.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlExpression is required")]
    public required TerraformValue<string> SqlExpression
    {
        get => GetArgument<TerraformValue<string>>("sql_expression");
        set => SetArgument("sql_expression", value);
    }

}

/// <summary>
/// Block type for set_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockSetExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "set_expectation";

    /// <summary>
    /// Expected values for the column value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for sql_assertion in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockSqlAssertionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_assertion";

    /// <summary>
    /// The SQL statement.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlStatement is required")]
    public required TerraformValue<string> SqlStatement
    {
        get => GetArgument<TerraformValue<string>>("sql_statement");
        set => SetArgument("sql_statement", value);
    }

}

/// <summary>
/// Block type for statistic_range_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockStatisticRangeExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "statistic_range_expectation";

    /// <summary>
    /// The maximum column statistic value allowed for a row to pass this validation.
    /// At least one of minValue and maxValue need to be provided.
    /// </summary>
    public TerraformValue<string>? MaxValue
    {
        get => GetArgument<TerraformValue<string>>("max_value");
        set => SetArgument("max_value", value);
    }

    /// <summary>
    /// The minimum column statistic value allowed for a row to pass this validation.
    /// At least one of minValue and maxValue need to be provided.
    /// </summary>
    public TerraformValue<string>? MinValue
    {
        get => GetArgument<TerraformValue<string>>("min_value");
        set => SetArgument("min_value", value);
    }

    /// <summary>
    /// column statistics. Possible values: [&amp;quot;STATISTIC_UNDEFINED&amp;quot;, &amp;quot;MEAN&amp;quot;, &amp;quot;MIN&amp;quot;, &amp;quot;MAX&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statistic is required")]
    public required TerraformValue<string> Statistic
    {
        get => GetArgument<TerraformValue<string>>("statistic");
        set => SetArgument("statistic", value);
    }

    /// <summary>
    /// Whether column statistic needs to be strictly lesser than (&#39;&amp;lt;&#39;) the maximum, or if equality is allowed.
    /// Only relevant if a maxValue has been defined. Default = false.
    /// </summary>
    public TerraformValue<bool>? StrictMaxEnabled
    {
        get => GetArgument<TerraformValue<bool>>("strict_max_enabled");
        set => SetArgument("strict_max_enabled", value);
    }

    /// <summary>
    /// Whether column statistic needs to be strictly greater than (&#39;&amp;gt;&#39;) the minimum, or if equality is allowed.
    /// Only relevant if a minValue has been defined. Default = false.
    /// </summary>
    public TerraformValue<bool>? StrictMinEnabled
    {
        get => GetArgument<TerraformValue<bool>>("strict_min_enabled");
        set => SetArgument("strict_min_enabled", value);
    }

}

/// <summary>
/// Block type for table_condition_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockTableConditionExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_condition_expectation";

    /// <summary>
    /// The SQL expression.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlExpression is required")]
    public required TerraformValue<string> SqlExpression
    {
        get => GetArgument<TerraformValue<string>>("sql_expression");
        set => SetArgument("sql_expression", value);
    }

}

/// <summary>
/// Block type for uniqueness_expectation in GoogleDataplexDatascanDataQualitySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlockRulesBlockUniquenessExpectationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "uniqueness_expectation";

}


/// <summary>
/// Block type for execution_spec in GoogleDataplexDatascan.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanExecutionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_spec";

    /// <summary>
    /// The unnested field (of type Date or Timestamp) that contains values which monotonically increase over time. If not specified, a data scan will run for all data in the table.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public required TerraformList<GoogleDataplexDatascanExecutionSpecBlockTriggerBlock> Trigger
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexDatascanExecutionSpecBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for trigger in GoogleDataplexDatascanExecutionSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanExecutionSpecBlockTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// OnDemand block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemand block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanExecutionSpecBlockTriggerBlockOnDemandBlock>? OnDemand
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanExecutionSpecBlockTriggerBlockOnDemandBlock>>("on_demand");
        set => SetArgument("on_demand", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanExecutionSpecBlockTriggerBlockScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanExecutionSpecBlockTriggerBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for on_demand in GoogleDataplexDatascanExecutionSpecBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanExecutionSpecBlockTriggerBlockOnDemandBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand";

}

/// <summary>
/// Block type for schedule in GoogleDataplexDatascanExecutionSpecBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanExecutionSpecBlockTriggerBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// Cron schedule for running scans periodically. This field is required for Schedule scans.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cron is required")]
    public required TerraformValue<string> Cron
    {
        get => GetArgument<TerraformValue<string>>("cron");
        set => SetArgument("cron", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexDatascan.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexDatascanTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataplex_datascan Terraform resource.
/// Manages a google_dataplex_datascan resource.
/// </summary>
public partial class GoogleDataplexDatascan(string name) : TerraformResource("google_dataplex_datascan", name)
{
    /// <summary>
    /// DataScan identifier. Must contain only lowercase letters, numbers and hyphens. Must start with a letter. Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    public required TerraformValue<string> DataScanId
    {
        get => GetArgument<TerraformValue<string>>("data_scan_id");
        set => SetArgument("data_scan_id", value);
    }

    /// <summary>
    /// Description of the scan.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels for the scan. A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where the data scan should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time when the scan was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Status of the data scan execution.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExecutionStatus
        => AsReference("execution_status");

    /// <summary>
    /// The relative resource name of the scan, of the form: projects/{project}/locations/{locationId}/dataScans/{datascan_id}, where project refers to a project_id or project_number and locationId refers to a GCP region.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Current state of the DataScan.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The type of DataScan.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// System generated globally unique ID for the scan. This ID will be different if the scan is deleted and re-created with the same name.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The time when the scan was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Data block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Data block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Data block(s) allowed")]
    public required TerraformList<GoogleDataplexDatascanDataBlock> Data
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexDatascanDataBlock>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// DataDiscoverySpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDiscoverySpec block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlock>? DataDiscoverySpec
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataDiscoverySpecBlock>>("data_discovery_spec");
        set => SetArgument("data_discovery_spec", value);
    }

    /// <summary>
    /// DataProfileSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProfileSpec block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataProfileSpecBlock>? DataProfileSpec
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataProfileSpecBlock>>("data_profile_spec");
        set => SetArgument("data_profile_spec", value);
    }

    /// <summary>
    /// DataQualitySpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualitySpec block(s) allowed")]
    public TerraformList<GoogleDataplexDatascanDataQualitySpecBlock>? DataQualitySpec
    {
        get => GetArgument<TerraformList<GoogleDataplexDatascanDataQualitySpecBlock>>("data_quality_spec");
        set => SetArgument("data_quality_spec", value);
    }

    /// <summary>
    /// ExecutionSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    public required TerraformList<GoogleDataplexDatascanExecutionSpecBlock> ExecutionSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexDatascanExecutionSpecBlock>>("execution_spec");
        set => SetArgument("execution_spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexDatascanTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexDatascanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
