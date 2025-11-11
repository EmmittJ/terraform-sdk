using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunV2ServiceBinaryAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass
    /// </summary>
    [TerraformProperty("breakglass_justification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BreakglassJustification { get; set; }

    /// <summary>
    /// The path to a binary authorization policy. Format: projects/{project}/platforms/cloudRun/{policy-name}
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Policy { get; set; }

    /// <summary>
    /// If True, indicates to use the default project&#39;s binary authorization policy. If False, binary authorization will be disabled.
    /// </summary>
    [TerraformProperty("use_default")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseDefault { get; set; }

}

/// <summary>
/// Block type for build_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunV2ServiceBuildConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The base image used to build the function.
    /// </summary>
    [TerraformProperty("base_image")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BaseImage { get; set; }

    /// <summary>
    /// Sets whether the function will receive automatic base image updates.
    /// </summary>
    [TerraformProperty("enable_automatic_updates")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableAutomaticUpdates { get; set; }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed. Defaults to the resource name suffix, if not specified. For backward compatibility, if function with given name is not found, then the system will try to use function named &amp;quot;function&amp;quot;.
    /// </summary>
    [TerraformProperty("function_target")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FunctionTarget { get; set; }

    /// <summary>
    /// Artifact Registry URI to store the built image.
    /// </summary>
    [TerraformProperty("image_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageUri { get; set; }


    /// <summary>
    /// Service account to be used for building the container. The format of this field is &#39;projects/{projectId}/serviceAccounts/{serviceAccountEmail}&#39;.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// The Cloud Storage bucket URI where the function source code is located.
    /// </summary>
    [TerraformProperty("source_location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceLocation { get; set; }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the Cloud Run function. The format of this field is &#39;projects/{project}/locations/{region}/workerPools/{workerPool}&#39; where {project} and {region} are the project id and region respectively where the worker pool is defined and {workerPool} is the short name of the worker pool.
    /// </summary>
    [TerraformProperty("worker_pool")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WorkerPool { get; set; }

}

/// <summary>
/// Block type for multi_region_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunV2ServiceMultiRegionSettingsBlock : TerraformBlockBase
{

    /// <summary>
    /// The list of regions to deploy the multi-region Service.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Regions { get; set; }

}

/// <summary>
/// Block type for scaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunV2ServiceScalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Total instance count for the service in manual scaling mode. This number of instances is divided among all revisions with specified traffic based on the percent of traffic they are receiving.
    /// </summary>
    [TerraformProperty("manual_instance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ManualInstanceCount { get; set; }

    /// <summary>
    /// Combined maximum number of instances for all revisions receiving traffic.
    /// </summary>
    [TerraformProperty("max_instance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxInstanceCount { get; set; }

    /// <summary>
    /// Minimum number of instances for the service, to be divided among all revisions receiving traffic.
    /// </summary>
    [TerraformProperty("min_instance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinInstanceCount { get; set; }

    /// <summary>
    /// The [scaling mode](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services#scalingmode) for the service. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    [TerraformProperty("scaling_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScalingMode { get; set; }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunV2ServiceTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system annotations in v1 now have a corresponding field in v2 RevisionTemplate.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
    /// </summary>
    [TerraformProperty("encryption_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EncryptionKey { get; set; }

    /// <summary>
    /// The sandbox environment to host this Revision. Possible values: [&amp;quot;EXECUTION_ENVIRONMENT_GEN1&amp;quot;, &amp;quot;EXECUTION_ENVIRONMENT_GEN2&amp;quot;]
    /// </summary>
    [TerraformProperty("execution_environment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExecutionEnvironment { get; set; }

    /// <summary>
    /// True if GPU zonal redundancy is disabled on this revision.
    /// </summary>
    [TerraformProperty("gpu_zonal_redundancy_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GpuZonalRedundancyDisabled { get; set; }

    /// <summary>
    /// Disables health checking containers during deployment.
    /// </summary>
    [TerraformProperty("health_check_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HealthCheckDisabled { get; set; }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc.
    /// For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 RevisionTemplate.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Sets the maximum number of requests that each serving instance can receive.
    /// If not specified or 0, defaults to 80 when requested CPU &amp;gt;= 1 and defaults to 1 when requested CPU &amp;lt; 1.
    /// </summary>
    [TerraformProperty("max_instance_request_concurrency")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxInstanceRequestConcurrency { get; set; }

    /// <summary>
    /// The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.
    /// </summary>
    [TerraformProperty("revision")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Revision { get; set; }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project&#39;s default service account.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity
    /// </summary>
    [TerraformProperty("session_affinity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SessionAffinity { get; set; }

    /// <summary>
    /// Max allowed time for an instance to respond to a request.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudRunV2ServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for traffic in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunV2ServiceTrafficBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.
    /// </summary>
    [TerraformProperty("percent")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Percent { get; set; }

    /// <summary>
    /// Revision to which to send this portion of traffic, if traffic allocation is by revision.
    /// </summary>
    [TerraformProperty("revision")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Revision { get; set; }

    /// <summary>
    /// Indicates a string to be part of the URI to exclusively reference this target.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The allocation type for this traffic target. Possible values: [&amp;quot;TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST&amp;quot;, &amp;quot;TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Manages a google_cloud_run_v2_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudRunV2Service : TerraformResource
{
    public GoogleCloudRunV2Service(string name) : base("google_cloud_run_v2_service", name)
    {
    }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected in new resources.
    /// All system annotations in v1 now have a corresponding field in v2 Service.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Arbitrary identifier for the API client.
    /// </summary>
    [TerraformProperty("client")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Client { get; set; }

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    [TerraformProperty("client_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientVersion { get; set; }

    /// <summary>
    /// One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests.
    /// For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
    /// </summary>
    [TerraformProperty("custom_audiences")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CustomAudiences { get; set; }

    /// <summary>
    /// Disables public resolution of the default URI of this service.
    /// </summary>
    [TerraformProperty("default_uri_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DefaultUriDisabled { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the service. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the service,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the service will fail.
    /// When the field is set to false, deleting the service is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// User-provided description of the Service. This field currently has a 512-character limit.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values: [&amp;quot;INGRESS_TRAFFIC_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER&amp;quot;]
    /// </summary>
    [TerraformProperty("ingress")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Ingress { get; set; }

    /// <summary>
    /// Disables IAM permission check for run.routes.invoke for callers of this service. For more information, visit https://cloud.google.com/run/docs/securing/managing-access#invoker_check.
    /// </summary>
    [TerraformProperty("invoker_iam_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InvokerIamDisabled { get; set; }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with  &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 Service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    [TerraformProperty("launch_stage")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LaunchStage { get; set; }

    /// <summary>
    /// The location of the cloud run service
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of the Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    [TerraformProperty("binary_authorization")]
    public TerraformList<TerraformBlock<GoogleCloudRunV2ServiceBinaryAuthorizationBlock>>? BinaryAuthorization { get; set; }

    /// <summary>
    /// Block for build_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    [TerraformProperty("build_config")]
    public TerraformList<TerraformBlock<GoogleCloudRunV2ServiceBuildConfigBlock>>? BuildConfig { get; set; }

    /// <summary>
    /// Block for multi_region_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiRegionSettings block(s) allowed")]
    [TerraformProperty("multi_region_settings")]
    public TerraformList<TerraformBlock<GoogleCloudRunV2ServiceMultiRegionSettingsBlock>>? MultiRegionSettings { get; set; }

    /// <summary>
    /// Block for scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaling block(s) allowed")]
    [TerraformProperty("scaling")]
    public TerraformList<TerraformBlock<GoogleCloudRunV2ServiceScalingBlock>>? Scaling { get; set; }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformProperty("template")]
    public TerraformList<TerraformBlock<GoogleCloudRunV2ServiceTemplateBlock>>? Template { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleCloudRunV2ServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("traffic")]
    public TerraformList<TerraformBlock<GoogleCloudRunV2ServiceTrafficBlock>>? Traffic { get; set; }

    /// <summary>
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    [TerraformProperty("conditions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Conditions { get; }

    /// <summary>
    /// The creation time.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    [TerraformProperty("creator")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Creator { get; }

    /// <summary>
    /// The deletion time.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    [TerraformProperty("generation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Generation { get; }

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    [TerraformProperty("last_modifier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifier { get; }

    /// <summary>
    /// Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    [TerraformProperty("latest_created_revision")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LatestCreatedRevision { get; }

    /// <summary>
    /// Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    [TerraformProperty("latest_ready_revision")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LatestReadyRevision { get; }

    /// <summary>
    /// The generation of this Service currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    [TerraformProperty("observed_generation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObservedGeneration { get; }

    /// <summary>
    /// Returns true if the Service is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.
    /// 
    /// If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in terminalCondition and conditions.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    [TerraformProperty("terminal_condition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TerminalCondition { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Detailed status information for corresponding traffic targets. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    [TerraformProperty("traffic_statuses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrafficStatuses { get; }

    /// <summary>
    /// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The last-modified time.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// The main URI in which this Service is serving traffic.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uri { get; }

    /// <summary>
    /// All URLs serving traffic for this Service.
    /// </summary>
    [TerraformProperty("urls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Urls { get; }

}
