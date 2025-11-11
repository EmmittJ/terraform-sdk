using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataflowJobTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataflow_job resource.
/// </summary>
public partial class GoogleDataflowJob : TerraformResource
{
    public GoogleDataflowJob(string name) : base("google_dataflow_job", name)
    {
    }

    /// <summary>
    /// List of experiments that should be used by the job. An example value is [&amp;quot;enable_stackdriver_agent_metrics&amp;quot;].
    /// </summary>
    [TerraformProperty("additional_experiments")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> AdditionalExperiments { get; set; }

    /// <summary>
    /// Indicates if the job should use the streaming engine feature.
    /// </summary>
    [TerraformProperty("enable_streaming_engine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStreamingEngine { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The configuration for VM IPs. Options are &amp;quot;WORKER_IP_PUBLIC&amp;quot; or &amp;quot;WORKER_IP_PRIVATE&amp;quot;.
    /// </summary>
    [TerraformProperty("ip_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpConfiguration { get; set; }

    /// <summary>
    /// The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. NOTE: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The machine type to use for the job.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MachineType { get; set; }

    /// <summary>
    /// The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.
    /// </summary>
    [TerraformProperty("max_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxWorkers { get; set; }

    /// <summary>
    /// A unique name for the resource, required by Dataflow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network to which VMs will be assigned. If it is not provided, &amp;quot;default&amp;quot; will be used.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// One of &amp;quot;drain&amp;quot; or &amp;quot;cancel&amp;quot;. Specifies behavior of deletion during terraform destroy.
    /// </summary>
    [TerraformProperty("on_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnDelete { get; set; }

    /// <summary>
    /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The project in which the resource belongs.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region in which the created job should run.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The Service Account email used to create the job.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccountEmail { get; set; }

    /// <summary>
    /// If true, treat DRAINING and CANCELLING as terminal job states and do not wait for further changes before removing from terraform state and moving on. WARNING: this will lead to job name conflicts if you do not ensure that the job names are different, e.g. by embedding a release ID or by using a random_id.
    /// </summary>
    [TerraformProperty("skip_wait_on_job_termination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipWaitOnJobTermination { get; set; }

    /// <summary>
    /// The subnetwork to which VMs will be assigned. Should be of the form &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subnetwork { get; set; }

    /// <summary>
    /// A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TempGcsLocation is required")]
    [TerraformProperty("temp_gcs_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TempGcsLocation { get; set; }

    /// <summary>
    /// The Google Cloud Storage path to the Dataflow job template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateGcsPath is required")]
    [TerraformProperty("template_gcs_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TemplateGcsPath { get; set; }

    /// <summary>
    /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.
    /// </summary>
    [TerraformProperty("transform_name_mapping")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? TransformNameMapping { get; set; }

    /// <summary>
    /// The zone in which the created job should run. If it is not provided, the provider zone is used.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataflowJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The unique ID of this job.
    /// </summary>
    [TerraformProperty("job_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobId { get; }

    /// <summary>
    /// The current state of the resource, selected from the JobState enum.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The type of this job, selected from the JobType enum.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
