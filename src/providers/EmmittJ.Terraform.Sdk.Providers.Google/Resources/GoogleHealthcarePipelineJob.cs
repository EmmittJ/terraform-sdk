using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_pipeline_job in GoogleHealthcarePipelineJob.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobBackfillPipelineJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backfill_pipeline_job";

    /// <summary>
    /// Specifies the mapping pipeline job to backfill, the name format
    /// should follow: projects/{projectId}/locations/{locationId}/datasets/{datasetId}/pipelineJobs/{pipelineJobId}.
    /// </summary>
    public TerraformValue<string>? MappingPipelineJob
    {
        get => GetArgument<TerraformValue<string>>("mapping_pipeline_job");
        set => SetArgument("mapping_pipeline_job", value);
    }

}


/// <summary>
/// Block type for mapping_pipeline_job in GoogleHealthcarePipelineJob.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobMappingPipelineJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_pipeline_job";

    /// <summary>
    /// If set, the mapping pipeline will write snapshots to this
    /// FHIR store without assigning stable IDs. You must
    /// grant your pipeline project&#39;s Cloud Healthcare Service
    /// Agent serviceaccount healthcare.fhirResources.executeBundle
    /// and healthcare.fhirResources.create permissions on the
    /// destination store. The destination store must set
    /// [disableReferentialIntegrity][FhirStore.disable_referential_integrity]
    /// to true. The destination store must use FHIR version R4.
    /// Format: project/{projectID}/locations/{locationID}/datasets/{datasetName}/fhirStores/{fhirStoreID}.
    /// </summary>
    public TerraformValue<string>? FhirStoreDestination
    {
        get => GetArgument<TerraformValue<string>>("fhir_store_destination");
        set => SetArgument("fhir_store_destination", value);
    }

    /// <summary>
    /// If set to true, a mapping pipeline will send output snapshots
    /// to the reconciliation pipeline in its dataset. A reconciliation
    /// pipeline must exist in this dataset before a mapping pipeline
    /// with a reconciliation destination can be created.
    /// </summary>
    public TerraformValue<bool>? ReconciliationDestination
    {
        get => GetArgument<TerraformValue<bool>>("reconciliation_destination");
        set => SetArgument("reconciliation_destination", value);
    }

    /// <summary>
    /// FhirStreamingSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FhirStreamingSource block(s) allowed")]
    public TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlockFhirStreamingSourceBlock>? FhirStreamingSource
    {
        get => GetArgument<TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlockFhirStreamingSourceBlock>>("fhir_streaming_source");
        set => SetArgument("fhir_streaming_source", value);
    }

    /// <summary>
    /// MappingConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MappingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MappingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingConfig block(s) allowed")]
    public required TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlock> MappingConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlock>>("mapping_config");
        set => SetArgument("mapping_config", value);
    }

}

/// <summary>
/// Block type for fhir_streaming_source in GoogleHealthcarePipelineJobMappingPipelineJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobMappingPipelineJobBlockFhirStreamingSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fhir_streaming_source";

    /// <summary>
    /// Describes the streaming FHIR data source.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The path to the FHIR store in the format projects/{projectId}/locations/{locationId}/datasets/{datasetId}/fhirStores/{fhirStoreId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FhirStore is required")]
    public required TerraformValue<string> FhirStore
    {
        get => GetRequiredArgument<TerraformValue<string>>("fhir_store");
        set => SetArgument("fhir_store", value);
    }

}

/// <summary>
/// Block type for mapping_config in GoogleHealthcarePipelineJobMappingPipelineJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_config";

    /// <summary>
    /// Describes the mapping configuration.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// WhistleConfigSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WhistleConfigSource block(s) allowed")]
    public TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlockWhistleConfigSourceBlock>? WhistleConfigSource
    {
        get => GetArgument<TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlockWhistleConfigSourceBlock>>("whistle_config_source");
        set => SetArgument("whistle_config_source", value);
    }

}

/// <summary>
/// Block type for whistle_config_source in GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobMappingPipelineJobBlockMappingConfigBlockWhistleConfigSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "whistle_config_source";

    /// <summary>
    /// Directory path where all the Whistle files are located.
    /// Example: gs://{bucket-id}/{path/to/import-root/dir}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportUriPrefix is required")]
    public required TerraformValue<string> ImportUriPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("import_uri_prefix");
        set => SetArgument("import_uri_prefix", value);
    }

    /// <summary>
    /// Main configuration file which has the entrypoint or the root function.
    /// Example: gs://{bucket-id}/{path/to/import-root/dir}/entrypoint-file-name.wstl.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for reconciliation_pipeline_job in GoogleHealthcarePipelineJob.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobReconciliationPipelineJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reconciliation_pipeline_job";

    /// <summary>
    /// The harmonized FHIR store to write harmonized FHIR resources to,
    /// in the format of: project/{projectID}/locations/{locationID}/datasets/{datasetName}/fhirStores/{id}
    /// </summary>
    public TerraformValue<string>? FhirStoreDestination
    {
        get => GetArgument<TerraformValue<string>>("fhir_store_destination");
        set => SetArgument("fhir_store_destination", value);
    }

    /// <summary>
    /// Specifies the top level directory of the matching configs used
    /// in all mapping pipelines, which extract properties for resources
    /// to be matched on.
    /// Example: gs://{bucket-id}/{path/to/matching/configs}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingUriPrefix is required")]
    public required TerraformValue<string> MatchingUriPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("matching_uri_prefix");
        set => SetArgument("matching_uri_prefix", value);
    }

    /// <summary>
    /// MergeConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MergeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MergeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MergeConfig block(s) allowed")]
    public required TerraformList<GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlock> MergeConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlock>>("merge_config");
        set => SetArgument("merge_config", value);
    }

}

/// <summary>
/// Block type for merge_config in GoogleHealthcarePipelineJobReconciliationPipelineJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "merge_config";

    /// <summary>
    /// Describes the mapping configuration.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// WhistleConfigSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WhistleConfigSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WhistleConfigSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WhistleConfigSource block(s) allowed")]
    public required TerraformList<GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlockWhistleConfigSourceBlock> WhistleConfigSource
    {
        get => GetRequiredArgument<TerraformList<GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlockWhistleConfigSourceBlock>>("whistle_config_source");
        set => SetArgument("whistle_config_source", value);
    }

}

/// <summary>
/// Block type for whistle_config_source in GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobReconciliationPipelineJobBlockMergeConfigBlockWhistleConfigSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "whistle_config_source";

    /// <summary>
    /// Directory path where all the Whistle files are located.
    /// Example: gs://{bucket-id}/{path/to/import-root/dir}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportUriPrefix is required")]
    public required TerraformValue<string> ImportUriPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("import_uri_prefix");
        set => SetArgument("import_uri_prefix", value);
    }

    /// <summary>
    /// Main configuration file which has the entrypoint or the root function.
    /// Example: gs://{bucket-id}/{path/to/import-root/dir}/entrypoint-file-name.wstl.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleHealthcarePipelineJob.
/// Nesting mode: single
/// </summary>
public class GoogleHealthcarePipelineJobTimeoutsBlock : TerraformBlock
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
/// Represents a google_healthcare_pipeline_job Terraform resource.
/// Manages a google_healthcare_pipeline_job resource.
/// </summary>
public partial class GoogleHealthcarePipelineJob(string name) : TerraformResource("google_healthcare_pipeline_job", name)
{
    /// <summary>
    /// Healthcare Dataset under which the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// If true, disables writing lineage for the pipeline.
    /// </summary>
    public TerraformValue<bool>? DisableLineage
    {
        get => GetArgument<TerraformValue<bool>>("disable_lineage");
        set => SetArgument("disable_lineage", value);
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
    /// User-supplied key-value pairs used to organize Pipeline Jobs.
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of
    /// maximum 128 bytes, and must conform to the following PCRE regular expression:
    /// [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    /// Label values are optional, must be between 1 and 63 characters long, have a
    /// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE
    /// regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    /// No more than 64 labels can be associated with a given pipeline.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
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
    /// Location where the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Specifies the name of the pipeline job. This field is user-assigned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// BackfillPipelineJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillPipelineJob block(s) allowed")]
    public TerraformList<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>? BackfillPipelineJob
    {
        get => GetArgument<TerraformList<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>>("backfill_pipeline_job");
        set => SetArgument("backfill_pipeline_job", value);
    }

    /// <summary>
    /// MappingPipelineJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingPipelineJob block(s) allowed")]
    public TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlock>? MappingPipelineJob
    {
        get => GetArgument<TerraformList<GoogleHealthcarePipelineJobMappingPipelineJobBlock>>("mapping_pipeline_job");
        set => SetArgument("mapping_pipeline_job", value);
    }

    /// <summary>
    /// ReconciliationPipelineJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReconciliationPipelineJob block(s) allowed")]
    public TerraformList<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>? ReconciliationPipelineJob
    {
        get => GetArgument<TerraformList<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>>("reconciliation_pipeline_job");
        set => SetArgument("reconciliation_pipeline_job", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleHealthcarePipelineJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleHealthcarePipelineJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
