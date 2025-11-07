using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<Dictionary<string, string>>? BuildEnvironmentVariables
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("build_environment_variables");
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
    public TerraformProperty<Dictionary<string, string>>? EnvironmentVariables
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("environment_variables");
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
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
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
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? Runtime
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
