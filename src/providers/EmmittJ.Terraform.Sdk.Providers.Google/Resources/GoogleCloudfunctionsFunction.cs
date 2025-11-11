using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_update_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for event_trigger in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctionsFunctionEventTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of event to observe. For example: &amp;quot;google.storage.object.finalize&amp;quot;. See the documentation on calling Cloud Functions for a full reference of accepted triggers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    [TerraformProperty("event_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventType { get; set; }

    /// <summary>
    /// The name or partial URI of the resource from which to observe events. For example, &amp;quot;myBucket&amp;quot; or &amp;quot;projects/my-project/topics/my-topic&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformProperty("resource")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Resource { get; set; }

}

/// <summary>
/// Block type for on_deploy_update_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock : TerraformBlockBase
{

}

/// <summary>
/// Block type for secret_environment_variables in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the environment variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProjectId { get; set; }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Secret { get; set; }

    /// <summary>
    /// Version of the secret (version number or the string &amp;quot;latest&amp;quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for secret_volumes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctionsFunctionSecretVolumesBlock : TerraformBlockBase
{
    /// <summary>
    /// The path within the container to mount the secret volume. For example, setting the mount_path as &amp;quot;/etc/secrets&amp;quot; would mount the secret value files under the &amp;quot;/etc/secrets&amp;quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &amp;quot;/etc/secrets&amp;quot; Restricted mount paths: &amp;quot;/cloudsql&amp;quot;, &amp;quot;/dev/log&amp;quot;, &amp;quot;/pod&amp;quot;, &amp;quot;/proc&amp;quot;, &amp;quot;/var/log&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    [TerraformProperty("mount_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MountPath { get; set; }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProjectId { get; set; }

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformProperty("secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Secret { get; set; }

}

/// <summary>
/// Block type for source_repository in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctionsFunctionSourceRepositoryBlock : TerraformBlockBase
{

    /// <summary>
    /// The URL pointing to the hosted repository where the function is defined.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudfunctionsFunctionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloudfunctions_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudfunctionsFunction : TerraformResource
{
    public GoogleCloudfunctionsFunction(string name) : base("google_cloudfunctions_function", name)
    {
    }

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    [TerraformProperty("available_memory_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AvailableMemoryMb { get; set; }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    [TerraformProperty("build_environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? BuildEnvironmentVariables { get; set; }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    [TerraformProperty("build_service_account")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BuildServiceAccount { get; set; }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    [TerraformProperty("build_worker_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BuildWorkerPool { get; set; }

    /// <summary>
    /// Description of the function.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    [TerraformProperty("docker_registry")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DockerRegistry { get; set; }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    [TerraformProperty("docker_repository")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DockerRepository { get; set; }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    [TerraformProperty("entry_point")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EntryPoint { get; set; }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    [TerraformProperty("https_trigger_security_level")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpsTriggerSecurityLevel { get; set; }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    [TerraformProperty("https_trigger_url")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpsTriggerUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    [TerraformProperty("ingress_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IngressSettings { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformProperty("max_instances")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxInstances { get; set; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformProperty("min_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinInstances { get; set; }

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    [TerraformProperty("runtime")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Runtime { get; set; }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccountEmail { get; set; }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    [TerraformProperty("source_archive_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceArchiveBucket { get; set; }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    [TerraformProperty("source_archive_object")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceArchiveObject { get; set; }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    [TerraformProperty("trigger_http")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TriggerHttp { get; set; }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    [TerraformProperty("vpc_connector")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcConnector { get; set; }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    [TerraformProperty("vpc_connector_egress_settings")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpcConnectorEgressSettings { get; set; }

    /// <summary>
    /// Block for automatic_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdatePolicy block(s) allowed")]
    [TerraformProperty("automatic_update_policy")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>>? AutomaticUpdatePolicy { get; set; }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    [TerraformProperty("event_trigger")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionEventTriggerBlock>>? EventTrigger { get; set; }

    /// <summary>
    /// Block for on_deploy_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDeployUpdatePolicy block(s) allowed")]
    [TerraformProperty("on_deploy_update_policy")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>>? OnDeployUpdatePolicy { get; set; }

    /// <summary>
    /// Block for secret_environment_variables.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("secret_environment_variables")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>>? SecretEnvironmentVariables { get; set; }

    /// <summary>
    /// Block for secret_volumes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("secret_volumes")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionSecretVolumesBlock>>? SecretVolumes { get; set; }

    /// <summary>
    /// Block for source_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceRepository block(s) allowed")]
    [TerraformProperty("source_repository")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionSourceRepositoryBlock>>? SourceRepository { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleCloudfunctionsFunctionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Describes the current stage of a deployment.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionId { get; }

}
