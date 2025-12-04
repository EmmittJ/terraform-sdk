using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for build_config in GoogleCloudfunctions2Function.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "build_config";

    /// <summary>
    /// The Cloud Build name of the latest successful
    /// deployment of the function.
    /// </summary>
    public TerraformValue<string> Build
        => AsReference("build");

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key.
    /// </summary>
    public TerraformValue<string>? DockerRepository
    {
        get => GetArgument<TerraformValue<string>>("docker_repository");
        set => SetArgument("docker_repository", value);
    }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &amp;quot;function&amp;quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    public TerraformValue<string>? EntryPoint
    {
        get => GetArgument<TerraformValue<string>>("entry_point");
        set => SetArgument("entry_point", value);
    }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    public TerraformValue<string>? Runtime
    {
        get => GetArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for building the container.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformValue<string>? WorkerPool
    {
        get => GetArgument<TerraformValue<string>>("worker_pool");
        set => SetArgument("worker_pool", value);
    }

    /// <summary>
    /// AutomaticUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdatePolicy block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockAutomaticUpdatePolicyBlock>? AutomaticUpdatePolicy
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockAutomaticUpdatePolicyBlock>>("automatic_update_policy");
        set => SetArgument("automatic_update_policy", value);
    }

    /// <summary>
    /// OnDeployUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDeployUpdatePolicy block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockOnDeployUpdatePolicyBlock>? OnDeployUpdatePolicy
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockOnDeployUpdatePolicyBlock>>("on_deploy_update_policy");
        set => SetArgument("on_deploy_update_policy", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlock>? Source
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for automatic_update_policy in GoogleCloudfunctions2FunctionBuildConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlockAutomaticUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_update_policy";

}

/// <summary>
/// Block type for on_deploy_update_policy in GoogleCloudfunctions2FunctionBuildConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlockOnDeployUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_deploy_update_policy";

    /// <summary>
    /// The runtime version which was used during latest function deployment.
    /// </summary>
    public TerraformValue<string> RuntimeVersion
        => AsReference("runtime_version");

}

/// <summary>
/// Block type for source in GoogleCloudfunctions2FunctionBuildConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// RepoSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RepoSource block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlockRepoSourceBlock>? RepoSource
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlockRepoSourceBlock>>("repo_source");
        set => SetArgument("repo_source", value);
    }

    /// <summary>
    /// StorageSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageSource block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlockStorageSourceBlock>? StorageSource
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlockStorageSourceBlock>>("storage_source");
        set => SetArgument("storage_source", value);
    }

}

/// <summary>
/// Block type for repo_source in GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlockRepoSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repo_source";

    /// <summary>
    /// Regex matching branches to build.
    /// </summary>
    public TerraformValue<string>? BranchName
    {
        get => GetArgument<TerraformValue<string>>("branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// Regex matching tags to build.
    /// </summary>
    public TerraformValue<string>? CommitSha
    {
        get => GetArgument<TerraformValue<string>>("commit_sha");
        set => SetArgument("commit_sha", value);
    }

    /// <summary>
    /// Directory, relative to the source root, in which to run the build.
    /// </summary>
    public TerraformValue<string>? Dir
    {
        get => GetArgument<TerraformValue<string>>("dir");
        set => SetArgument("dir", value);
    }

    /// <summary>
    /// Only trigger a build if the revision regex does
    /// NOT match the revision regex.
    /// </summary>
    public TerraformValue<bool>? InvertRegex
    {
        get => GetArgument<TerraformValue<bool>>("invert_regex");
        set => SetArgument("invert_regex", value);
    }

    /// <summary>
    /// ID of the project that owns the Cloud Source Repository. If omitted, the
    /// project ID requesting the build is assumed.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Name of the Cloud Source Repository.
    /// </summary>
    public TerraformValue<string>? RepoName
    {
        get => GetArgument<TerraformValue<string>>("repo_name");
        set => SetArgument("repo_name", value);
    }

    /// <summary>
    /// Regex matching tags to build.
    /// </summary>
    public TerraformValue<string>? TagName
    {
        get => GetArgument<TerraformValue<string>>("tag_name");
        set => SetArgument("tag_name", value);
    }

}

/// <summary>
/// Block type for storage_source in GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlockSourceBlockStorageSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_source";

    /// <summary>
    /// Google Cloud Storage bucket containing the source
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Google Cloud Storage generation for the object. If the generation
    /// is omitted, the latest generation will be used.
    /// </summary>
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Google Cloud Storage object containing the source.
    /// </summary>
    public TerraformValue<string>? ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}


/// <summary>
/// Block type for event_trigger in GoogleCloudfunctions2Function.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionEventTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_trigger";

    /// <summary>
    /// Required. The type of event to observe.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    public TerraformValue<string>? PubsubTopic
    {
        get => GetArgument<TerraformValue<string>>("pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

    /// <summary>
    /// Describes the retry policy in case of function&#39;s execution failure.
    /// Retried execution is charged as any other execution. Possible values: [&amp;quot;RETRY_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RETRY_POLICY_DO_NOT_RETRY&amp;quot;, &amp;quot;RETRY_POLICY_RETRY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RetryPolicy
    {
        get => GetArgument<TerraformValue<string>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Optional. The email of the trigger&#39;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// Output only. The resource name of the Eventarc trigger.
    /// </summary>
    public TerraformValue<string> Trigger
        => AsReference("trigger");

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    public TerraformValue<string>? TriggerRegion
    {
        get => GetArgument<TerraformValue<string>>("trigger_region");
        set => SetArgument("trigger_region", value);
    }

    /// <summary>
    /// EventFilters block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleCloudfunctions2FunctionEventTriggerBlockEventFiltersBlock>? EventFilters
    {
        get => GetArgument<TerraformSet<GoogleCloudfunctions2FunctionEventTriggerBlockEventFiltersBlock>>("event_filters");
        set => SetArgument("event_filters", value);
    }

}

/// <summary>
/// Block type for event_filters in GoogleCloudfunctions2FunctionEventTriggerBlock.
/// Nesting mode: set
/// </summary>
public class GoogleCloudfunctions2FunctionEventTriggerBlockEventFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_filters";

    /// <summary>
    /// &#39;Required. The name of a CloudEvents attribute.
    /// Currently, only a subset of attributes are supported for filtering. Use the &#39;gcloud eventarc providers describe&#39; command to learn more about events and their attributes.
    /// Do not filter for the &#39;type&#39; attribute here, as this is already achieved by the resource&#39;s &#39;event_type&#39; attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attribute is required")]
    public required TerraformValue<string> Attribute
    {
        get => GetArgument<TerraformValue<string>>("attribute");
        set => SetArgument("attribute", value);
    }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of
    /// the filter. If not specified, only events that have an exact key-value
    /// pair specified in the filter are matched.
    /// The only allowed value is &#39;match-path-pattern&#39;.
    /// [See documentation on path patterns here](https://cloud.google.com/eventarc/docs/path-patterns)&#39;
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// Required. The value for the attribute.
    /// If the operator field is set as &#39;match-path-pattern&#39;, this value can be a path pattern instead of an exact value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for service_config in GoogleCloudfunctions2Function.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionServiceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_config";

    /// <summary>
    /// Whether 100% of traffic is routed to the latest revision. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? AllTrafficOnLatestRevision
    {
        get => GetArgument<TerraformValue<bool>>("all_traffic_on_latest_revision");
        set => SetArgument("all_traffic_on_latest_revision", value);
    }

    /// <summary>
    /// The number of CPUs used in a single container instance. Default value is calculated from available memory.
    /// </summary>
    public TerraformValue<string>? AvailableCpu
    {
        get => GetArgument<TerraformValue<string>>("available_cpu");
        set => SetArgument("available_cpu", value);
    }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    public TerraformValue<string>? AvailableMemory
    {
        get => GetArgument<TerraformValue<string>>("available_memory");
        set => SetArgument("available_memory", value);
    }

    /// <summary>
    /// The binary authorization policy to be checked when deploying the Cloud Run service.
    /// </summary>
    public TerraformValue<string>? BinaryAuthorizationPolicy
    {
        get => GetArgument<TerraformValue<string>>("binary_authorization_policy");
        set => SetArgument("binary_authorization_policy", value);
    }

    /// <summary>
    /// Environment variables that shall be available during function execution.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// URIs of the Service deployed
    /// </summary>
    public TerraformValue<string> GcfUri
        => AsReference("gcf_uri");

    /// <summary>
    /// Available ingress settings. Defaults to &amp;quot;ALLOW_ALL&amp;quot; if unspecified. Default value: &amp;quot;ALLOW_ALL&amp;quot; Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;ALLOW_INTERNAL_ONLY&amp;quot;, &amp;quot;ALLOW_INTERNAL_AND_GCLB&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IngressSettings
    {
        get => GetArgument<TerraformValue<string>>("ingress_settings");
        set => SetArgument("ingress_settings", value);
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    public TerraformValue<double>? MaxInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.
    /// </summary>
    public TerraformValue<double>? MaxInstanceRequestConcurrency
    {
        get => GetArgument<TerraformValue<double>>("max_instance_request_concurrency");
        set => SetArgument("max_instance_request_concurrency", value);
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    public TerraformValue<double>? MinInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

    /// <summary>
    /// Name of the service associated with a Function.
    /// </summary>
    public TerraformValue<string> Service
        => AsReference("service");

    /// <summary>
    /// The email of the service account for this function.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// URI of the Service deployed.
    /// </summary>
    public TerraformValue<string> Uri
        => AsReference("uri");

    /// <summary>
    /// The Serverless VPC Access connector that this cloud function can connect to.
    /// </summary>
    public TerraformValue<string>? VpcConnector
    {
        get => GetArgument<TerraformValue<string>>("vpc_connector");
        set => SetArgument("vpc_connector", value);
    }

    /// <summary>
    /// Available egress settings. Possible values: [&amp;quot;VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;, &amp;quot;ALL_TRAFFIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? VpcConnectorEgressSettings
    {
        get => GetArgument<TerraformValue<string>>("vpc_connector_egress_settings");
        set => SetArgument("vpc_connector_egress_settings", value);
    }

    /// <summary>
    /// SecretEnvironmentVariables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlockSecretEnvironmentVariablesBlock>? SecretEnvironmentVariables
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlockSecretEnvironmentVariablesBlock>>("secret_environment_variables");
        set => SetArgument("secret_environment_variables", value);
    }

    /// <summary>
    /// SecretVolumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlock>? SecretVolumes
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlock>>("secret_volumes");
        set => SetArgument("secret_volumes", value);
    }

}

/// <summary>
/// Block type for secret_environment_variables in GoogleCloudfunctions2FunctionServiceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionServiceConfigBlockSecretEnvironmentVariablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_environment_variables";

    /// <summary>
    /// Name of the environment variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&#39;s project assuming that the secret exists in the same project as of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Name of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Version of the secret (version number or the string &#39;latest&#39;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new instances start.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for secret_volumes in GoogleCloudfunctions2FunctionServiceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_volumes";

    /// <summary>
    /// The path within the container to mount the secret volume. For example, setting the mountPath as /etc/secrets would mount the secret value files under the /etc/secrets directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount path: /etc/secrets
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&#39;s project assuming that the secret exists in the same project as of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Name of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Versions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlockVersionsBlock>? Versions
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlockVersionsBlock>>("versions");
        set => SetArgument("versions", value);
    }

}

/// <summary>
/// Block type for versions in GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionServiceConfigBlockSecretVolumesBlockVersionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "versions";

    /// <summary>
    /// Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mountPath as &#39;/etc/secrets&#39; and path as secret_foo would mount the secret value file at /etc/secrets/secret_foo.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Version of the secret (version number or the string &#39;latest&#39;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudfunctions2Function.
/// Nesting mode: single
/// </summary>
public class GoogleCloudfunctions2FunctionTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloudfunctions2_function Terraform resource.
/// Manages a google_cloudfunctions2_function resource.
/// </summary>
public partial class GoogleCloudfunctions2Function(string name) : TerraformResource("google_cloudfunctions2_function", name)
{
    /// <summary>
    /// User-provided description of a function.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs associated with this Cloud Function.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of this cloud function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must
    /// be unique globally and match pattern &#39;projects/*/locations/*/functions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The environment the function is hosted on.
    /// </summary>
    public TerraformValue<string> Environment
        => AsReference("environment");

    /// <summary>
    /// Describes the current state of the function.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The last update timestamp of a Cloud Function.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Output only. The deployed url for the function.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// BuildConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlock>? BuildConfig
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionBuildConfigBlock>>("build_config");
        set => SetArgument("build_config", value);
    }

    /// <summary>
    /// EventTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionEventTriggerBlock>? EventTrigger
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionEventTriggerBlock>>("event_trigger");
        set => SetArgument("event_trigger", value);
    }

    /// <summary>
    /// ServiceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConfig block(s) allowed")]
    public TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlock>? ServiceConfig
    {
        get => GetArgument<TerraformList<GoogleCloudfunctions2FunctionServiceConfigBlock>>("service_config");
        set => SetArgument("service_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudfunctions2FunctionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudfunctions2FunctionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
