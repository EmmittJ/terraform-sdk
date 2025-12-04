using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_update_policy in GoogleCloudfunctionsFunction.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_update_policy";

}


/// <summary>
/// Block type for event_trigger in GoogleCloudfunctionsFunction.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionEventTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_trigger";

    /// <summary>
    /// The type of event to observe. For example: &amp;quot;google.storage.object.finalize&amp;quot;. See the documentation on calling Cloud Functions for a full reference of accepted triggers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The name or partial URI of the resource from which to observe events. For example, &amp;quot;myBucket&amp;quot; or &amp;quot;projects/my-project/topics/my-topic&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// FailurePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailurePolicy block(s) allowed")]
    public TerraformList<GoogleCloudfunctionsFunctionEventTriggerBlockFailurePolicyBlock>? FailurePolicy
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionEventTriggerBlockFailurePolicyBlock>>("failure_policy");
        set => SetArgument("failure_policy", value);
    }

}

/// <summary>
/// Block type for failure_policy in GoogleCloudfunctionsFunctionEventTriggerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionEventTriggerBlockFailurePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failure_policy";

    /// <summary>
    /// Whether the function should be retried on failure. Defaults to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retry is required")]
    public required TerraformValue<bool> Retry
    {
        get => GetArgument<TerraformValue<bool>>("retry");
        set => SetArgument("retry", value);
    }

}


/// <summary>
/// Block type for on_deploy_update_policy in GoogleCloudfunctionsFunction.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock : TerraformBlock
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
/// Block type for secret_environment_variables in GoogleCloudfunctionsFunction.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock : TerraformBlock
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
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Version of the secret (version number or the string &amp;quot;latest&amp;quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for secret_volumes in GoogleCloudfunctionsFunction.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_volumes";

    /// <summary>
    /// The path within the container to mount the secret volume. For example, setting the mount_path as &amp;quot;/etc/secrets&amp;quot; would mount the secret value files under the &amp;quot;/etc/secrets&amp;quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &amp;quot;/etc/secrets&amp;quot; Restricted mount paths: &amp;quot;/cloudsql&amp;quot;, &amp;quot;/dev/log&amp;quot;, &amp;quot;/pod&amp;quot;, &amp;quot;/proc&amp;quot;, &amp;quot;/var/log&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
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
    public TerraformList<GoogleCloudfunctionsFunctionSecretVolumesBlockVersionsBlock>? Versions
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionSecretVolumesBlockVersionsBlock>>("versions");
        set => SetArgument("versions", value);
    }

}

/// <summary>
/// Block type for versions in GoogleCloudfunctionsFunctionSecretVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretVolumesBlockVersionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "versions";

    /// <summary>
    /// Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mount_path as &amp;quot;/etc/secrets&amp;quot; and path as &amp;quot;/secret_foo&amp;quot; would mount the secret value file at &amp;quot;/etc/secrets/secret_foo&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Version of the secret (version number or the string &amp;quot;latest&amp;quot;). It is preferable to use &amp;quot;latest&amp;quot; version with secret volumes as secret value changes are reflected immediately.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for source_repository in GoogleCloudfunctionsFunction.
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSourceRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_repository";

    /// <summary>
    /// The URL pointing to the hosted repository where the function was defined at the time of deployment.
    /// </summary>
    public TerraformValue<string> DeployedUrl
        => AsReference("deployed_url");

    /// <summary>
    /// The URL pointing to the hosted repository where the function is defined.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudfunctionsFunction.
/// Nesting mode: single
/// </summary>
public class GoogleCloudfunctionsFunctionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a google_cloudfunctions_function Terraform resource.
/// Manages a google_cloudfunctions_function resource.
/// </summary>
public partial class GoogleCloudfunctionsFunction(string name) : TerraformResource("google_cloudfunctions_function", name)
{
    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    public TerraformValue<double>? AvailableMemoryMb
    {
        get => GetArgument<TerraformValue<double>>("available_memory_mb");
        set => SetArgument("available_memory_mb", value);
    }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    public TerraformMap<string>? BuildEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("build_environment_variables");
        set => SetArgument("build_environment_variables", value);
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    public TerraformValue<string>? BuildServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("build_service_account");
        set => SetArgument("build_service_account", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformValue<string>? BuildWorkerPool
    {
        get => GetArgument<TerraformValue<string>>("build_worker_pool");
        set => SetArgument("build_worker_pool", value);
    }

    /// <summary>
    /// Description of the function.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    public TerraformValue<string>? DockerRegistry
    {
        get => GetArgument<TerraformValue<string>>("docker_registry");
        set => SetArgument("docker_registry", value);
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    public TerraformValue<string>? DockerRepository
    {
        get => GetArgument<TerraformValue<string>>("docker_repository");
        set => SetArgument("docker_repository", value);
    }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    public TerraformValue<string>? EntryPoint
    {
        get => GetArgument<TerraformValue<string>>("entry_point");
        set => SetArgument("entry_point", value);
    }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    public TerraformValue<string>? HttpsTriggerSecurityLevel
    {
        get => GetArgument<TerraformValue<string>>("https_trigger_security_level");
        set => SetArgument("https_trigger_security_level", value);
    }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    public TerraformValue<string>? HttpsTriggerUrl
    {
        get => GetArgument<TerraformValue<string>>("https_trigger_url");
        set => SetArgument("https_trigger_url", value);
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
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    public TerraformValue<string>? IngressSettings
    {
        get => GetArgument<TerraformValue<string>>("ingress_settings");
        set => SetArgument("ingress_settings", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformValue<double>? MaxInstances
    {
        get => GetArgument<TerraformValue<double>>("max_instances");
        set => SetArgument("max_instances", value);
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformValue<double>? MinInstances
    {
        get => GetArgument<TerraformValue<double>>("min_instances");
        set => SetArgument("min_instances", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformValue<string> Runtime
    {
        get => GetArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    public TerraformValue<string>? SourceArchiveBucket
    {
        get => GetArgument<TerraformValue<string>>("source_archive_bucket");
        set => SetArgument("source_archive_bucket", value);
    }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    public TerraformValue<string>? SourceArchiveObject
    {
        get => GetArgument<TerraformValue<string>>("source_archive_object");
        set => SetArgument("source_archive_object", value);
    }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => GetArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    public TerraformValue<bool>? TriggerHttp
    {
        get => GetArgument<TerraformValue<bool>>("trigger_http");
        set => SetArgument("trigger_http", value);
    }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    public TerraformValue<string>? VpcConnector
    {
        get => GetArgument<TerraformValue<string>>("vpc_connector");
        set => SetArgument("vpc_connector", value);
    }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    public TerraformValue<string>? VpcConnectorEgressSettings
    {
        get => GetArgument<TerraformValue<string>>("vpc_connector_egress_settings");
        set => SetArgument("vpc_connector_egress_settings", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Describes the current stage of a deployment.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    public TerraformValue<string> VersionId
        => AsReference("version_id");

    /// <summary>
    /// AutomaticUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdatePolicy block(s) allowed")]
    public TerraformList<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>? AutomaticUpdatePolicy
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>>("automatic_update_policy");
        set => SetArgument("automatic_update_policy", value);
    }

    /// <summary>
    /// EventTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    public TerraformList<GoogleCloudfunctionsFunctionEventTriggerBlock>? EventTrigger
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionEventTriggerBlock>>("event_trigger");
        set => SetArgument("event_trigger", value);
    }

    /// <summary>
    /// OnDeployUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDeployUpdatePolicy block(s) allowed")]
    public TerraformList<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>? OnDeployUpdatePolicy
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>>("on_deploy_update_policy");
        set => SetArgument("on_deploy_update_policy", value);
    }

    /// <summary>
    /// SecretEnvironmentVariables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>? SecretEnvironmentVariables
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>>("secret_environment_variables");
        set => SetArgument("secret_environment_variables", value);
    }

    /// <summary>
    /// SecretVolumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudfunctionsFunctionSecretVolumesBlock>? SecretVolumes
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionSecretVolumesBlock>>("secret_volumes");
        set => SetArgument("secret_volumes", value);
    }

    /// <summary>
    /// SourceRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceRepository block(s) allowed")]
    public TerraformList<GoogleCloudfunctionsFunctionSourceRepositoryBlock>? SourceRepository
    {
        get => GetArgument<TerraformList<GoogleCloudfunctionsFunctionSourceRepositoryBlock>>("source_repository");
        set => SetArgument("source_repository", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudfunctionsFunctionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudfunctionsFunctionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
