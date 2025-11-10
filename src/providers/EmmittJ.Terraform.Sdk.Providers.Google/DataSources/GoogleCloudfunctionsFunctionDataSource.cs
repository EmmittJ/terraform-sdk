using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloudfunctions_function.
/// </summary>
public class GoogleCloudfunctionsFunctionDataSource : TerraformDataSource
{
    public GoogleCloudfunctionsFunctionDataSource(string name) : base("google_cloudfunctions_function", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// Security patches are applied automatically to the runtime without requiring the function to be redeployed.
    /// </summary>
    [TerraformPropertyName("automatic_update_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutomaticUpdatePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "automatic_update_policy");

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    [TerraformPropertyName("available_memory_mb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableMemoryMb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_memory_mb");

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    [TerraformPropertyName("build_environment_variables")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> BuildEnvironmentVariables => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "build_environment_variables");

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    [TerraformPropertyName("build_service_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BuildServiceAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "build_service_account");

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    [TerraformPropertyName("build_worker_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BuildWorkerPool => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "build_worker_pool");

    /// <summary>
    /// Description of the function.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    [TerraformPropertyName("docker_registry")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DockerRegistry => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "docker_registry");

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    [TerraformPropertyName("docker_repository")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DockerRepository => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "docker_repository");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    [TerraformPropertyName("entry_point")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EntryPoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "entry_point");

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EnvironmentVariables => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "environment_variables");

    /// <summary>
    /// A source that fires events in response to a condition in another service. Cannot be used with trigger_http.
    /// </summary>
    [TerraformPropertyName("event_trigger")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EventTrigger => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "event_trigger");

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    [TerraformPropertyName("https_trigger_security_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpsTriggerSecurityLevel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "https_trigger_security_level");

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    [TerraformPropertyName("https_trigger_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpsTriggerUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "https_trigger_url");

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    [TerraformPropertyName("ingress_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IngressSettings => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ingress_settings");

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_name");

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformPropertyName("max_instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxInstances => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_instances");

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformPropertyName("min_instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinInstances => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_instances");

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// </summary>
    [TerraformPropertyName("on_deploy_update_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OnDeployUpdatePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "on_deploy_update_policy");

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Runtime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "runtime");

    /// <summary>
    /// Secret environment variables configuration
    /// </summary>
    [TerraformPropertyName("secret_environment_variables")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecretEnvironmentVariables => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secret_environment_variables");

    /// <summary>
    /// Secret volumes configuration.
    /// </summary>
    [TerraformPropertyName("secret_volumes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecretVolumes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secret_volumes");

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    [TerraformPropertyName("service_account_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAccountEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_account_email");

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    [TerraformPropertyName("source_archive_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceArchiveBucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_archive_bucket");

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    [TerraformPropertyName("source_archive_object")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceArchiveObject => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_archive_object");

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted. Cannot be set alongside source_archive_bucket or source_archive_object.
    /// </summary>
    [TerraformPropertyName("source_repository")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SourceRepository => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "source_repository");

    /// <summary>
    /// Describes the current stage of a deployment.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Timeout => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "timeout");

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    [TerraformPropertyName("trigger_http")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TriggerHttp => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "trigger_http");

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    [TerraformPropertyName("vpc_connector")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcConnector => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_connector");

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    [TerraformPropertyName("vpc_connector_egress_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcConnectorEgressSettings => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_connector_egress_settings");

}
