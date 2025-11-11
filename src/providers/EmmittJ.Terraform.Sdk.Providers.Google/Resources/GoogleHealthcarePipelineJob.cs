using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_pipeline_job in .
/// Nesting mode: list
/// </summary>
public partial class GoogleHealthcarePipelineJobBackfillPipelineJobBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the mapping pipeline job to backfill, the name format
    /// should follow: projects/{projectId}/locations/{locationId}/datasets/{datasetId}/pipelineJobs/{pipelineJobId}.
    /// </summary>
    [TerraformProperty("mapping_pipeline_job")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MappingPipelineJob { get; set; }

}

/// <summary>
/// Block type for mapping_pipeline_job in .
/// Nesting mode: list
/// </summary>
public partial class GoogleHealthcarePipelineJobMappingPipelineJobBlock : TerraformBlockBase
{
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
    [TerraformProperty("fhir_store_destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FhirStoreDestination { get; set; }

    /// <summary>
    /// If set to true, a mapping pipeline will send output snapshots
    /// to the reconciliation pipeline in its dataset. A reconciliation
    /// pipeline must exist in this dataset before a mapping pipeline
    /// with a reconciliation destination can be created.
    /// </summary>
    [TerraformProperty("reconciliation_destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReconciliationDestination { get; set; }

}

/// <summary>
/// Block type for reconciliation_pipeline_job in .
/// Nesting mode: list
/// </summary>
public partial class GoogleHealthcarePipelineJobReconciliationPipelineJobBlock : TerraformBlockBase
{
    /// <summary>
    /// The harmonized FHIR store to write harmonized FHIR resources to,
    /// in the format of: project/{projectID}/locations/{locationID}/datasets/{datasetName}/fhirStores/{id}
    /// </summary>
    [TerraformProperty("fhir_store_destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FhirStoreDestination { get; set; }

    /// <summary>
    /// Specifies the top level directory of the matching configs used
    /// in all mapping pipelines, which extract properties for resources
    /// to be matched on.
    /// Example: gs://{bucket-id}/{path/to/matching/configs}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingUriPrefix is required")]
    [TerraformProperty("matching_uri_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MatchingUriPrefix { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleHealthcarePipelineJobTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_healthcare_pipeline_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleHealthcarePipelineJob : TerraformResource
{
    public GoogleHealthcarePipelineJob(string name) : base("google_healthcare_pipeline_job", name)
    {
    }

    /// <summary>
    /// Healthcare Dataset under which the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformProperty("dataset")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Dataset { get; set; }

    /// <summary>
    /// If true, disables writing lineage for the pipeline.
    /// </summary>
    [TerraformProperty("disable_lineage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableLineage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location where the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Specifies the name of the pipeline job. This field is user-assigned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for backfill_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillPipelineJob block(s) allowed")]
    [TerraformProperty("backfill_pipeline_job")]
    public partial TerraformList<TerraformBlock<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>>? BackfillPipelineJob { get; set; }

    /// <summary>
    /// Block for mapping_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingPipelineJob block(s) allowed")]
    [TerraformProperty("mapping_pipeline_job")]
    public partial TerraformList<TerraformBlock<GoogleHealthcarePipelineJobMappingPipelineJobBlock>>? MappingPipelineJob { get; set; }

    /// <summary>
    /// Block for reconciliation_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReconciliationPipelineJob block(s) allowed")]
    [TerraformProperty("reconciliation_pipeline_job")]
    public partial TerraformList<TerraformBlock<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>>? ReconciliationPipelineJob { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleHealthcarePipelineJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
