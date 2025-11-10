using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataflowJobTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataflow_job resource.
/// </summary>
public class GoogleDataflowJob : TerraformResource
{
    public GoogleDataflowJob(string name) : base("google_dataflow_job", name)
    {
    }

    /// <summary>
    /// List of experiments that should be used by the job. An example value is [&amp;quot;enable_stackdriver_agent_metrics&amp;quot;].
    /// </summary>
    [TerraformPropertyName("additional_experiments")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AdditionalExperiments { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "additional_experiments");

    /// <summary>
    /// Indicates if the job should use the streaming engine feature.
    /// </summary>
    [TerraformPropertyName("enable_streaming_engine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableStreamingEngine { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The configuration for VM IPs. Options are &amp;quot;WORKER_IP_PUBLIC&amp;quot; or &amp;quot;WORKER_IP_PRIVATE&amp;quot;.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpConfiguration { get; set; }

    /// <summary>
    /// The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

    /// <summary>
    /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. NOTE: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The machine type to use for the job.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MachineType { get; set; }

    /// <summary>
    /// The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.
    /// </summary>
    [TerraformPropertyName("max_workers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxWorkers { get; set; }

    /// <summary>
    /// A unique name for the resource, required by Dataflow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network to which VMs will be assigned. If it is not provided, &amp;quot;default&amp;quot; will be used.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// One of &amp;quot;drain&amp;quot; or &amp;quot;cancel&amp;quot;. Specifies behavior of deletion during terraform destroy.
    /// </summary>
    [TerraformPropertyName("on_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnDelete { get; set; }

    /// <summary>
    /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region in which the created job should run.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The Service Account email used to create the job.
    /// </summary>
    [TerraformPropertyName("service_account_email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccountEmail { get; set; }

    /// <summary>
    /// If true, treat DRAINING and CANCELLING as terminal job states and do not wait for further changes before removing from terraform state and moving on. WARNING: this will lead to job name conflicts if you do not ensure that the job names are different, e.g. by embedding a release ID or by using a random_id.
    /// </summary>
    [TerraformPropertyName("skip_wait_on_job_termination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipWaitOnJobTermination { get; set; }

    /// <summary>
    /// The subnetwork to which VMs will be assigned. Should be of the form &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Subnetwork { get; set; }

    /// <summary>
    /// A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TempGcsLocation is required")]
    [TerraformPropertyName("temp_gcs_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TempGcsLocation { get; set; }

    /// <summary>
    /// The Google Cloud Storage path to the Dataflow job template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateGcsPath is required")]
    [TerraformPropertyName("template_gcs_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TemplateGcsPath { get; set; }

    /// <summary>
    /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.
    /// </summary>
    [TerraformPropertyName("transform_name_mapping")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? TransformNameMapping { get; set; }

    /// <summary>
    /// The zone in which the created job should run. If it is not provided, the provider zone is used.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataflowJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The unique ID of this job.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_id");

    /// <summary>
    /// The current state of the resource, selected from the JobState enum.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The type of this job, selected from the JobType enum.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
