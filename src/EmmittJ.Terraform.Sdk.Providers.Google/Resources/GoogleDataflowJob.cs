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
    public HashSet<string>? AdditionalExperiments
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_experiments")?.Value;
        set => this.WithProperty("additional_experiments", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Indicates if the job should use the streaming engine feature.
    /// </summary>
    public bool? EnableStreamingEngine
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_streaming_engine")?.Value;
        set => this.WithProperty("enable_streaming_engine", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration for VM IPs. Options are &amp;quot;WORKER_IP_PUBLIC&amp;quot; or &amp;quot;WORKER_IP_PRIVATE&amp;quot;.
    /// </summary>
    public string? IpConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_configuration")?.Value;
        set => this.WithProperty("ip_configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
    /// </summary>
    public string? KmsKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_name")?.Value;
        set => this.WithProperty("kms_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. NOTE: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The machine type to use for the job.
    /// </summary>
    public string? MachineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("machine_type")?.Value;
        set => this.WithProperty("machine_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.
    /// </summary>
    public double? MaxWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_workers")?.Value;
        set => this.WithProperty("max_workers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// A unique name for the resource, required by Dataflow.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network to which VMs will be assigned. If it is not provided, &amp;quot;default&amp;quot; will be used.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// One of &amp;quot;drain&amp;quot; or &amp;quot;cancel&amp;quot;. Specifies behavior of deletion during terraform destroy.
    /// </summary>
    public string? OnDelete
    {
        get => GetProperty<TerraformLiteralProperty<string>>("on_delete")?.Value;
        set => this.WithProperty("on_delete", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The project in which the resource belongs.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region in which the created job should run.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Service Account email used to create the job.
    /// </summary>
    public string? ServiceAccountEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_email")?.Value;
        set => this.WithProperty("service_account_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, treat DRAINING and CANCELLING as terminal job states and do not wait for further changes before removing from terraform state and moving on. WARNING: this will lead to job name conflicts if you do not ensure that the job names are different, e.g. by embedding a release ID or by using a random_id.
    /// </summary>
    public bool? SkipWaitOnJobTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_wait_on_job_termination")?.Value;
        set => this.WithProperty("skip_wait_on_job_termination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The subnetwork to which VMs will be assigned. Should be of the form &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;.
    /// </summary>
    public string? Subnetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnetwork")?.Value;
        set => this.WithProperty("subnetwork", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.
    /// </summary>
    public string? TempGcsLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("temp_gcs_location")?.Value;
        set => this.WithProperty("temp_gcs_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Google Cloud Storage path to the Dataflow job template.
    /// </summary>
    public string? TemplateGcsPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_gcs_path")?.Value;
        set => this.WithProperty("template_gcs_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.
    /// </summary>
    public Dictionary<string, string>? TransformNameMapping
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("transform_name_mapping")?.Value;
        set => this.WithProperty("transform_name_mapping", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone in which the created job should run. If it is not provided, the provider zone is used.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
