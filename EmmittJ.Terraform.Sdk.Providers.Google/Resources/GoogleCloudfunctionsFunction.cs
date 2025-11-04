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
    public double? AvailableMemoryMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("available_memory_mb")?.Value;
        set => this.WithProperty("available_memory_mb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    public Dictionary<string, string>? BuildEnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("build_environment_variables")?.Value;
        set => this.WithProperty("build_environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    public string? BuildServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_service_account")?.Value;
        set => this.WithProperty("build_service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public string? BuildWorkerPool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_worker_pool")?.Value;
        set => this.WithProperty("build_worker_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Description of the function.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    public string? DockerRegistry
    {
        get => GetProperty<TerraformLiteralProperty<string>>("docker_registry")?.Value;
        set => this.WithProperty("docker_registry", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    public string? DockerRepository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("docker_repository")?.Value;
        set => this.WithProperty("docker_repository", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    public string? EntryPoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entry_point")?.Value;
        set => this.WithProperty("entry_point", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    public Dictionary<string, string>? EnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("environment_variables")?.Value;
        set => this.WithProperty("environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    public string? HttpsTriggerSecurityLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("https_trigger_security_level")?.Value;
        set => this.WithProperty("https_trigger_security_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    public string? HttpsTriggerUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("https_trigger_url")?.Value;
        set => this.WithProperty("https_trigger_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    public string? IngressSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingress_settings")?.Value;
        set => this.WithProperty("ingress_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    public string? KmsKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_name")?.Value;
        set => this.WithProperty("kms_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    public double? MaxInstances
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_instances")?.Value;
        set => this.WithProperty("max_instances", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    public double? MinInstances
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_instances")?.Value;
        set => this.WithProperty("min_instances", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Project of the function. If it is not provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    public string? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime")?.Value;
        set => this.WithProperty("runtime", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    public string? ServiceAccountEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_email")?.Value;
        set => this.WithProperty("service_account_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    public string? SourceArchiveBucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_archive_bucket")?.Value;
        set => this.WithProperty("source_archive_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    public string? SourceArchiveObject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_archive_object")?.Value;
        set => this.WithProperty("source_archive_object", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    public double? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    public bool? TriggerHttp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trigger_http")?.Value;
        set => this.WithProperty("trigger_http", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    public string? VpcConnector
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_connector")?.Value;
        set => this.WithProperty("vpc_connector", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    public string? VpcConnectorEgressSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_connector_egress_settings")?.Value;
        set => this.WithProperty("vpc_connector_egress_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
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
