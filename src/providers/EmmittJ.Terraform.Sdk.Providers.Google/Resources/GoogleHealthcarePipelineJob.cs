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
        set => SetProperty("mapping_pipeline_job", value);
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
        set => SetProperty("fhir_store_destination", value);
    }

    /// <summary>
    /// If set to true, a mapping pipeline will send output snapshots
    /// to the reconciliation pipeline in its dataset. A reconciliation
    /// pipeline must exist in this dataset before a mapping pipeline
    /// with a reconciliation destination can be created.
    /// </summary>
    public TerraformProperty<bool>? ReconciliationDestination
    {
        set => SetProperty("reconciliation_destination", value);
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
        set => SetProperty("fhir_store_destination", value);
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
        set => SetProperty("matching_uri_prefix", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("effective_labels");
        SetOutput("self_link");
        SetOutput("terraform_labels");
        SetOutput("dataset");
        SetOutput("disable_lineage");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
    }

    /// <summary>
    /// Healthcare Dataset under which the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformProperty<string> Dataset
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset");
        set => SetProperty("dataset", value);
    }

    /// <summary>
    /// If true, disables writing lineage for the pipeline.
    /// </summary>
    public TerraformProperty<bool> DisableLineage
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_lineage");
        set => SetProperty("disable_lineage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location where the Pipeline Job is to run
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Specifies the name of the pipeline job. This field is user-assigned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for backfill_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillPipelineJob block(s) allowed")]
    public List<GoogleHealthcarePipelineJobBackfillPipelineJobBlock>? BackfillPipelineJob
    {
        set => SetProperty("backfill_pipeline_job", value);
    }

    /// <summary>
    /// Block for mapping_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingPipelineJob block(s) allowed")]
    public List<GoogleHealthcarePipelineJobMappingPipelineJobBlock>? MappingPipelineJob
    {
        set => SetProperty("mapping_pipeline_job", value);
    }

    /// <summary>
    /// Block for reconciliation_pipeline_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReconciliationPipelineJob block(s) allowed")]
    public List<GoogleHealthcarePipelineJobReconciliationPipelineJobBlock>? ReconciliationPipelineJob
    {
        set => SetProperty("reconciliation_pipeline_job", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleHealthcarePipelineJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
