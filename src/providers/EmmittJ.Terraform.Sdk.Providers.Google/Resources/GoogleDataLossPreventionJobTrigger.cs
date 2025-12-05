using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_job in GoogleDataLossPreventionJobTrigger.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_job";

    /// <summary>
    /// The name of the template to run when this job is triggered.
    /// </summary>
    public TerraformValue<string>? InspectTemplateName
    {
        get => GetArgument<TerraformValue<string>>("inspect_template_name");
        set => SetArgument("inspect_template_name", value);
    }

    /// <summary>
    /// Actions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock>? Actions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// InspectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock>? InspectConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock>>("inspect_config");
        set => SetArgument("inspect_config", value);
    }

    /// <summary>
    /// StorageConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock> StorageConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock>>("storage_config");
        set => SetArgument("storage_config", value);
    }

}

/// <summary>
/// Block type for actions in GoogleDataLossPreventionJobTriggerInspectJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// Deidentify block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deidentify block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlock>? Deidentify
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlock>>("deidentify");
        set => SetArgument("deidentify", value);
    }

    /// <summary>
    /// JobNotificationEmails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobNotificationEmails block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockJobNotificationEmailsBlock>? JobNotificationEmails
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockJobNotificationEmailsBlock>>("job_notification_emails");
        set => SetArgument("job_notification_emails", value);
    }

    /// <summary>
    /// PubSub block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubSub block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPubSubBlock>? PubSub
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPubSubBlock>>("pub_sub");
        set => SetArgument("pub_sub", value);
    }

    /// <summary>
    /// PublishFindingsToCloudDataCatalog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishFindingsToCloudDataCatalog block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishFindingsToCloudDataCatalogBlock>? PublishFindingsToCloudDataCatalog
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishFindingsToCloudDataCatalogBlock>>("publish_findings_to_cloud_data_catalog");
        set => SetArgument("publish_findings_to_cloud_data_catalog", value);
    }

    /// <summary>
    /// PublishFindingsToDataplexCatalog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishFindingsToDataplexCatalog block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishFindingsToDataplexCatalogBlock>? PublishFindingsToDataplexCatalog
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishFindingsToDataplexCatalogBlock>>("publish_findings_to_dataplex_catalog");
        set => SetArgument("publish_findings_to_dataplex_catalog", value);
    }

    /// <summary>
    /// PublishSummaryToCscc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishSummaryToCscc block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishSummaryToCsccBlock>? PublishSummaryToCscc
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishSummaryToCsccBlock>>("publish_summary_to_cscc");
        set => SetArgument("publish_summary_to_cscc", value);
    }

    /// <summary>
    /// PublishToStackdriver block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishToStackdriver block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishToStackdriverBlock>? PublishToStackdriver
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishToStackdriverBlock>>("publish_to_stackdriver");
        set => SetArgument("publish_to_stackdriver", value);
    }

    /// <summary>
    /// SaveFindings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SaveFindings block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlock>? SaveFindings
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlock>>("save_findings");
        set => SetArgument("save_findings", value);
    }

}

/// <summary>
/// Block type for deidentify in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deidentify";

    /// <summary>
    /// User settable Cloud Storage bucket and folders to store de-identified files.
    /// 
    /// This field must be set for cloud storage deidentification.
    /// 
    /// The output Cloud Storage bucket must be different from the input bucket.
    /// 
    /// De-identified files will overwrite files in the output path.
    /// 
    /// Form of: gs://bucket/folder/ or gs://bucket
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudStorageOutput is required")]
    public required TerraformValue<string> CloudStorageOutput
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_storage_output");
        set => SetArgument("cloud_storage_output", value);
    }

    /// <summary>
    /// List of user-specified file type groups to transform. If specified, only the files with these filetypes will be transformed.
    /// 
    /// If empty, all supported files will be transformed. Supported types may be automatically added over time.
    /// 
    /// If a file type is set in this field that isn&#39;t supported by the Deidentify action then the job will fail and will not be successfully created/started. Possible values: [&amp;quot;IMAGE&amp;quot;, &amp;quot;TEXT_FILE&amp;quot;, &amp;quot;CSV&amp;quot;, &amp;quot;TSV&amp;quot;]
    /// </summary>
    public TerraformList<string>? FileTypesToTransform
    {
        get => GetArgument<TerraformList<string>>("file_types_to_transform");
        set => SetArgument("file_types_to_transform", value);
    }

    /// <summary>
    /// TransformationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransformationConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationConfigBlock>? TransformationConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationConfigBlock>>("transformation_config");
        set => SetArgument("transformation_config", value);
    }

    /// <summary>
    /// TransformationDetailsStorageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransformationDetailsStorageConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlock>? TransformationDetailsStorageConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlock>>("transformation_details_storage_config");
        set => SetArgument("transformation_details_storage_config", value);
    }

}

/// <summary>
/// Block type for transformation_config in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation_config";

    /// <summary>
    /// If this template is specified, it will serve as the default de-identify template.
    /// </summary>
    public TerraformValue<string>? DeidentifyTemplate
    {
        get => GetArgument<TerraformValue<string>>("deidentify_template");
        set => SetArgument("deidentify_template", value);
    }

    /// <summary>
    /// If this template is specified, it will serve as the de-identify template for images.
    /// </summary>
    public TerraformValue<string>? ImageRedactTemplate
    {
        get => GetArgument<TerraformValue<string>>("image_redact_template");
        set => SetArgument("image_redact_template", value);
    }

    /// <summary>
    /// If this template is specified, it will serve as the de-identify template for structured content such as delimited files and tables.
    /// </summary>
    public TerraformValue<string>? StructuredDeidentifyTemplate
    {
        get => GetArgument<TerraformValue<string>>("structured_deidentify_template");
        set => SetArgument("structured_deidentify_template", value);
    }

}

/// <summary>
/// Block type for transformation_details_storage_config in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation_details_storage_config";

    /// <summary>
    /// Table block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Table block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlockTableBlock> Table
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlockTableBlock>>("table");
        set => SetArgument("table", value);
    }

}

/// <summary>
/// Block type for table in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockDeidentifyBlockTransformationDetailsStorageConfigBlockTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    public TerraformValue<string>? TableId
    {
        get => GetArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for job_notification_emails in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockJobNotificationEmailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_notification_emails";

}

/// <summary>
/// Block type for pub_sub in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPubSubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pub_sub";

    /// <summary>
    /// Cloud Pub/Sub topic to send notifications to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}

/// <summary>
/// Block type for publish_findings_to_cloud_data_catalog in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishFindingsToCloudDataCatalogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_findings_to_cloud_data_catalog";

}

/// <summary>
/// Block type for publish_findings_to_dataplex_catalog in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishFindingsToDataplexCatalogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_findings_to_dataplex_catalog";

}

/// <summary>
/// Block type for publish_summary_to_cscc in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishSummaryToCsccBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_summary_to_cscc";

}

/// <summary>
/// Block type for publish_to_stackdriver in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockPublishToStackdriverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_to_stackdriver";

}

/// <summary>
/// Block type for save_findings in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "save_findings";

    /// <summary>
    /// OutputConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlock> OutputConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlock>>("output_config");
        set => SetArgument("output_config", value);
    }

}

/// <summary>
/// Block type for output_config in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_config";

    /// <summary>
    /// Schema used for writing the findings for Inspect jobs. This field is only used for
    /// Inspect and must be unspecified for Risk jobs. Columns are derived from the Finding
    /// object. If appending to an existing table, any columns from the predefined schema
    /// that are missing will be added. No columns in the existing table will be deleted.
    /// 
    /// If unspecified, then all available columns will be used for a new table or an (existing)
    /// table with no schema, and no changes will be made to an existing table that has a schema.
    /// Only for use with external storage. Possible values: [&amp;quot;BASIC_COLUMNS&amp;quot;, &amp;quot;GCS_COLUMNS&amp;quot;, &amp;quot;DATASTORE_COLUMNS&amp;quot;, &amp;quot;BIG_QUERY_COLUMNS&amp;quot;, &amp;quot;ALL_COLUMNS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OutputSchema
    {
        get => GetArgument<TerraformValue<string>>("output_schema");
        set => SetArgument("output_schema", value);
    }

    /// <summary>
    /// StoragePath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoragePath block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlockStoragePathBlock>? StoragePath
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlockStoragePathBlock>>("storage_path");
        set => SetArgument("storage_path", value);
    }

    /// <summary>
    /// Table block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlockTableBlock>? Table
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlockTableBlock>>("table");
        set => SetArgument("table", value);
    }

}

/// <summary>
/// Block type for storage_path in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlockStoragePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_path";

    /// <summary>
    /// A URL representing a file or path (no wildcards) in Cloud Storage.
    /// Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for table in GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockActionsBlockSaveFindingsBlockOutputConfigBlockTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table";

    /// <summary>
    /// Dataset ID of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The Google Cloud Platform project ID of the project containing the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Name of the table. If is not set a new one will be generated for you with the following format:
    /// &#39;dlp_googleapis_yyyy_mm_dd_[dlp_job_id]&#39;. Pacific timezone will be used for generating the date details.
    /// </summary>
    public TerraformValue<string>? TableId
    {
        get => GetArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for inspect_config in GoogleDataLossPreventionJobTriggerInspectJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_config";

    /// <summary>
    /// When true, excludes type information of the findings.
    /// </summary>
    public TerraformValue<bool>? ExcludeInfoTypes
    {
        get => GetArgument<TerraformValue<bool>>("exclude_info_types");
        set => SetArgument("exclude_info_types", value);
    }

    /// <summary>
    /// When true, a contextual quote from the data that triggered a finding is included in the response.
    /// </summary>
    public TerraformValue<bool>? IncludeQuote
    {
        get => GetArgument<TerraformValue<bool>>("include_quote");
        set => SetArgument("include_quote", value);
    }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value: &amp;quot;POSSIBLE&amp;quot; Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MinLikelihood
    {
        get => GetArgument<TerraformValue<string>>("min_likelihood");
        set => SetArgument("min_likelihood", value);
    }

    /// <summary>
    /// CustomInfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock>? CustomInfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock>>("custom_info_types");
        set => SetArgument("custom_info_types", value);
    }

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlock>? InfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

    /// <summary>
    /// Limits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlock>? Limits
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlock>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// RuleSet block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlock>? RuleSet
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlock>>("rule_set");
        set => SetArgument("rule_set", value);
    }

}

/// <summary>
/// Block type for custom_info_types in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_info_types";

    /// <summary>
    /// If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values: [&amp;quot;EXCLUSION_TYPE_EXCLUDE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ExclusionType
    {
        get => GetArgument<TerraformValue<string>>("exclusion_type");
        set => SetArgument("exclusion_type", value);
    }

    /// <summary>
    /// Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria
    /// specified by the rule. Default value: &amp;quot;VERY_LIKELY&amp;quot; Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Likelihood
    {
        get => GetArgument<TerraformValue<string>>("likelihood");
        set => SetArgument("likelihood", value);
    }

    /// <summary>
    /// Dictionary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlock>? Dictionary
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlock>>("dictionary");
        set => SetArgument("dictionary", value);
    }

    /// <summary>
    /// InfoType block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfoType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfoType block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfoType block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock> InfoType
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock>>("info_type");
        set => SetArgument("info_type", value);
    }

    /// <summary>
    /// Regex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockRegexBlock>? Regex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockRegexBlock>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

    /// <summary>
    /// StoredType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoredType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockStoredTypeBlock>? StoredType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockStoredTypeBlock>>("stored_type");
        set => SetArgument("stored_type", value);
    }

    /// <summary>
    /// SurrogateType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockSurrogateTypeBlock>? SurrogateType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockSurrogateTypeBlock>>("surrogate_type");
        set => SetArgument("surrogate_type", value);
    }

}

/// <summary>
/// Block type for dictionary in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dictionary";

    /// <summary>
    /// CloudStoragePath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStoragePath block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlockCloudStoragePathBlock>? CloudStoragePath
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlockCloudStoragePathBlock>>("cloud_storage_path");
        set => SetArgument("cloud_storage_path", value);
    }

    /// <summary>
    /// WordList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlockWordListBlock>? WordList
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for cloud_storage_path in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlockCloudStoragePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_path";

    /// <summary>
    /// A url representing a file or path (no wildcards) in Cloud Storage. Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockDictionaryBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for info_type in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names
    /// listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the information type to use. By default, the version is set to stable.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for regex in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for stored_type in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockStoredTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stored_type";

    /// <summary>
    /// The creation timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Resource name of the requested StoredInfoType, for example &#39;organizations/433245324/storedInfoTypes/432452342&#39;
    /// or &#39;projects/project-id/storedInfoTypes/432452342&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for surrogate_type in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockCustomInfoTypesBlockSurrogateTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_type";

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the information type to use. By default, the version is set to stable
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for limits in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limits";

    /// <summary>
    /// Max number of findings that will be returned for each item scanned. The maximum returned is 2000.
    /// </summary>
    public TerraformValue<double>? MaxFindingsPerItem
    {
        get => GetArgument<TerraformValue<double>>("max_findings_per_item");
        set => SetArgument("max_findings_per_item", value);
    }

    /// <summary>
    /// Max number of findings that will be returned per request/job. The maximum returned is 2000.
    /// </summary>
    public TerraformValue<double>? MaxFindingsPerRequest
    {
        get => GetArgument<TerraformValue<double>>("max_findings_per_request");
        set => SetArgument("max_findings_per_request", value);
    }

    /// <summary>
    /// MaxFindingsPerInfoType block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock>? MaxFindingsPerInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock>>("max_findings_per_info_type");
        set => SetArgument("max_findings_per_info_type", value);
    }

}

/// <summary>
/// Block type for max_findings_per_info_type in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_findings_per_info_type";

    /// <summary>
    /// Max findings limit for the given infoType.
    /// </summary>
    public TerraformValue<double>? MaxFindings
    {
        get => GetArgument<TerraformValue<double>>("max_findings");
        set => SetArgument("max_findings", value);
    }

    /// <summary>
    /// InfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock>? InfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock>>("info_type");
        set => SetArgument("info_type", value);
    }

}

/// <summary>
/// Block type for info_type in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the information type to use. By default, the version is set to stable
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for rule_set in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_set";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlock>? InfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the information type to use. By default, the version is set to stable.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for rules in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// ExclusionRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExclusionRule block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock>? ExclusionRule
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock>>("exclusion_rule");
        set => SetArgument("exclusion_rule", value);
    }

    /// <summary>
    /// HotwordRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HotwordRule block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock>? HotwordRule
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock>>("hotword_rule");
        set => SetArgument("hotword_rule", value);
    }

}

/// <summary>
/// Block type for exclusion_rule in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_rule";

    /// <summary>
    /// How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values: [&amp;quot;MATCHING_TYPE_FULL_MATCH&amp;quot;, &amp;quot;MATCHING_TYPE_PARTIAL_MATCH&amp;quot;, &amp;quot;MATCHING_TYPE_INVERSE_MATCH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingType is required")]
    public required TerraformValue<string> MatchingType
    {
        get => GetRequiredArgument<TerraformValue<string>>("matching_type");
        set => SetArgument("matching_type", value);
    }

    /// <summary>
    /// Dictionary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock>? Dictionary
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock>>("dictionary");
        set => SetArgument("dictionary", value);
    }

    /// <summary>
    /// ExcludeByHotword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeByHotword block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock>? ExcludeByHotword
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock>>("exclude_by_hotword");
        set => SetArgument("exclude_by_hotword", value);
    }

    /// <summary>
    /// ExcludeInfoTypes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeInfoTypes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock>? ExcludeInfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock>>("exclude_info_types");
        set => SetArgument("exclude_info_types", value);
    }

    /// <summary>
    /// Regex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockRegexBlock>? Regex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockRegexBlock>>("regex");
        set => SetArgument("regex", value);
    }

}

/// <summary>
/// Block type for dictionary in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dictionary";

    /// <summary>
    /// CloudStoragePath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStoragePath block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockCloudStoragePathBlock>? CloudStoragePath
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockCloudStoragePathBlock>>("cloud_storage_path");
        set => SetArgument("cloud_storage_path", value);
    }

    /// <summary>
    /// WordList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockWordListBlock>? WordList
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for cloud_storage_path in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockCloudStoragePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_path";

    /// <summary>
    /// A url representing a file or path (no wildcards) in Cloud Storage. Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for exclude_by_hotword in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_by_hotword";

    /// <summary>
    /// HotwordRegex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HotwordRegex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockHotwordRegexBlock>? HotwordRegex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockHotwordRegexBlock>>("hotword_regex");
        set => SetArgument("hotword_regex", value);
    }

    /// <summary>
    /// Proximity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proximity block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockProximityBlock>? Proximity
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockProximityBlock>>("proximity");
        set => SetArgument("proximity", value);
    }

}

/// <summary>
/// Block type for hotword_regex in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockHotwordRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hotword_regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified,
    /// the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression. Its syntax
    /// (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    public TerraformValue<string>? Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for proximity in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockProximityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proximity";

    /// <summary>
    /// Number of characters after the finding to consider. Either this or window_before must be specified
    /// </summary>
    public TerraformValue<double>? WindowAfter
    {
        get => GetArgument<TerraformValue<double>>("window_after");
        set => SetArgument("window_after", value);
    }

    /// <summary>
    /// Number of characters before the finding to consider. Either this or window_after must be specified
    /// </summary>
    public TerraformValue<double>? WindowBefore
    {
        get => GetArgument<TerraformValue<double>>("window_before");
        set => SetArgument("window_before", value);
    }

}

/// <summary>
/// Block type for exclude_info_types in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_info_types";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfoTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfoTypes block(s) required")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock> InfoTypes
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the information type to use. By default, the version is set to stable.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for regex in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for hotword_rule in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hotword_rule";

    /// <summary>
    /// HotwordRegex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HotwordRegex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockHotwordRegexBlock>? HotwordRegex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockHotwordRegexBlock>>("hotword_regex");
        set => SetArgument("hotword_regex", value);
    }

    /// <summary>
    /// LikelihoodAdjustment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LikelihoodAdjustment block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockLikelihoodAdjustmentBlock>? LikelihoodAdjustment
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockLikelihoodAdjustmentBlock>>("likelihood_adjustment");
        set => SetArgument("likelihood_adjustment", value);
    }

    /// <summary>
    /// Proximity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proximity block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockProximityBlock>? Proximity
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockProximityBlock>>("proximity");
        set => SetArgument("proximity", value);
    }

}

/// <summary>
/// Block type for hotword_regex in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockHotwordRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hotword_regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified,
    /// the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression. Its syntax
    /// (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    public TerraformValue<string>? Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for likelihood_adjustment in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockLikelihoodAdjustmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "likelihood_adjustment";

    /// <summary>
    /// Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? FixedLikelihood
    {
        get => GetArgument<TerraformValue<string>>("fixed_likelihood");
        set => SetArgument("fixed_likelihood", value);
    }

    /// <summary>
    /// Increase or decrease the likelihood by the specified number of levels. For example,
    /// if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1,
    /// then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY.
    /// Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an
    /// adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY
    /// will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.
    /// </summary>
    public TerraformValue<double>? RelativeLikelihood
    {
        get => GetArgument<TerraformValue<double>>("relative_likelihood");
        set => SetArgument("relative_likelihood", value);
    }

}

/// <summary>
/// Block type for proximity in GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockProximityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proximity";

    /// <summary>
    /// Number of characters after the finding to consider. Either this or window_before must be specified
    /// </summary>
    public TerraformValue<double>? WindowAfter
    {
        get => GetArgument<TerraformValue<double>>("window_after");
        set => SetArgument("window_after", value);
    }

    /// <summary>
    /// Number of characters before the finding to consider. Either this or window_after must be specified
    /// </summary>
    public TerraformValue<double>? WindowBefore
    {
        get => GetArgument<TerraformValue<double>>("window_before");
        set => SetArgument("window_before", value);
    }

}

/// <summary>
/// Block type for storage_config in GoogleDataLossPreventionJobTriggerInspectJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_config";

    /// <summary>
    /// BigQueryOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQueryOptions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock>? BigQueryOptions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock>>("big_query_options");
        set => SetArgument("big_query_options", value);
    }

    /// <summary>
    /// CloudStorageOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageOptions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlock>? CloudStorageOptions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlock>>("cloud_storage_options");
        set => SetArgument("cloud_storage_options", value);
    }

    /// <summary>
    /// DatastoreOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatastoreOptions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlock>? DatastoreOptions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlock>>("datastore_options");
        set => SetArgument("datastore_options", value);
    }

    /// <summary>
    /// HybridOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HybridOptions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlock>? HybridOptions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlock>>("hybrid_options");
        set => SetArgument("hybrid_options", value);
    }

    /// <summary>
    /// TimespanConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimespanConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlock>? TimespanConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlock>>("timespan_config");
        set => SetArgument("timespan_config", value);
    }

}

/// <summary>
/// Block type for big_query_options in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "big_query_options";

    /// <summary>
    /// Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted.
    /// If not set, or if set to 0, all rows will be scanned. Only one of rowsLimit and rowsLimitPercent can be
    /// specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    public TerraformValue<double>? RowsLimit
    {
        get => GetArgument<TerraformValue<double>>("rows_limit");
        set => SetArgument("rows_limit", value);
    }

    /// <summary>
    /// Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of
    /// rowsLimit and rowsLimitPercent can be specified. Cannot be used in conjunction with TimespanConfig.
    /// </summary>
    public TerraformValue<double>? RowsLimitPercent
    {
        get => GetArgument<TerraformValue<double>>("rows_limit_percent");
        set => SetArgument("rows_limit_percent", value);
    }

    /// <summary>
    /// How to sample rows if not all rows are scanned. Meaningful only when used in conjunction with either
    /// rowsLimit or rowsLimitPercent. If not specified, rows are scanned in the order BigQuery reads them.
    /// If TimespanConfig is set, set this to an empty string to avoid using the default value. Default value: &amp;quot;TOP&amp;quot; Possible values: [&amp;quot;TOP&amp;quot;, &amp;quot;RANDOM_START&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SampleMethod
    {
        get => GetArgument<TerraformValue<string>>("sample_method");
        set => SetArgument("sample_method", value);
    }

    /// <summary>
    /// ExcludedFields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockExcludedFieldsBlock>? ExcludedFields
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockExcludedFieldsBlock>>("excluded_fields");
        set => SetArgument("excluded_fields", value);
    }

    /// <summary>
    /// IdentifyingFields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockIdentifyingFieldsBlock>? IdentifyingFields
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockIdentifyingFieldsBlock>>("identifying_fields");
        set => SetArgument("identifying_fields", value);
    }

    /// <summary>
    /// IncludedFields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockIncludedFieldsBlock>? IncludedFields
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockIncludedFieldsBlock>>("included_fields");
        set => SetArgument("included_fields", value);
    }

    /// <summary>
    /// TableReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TableReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableReference block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockTableReferenceBlock> TableReference
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockTableReferenceBlock>>("table_reference");
        set => SetArgument("table_reference", value);
    }

}

/// <summary>
/// Block type for excluded_fields in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockExcludedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_fields";

    /// <summary>
    /// Name describing the field excluded from scanning.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for identifying_fields in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockIdentifyingFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identifying_fields";

    /// <summary>
    /// Name of a BigQuery field to be returned with the findings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for included_fields in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockIncludedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_fields";

    /// <summary>
    /// Name describing the field to which scanning is limited.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for table_reference in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockBigQueryOptionsBlockTableReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_reference";

    /// <summary>
    /// The dataset ID of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The Google Cloud Platform project ID of the project containing the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for cloud_storage_options in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_options";

    /// <summary>
    /// Max number of bytes to scan from a file. If a scanned file&#39;s size is bigger than this value
    /// then the rest of the bytes are omitted.
    /// </summary>
    public TerraformValue<double>? BytesLimitPerFile
    {
        get => GetArgument<TerraformValue<double>>("bytes_limit_per_file");
        set => SetArgument("bytes_limit_per_file", value);
    }

    /// <summary>
    /// Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    public TerraformValue<double>? BytesLimitPerFilePercent
    {
        get => GetArgument<TerraformValue<double>>("bytes_limit_per_file_percent");
        set => SetArgument("bytes_limit_per_file_percent", value);
    }

    /// <summary>
    /// List of file type groups to include in the scan. If empty, all files are scanned and available data
    /// format processors are applied. In addition, the binary content of the selected files is always scanned as well.
    /// Images are scanned only as binary if the specified region does not support image inspection and no fileTypes were specified. Possible values: [&amp;quot;BINARY_FILE&amp;quot;, &amp;quot;TEXT_FILE&amp;quot;, &amp;quot;IMAGE&amp;quot;, &amp;quot;WORD&amp;quot;, &amp;quot;PDF&amp;quot;, &amp;quot;AVRO&amp;quot;, &amp;quot;CSV&amp;quot;, &amp;quot;TSV&amp;quot;, &amp;quot;POWERPOINT&amp;quot;, &amp;quot;EXCEL&amp;quot;]
    /// </summary>
    public TerraformList<string>? FileTypes
    {
        get => GetArgument<TerraformList<string>>("file_types");
        set => SetArgument("file_types", value);
    }

    /// <summary>
    /// Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is rounded down.
    /// Must be between 0 and 100, inclusively. Both 0 and 100 means no limit.
    /// </summary>
    public TerraformValue<double>? FilesLimitPercent
    {
        get => GetArgument<TerraformValue<double>>("files_limit_percent");
        set => SetArgument("files_limit_percent", value);
    }

    /// <summary>
    /// How to sample bytes if not all bytes are scanned. Meaningful only when used in conjunction with bytesLimitPerFile.
    /// If not specified, scanning would start from the top. Possible values: [&amp;quot;TOP&amp;quot;, &amp;quot;RANDOM_START&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SampleMethod
    {
        get => GetArgument<TerraformValue<string>>("sample_method");
        set => SetArgument("sample_method", value);
    }

    /// <summary>
    /// FileSet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FileSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSet block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlock> FileSet
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlock>>("file_set");
        set => SetArgument("file_set", value);
    }

}

/// <summary>
/// Block type for file_set in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_set";

    /// <summary>
    /// The Cloud Storage url of the file(s) to scan, in the format &#39;gs://&amp;lt;bucket&amp;gt;/&amp;lt;path&amp;gt;&#39;. Trailing wildcard
    /// in the path is allowed.
    /// 
    /// If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned
    /// non-recursively (content in sub-directories will not be scanned). This means that &#39;gs://mybucket/&#39; is
    /// equivalent to &#39;gs://mybucket/*&#39;, and &#39;gs://mybucket/directory/&#39; is equivalent to &#39;gs://mybucket/directory/*&#39;.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// RegexFileSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegexFileSet block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlockRegexFileSetBlock>? RegexFileSet
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlockRegexFileSetBlock>>("regex_file_set");
        set => SetArgument("regex_file_set", value);
    }

}

/// <summary>
/// Block type for regex_file_set in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockCloudStorageOptionsBlockFileSetBlockRegexFileSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex_file_set";

    /// <summary>
    /// The name of a Cloud Storage bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// A list of regular expressions matching file paths to exclude. All files in the bucket that match at
    /// least one of these regular expressions will be excluded from the scan.
    /// </summary>
    public TerraformList<string>? ExcludeRegex
    {
        get => GetArgument<TerraformList<string>>("exclude_regex");
        set => SetArgument("exclude_regex", value);
    }

    /// <summary>
    /// A list of regular expressions matching file paths to include. All files in the bucket
    /// that match at least one of these regular expressions will be included in the set of files,
    /// except for those that also match an item in excludeRegex. Leaving this field empty will
    /// match all files by default (this is equivalent to including .* in the list)
    /// </summary>
    public TerraformList<string>? IncludeRegex
    {
        get => GetArgument<TerraformList<string>>("include_regex");
        set => SetArgument("include_regex", value);
    }

}

/// <summary>
/// Block type for datastore_options in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "datastore_options";

    /// <summary>
    /// Kind block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kind block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Kind block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlockKindBlock> Kind
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlockKindBlock>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// PartitionId block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionId is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartitionId block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionId block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlockPartitionIdBlock> PartitionId
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlockPartitionIdBlock>>("partition_id");
        set => SetArgument("partition_id", value);
    }

}

/// <summary>
/// Block type for kind in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlockKindBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kind";

    /// <summary>
    /// The name of the Datastore kind.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for partition_id in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockDatastoreOptionsBlockPartitionIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partition_id";

    /// <summary>
    /// If not empty, the ID of the namespace to which the entities belong.
    /// </summary>
    public TerraformValue<string>? NamespaceId
    {
        get => GetArgument<TerraformValue<string>>("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The ID of the project to which the entities belong.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for hybrid_options in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hybrid_options";

    /// <summary>
    /// A short description of where the data is coming from. Will be stored once in the job. 256 max length.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// To organize findings, these labels will be added to each finding.
    /// 
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;.
    /// 
    /// Label values must be between 0 and 63 characters long and must conform to the regular expression &#39;([a-z]([-a-z0-9]*[a-z0-9])?)?&#39;.
    /// 
    /// No more than 10 labels can be associated with a given finding.
    /// 
    /// Examples:
    /// * &#39;&amp;quot;environment&amp;quot; : &amp;quot;production&amp;quot;&#39;
    /// * &#39;&amp;quot;pipeline&amp;quot; : &amp;quot;etl&amp;quot;&#39;
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// These are labels that each inspection request must include within their &#39;finding_labels&#39; map. Request
    /// may contain others, but any missing one of these will be rejected.
    /// 
    /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression: &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;.
    /// 
    /// No more than 10 keys can be required.
    /// </summary>
    public TerraformList<string>? RequiredFindingLabelKeys
    {
        get => GetArgument<TerraformList<string>>("required_finding_label_keys");
        set => SetArgument("required_finding_label_keys", value);
    }

    /// <summary>
    /// TableOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableOptions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlock>? TableOptions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlock>>("table_options");
        set => SetArgument("table_options", value);
    }

}

/// <summary>
/// Block type for table_options in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_options";

    /// <summary>
    /// IdentifyingFields block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlockIdentifyingFieldsBlock>? IdentifyingFields
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlockIdentifyingFieldsBlock>>("identifying_fields");
        set => SetArgument("identifying_fields", value);
    }

}

/// <summary>
/// Block type for identifying_fields in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockHybridOptionsBlockTableOptionsBlockIdentifyingFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identifying_fields";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timespan_config in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timespan_config";

    /// <summary>
    /// When the job is started by a JobTrigger we will automatically figure out a valid startTime to avoid
    /// scanning files that have not been modified since the last time the JobTrigger executed. This will
    /// be based on the time of the execution of the last run of the JobTrigger or the timespan endTime
    /// used in the last run of the JobTrigger.
    /// </summary>
    public TerraformValue<bool>? EnableAutoPopulationOfTimespanConfig
    {
        get => GetArgument<TerraformValue<bool>>("enable_auto_population_of_timespan_config");
        set => SetArgument("enable_auto_population_of_timespan_config", value);
    }

    /// <summary>
    /// Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// TimestampField block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimestampField block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlockTimestampFieldBlock>? TimestampField
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlockTimestampFieldBlock>>("timestamp_field");
        set => SetArgument("timestamp_field", value);
    }

}

/// <summary>
/// Block type for timestamp_field in GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlockStorageConfigBlockTimespanConfigBlockTimestampFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestamp_field";

    /// <summary>
    /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore and BigQuery.
    /// 
    /// For BigQuery: Required to filter out rows based on the given start and end times. If not specified and the table was
    /// modified between the given start and end times, the entire table will be scanned. The valid data types of the timestamp
    /// field are: INTEGER, DATE, TIMESTAMP, or DATETIME BigQuery column.
    /// 
    /// For Datastore. Valid data types of the timestamp field are: TIMESTAMP. Datastore entity will be scanned if the
    /// timestamp property does not exist or its value is empty or invalid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataLossPreventionJobTrigger.
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionJobTriggerTimeoutsBlock : TerraformBlock
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
/// Block type for triggers in GoogleDataLossPreventionJobTrigger.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerTriggersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "triggers";

    /// <summary>
    /// Manual block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Manual block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerTriggersBlockManualBlock>? Manual
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerTriggersBlockManualBlock>>("manual");
        set => SetArgument("manual", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerTriggersBlockScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerTriggersBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for manual in GoogleDataLossPreventionJobTriggerTriggersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerTriggersBlockManualBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual";

}

/// <summary>
/// Block type for schedule in GoogleDataLossPreventionJobTriggerTriggersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerTriggersBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// With this option a job is started a regular periodic basis. For example: every day (86400 seconds).
    /// 
    /// A scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs.
    /// 
    /// This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? RecurrencePeriodDuration
    {
        get => GetArgument<TerraformValue<string>>("recurrence_period_duration");
        set => SetArgument("recurrence_period_duration", value);
    }

}


/// <summary>
/// Represents a google_data_loss_prevention_job_trigger Terraform resource.
/// Manages a google_data_loss_prevention_job_trigger resource.
/// </summary>
public partial class GoogleDataLossPreventionJobTrigger(string name) : TerraformResource("google_data_loss_prevention_job_trigger", name)
{
    /// <summary>
    /// A description of the job trigger.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User set display name of the job trigger.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The parent of the trigger, either in the format &#39;projects/{{project}}&#39;
    /// or &#39;projects/{{project}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Whether the trigger is currently active. Default value: &amp;quot;HEALTHY&amp;quot; Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;HEALTHY&amp;quot;, &amp;quot;CANCELLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformValue<string> TriggerId
    {
        get => GetArgument<TerraformValue<string>>("trigger_id") ?? CreateReference("trigger_id");
        set => SetArgument("trigger_id", value);
    }

    /// <summary>
    /// The creation timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The timestamp of the last time this trigger executed.
    /// </summary>
    public TerraformValue<string> LastRunTime
        => CreateReference("last_run_time");

    /// <summary>
    /// The resource name of the job trigger. Set by the server.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The last update timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// InspectJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectJob block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlock>? InspectJob
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionJobTriggerInspectJobBlock>>("inspect_job");
        set => SetArgument("inspect_job", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataLossPreventionJobTriggerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataLossPreventionJobTriggerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Triggers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Triggers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Triggers block(s) required")]
    public required TerraformList<GoogleDataLossPreventionJobTriggerTriggersBlock> Triggers
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionJobTriggerTriggersBlock>>("triggers");
        set => SetArgument("triggers", value);
    }

}
