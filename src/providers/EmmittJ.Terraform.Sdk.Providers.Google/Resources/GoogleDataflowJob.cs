using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataflowJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataflow_job resource.
/// </summary>
public class GoogleDataflowJob : TerraformResource
{
    public GoogleDataflowJob(string name) : base("google_dataflow_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("job_id");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("type");
        SetOutput("additional_experiments");
        SetOutput("enable_streaming_engine");
        SetOutput("id");
        SetOutput("ip_configuration");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("machine_type");
        SetOutput("max_workers");
        SetOutput("name");
        SetOutput("network");
        SetOutput("on_delete");
        SetOutput("parameters");
        SetOutput("project");
        SetOutput("region");
        SetOutput("service_account_email");
        SetOutput("skip_wait_on_job_termination");
        SetOutput("subnetwork");
        SetOutput("temp_gcs_location");
        SetOutput("template_gcs_path");
        SetOutput("transform_name_mapping");
        SetOutput("zone");
    }

    /// <summary>
    /// List of experiments that should be used by the job. An example value is [&amp;quot;enable_stackdriver_agent_metrics&amp;quot;].
    /// </summary>
    public HashSet<TerraformProperty<string>> AdditionalExperiments
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("additional_experiments");
        set => SetProperty("additional_experiments", value);
    }

    /// <summary>
    /// Indicates if the job should use the streaming engine feature.
    /// </summary>
    public TerraformProperty<bool> EnableStreamingEngine
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_streaming_engine");
        set => SetProperty("enable_streaming_engine", value);
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
    /// The configuration for VM IPs. Options are &amp;quot;WORKER_IP_PUBLIC&amp;quot; or &amp;quot;WORKER_IP_PRIVATE&amp;quot;.
    /// </summary>
    public TerraformProperty<string> IpConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_configuration");
        set => SetProperty("ip_configuration", value);
    }

    /// <summary>
    /// The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. NOTE: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The machine type to use for the job.
    /// </summary>
    public TerraformProperty<string> MachineType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("machine_type");
        set => SetProperty("machine_type", value);
    }

    /// <summary>
    /// The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.
    /// </summary>
    public TerraformProperty<double> MaxWorkers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_workers");
        set => SetProperty("max_workers", value);
    }

    /// <summary>
    /// A unique name for the resource, required by Dataflow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network to which VMs will be assigned. If it is not provided, &amp;quot;default&amp;quot; will be used.
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// One of &amp;quot;drain&amp;quot; or &amp;quot;cancel&amp;quot;. Specifies behavior of deletion during terraform destroy.
    /// </summary>
    public TerraformProperty<string> OnDelete
    {
        get => GetRequiredOutput<TerraformProperty<string>>("on_delete");
        set => SetProperty("on_delete", value);
    }

    /// <summary>
    /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The project in which the resource belongs.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region in which the created job should run.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The Service Account email used to create the job.
    /// </summary>
    public TerraformProperty<string> ServiceAccountEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account_email");
        set => SetProperty("service_account_email", value);
    }

    /// <summary>
    /// If true, treat DRAINING and CANCELLING as terminal job states and do not wait for further changes before removing from terraform state and moving on. WARNING: this will lead to job name conflicts if you do not ensure that the job names are different, e.g. by embedding a release ID or by using a random_id.
    /// </summary>
    public TerraformProperty<bool> SkipWaitOnJobTermination
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_wait_on_job_termination");
        set => SetProperty("skip_wait_on_job_termination", value);
    }

    /// <summary>
    /// The subnetwork to which VMs will be assigned. Should be of the form &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;.
    /// </summary>
    public TerraformProperty<string> Subnetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnetwork");
        set => SetProperty("subnetwork", value);
    }

    /// <summary>
    /// A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TempGcsLocation is required")]
    public required TerraformProperty<string> TempGcsLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("temp_gcs_location");
        set => SetProperty("temp_gcs_location", value);
    }

    /// <summary>
    /// The Google Cloud Storage path to the Dataflow job template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateGcsPath is required")]
    public required TerraformProperty<string> TemplateGcsPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_gcs_path");
        set => SetProperty("template_gcs_path", value);
    }

    /// <summary>
    /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TransformNameMapping
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("transform_name_mapping");
        set => SetProperty("transform_name_mapping", value);
    }

    /// <summary>
    /// The zone in which the created job should run. If it is not provided, the provider zone is used.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataflowJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique ID of this job.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

    /// <summary>
    /// The current state of the resource, selected from the JobState enum.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The type of this job, selected from the JobType enum.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
