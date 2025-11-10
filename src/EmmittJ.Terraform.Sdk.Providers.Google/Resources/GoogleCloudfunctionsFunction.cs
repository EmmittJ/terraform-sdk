using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for event_trigger in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionEventTriggerBlock : TerraformBlock
{
    /// <summary>
    /// The type of event to observe. For example: &amp;quot;google.storage.object.finalize&amp;quot;. See the documentation on calling Cloud Functions for a full reference of accepted triggers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformProperty<string> EventType
    {
        get => GetProperty<TerraformProperty<string>>("event_type");
        set => WithProperty("event_type", value);
    }

    /// <summary>
    /// The name or partial URI of the resource from which to observe events. For example, &amp;quot;myBucket&amp;quot; or &amp;quot;projects/my-project/topics/my-topic&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformProperty<string> Resource
    {
        get => GetProperty<TerraformProperty<string>>("resource");
        set => WithProperty("resource", value);
    }

}

/// <summary>
/// Block type for on_deploy_update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The runtime version which was used during latest function deployment.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => WithProperty("runtime_version", value);
    }

}

/// <summary>
/// Block type for secret_environment_variables in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock : TerraformBlock
{
    /// <summary>
    /// Name of the environment variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        get => GetProperty<TerraformProperty<string>>("secret");
        set => WithProperty("secret", value);
    }

    /// <summary>
    /// Version of the secret (version number or the string &amp;quot;latest&amp;quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for secret_volumes in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretVolumesBlock : TerraformBlock
{
    /// <summary>
    /// The path within the container to mount the secret volume. For example, setting the mount_path as &amp;quot;/etc/secrets&amp;quot; would mount the secret value files under the &amp;quot;/etc/secrets&amp;quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &amp;quot;/etc/secrets&amp;quot; Restricted mount paths: &amp;quot;/cloudsql&amp;quot;, &amp;quot;/dev/log&amp;quot;, &amp;quot;/pod&amp;quot;, &amp;quot;/proc&amp;quot;, &amp;quot;/var/log&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformProperty<string> MountPath
    {
        get => GetProperty<TerraformProperty<string>>("mount_path");
        set => WithProperty("mount_path", value);
    }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        get => GetProperty<TerraformProperty<string>>("secret");
        set => WithProperty("secret", value);
    }

}

/// <summary>
/// Block type for source_repository in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSourceRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// The URL pointing to the hosted repository where the function was defined at the time of deployment.
    /// </summary>
    public TerraformProperty<string>? DeployedUrl
    {
        get => GetProperty<TerraformProperty<string>>("deployed_url");
        set => WithProperty("deployed_url", value);
    }

    /// <summary>
    /// The URL pointing to the hosted repository where the function is defined.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudfunctionsFunctionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a google_cloudfunctions_function resource.
/// </summary>
public class GoogleCloudfunctionsFunction : TerraformResource
{
    public GoogleCloudfunctionsFunction(string name) : base("google_cloudfunctions_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("status");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("version_id");
    }

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    public TerraformProperty<double>? AvailableMemoryMb
    {
        get => GetProperty<TerraformProperty<double>>("available_memory_mb");
        set => this.WithProperty("available_memory_mb", value);
    }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? BuildEnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("build_environment_variables");
        set => this.WithProperty("build_environment_variables", value);
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    public TerraformProperty<string>? BuildServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("build_service_account");
        set => this.WithProperty("build_service_account", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformProperty<string>? BuildWorkerPool
    {
        get => GetProperty<TerraformProperty<string>>("build_worker_pool");
        set => this.WithProperty("build_worker_pool", value);
    }

    /// <summary>
    /// Description of the function.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    public TerraformProperty<string>? DockerRegistry
    {
        get => GetProperty<TerraformProperty<string>>("docker_registry");
        set => this.WithProperty("docker_registry", value);
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    public TerraformProperty<string>? DockerRepository
    {
        get => GetProperty<TerraformProperty<string>>("docker_repository");
        set => this.WithProperty("docker_repository", value);
    }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    public TerraformProperty<string>? EntryPoint
    {
        get => GetProperty<TerraformProperty<string>>("entry_point");
        set => this.WithProperty("entry_point", value);
    }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    public TerraformProperty<string>? HttpsTriggerSecurityLevel
    {
        get => GetProperty<TerraformProperty<string>>("https_trigger_security_level");
        set => this.WithProperty("https_trigger_security_level", value);
    }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    public TerraformProperty<string>? HttpsTriggerUrl
    {
        get => GetProperty<TerraformProperty<string>>("https_trigger_url");
        set => this.WithProperty("https_trigger_url", value);
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
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    public TerraformProperty<string>? IngressSettings
    {
        get => GetProperty<TerraformProperty<string>>("ingress_settings");
        set => this.WithProperty("ingress_settings", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformProperty<double>? MaxInstances
    {
        get => GetProperty<TerraformProperty<double>>("max_instances");
        set => this.WithProperty("max_instances", value);
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformProperty<double>? MinInstances
    {
        get => GetProperty<TerraformProperty<double>>("min_instances");
        set => this.WithProperty("min_instances", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformProperty<string> Runtime
    {
        get => GetProperty<TerraformProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("service_account_email");
        set => this.WithProperty("service_account_email", value);
    }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    public TerraformProperty<string>? SourceArchiveBucket
    {
        get => GetProperty<TerraformProperty<string>>("source_archive_bucket");
        set => this.WithProperty("source_archive_bucket", value);
    }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    public TerraformProperty<string>? SourceArchiveObject
    {
        get => GetProperty<TerraformProperty<string>>("source_archive_object");
        set => this.WithProperty("source_archive_object", value);
    }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    public TerraformProperty<bool>? TriggerHttp
    {
        get => GetProperty<TerraformProperty<bool>>("trigger_http");
        set => this.WithProperty("trigger_http", value);
    }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    public TerraformProperty<string>? VpcConnector
    {
        get => GetProperty<TerraformProperty<string>>("vpc_connector");
        set => this.WithProperty("vpc_connector", value);
    }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    public TerraformProperty<string>? VpcConnectorEgressSettings
    {
        get => GetProperty<TerraformProperty<string>>("vpc_connector_egress_settings");
        set => this.WithProperty("vpc_connector_egress_settings", value);
    }

    /// <summary>
    /// Block for automatic_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdatePolicy block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>? AutomaticUpdatePolicy
    {
        get => GetProperty<List<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>>("automatic_update_policy");
        set => this.WithProperty("automatic_update_policy", value);
    }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionEventTriggerBlock>? EventTrigger
    {
        get => GetProperty<List<GoogleCloudfunctionsFunctionEventTriggerBlock>>("event_trigger");
        set => this.WithProperty("event_trigger", value);
    }

    /// <summary>
    /// Block for on_deploy_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDeployUpdatePolicy block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>? OnDeployUpdatePolicy
    {
        get => GetProperty<List<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>>("on_deploy_update_policy");
        set => this.WithProperty("on_deploy_update_policy", value);
    }

    /// <summary>
    /// Block for secret_environment_variables.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>? SecretEnvironmentVariables
    {
        get => GetProperty<List<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>>("secret_environment_variables");
        set => this.WithProperty("secret_environment_variables", value);
    }

    /// <summary>
    /// Block for secret_volumes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleCloudfunctionsFunctionSecretVolumesBlock>? SecretVolumes
    {
        get => GetProperty<List<GoogleCloudfunctionsFunctionSecretVolumesBlock>>("secret_volumes");
        set => this.WithProperty("secret_volumes", value);
    }

    /// <summary>
    /// Block for source_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceRepository block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionSourceRepositoryBlock>? SourceRepository
    {
        get => GetProperty<List<GoogleCloudfunctionsFunctionSourceRepositoryBlock>>("source_repository");
        set => this.WithProperty("source_repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudfunctionsFunctionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudfunctionsFunctionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Describes the current stage of a deployment.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
