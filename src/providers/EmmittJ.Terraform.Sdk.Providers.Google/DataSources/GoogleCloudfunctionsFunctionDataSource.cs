using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloudfunctions_function.
/// </summary>
public partial class GoogleCloudfunctionsFunctionDataSource : TerraformDataSource
{
    public GoogleCloudfunctionsFunctionDataSource(string name) : base("google_cloudfunctions_function", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Security patches are applied automatically to the runtime without requiring the function to be redeployed.
    /// </summary>
    [TerraformProperty("automatic_update_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutomaticUpdatePolicy { get; }

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    [TerraformProperty("available_memory_mb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableMemoryMb { get; }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    [TerraformProperty("build_environment_variables")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> BuildEnvironmentVariables { get; }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    [TerraformProperty("build_service_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BuildServiceAccount { get; }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    [TerraformProperty("build_worker_pool")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BuildWorkerPool { get; }

    /// <summary>
    /// Description of the function.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    [TerraformProperty("docker_registry")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DockerRegistry { get; }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    [TerraformProperty("docker_repository")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DockerRepository { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    [TerraformProperty("entry_point")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EntryPoint { get; }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EnvironmentVariables { get; }

    /// <summary>
    /// A source that fires events in response to a condition in another service. Cannot be used with trigger_http.
    /// </summary>
    [TerraformProperty("event_trigger")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EventTrigger { get; }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    [TerraformProperty("https_trigger_security_level")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HttpsTriggerSecurityLevel { get; }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    [TerraformProperty("https_trigger_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HttpsTriggerUrl { get; }

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    [TerraformProperty("ingress_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IngressSettings { get; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyName { get; }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformProperty("max_instances")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxInstances { get; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformProperty("min_instances")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinInstances { get; }

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// </summary>
    [TerraformProperty("on_deploy_update_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OnDeployUpdatePolicy { get; }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [TerraformProperty("runtime")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Runtime { get; }

    /// <summary>
    /// Secret environment variables configuration
    /// </summary>
    [TerraformProperty("secret_environment_variables")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SecretEnvironmentVariables { get; }

    /// <summary>
    /// Secret volumes configuration.
    /// </summary>
    [TerraformProperty("secret_volumes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SecretVolumes { get; }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceAccountEmail { get; }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    [TerraformProperty("source_archive_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceArchiveBucket { get; }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    [TerraformProperty("source_archive_object")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceArchiveObject { get; }

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted. Cannot be set alongside source_archive_bucket or source_archive_object.
    /// </summary>
    [TerraformProperty("source_repository")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SourceRepository { get; }

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
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    [TerraformProperty("timeout")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Timeout { get; }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    [TerraformProperty("trigger_http")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TriggerHttp { get; }

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionId { get; }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    [TerraformProperty("vpc_connector")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcConnector { get; }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    [TerraformProperty("vpc_connector_egress_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcConnectorEgressSettings { get; }

}
