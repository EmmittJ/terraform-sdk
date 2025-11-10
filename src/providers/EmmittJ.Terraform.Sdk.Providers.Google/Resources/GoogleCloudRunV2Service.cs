using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// If present, indicates to use Breakglass using this justification. If useDefault is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass
    /// </summary>
    public TerraformProperty<string>? BreakglassJustification
    {
        get => GetProperty<TerraformProperty<string>>("breakglass_justification");
        set => WithProperty("breakglass_justification", value);
    }

    /// <summary>
    /// The path to a binary authorization policy. Format: projects/{project}/platforms/cloudRun/{policy-name}
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => WithProperty("policy", value);
    }

    /// <summary>
    /// If True, indicates to use the default project&#39;s binary authorization policy. If False, binary authorization will be disabled.
    /// </summary>
    public TerraformProperty<bool>? UseDefault
    {
        get => GetProperty<TerraformProperty<bool>>("use_default");
        set => WithProperty("use_default", value);
    }

}

/// <summary>
/// Block type for build_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceBuildConfigBlock : TerraformBlock
{
    /// <summary>
    /// The base image used to build the function.
    /// </summary>
    public TerraformProperty<string>? BaseImage
    {
        get => GetProperty<TerraformProperty<string>>("base_image");
        set => WithProperty("base_image", value);
    }

    /// <summary>
    /// Sets whether the function will receive automatic base image updates.
    /// </summary>
    public TerraformProperty<bool>? EnableAutomaticUpdates
    {
        get => GetProperty<TerraformProperty<bool>>("enable_automatic_updates");
        set => WithProperty("enable_automatic_updates", value);
    }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed. Defaults to the resource name suffix, if not specified. For backward compatibility, if function with given name is not found, then the system will try to use function named &amp;quot;function&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? FunctionTarget
    {
        get => GetProperty<TerraformProperty<string>>("function_target");
        set => WithProperty("function_target", value);
    }

    /// <summary>
    /// Artifact Registry URI to store the built image.
    /// </summary>
    public TerraformProperty<string>? ImageUri
    {
        get => GetProperty<TerraformProperty<string>>("image_uri");
        set => WithProperty("image_uri", value);
    }

    /// <summary>
    /// The Cloud Build name of the latest successful deployment of the function.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Service account to be used for building the container. The format of this field is &#39;projects/{projectId}/serviceAccounts/{serviceAccountEmail}&#39;.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => WithProperty("service_account", value);
    }

    /// <summary>
    /// The Cloud Storage bucket URI where the function source code is located.
    /// </summary>
    public TerraformProperty<string>? SourceLocation
    {
        get => GetProperty<TerraformProperty<string>>("source_location");
        set => WithProperty("source_location", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the Cloud Run function. The format of this field is &#39;projects/{project}/locations/{region}/workerPools/{workerPool}&#39; where {project} and {region} are the project id and region respectively where the worker pool is defined and {workerPool} is the short name of the worker pool.
    /// </summary>
    public TerraformProperty<string>? WorkerPool
    {
        get => GetProperty<TerraformProperty<string>>("worker_pool");
        set => WithProperty("worker_pool", value);
    }

}

/// <summary>
/// Block type for multi_region_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceMultiRegionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// System-generated unique id for the multi-region Service.
    /// </summary>
    public TerraformProperty<string>? MultiRegionId
    {
        get => GetProperty<TerraformProperty<string>>("multi_region_id");
        set => WithProperty("multi_region_id", value);
    }

    /// <summary>
    /// The list of regions to deploy the multi-region Service.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        get => GetProperty<List<TerraformProperty<string>>>("regions");
        set => WithProperty("regions", value);
    }

}

/// <summary>
/// Block type for scaling in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceScalingBlock : TerraformBlock
{
    /// <summary>
    /// Total instance count for the service in manual scaling mode. This number of instances is divided among all revisions with specified traffic based on the percent of traffic they are receiving.
    /// </summary>
    public TerraformProperty<double>? ManualInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("manual_instance_count");
        set => WithProperty("manual_instance_count", value);
    }

    /// <summary>
    /// Combined maximum number of instances for all revisions receiving traffic.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("max_instance_count");
        set => WithProperty("max_instance_count", value);
    }

    /// <summary>
    /// Minimum number of instances for the service, to be divided among all revisions receiving traffic.
    /// </summary>
    public TerraformProperty<double>? MinInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("min_instance_count");
        set => WithProperty("min_instance_count", value);
    }

    /// <summary>
    /// The [scaling mode](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services#scalingmode) for the service. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ScalingMode
    {
        get => GetProperty<TerraformProperty<string>>("scaling_mode");
        set => WithProperty("scaling_mode", value);
    }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system annotations in v1 now have a corresponding field in v2 RevisionTemplate.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => WithProperty("annotations", value);
    }

    /// <summary>
    /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
    /// </summary>
    public TerraformProperty<string>? EncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key");
        set => WithProperty("encryption_key", value);
    }

    /// <summary>
    /// The sandbox environment to host this Revision. Possible values: [&amp;quot;EXECUTION_ENVIRONMENT_GEN1&amp;quot;, &amp;quot;EXECUTION_ENVIRONMENT_GEN2&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ExecutionEnvironment
    {
        get => GetProperty<TerraformProperty<string>>("execution_environment");
        set => WithProperty("execution_environment", value);
    }

    /// <summary>
    /// True if GPU zonal redundancy is disabled on this revision.
    /// </summary>
    public TerraformProperty<bool>? GpuZonalRedundancyDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("gpu_zonal_redundancy_disabled");
        set => WithProperty("gpu_zonal_redundancy_disabled", value);
    }

    /// <summary>
    /// Disables health checking containers during deployment.
    /// </summary>
    public TerraformProperty<bool>? HealthCheckDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("health_check_disabled");
        set => WithProperty("health_check_disabled", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc.
    /// For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 RevisionTemplate.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// Sets the maximum number of requests that each serving instance can receive.
    /// If not specified or 0, defaults to 80 when requested CPU &amp;gt;= 1 and defaults to 1 when requested CPU &amp;lt; 1.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceRequestConcurrency
    {
        get => GetProperty<TerraformProperty<double>>("max_instance_request_concurrency");
        set => WithProperty("max_instance_request_concurrency", value);
    }

    /// <summary>
    /// The unique name for the revision. If this field is omitted, it will be automatically generated based on the Service name.
    /// </summary>
    public TerraformProperty<string>? Revision
    {
        get => GetProperty<TerraformProperty<string>>("revision");
        set => WithProperty("revision", value);
    }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the service. The service account represents the identity of the running revision, and determines what permissions the revision has. If not provided, the revision will use the project&#39;s default service account.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => WithProperty("service_account", value);
    }

    /// <summary>
    /// Enables session affinity. For more information, go to https://cloud.google.com/run/docs/configuring/session-affinity
    /// </summary>
    public TerraformProperty<bool>? SessionAffinity
    {
        get => GetProperty<TerraformProperty<bool>>("session_affinity");
        set => WithProperty("session_affinity", value);
    }

    /// <summary>
    /// Max allowed time for an instance to respond to a request.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunV2ServiceTimeoutsBlock : TerraformBlock
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
/// Block type for traffic in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunV2ServiceTrafficBlock : TerraformBlock
{
    /// <summary>
    /// Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.
    /// </summary>
    public TerraformProperty<double>? Percent
    {
        get => GetProperty<TerraformProperty<double>>("percent");
        set => WithProperty("percent", value);
    }

    /// <summary>
    /// Revision to which to send this portion of traffic, if traffic allocation is by revision.
    /// </summary>
    public TerraformProperty<string>? Revision
    {
        get => GetProperty<TerraformProperty<string>>("revision");
        set => WithProperty("revision", value);
    }

    /// <summary>
    /// Indicates a string to be part of the URI to exclusively reference this target.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => WithProperty("tag", value);
    }

    /// <summary>
    /// The allocation type for this traffic target. Possible values: [&amp;quot;TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST&amp;quot;, &amp;quot;TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a google_cloud_run_v2_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudRunV2Service : TerraformResource
{
    public GoogleCloudRunV2Service(string name) : base("google_cloud_run_v2_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("conditions");
        this.WithOutput("create_time");
        this.WithOutput("creator");
        this.WithOutput("delete_time");
        this.WithOutput("effective_annotations");
        this.WithOutput("effective_labels");
        this.WithOutput("etag");
        this.WithOutput("expire_time");
        this.WithOutput("generation");
        this.WithOutput("last_modifier");
        this.WithOutput("latest_created_revision");
        this.WithOutput("latest_ready_revision");
        this.WithOutput("observed_generation");
        this.WithOutput("reconciling");
        this.WithOutput("terminal_condition");
        this.WithOutput("terraform_labels");
        this.WithOutput("traffic_statuses");
        this.WithOutput("uid");
        this.WithOutput("update_time");
        this.WithOutput("uri");
        this.WithOutput("urls");
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
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Arbitrary identifier for the API client.
    /// </summary>
    public TerraformProperty<string>? Client
    {
        get => GetProperty<TerraformProperty<string>>("client");
        set => this.WithProperty("client", value);
    }

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    public TerraformProperty<string>? ClientVersion
    {
        get => GetProperty<TerraformProperty<string>>("client_version");
        set => this.WithProperty("client_version", value);
    }

    /// <summary>
    /// One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests.
    /// For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
    /// </summary>
    public List<TerraformProperty<string>>? CustomAudiences
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_audiences");
        set => this.WithProperty("custom_audiences", value);
    }

    /// <summary>
    /// Disables public resolution of the default URI of this service.
    /// </summary>
    public TerraformProperty<bool>? DefaultUriDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("default_uri_disabled");
        set => this.WithProperty("default_uri_disabled", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the service. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the service,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the service will fail.
    /// When the field is set to false, deleting the service is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// User-provided description of the Service. This field currently has a 512-character limit.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values: [&amp;quot;INGRESS_TRAFFIC_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Ingress
    {
        get => GetProperty<TerraformProperty<string>>("ingress");
        set => this.WithProperty("ingress", value);
    }

    /// <summary>
    /// Disables IAM permission check for run.routes.invoke for callers of this service. For more information, visit https://cloud.google.com/run/docs/securing/managing-access#invoker_check.
    /// </summary>
    public TerraformProperty<bool>? InvokerIamDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("invoker_iam_disabled");
        set => this.WithProperty("invoker_iam_disabled", value);
    }

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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LaunchStage
    {
        get => GetProperty<TerraformProperty<string>>("launch_stage");
        set => this.WithProperty("launch_stage", value);
    }

    /// <summary>
    /// The location of the cloud run service
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public List<GoogleCloudRunV2ServiceBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetProperty<List<GoogleCloudRunV2ServiceBinaryAuthorizationBlock>>("binary_authorization");
        set => this.WithProperty("binary_authorization", value);
    }

    /// <summary>
    /// Block for build_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    public List<GoogleCloudRunV2ServiceBuildConfigBlock>? BuildConfig
    {
        get => GetProperty<List<GoogleCloudRunV2ServiceBuildConfigBlock>>("build_config");
        set => this.WithProperty("build_config", value);
    }

    /// <summary>
    /// Block for multi_region_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiRegionSettings block(s) allowed")]
    public List<GoogleCloudRunV2ServiceMultiRegionSettingsBlock>? MultiRegionSettings
    {
        get => GetProperty<List<GoogleCloudRunV2ServiceMultiRegionSettingsBlock>>("multi_region_settings");
        set => this.WithProperty("multi_region_settings", value);
    }

    /// <summary>
    /// Block for scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaling block(s) allowed")]
    public List<GoogleCloudRunV2ServiceScalingBlock>? Scaling
    {
        get => GetProperty<List<GoogleCloudRunV2ServiceScalingBlock>>("scaling");
        set => this.WithProperty("scaling", value);
    }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public List<GoogleCloudRunV2ServiceTemplateBlock>? Template
    {
        get => GetProperty<List<GoogleCloudRunV2ServiceTemplateBlock>>("template");
        set => this.WithProperty("template", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudRunV2ServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudRunV2ServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleCloudRunV2ServiceTrafficBlock>? Traffic
    {
        get => GetProperty<List<GoogleCloudRunV2ServiceTrafficBlock>>("traffic");
        set => this.WithProperty("traffic", value);
    }

    /// <summary>
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression Conditions => this["conditions"];

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    public TerraformExpression Creator => this["creator"];

    /// <summary>
    /// The deletion time.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformExpression Generation => this["generation"];

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    public TerraformExpression LastModifier => this["last_modifier"];

    /// <summary>
    /// Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression LatestCreatedRevision => this["latest_created_revision"];

    /// <summary>
    /// Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression LatestReadyRevision => this["latest_ready_revision"];

    /// <summary>
    /// The generation of this Service currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformExpression ObservedGeneration => this["observed_generation"];

    /// <summary>
    /// Returns true if the Service is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.
    /// 
    /// If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in terminalCondition and conditions.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression TerminalCondition => this["terminal_condition"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Detailed status information for corresponding traffic targets. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression TrafficStatuses => this["traffic_statuses"];

    /// <summary>
    /// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The main URI in which this Service is serving traffic.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

    /// <summary>
    /// All URLs serving traffic for this Service.
    /// </summary>
    public TerraformExpression Urls => this["urls"];

}
