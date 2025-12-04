using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDataflowJob.
/// Nesting mode: single
/// </summary>
public class GoogleDataflowJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a google_dataflow_job Terraform resource.
/// Manages a google_dataflow_job resource.
/// </summary>
public partial class GoogleDataflowJob(string name) : TerraformResource("google_dataflow_job", name)
{
    /// <summary>
    /// List of experiments that should be used by the job. An example value is [&amp;quot;enable_stackdriver_agent_metrics&amp;quot;].
    /// </summary>
    public TerraformSet<string> AdditionalExperiments
    {
        get => GetArgument<TerraformSet<string>>("additional_experiments") ?? AsReference("additional_experiments");
        set => SetArgument("additional_experiments", value);
    }

    /// <summary>
    /// Indicates if the job should use the streaming engine feature.
    /// </summary>
    public TerraformValue<bool>? EnableStreamingEngine
    {
        get => GetArgument<TerraformValue<bool>>("enable_streaming_engine");
        set => SetArgument("enable_streaming_engine", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The configuration for VM IPs. Options are &amp;quot;WORKER_IP_PUBLIC&amp;quot; or &amp;quot;WORKER_IP_PRIVATE&amp;quot;.
    /// </summary>
    public TerraformValue<string>? IpConfiguration
    {
        get => GetArgument<TerraformValue<string>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// The name for the Cloud KMS key for the job. Key format is: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. NOTE: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The machine type to use for the job.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The number of workers permitted to work on the job. More workers may improve processing speed at additional cost.
    /// </summary>
    public TerraformValue<double>? MaxWorkers
    {
        get => GetArgument<TerraformValue<double>>("max_workers");
        set => SetArgument("max_workers", value);
    }

    /// <summary>
    /// A unique name for the resource, required by Dataflow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network to which VMs will be assigned. If it is not provided, &amp;quot;default&amp;quot; will be used.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// One of &amp;quot;drain&amp;quot; or &amp;quot;cancel&amp;quot;. Specifies behavior of deletion during terraform destroy.
    /// </summary>
    public TerraformValue<string>? OnDelete
    {
        get => GetArgument<TerraformValue<string>>("on_delete");
        set => SetArgument("on_delete", value);
    }

    /// <summary>
    /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The project in which the resource belongs.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region in which the created job should run.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The Service Account email used to create the job.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// If true, treat DRAINING and CANCELLING as terminal job states and do not wait for further changes before removing from terraform state and moving on. WARNING: this will lead to job name conflicts if you do not ensure that the job names are different, e.g. by embedding a release ID or by using a random_id.
    /// </summary>
    public TerraformValue<bool>? SkipWaitOnJobTermination
    {
        get => GetArgument<TerraformValue<bool>>("skip_wait_on_job_termination");
        set => SetArgument("skip_wait_on_job_termination", value);
    }

    /// <summary>
    /// The subnetwork to which VMs will be assigned. Should be of the form &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// A writeable location on Google Cloud Storage for the Dataflow job to dump its temporary data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TempGcsLocation is required")]
    public required TerraformValue<string> TempGcsLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("temp_gcs_location");
        set => SetArgument("temp_gcs_location", value);
    }

    /// <summary>
    /// The Google Cloud Storage path to the Dataflow job template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateGcsPath is required")]
    public required TerraformValue<string> TemplateGcsPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("template_gcs_path");
        set => SetArgument("template_gcs_path", value);
    }

    /// <summary>
    /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced with the corresponding name prefixes of the new job.
    /// </summary>
    public TerraformMap<string>? TransformNameMapping
    {
        get => GetArgument<TerraformMap<string>>("transform_name_mapping");
        set => SetArgument("transform_name_mapping", value);
    }

    /// <summary>
    /// The zone in which the created job should run. If it is not provided, the provider zone is used.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The unique ID of this job.
    /// </summary>
    public TerraformValue<string> JobId
        => AsReference("job_id");

    /// <summary>
    /// The current state of the resource, selected from the JobState enum.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The type of this job, selected from the JobType enum.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataflowJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataflowJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
