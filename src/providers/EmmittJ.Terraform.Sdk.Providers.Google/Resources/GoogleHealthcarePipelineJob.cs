using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_pipeline_job in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobBackfillPipelineJobBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the mapping pipeline job to backfill, the name format
    /// should follow: projects/{projectId}/locations/{locationId}/datasets/{datasetId}/pipelineJobs/{pipelineJobId}.
    /// </summary>
    public TerraformProperty<string>? MappingPipelineJob
    {
        get => GetProperty<TerraformProperty<string>>("mapping_pipeline_job");
        set => WithProperty("mapping_pipeline_job", value);
    }

}

/// <summary>
/// Block type for mapping_pipeline_job in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobMappingPipelineJobBlock : TerraformBlock
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
    public TerraformProperty<string>? FhirStoreDestination
    {
        get => GetProperty<TerraformProperty<string>>("fhir_store_destination");
        set => WithProperty("fhir_store_destination", value);
    }

    /// <summary>
    /// If set to true, a mapping pipeline will send output snapshots
    /// to the reconciliation pipeline in its dataset. A reconciliation
    /// pipeline must exist in this dataset before a mapping pipeline
    /// with a reconciliation destination can be created.
    /// </summary>
    public TerraformProperty<bool>? ReconciliationDestination
    {
        get => GetProperty<TerraformProperty<bool>>("reconciliation_destination");
        set => WithProperty("reconciliation_destination", value);
    }

}

/// <summary>
/// Block type for reconciliation_pipeline_job in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcarePipelineJobReconciliationPipelineJobBlock : TerraformBlock
{
    /// <summary>
    /// The harmonized FHIR store to write harmonized FHIR resources to,
    /// in the format of: project/{projectID}/locations/{locationID}/datasets/{datasetName}/fhirStores/{id}
    /// </summary>
    public TerraformProperty<string>? FhirStoreDestination
    {
        get => GetProperty<TerraformProperty<string>>("fhir_store_destination");
        set => WithProperty("fhir_store_destination", value);
    }

    /// <summary>
    /// Specifies the top level directory of the matching configs used
    /// in all mapping pipelines, which extract properties for resources
    /// to be matched on.
    /// Example: gs://{bucket-id}/{path/to/matching/configs}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingUriPrefix is required")]
    public required TerraformProperty<string> MatchingUriPrefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("matching_uri_prefix");
        set => WithProperty("matching_uri_prefix", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleHealthcarePipelineJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_healthcare_pipeline_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleHealthcarePipelineJob : TerraformResource
{
    public GoogleHealthcarePipelineJob(string name) : base("google_healthcare_pipeline_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("self_link");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// Healthcare Dataset under which the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformProperty<string> Dataset
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dataset");
        set => this.WithProperty("dataset", value);
    }

    /// <summary>
    /// If true, disables writing lineage for the pipeline.
    /// </summary>
    public TerraformProperty<bool>? DisableLineage
    {
        get => GetProperty<TerraformProperty<bool>>("disable_lineage");
        set => this.WithProperty("disable_lineage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Location where the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Specifies the name of the pipeline job. This field is user-assigned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for backfill_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillPipelineJob block(s) allowed")]
    public List<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>? BackfillPipelineJob
    {
        get => GetProperty<List<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>>("backfill_pipeline_job");
        set => this.WithProperty("backfill_pipeline_job", value);
    }

    /// <summary>
    /// Block for mapping_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingPipelineJob block(s) allowed")]
    public List<GoogleHealthcarePipelineJobMappingPipelineJobBlock>? MappingPipelineJob
    {
        get => GetProperty<List<GoogleHealthcarePipelineJobMappingPipelineJobBlock>>("mapping_pipeline_job");
        set => this.WithProperty("mapping_pipeline_job", value);
    }

    /// <summary>
    /// Block for reconciliation_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReconciliationPipelineJob block(s) allowed")]
    public List<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>? ReconciliationPipelineJob
    {
        get => GetProperty<List<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>>("reconciliation_pipeline_job");
        set => this.WithProperty("reconciliation_pipeline_job", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleHealthcarePipelineJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleHealthcarePipelineJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
