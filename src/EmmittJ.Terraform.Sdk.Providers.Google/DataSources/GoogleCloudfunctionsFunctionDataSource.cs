using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloudfunctions_function.
/// </summary>
public class GoogleCloudfunctionsFunctionDataSource : TerraformDataSource
{
    public GoogleCloudfunctionsFunctionDataSource(string name) : base("google_cloudfunctions_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("automatic_update_policy");
        this.DeclareOutput("available_memory_mb");
        this.DeclareOutput("build_environment_variables");
        this.DeclareOutput("build_service_account");
        this.DeclareOutput("build_worker_pool");
        this.DeclareOutput("description");
        this.DeclareOutput("docker_registry");
        this.DeclareOutput("docker_repository");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("entry_point");
        this.DeclareOutput("environment_variables");
        this.DeclareOutput("event_trigger");
        this.DeclareOutput("https_trigger_security_level");
        this.DeclareOutput("https_trigger_url");
        this.DeclareOutput("ingress_settings");
        this.DeclareOutput("kms_key_name");
        this.DeclareOutput("labels");
        this.DeclareOutput("max_instances");
        this.DeclareOutput("min_instances");
        this.DeclareOutput("on_deploy_update_policy");
        this.DeclareOutput("runtime");
        this.DeclareOutput("secret_environment_variables");
        this.DeclareOutput("secret_volumes");
        this.DeclareOutput("service_account_email");
        this.DeclareOutput("source_archive_bucket");
        this.DeclareOutput("source_archive_object");
        this.DeclareOutput("source_repository");
        this.DeclareOutput("status");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("timeout");
        this.DeclareOutput("trigger_http");
        this.DeclareOutput("version_id");
        this.DeclareOutput("vpc_connector");
        this.DeclareOutput("vpc_connector_egress_settings");
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
    /// A user-defined name of the function. Function names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Security patches are applied automatically to the runtime without requiring the function to be redeployed.
    /// </summary>
    public TerraformExpression AutomaticUpdatePolicy => this["automatic_update_policy"];

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    public TerraformExpression AvailableMemoryMb => this["available_memory_mb"];

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    public TerraformExpression BuildEnvironmentVariables => this["build_environment_variables"];

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    public TerraformExpression BuildServiceAccount => this["build_service_account"];

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformExpression BuildWorkerPool => this["build_worker_pool"];

    /// <summary>
    /// Description of the function.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    public TerraformExpression DockerRegistry => this["docker_registry"];

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    public TerraformExpression DockerRepository => this["docker_repository"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    public TerraformExpression EntryPoint => this["entry_point"];

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    public TerraformExpression EnvironmentVariables => this["environment_variables"];

    /// <summary>
    /// A source that fires events in response to a condition in another service. Cannot be used with trigger_http.
    /// </summary>
    public TerraformExpression EventTrigger => this["event_trigger"];

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    public TerraformExpression HttpsTriggerSecurityLevel => this["https_trigger_security_level"];

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    public TerraformExpression HttpsTriggerUrl => this["https_trigger_url"];

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    public TerraformExpression IngressSettings => this["ingress_settings"];

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformExpression MaxInstances => this["max_instances"];

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    public TerraformExpression MinInstances => this["min_instances"];

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// </summary>
    public TerraformExpression OnDeployUpdatePolicy => this["on_deploy_update_policy"];

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    public TerraformExpression Runtime => this["runtime"];

    /// <summary>
    /// Secret environment variables configuration
    /// </summary>
    public TerraformExpression SecretEnvironmentVariables => this["secret_environment_variables"];

    /// <summary>
    /// Secret volumes configuration.
    /// </summary>
    public TerraformExpression SecretVolumes => this["secret_volumes"];

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    public TerraformExpression ServiceAccountEmail => this["service_account_email"];

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    public TerraformExpression SourceArchiveBucket => this["source_archive_bucket"];

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    public TerraformExpression SourceArchiveObject => this["source_archive_object"];

    /// <summary>
    /// Represents parameters related to source repository where a function is hosted. Cannot be set alongside source_archive_bucket or source_archive_object.
    /// </summary>
    public TerraformExpression SourceRepository => this["source_repository"];

    /// <summary>
    /// Describes the current stage of a deployment.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    public TerraformExpression Timeout => this["timeout"];

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    public TerraformExpression TriggerHttp => this["trigger_http"];

    /// <summary>
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    public TerraformExpression VpcConnector => this["vpc_connector"];

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    public TerraformExpression VpcConnectorEgressSettings => this["vpc_connector_egress_settings"];

}
