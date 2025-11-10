using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_pipeline_job in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobBackfillPipelineJobBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the mapping pipeline job to backfill, the name format
    /// should follow: projects/{projectId}/locations/{locationId}/datasets/{datasetId}/pipelineJobs/{pipelineJobId}.
    /// </summary>
    [TerraformPropertyName("mapping_pipeline_job")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MappingPipelineJob { get; set; }

}

/// <summary>
/// Block type for mapping_pipeline_job in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobMappingPipelineJobBlock : ITerraformBlock
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
    [TerraformPropertyName("fhir_store_destination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FhirStoreDestination { get; set; }

    /// <summary>
    /// If set to true, a mapping pipeline will send output snapshots
    /// to the reconciliation pipeline in its dataset. A reconciliation
    /// pipeline must exist in this dataset before a mapping pipeline
    /// with a reconciliation destination can be created.
    /// </summary>
    [TerraformPropertyName("reconciliation_destination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReconciliationDestination { get; set; }

}

/// <summary>
/// Block type for reconciliation_pipeline_job in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobReconciliationPipelineJobBlock : ITerraformBlock
{
    /// <summary>
    /// The harmonized FHIR store to write harmonized FHIR resources to,
    /// in the format of: project/{projectID}/locations/{locationID}/datasets/{datasetName}/fhirStores/{id}
    /// </summary>
    [TerraformPropertyName("fhir_store_destination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FhirStoreDestination { get; set; }

    /// <summary>
    /// Specifies the top level directory of the matching configs used
    /// in all mapping pipelines, which extract properties for resources
    /// to be matched on.
    /// Example: gs://{bucket-id}/{path/to/matching/configs}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingUriPrefix is required")]
    [TerraformPropertyName("matching_uri_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MatchingUriPrefix { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleHealthcarePipelineJobTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_healthcare_pipeline_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleHealthcarePipelineJob : TerraformResource
{
    public GoogleHealthcarePipelineJob(string name) : base("google_healthcare_pipeline_job", name)
    {
    }

    /// <summary>
    /// Healthcare Dataset under which the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformPropertyName("dataset")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Dataset { get; set; }

    /// <summary>
    /// If true, disables writing lineage for the pipeline.
    /// </summary>
    [TerraformPropertyName("disable_lineage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableLineage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Location where the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Specifies the name of the pipeline job. This field is user-assigned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for backfill_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillPipelineJob block(s) allowed")]
    [TerraformPropertyName("backfill_pipeline_job")]
    public TerraformList<TerraformBlock<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>>? BackfillPipelineJob { get; set; } = new();

    /// <summary>
    /// Block for mapping_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingPipelineJob block(s) allowed")]
    [TerraformPropertyName("mapping_pipeline_job")]
    public TerraformList<TerraformBlock<GoogleHealthcarePipelineJobMappingPipelineJobBlock>>? MappingPipelineJob { get; set; } = new();

    /// <summary>
    /// Block for reconciliation_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReconciliationPipelineJob block(s) allowed")]
    [TerraformPropertyName("reconciliation_pipeline_job")]
    public TerraformList<TerraformBlock<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>>? ReconciliationPipelineJob { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleHealthcarePipelineJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
