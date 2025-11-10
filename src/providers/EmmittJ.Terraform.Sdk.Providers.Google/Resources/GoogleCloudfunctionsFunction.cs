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
        set => SetProperty("event_type", value);
    }

    /// <summary>
    /// The name or partial URI of the resource from which to observe events. For example, &amp;quot;myBucket&amp;quot; or &amp;quot;projects/my-project/topics/my-topic&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformProperty<string> Resource
    {
        set => SetProperty("resource", value);
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
        set => SetProperty("runtime_version", value);
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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// Version of the secret (version number or the string &amp;quot;latest&amp;quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("mount_path", value);
    }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        set => SetProperty("secret", value);
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
        set => SetProperty("deployed_url", value);
    }

    /// <summary>
    /// The URL pointing to the hosted repository where the function is defined.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_cloudfunctions_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudfunctionsFunction : TerraformResource
{
    public GoogleCloudfunctionsFunction(string name) : base("google_cloudfunctions_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("status");
        SetOutput("terraform_labels");
        SetOutput("version_id");
        SetOutput("available_memory_mb");
        SetOutput("build_environment_variables");
        SetOutput("build_service_account");
        SetOutput("build_worker_pool");
        SetOutput("description");
        SetOutput("docker_registry");
        SetOutput("docker_repository");
        SetOutput("entry_point");
        SetOutput("environment_variables");
        SetOutput("https_trigger_security_level");
        SetOutput("https_trigger_url");
        SetOutput("id");
        SetOutput("ingress_settings");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("max_instances");
        SetOutput("min_instances");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("runtime");
        SetOutput("service_account_email");
        SetOutput("source_archive_bucket");
        SetOutput("source_archive_object");
        SetOutput("timeout");
        SetOutput("trigger_http");
        SetOutput("vpc_connector");
        SetOutput("vpc_connector_egress_settings");
    }

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    public TerraformProperty<double> AvailableMemoryMb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("available_memory_mb");
        set => SetProperty("available_memory_mb", value);
    }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> BuildEnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("build_environment_variables");
        set => SetProperty("build_environment_variables", value);
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    public TerraformProperty<string> BuildServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_service_account");
        set => SetProperty("build_service_account", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformProperty<string> BuildWorkerPool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("build_worker_pool");
        set => SetProperty("build_worker_pool", value);
    }

    /// <summary>
    /// Description of the function.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    public TerraformProperty<string> DockerRegistry
    {
        get => GetRequiredOutput<TerraformProperty<string>>("docker_registry");
        set => SetProperty("docker_registry", value);
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    public TerraformProperty<string> DockerRepository
    {
        get => GetRequiredOutput<TerraformProperty<string>>("docker_repository");
        set => SetProperty("docker_repository", value);
    }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    public TerraformProperty<string> EntryPoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_point");
        set => SetProperty("entry_point", value);
    }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> EnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    public TerraformProperty<string> HttpsTriggerSecurityLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("https_trigger_security_level");
        set => SetProperty("https_trigger_security_level", value);
    }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    public TerraformProperty<string> HttpsTriggerUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("https_trigger_url");
        set => SetProperty("https_trigger_url", value);
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
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    public TerraformProperty<string> IngressSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ingress_settings");
        set => SetProperty("ingress_settings", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformProperty<double> MaxInstances
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_instances");
        set => SetProperty("max_instances", value);
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformProperty<double> MinInstances
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_instances");
        set => SetProperty("min_instances", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformProperty<string> Runtime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime");
        set => SetProperty("runtime", value);
    }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    public TerraformProperty<string> ServiceAccountEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account_email");
        set => SetProperty("service_account_email", value);
    }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    public TerraformProperty<string> SourceArchiveBucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_archive_bucket");
        set => SetProperty("source_archive_bucket", value);
    }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    public TerraformProperty<string> SourceArchiveObject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_archive_object");
        set => SetProperty("source_archive_object", value);
    }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    public TerraformProperty<double> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    public TerraformProperty<bool> TriggerHttp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("trigger_http");
        set => SetProperty("trigger_http", value);
    }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    public TerraformProperty<string> VpcConnector
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_connector");
        set => SetProperty("vpc_connector", value);
    }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    public TerraformProperty<string> VpcConnectorEgressSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_connector_egress_settings");
        set => SetProperty("vpc_connector_egress_settings", value);
    }

    /// <summary>
    /// Block for automatic_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdatePolicy block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>? AutomaticUpdatePolicy
    {
        set => SetProperty("automatic_update_policy", value);
    }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionEventTriggerBlock>? EventTrigger
    {
        set => SetProperty("event_trigger", value);
    }

    /// <summary>
    /// Block for on_deploy_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDeployUpdatePolicy block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>? OnDeployUpdatePolicy
    {
        set => SetProperty("on_deploy_update_policy", value);
    }

    /// <summary>
    /// Block for secret_environment_variables.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>? SecretEnvironmentVariables
    {
        set => SetProperty("secret_environment_variables", value);
    }

    /// <summary>
    /// Block for secret_volumes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleCloudfunctionsFunctionSecretVolumesBlock>? SecretVolumes
    {
        set => SetProperty("secret_volumes", value);
    }

    /// <summary>
    /// Block for source_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceRepository block(s) allowed")]
    public List<GoogleCloudfunctionsFunctionSourceRepositoryBlock>? SourceRepository
    {
        set => SetProperty("source_repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudfunctionsFunctionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
