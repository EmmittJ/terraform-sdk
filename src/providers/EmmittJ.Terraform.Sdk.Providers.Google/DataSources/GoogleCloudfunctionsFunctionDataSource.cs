using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloudfunctions_function Terraform data source.
/// Retrieves information about a google_cloudfunctions_function.
/// </summary>
public partial class GoogleCloudfunctionsFunctionDataSource(string name) : TerraformDataSource("google_cloudfunctions_function", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Security patches are applied automatically to the runtime without requiring the function to be redeployed.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomaticUpdatePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "automatic_update_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    public TerraformValue<double> AvailableMemoryMb
    {
        get => new TerraformReference<double>(this, "available_memory_mb");
    }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    public TerraformMap<string> BuildEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "build_environment_variables").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    public TerraformValue<string> BuildServiceAccount
    {
        get => new TerraformReference<string>(this, "build_service_account");
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformValue<string> BuildWorkerPool
    {
        get => new TerraformReference<string>(this, "build_worker_pool");
    }

    /// <summary>
    /// Description of the function.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    public TerraformValue<string> DockerRegistry
    {
        get => new TerraformReference<string>(this, "docker_registry");
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    public TerraformValue<string> DockerRepository
    {
        get => new TerraformReference<string>(this, "docker_repository");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    public TerraformValue<string> EntryPoint
    {
        get => new TerraformReference<string>(this, "entry_point");
    }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    public TerraformMap<string> EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
    }

    /// <summary>
    /// A source that fires events in response to a condition in another service. Cannot be used with trigger_http.
    /// </summary>
    public TerraformList<TerraformMap<object>> EventTrigger
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "event_trigger").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    public TerraformValue<string> HttpsTriggerSecurityLevel
    {
        get => new TerraformReference<string>(this, "https_trigger_security_level");
    }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    public TerraformValue<string> HttpsTriggerUrl
    {
        get => new TerraformReference<string>(this, "https_trigger_url");
    }

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    public TerraformValue<string> IngressSettings
    {
        get => new TerraformReference<string>(this, "ingress_settings");
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformValue<double> MaxInstances
    {
        get => new TerraformReference<double>(this, "max_instances");
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformValue<double> MinInstances
    {
        get => new TerraformReference<double>(this, "min_instances");
    }

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// </summary>
    public TerraformList<TerraformMap<object>> OnDeployUpdatePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "on_deploy_update_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    public TerraformValue<string> Runtime
    {
        get => new TerraformReference<string>(this, "runtime");
    }

    /// <summary>
    /// Secret environment variables configuration
    /// </summary>
    public TerraformList<TerraformMap<object>> SecretEnvironmentVariables
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secret_environment_variables").ResolveNodes(ctx));
    }

    /// <summary>
    /// Secret volumes configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecretVolumes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secret_volumes").ResolveNodes(ctx));
    }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    public TerraformValue<string> ServiceAccountEmail
    {
        get => new TerraformReference<string>(this, "service_account_email");
    }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    public TerraformValue<string> SourceArchiveBucket
    {
        get => new TerraformReference<string>(this, "source_archive_bucket");
    }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    public TerraformValue<string> SourceArchiveObject
    {
        get => new TerraformReference<string>(this, "source_archive_object");
    }

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted. Cannot be set alongside source_archive_bucket or source_archive_object.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceRepository
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source_repository").ResolveNodes(ctx));
    }

    /// <summary>
    /// Describes the current stage of a deployment.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    public TerraformValue<double> Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
    }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    public TerraformValue<bool> TriggerHttp
    {
        get => new TerraformReference<bool>(this, "trigger_http");
    }

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
    }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    public TerraformValue<string> VpcConnector
    {
        get => new TerraformReference<string>(this, "vpc_connector");
    }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    public TerraformValue<string> VpcConnectorEgressSettings
    {
        get => new TerraformReference<string>(this, "vpc_connector_egress_settings");
    }

}
