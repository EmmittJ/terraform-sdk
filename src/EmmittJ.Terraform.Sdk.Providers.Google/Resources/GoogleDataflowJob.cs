using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("job_id");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// List of experiments that should be used by the job. An example value is [&amp;quot;enable_stackdriver_agent_metrics&amp;quot;].
    /// </summary>
    public TerraformProperty<HashSet<string>>? AdditionalExperiments
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("additional_experiments");
        set => this.WithProperty("additional_experiments", value);
    }

    /// <summary>
    /// Indicates if the job should use the streaming engine feature.
    /// </summary>
    public TerraformProperty<bool>? EnableStreamingEngine
    {
        get => GetProperty<TerraformProperty<bool>>("enable_streaming_engine");
        set => this.WithProperty("enable_streaming_engine", value);
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
    /// The configuration for VM IPs. Options are &amp;quot;WORKER_IP_PUBLIC&amp;quot; or &amp;quot;WORKER_IP_PRIVATE&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? IpConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("ip_configuration");
        set => this.WithProperty("ip_configuration", value);
    }

    /// <summary>
    /// The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. NOTE: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The machine type to use for the job.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => this.WithProperty("machine_type", value);
    }

    /// <summary>
    /// The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.
    /// </summary>
    public TerraformProperty<double>? MaxWorkers
    {
        get => GetProperty<TerraformProperty<double>>("max_workers");
        set => this.WithProperty("max_workers", value);
    }

    /// <summary>
    /// A unique name for the resource, required by Dataflow.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network to which VMs will be assigned. If it is not provided, &amp;quot;default&amp;quot; will be used.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// One of &amp;quot;drain&amp;quot; or &amp;quot;cancel&amp;quot;. Specifies behavior of deletion during terraform destroy.
    /// </summary>
    public TerraformProperty<string>? OnDelete
    {
        get => GetProperty<TerraformProperty<string>>("on_delete");
        set => this.WithProperty("on_delete", value);
    }

    /// <summary>
    /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The project in which the resource belongs.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region in which the created job should run.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The Service Account email used to create the job.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("service_account_email");
        set => this.WithProperty("service_account_email", value);
    }

    /// <summary>
    /// If true, treat DRAINING and CANCELLING as terminal job states and do not wait for further changes before removing from terraform state and moving on. WARNING: this will lead to job name conflicts if you do not ensure that the job names are different, e.g. by embedding a release ID or by using a random_id.
    /// </summary>
    public TerraformProperty<bool>? SkipWaitOnJobTermination
    {
        get => GetProperty<TerraformProperty<bool>>("skip_wait_on_job_termination");
        set => this.WithProperty("skip_wait_on_job_termination", value);
    }

    /// <summary>
    /// The subnetwork to which VMs will be assigned. Should be of the form &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => this.WithProperty("subnetwork", value);
    }

    /// <summary>
    /// A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.
    /// </summary>
    public TerraformProperty<string>? TempGcsLocation
    {
        get => GetProperty<TerraformProperty<string>>("temp_gcs_location");
        set => this.WithProperty("temp_gcs_location", value);
    }

    /// <summary>
    /// The Google Cloud Storage path to the Dataflow job template.
    /// </summary>
    public TerraformProperty<string>? TemplateGcsPath
    {
        get => GetProperty<TerraformProperty<string>>("template_gcs_path");
        set => this.WithProperty("template_gcs_path", value);
    }

    /// <summary>
    /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.
    /// </summary>
    public TerraformMapProperty<string>? TransformNameMapping
    {
        get => GetProperty<TerraformMapProperty<string>>("transform_name_mapping");
        set => this.WithProperty("transform_name_mapping", value);
    }

    /// <summary>
    /// The zone in which the created job should run. If it is not provided, the provider zone is used.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
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
