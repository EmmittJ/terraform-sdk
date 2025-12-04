using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for schedule_info in GoogleDataPipelinePipeline.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineScheduleInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_info";

    /// <summary>
    /// When the next Scheduler job is going to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> NextJobTime
        => AsReference("next_job_time");

    /// <summary>
    /// Unix-cron format of the schedule. This information is retrieved from the linked Cloud Scheduler.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Timezone ID. This matches the timezone IDs used by the Cloud Scheduler API. If empty, UTC time is assumed.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataPipelinePipeline.
/// Nesting mode: single
/// </summary>
public class GoogleDataPipelinePipelineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

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
/// Block type for workload in GoogleDataPipelinePipeline.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload";

    /// <summary>
    /// DataflowFlexTemplateRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataflowFlexTemplateRequest block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlock>? DataflowFlexTemplateRequest
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlock>>("dataflow_flex_template_request");
        set => SetArgument("dataflow_flex_template_request", value);
    }

    /// <summary>
    /// DataflowLaunchTemplateRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataflowLaunchTemplateRequest block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlock>? DataflowLaunchTemplateRequest
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlock>>("dataflow_launch_template_request");
        set => SetArgument("dataflow_launch_template_request", value);
    }

}

/// <summary>
/// Block type for dataflow_flex_template_request in GoogleDataPipelinePipelineWorkloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataflow_flex_template_request";

    /// <summary>
    /// The regional endpoint to which to direct the request. For example, us-central1, us-west1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the Cloud Platform project that the job belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// If true, the request is validated but not actually executed. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ValidateOnly
    {
        get => GetArgument<TerraformValue<bool>>("validate_only");
        set => SetArgument("validate_only", value);
    }

    /// <summary>
    /// LaunchParameter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchParameter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchParameter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchParameter block(s) allowed")]
    public required TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlock> LaunchParameter
    {
        get => GetRequiredArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlock>>("launch_parameter");
        set => SetArgument("launch_parameter", value);
    }

}

/// <summary>
/// Block type for launch_parameter in GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_parameter";

    /// <summary>
    /// Cloud Storage path to a file with a JSON-serialized ContainerSpec as content.
    /// </summary>
    public TerraformValue<string>? ContainerSpecGcsPath
    {
        get => GetArgument<TerraformValue<string>>("container_spec_gcs_path");
        set => SetArgument("container_spec_gcs_path", value);
    }

    /// <summary>
    /// The job name to use for the created job. For an update job request, the job name should be the same as the existing running job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformValue<string> JobName
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_name");
        set => SetArgument("job_name", value);
    }

    /// <summary>
    /// Launch options for this Flex Template job. This is a common set of options across languages and templates. This should not be used to pass job parameters.
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? LaunchOptions
    {
        get => GetArgument<TerraformMap<string>>("launch_options");
        set => SetArgument("launch_options", value);
    }

    /// <summary>
    /// &#39;The parameters for the Flex Template. Example: {&amp;quot;numWorkers&amp;quot;:&amp;quot;5&amp;quot;}&#39;
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// &#39;Use this to pass transform name mappings for streaming update jobs. Example: {&amp;quot;oldTransformName&amp;quot;:&amp;quot;newTransformName&amp;quot;,...}&#39;
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? TransformNameMappings
    {
        get => GetArgument<TerraformMap<string>>("transform_name_mappings");
        set => SetArgument("transform_name_mappings", value);
    }

    /// <summary>
    /// Set this to true if you are sending a request to update a running streaming job. When set, the job name should be the same as the running job.
    /// </summary>
    public TerraformValue<bool>? Update
    {
        get => GetArgument<TerraformValue<bool>>("update");
        set => SetArgument("update", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

}

/// <summary>
/// Block type for environment in GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlockDataflowFlexTemplateRequestBlockLaunchParameterBlockEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// Additional experiment flags for the job.
    /// </summary>
    public TerraformList<string>? AdditionalExperiments
    {
        get => GetArgument<TerraformList<string>>("additional_experiments");
        set => SetArgument("additional_experiments", value);
    }

    /// <summary>
    /// Additional user labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. An object containing a list of key/value pairs.
    /// &#39;Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? AdditionalUserLabels
    {
        get => GetArgument<TerraformMap<string>>("additional_user_labels");
        set => SetArgument("additional_user_labels", value);
    }

    /// <summary>
    /// Whether to enable Streaming Engine for the job.
    /// </summary>
    public TerraformValue<bool>? EnableStreamingEngine
    {
        get => GetArgument<TerraformValue<bool>>("enable_streaming_engine");
        set => SetArgument("enable_streaming_engine", value);
    }

    /// <summary>
    /// Set FlexRS goal for the job. https://cloud.google.com/dataflow/docs/guides/flexrs
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#FlexResourceSchedulingGoal Possible values: [&amp;quot;FLEXRS_UNSPECIFIED&amp;quot;, &amp;quot;FLEXRS_SPEED_OPTIMIZED&amp;quot;, &amp;quot;FLEXRS_COST_OPTIMIZED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? FlexrsGoal
    {
        get => GetArgument<TerraformValue<string>>("flexrs_goal");
        set => SetArgument("flexrs_goal", value);
    }

    /// <summary>
    /// Configuration for VM IPs.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#WorkerIPAddressConfiguration Possible values: [&amp;quot;WORKER_IP_UNSPECIFIED&amp;quot;, &amp;quot;WORKER_IP_PUBLIC&amp;quot;, &amp;quot;WORKER_IP_PRIVATE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpConfiguration
    {
        get => GetArgument<TerraformValue<string>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// &#39;Name for the Cloud KMS key for the job. The key format is: projects//locations//keyRings//cryptoKeys/&#39;
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The machine type to use for the job. Defaults to the value from the template if not specified.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The maximum number of Compute Engine instances to be made available to your pipeline during execution, from 1 to 1000.
    /// </summary>
    public TerraformValue<double>? MaxWorkers
    {
        get => GetArgument<TerraformValue<double>>("max_workers");
        set => SetArgument("max_workers", value);
    }

    /// <summary>
    /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network &amp;quot;default&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The initial number of Compute Engine instances for the job.
    /// </summary>
    public TerraformValue<double>? NumWorkers
    {
        get => GetArgument<TerraformValue<double>>("num_workers");
        set => SetArgument("num_workers", value);
    }

    /// <summary>
    /// The email address of the service account to run the job as.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// Subnetwork to which VMs will be assigned, if desired. You can specify a subnetwork using either a complete URL or an abbreviated path. Expected to be of the form &amp;quot;https://www.googleapis.com/compute/v1/projects/HOST_PROJECT_ID/regions/REGION/subnetworks/SUBNETWORK&amp;quot; or &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;. If the subnetwork is located in a Shared VPC network, you must use the complete URL.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The Cloud Storage path to use for temporary files. Must be a valid Cloud Storage URL, beginning with gs://.
    /// </summary>
    public TerraformValue<string>? TempLocation
    {
        get => GetArgument<TerraformValue<string>>("temp_location");
        set => SetArgument("temp_location", value);
    }

    /// <summary>
    /// The Compute Engine region (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which worker processing should occur, e.g. &amp;quot;us-west1&amp;quot;. Mutually exclusive with workerZone. If neither workerRegion nor workerZone is specified, default to the control plane&#39;s region.
    /// </summary>
    public TerraformValue<string>? WorkerRegion
    {
        get => GetArgument<TerraformValue<string>>("worker_region");
        set => SetArgument("worker_region", value);
    }

    /// <summary>
    /// The Compute Engine zone (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which worker processing should occur, e.g. &amp;quot;us-west1-a&amp;quot;. Mutually exclusive with workerRegion. If neither workerRegion nor workerZone is specified, a zone in the control plane&#39;s region is chosen based on available capacity. If both workerZone and zone are set, workerZone takes precedence.
    /// </summary>
    public TerraformValue<string>? WorkerZone
    {
        get => GetArgument<TerraformValue<string>>("worker_zone");
        set => SetArgument("worker_zone", value);
    }

    /// <summary>
    /// The Compute Engine availability zone for launching worker instances to run your pipeline. In the future, workerZone will take precedence.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

}

/// <summary>
/// Block type for dataflow_launch_template_request in GoogleDataPipelinePipelineWorkloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataflow_launch_template_request";

    /// <summary>
    /// A Cloud Storage path to the template from which to create the job. Must be a valid Cloud Storage URL, beginning with &#39;gs://&#39;.
    /// </summary>
    public TerraformValue<string>? GcsPath
    {
        get => GetArgument<TerraformValue<string>>("gcs_path");
        set => SetArgument("gcs_path", value);
    }

    /// <summary>
    /// The regional endpoint to which to direct the request.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the Cloud Platform project that the job belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The validate_only attribute.
    /// </summary>
    public TerraformValue<bool>? ValidateOnly
    {
        get => GetArgument<TerraformValue<bool>>("validate_only");
        set => SetArgument("validate_only", value);
    }

    /// <summary>
    /// LaunchParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchParameters block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlock>? LaunchParameters
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlock>>("launch_parameters");
        set => SetArgument("launch_parameters", value);
    }

}

/// <summary>
/// Block type for launch_parameters in GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_parameters";

    /// <summary>
    /// The job name to use for the created job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformValue<string> JobName
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_name");
        set => SetArgument("job_name", value);
    }

    /// <summary>
    /// The runtime parameters to pass to the job.
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Map of transform name prefixes of the job to be replaced to the corresponding name prefixes of the new job. Only applicable when updating a pipeline.
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? TransformNameMapping
    {
        get => GetArgument<TerraformMap<string>>("transform_name_mapping");
        set => SetArgument("transform_name_mapping", value);
    }

    /// <summary>
    /// If set, replace the existing pipeline with the name specified by jobName with this pipeline, preserving state.
    /// </summary>
    public TerraformValue<bool>? Update
    {
        get => GetArgument<TerraformValue<bool>>("update");
        set => SetArgument("update", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

}

/// <summary>
/// Block type for environment in GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlockDataflowLaunchTemplateRequestBlockLaunchParametersBlockEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// Additional experiment flags for the job.
    /// </summary>
    public TerraformList<string>? AdditionalExperiments
    {
        get => GetArgument<TerraformList<string>>("additional_experiments");
        set => SetArgument("additional_experiments", value);
    }

    /// <summary>
    /// Additional user labels to be specified for the job. Keys and values should follow the restrictions specified in the labeling restrictions page. An object containing a list of key/value pairs.
    /// &#39;Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// &#39;An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.&#39;
    /// </summary>
    public TerraformMap<string>? AdditionalUserLabels
    {
        get => GetArgument<TerraformMap<string>>("additional_user_labels");
        set => SetArgument("additional_user_labels", value);
    }

    /// <summary>
    /// Whether to bypass the safety checks for the job&#39;s temporary directory. Use with caution.
    /// </summary>
    public TerraformValue<bool>? BypassTempDirValidation
    {
        get => GetArgument<TerraformValue<bool>>("bypass_temp_dir_validation");
        set => SetArgument("bypass_temp_dir_validation", value);
    }

    /// <summary>
    /// Whether to enable Streaming Engine for the job.
    /// </summary>
    public TerraformValue<bool>? EnableStreamingEngine
    {
        get => GetArgument<TerraformValue<bool>>("enable_streaming_engine");
        set => SetArgument("enable_streaming_engine", value);
    }

    /// <summary>
    /// Configuration for VM IPs.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#WorkerIPAddressConfiguration Possible values: [&amp;quot;WORKER_IP_UNSPECIFIED&amp;quot;, &amp;quot;WORKER_IP_PUBLIC&amp;quot;, &amp;quot;WORKER_IP_PRIVATE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpConfiguration
    {
        get => GetArgument<TerraformValue<string>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// &#39;Name for the Cloud KMS key for the job. The key format is: projects//locations//keyRings//cryptoKeys/&#39;
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The machine type to use for the job. Defaults to the value from the template if not specified.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The maximum number of Compute Engine instances to be made available to your pipeline during execution, from 1 to 1000.
    /// </summary>
    public TerraformValue<double>? MaxWorkers
    {
        get => GetArgument<TerraformValue<double>>("max_workers");
        set => SetArgument("max_workers", value);
    }

    /// <summary>
    /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network &amp;quot;default&amp;quot;.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The initial number of Compute Engine instances for the job.
    /// </summary>
    public TerraformValue<double>? NumWorkers
    {
        get => GetArgument<TerraformValue<double>>("num_workers");
        set => SetArgument("num_workers", value);
    }

    /// <summary>
    /// The email address of the service account to run the job as.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// Subnetwork to which VMs will be assigned, if desired. You can specify a subnetwork using either a complete URL or an abbreviated path. Expected to be of the form &amp;quot;https://www.googleapis.com/compute/v1/projects/HOST_PROJECT_ID/regions/REGION/subnetworks/SUBNETWORK&amp;quot; or &amp;quot;regions/REGION/subnetworks/SUBNETWORK&amp;quot;. If the subnetwork is located in a Shared VPC network, you must use the complete URL.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The Cloud Storage path to use for temporary files. Must be a valid Cloud Storage URL, beginning with gs://.
    /// </summary>
    public TerraformValue<string>? TempLocation
    {
        get => GetArgument<TerraformValue<string>>("temp_location");
        set => SetArgument("temp_location", value);
    }

    /// <summary>
    /// The Compute Engine region (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which worker processing should occur, e.g. &amp;quot;us-west1&amp;quot;. Mutually exclusive with workerZone. If neither workerRegion nor workerZone is specified, default to the control plane&#39;s region.
    /// </summary>
    public TerraformValue<string>? WorkerRegion
    {
        get => GetArgument<TerraformValue<string>>("worker_region");
        set => SetArgument("worker_region", value);
    }

    /// <summary>
    /// The Compute Engine zone (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which worker processing should occur, e.g. &amp;quot;us-west1-a&amp;quot;. Mutually exclusive with workerRegion. If neither workerRegion nor workerZone is specified, a zone in the control plane&#39;s region is chosen based on available capacity. If both workerZone and zone are set, workerZone takes precedence.
    /// </summary>
    public TerraformValue<string>? WorkerZone
    {
        get => GetArgument<TerraformValue<string>>("worker_zone");
        set => SetArgument("worker_zone", value);
    }

    /// <summary>
    /// The Compute Engine availability zone for launching worker instances to run your pipeline. In the future, workerZone will take precedence.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

}


/// <summary>
/// Represents a google_data_pipeline_pipeline Terraform resource.
/// Manages a google_data_pipeline_pipeline resource.
/// </summary>
public partial class GoogleDataPipelinePipeline(string name) : TerraformResource("google_data_pipeline_pipeline", name)
{
    /// <summary>
    /// The display name of the pipeline. It can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), and underscores (_).
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// &amp;quot;The pipeline name. For example&#39;: &#39;projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID.&amp;quot;
    /// &amp;quot;- PROJECT_ID can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), and periods (.). For more information, see Identifying projects.&amp;quot;
    /// &amp;quot;LOCATION_ID is the canonical ID for the pipeline&#39;s location. The list of available locations can be obtained by calling google.cloud.location.Locations.ListLocations. Note that the Data Pipelines service is not available in all regions. It depends on Cloud Scheduler, an App Engine application, so it&#39;s only available in App Engine regions.&amp;quot;
    /// &amp;quot;PIPELINE_ID is the ID of the pipeline. Must be unique for the selected project and location.&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sources of the pipeline (for example, Dataplex). The keys and values are set by the corresponding sources during pipeline creation.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? PipelineSources
    {
        get => GetArgument<TerraformMap<string>>("pipeline_sources");
        set => SetArgument("pipeline_sources", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A reference to the region
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Optional. A service account email to be used with the Cloud Scheduler job. If not specified, the default compute engine service account will be used.
    /// </summary>
    public TerraformValue<string> SchedulerServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("scheduler_service_account_email") ?? AsReference("scheduler_service_account_email");
        set => SetArgument("scheduler_service_account_email", value);
    }

    /// <summary>
    /// The state of the pipeline. When the pipeline is created, the state is set to &#39;PIPELINE_STATE_ACTIVE&#39; by default. State changes can be requested by setting the state to stopping, paused, or resuming. State cannot be changed through pipelines.patch requests.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#state Possible values: [&amp;quot;STATE_UNSPECIFIED&amp;quot;, &amp;quot;STATE_RESUMING&amp;quot;, &amp;quot;STATE_ACTIVE&amp;quot;, &amp;quot;STATE_STOPPING&amp;quot;, &amp;quot;STATE_ARCHIVED&amp;quot;, &amp;quot;STATE_PAUSED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetRequiredArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The type of the pipeline. This field affects the scheduling of the pipeline and the type of metrics to show for the pipeline.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#pipelinetype Possible values: [&amp;quot;PIPELINE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PIPELINE_TYPE_BATCH&amp;quot;, &amp;quot;PIPELINE_TYPE_STREAMING&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The timestamp when the pipeline was initially created. Set by the Data Pipelines service.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Number of jobs.
    /// </summary>
    public TerraformValue<double> JobCount
        => AsReference("job_count");

    /// <summary>
    /// The timestamp when the pipeline was last modified. Set by the Data Pipelines service.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> LastUpdateTime
        => AsReference("last_update_time");

    /// <summary>
    /// ScheduleInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleInfo block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineScheduleInfoBlock>? ScheduleInfo
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineScheduleInfoBlock>>("schedule_info");
        set => SetArgument("schedule_info", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataPipelinePipelineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataPipelinePipelineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Workload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Workload block(s) allowed")]
    public TerraformList<GoogleDataPipelinePipelineWorkloadBlock>? Workload
    {
        get => GetArgument<TerraformList<GoogleDataPipelinePipelineWorkloadBlock>>("workload");
        set => SetArgument("workload", value);
    }

}
