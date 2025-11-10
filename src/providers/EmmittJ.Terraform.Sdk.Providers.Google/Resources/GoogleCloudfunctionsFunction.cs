using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for event_trigger in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionEventTriggerBlock : ITerraformBlock
{
    /// <summary>
    /// The type of event to observe. For example: &amp;quot;google.storage.object.finalize&amp;quot;. See the documentation on calling Cloud Functions for a full reference of accepted triggers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    [TerraformPropertyName("event_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventType { get; set; }

    /// <summary>
    /// The name or partial URI of the resource from which to observe events. For example, &amp;quot;myBucket&amp;quot; or &amp;quot;projects/my-project/topics/my-topic&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformPropertyName("resource")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Resource { get; set; }

}

/// <summary>
/// Block type for on_deploy_update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The runtime version which was used during latest function deployment.
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RuntimeVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "runtime_version");

}

/// <summary>
/// Block type for secret_environment_variables in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the environment variable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "project_id");

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Secret { get; set; }

    /// <summary>
    /// Version of the secret (version number or the string &amp;quot;latest&amp;quot;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new clones start.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for secret_volumes in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSecretVolumesBlock : ITerraformBlock
{
    /// <summary>
    /// The path within the container to mount the secret volume. For example, setting the mount_path as &amp;quot;/etc/secrets&amp;quot; would mount the secret value files under the &amp;quot;/etc/secrets&amp;quot; directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount paths: &amp;quot;/etc/secrets&amp;quot; Restricted mount paths: &amp;quot;/cloudsql&amp;quot;, &amp;quot;/dev/log&amp;quot;, &amp;quot;/pod&amp;quot;, &amp;quot;/proc&amp;quot;, &amp;quot;/var/log&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    [TerraformPropertyName("mount_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MountPath { get; set; }

    /// <summary>
    /// Project identifier (due to a known limitation, only project number is supported by this field) of the project that contains the secret. If not set, it will be populated with the function&#39;s project, assuming that the secret exists in the same project as of the function.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "project_id");

    /// <summary>
    /// ID of the secret in secret manager (not the full resource name).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [TerraformPropertyName("secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Secret { get; set; }

}

/// <summary>
/// Block type for source_repository in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctionsFunctionSourceRepositoryBlock : ITerraformBlock
{
    /// <summary>
    /// The URL pointing to the hosted repository where the function was defined at the time of deployment.
    /// </summary>
    [TerraformPropertyName("deployed_url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeployedUrl => new TerraformReferenceProperty<TerraformProperty<string>>("", "deployed_url");

    /// <summary>
    /// The URL pointing to the hosted repository where the function is defined.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudfunctionsFunctionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloudfunctions_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudfunctionsFunction : TerraformResource
{
    public GoogleCloudfunctionsFunction(string name) : base("google_cloudfunctions_function", name)
    {
    }

    /// <summary>
    /// Memory (in MB), available to the function. Default value is 256. Possible values include 128, 256, 512, 1024, etc.
    /// </summary>
    [TerraformPropertyName("available_memory_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AvailableMemoryMb { get; set; }

    /// <summary>
    ///  A set of key/value environment variable pairs available during build time.
    /// </summary>
    [TerraformPropertyName("build_environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? BuildEnvironmentVariables { get; set; }

    /// <summary>
    /// The fully-qualified name of the service account to be used for the build step of deploying this function
    /// </summary>
    [TerraformPropertyName("build_service_account")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BuildServiceAccount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "build_service_account");

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    [TerraformPropertyName("build_worker_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BuildWorkerPool { get; set; }

    /// <summary>
    /// Description of the function.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Docker Registry to use for storing the function&#39;s Docker images. Allowed values are ARTIFACT_REGISTRY (default) and CONTAINER_REGISTRY.
    /// </summary>
    [TerraformPropertyName("docker_registry")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DockerRegistry { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "docker_registry");

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key. If specified, deployments will use Artifact Registry for storing images built with Cloud Build.
    /// </summary>
    [TerraformPropertyName("docker_repository")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DockerRepository { get; set; }

    /// <summary>
    /// Name of the function that will be executed when the Google Cloud Function is triggered.
    /// </summary>
    [TerraformPropertyName("entry_point")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EntryPoint { get; set; }

    /// <summary>
    /// A set of key/value environment variable pairs to assign to the function.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The security level for the function. Defaults to SECURE_OPTIONAL. Valid only if trigger_http is used.
    /// </summary>
    [TerraformPropertyName("https_trigger_security_level")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpsTriggerSecurityLevel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "https_trigger_security_level");

    /// <summary>
    /// URL which triggers function execution. Returned only if trigger_http is used.
    /// </summary>
    [TerraformPropertyName("https_trigger_url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpsTriggerUrl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "https_trigger_url");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// String value that controls what traffic can reach the function. Allowed values are ALLOW_ALL and ALLOW_INTERNAL_ONLY. Changes to this field will recreate the cloud function.
    /// </summary>
    [TerraformPropertyName("ingress_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IngressSettings { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to the function. Label keys must follow the requirements at https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformPropertyName("max_instances")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxInstances { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_instances");

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a given time.
    /// </summary>
    [TerraformPropertyName("min_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinInstances { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Region of function. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The runtime in which the function is going to run. Eg. &amp;quot;nodejs20&amp;quot;, &amp;quot;python37&amp;quot;, &amp;quot;go111&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    [TerraformPropertyName("runtime")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Runtime { get; set; }

    /// <summary>
    ///  If provided, the self-provided service account to run the function with.
    /// </summary>
    [TerraformPropertyName("service_account_email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceAccountEmail { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_account_email");

    /// <summary>
    /// The GCS bucket containing the zip archive which contains the function.
    /// </summary>
    [TerraformPropertyName("source_archive_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceArchiveBucket { get; set; }

    /// <summary>
    /// The source archive object (file) in archive bucket.
    /// </summary>
    [TerraformPropertyName("source_archive_object")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceArchiveObject { get; set; }

    /// <summary>
    /// Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Timeout { get; set; }

    /// <summary>
    /// Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as https_trigger_url. Cannot be used with trigger_bucket and trigger_topic.
    /// </summary>
    [TerraformPropertyName("trigger_http")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TriggerHttp { get; set; }

    /// <summary>
    /// The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is projects/*/locations/*/connectors/*.
    /// </summary>
    [TerraformPropertyName("vpc_connector")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcConnector { get; set; }

    /// <summary>
    /// The egress settings for the connector, controlling what traffic is diverted through it. Allowed values are ALL_TRAFFIC and PRIVATE_RANGES_ONLY. Defaults to PRIVATE_RANGES_ONLY. If unset, this field preserves the previously set value.
    /// </summary>
    [TerraformPropertyName("vpc_connector_egress_settings")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcConnectorEgressSettings { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_connector_egress_settings");

    /// <summary>
    /// Block for automatic_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdatePolicy block(s) allowed")]
    [TerraformPropertyName("automatic_update_policy")]
    public TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionAutomaticUpdatePolicyBlock>>? AutomaticUpdatePolicy { get; set; } = new();

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    [TerraformPropertyName("event_trigger")]
    public TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionEventTriggerBlock>>? EventTrigger { get; set; } = new();

    /// <summary>
    /// Block for on_deploy_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDeployUpdatePolicy block(s) allowed")]
    [TerraformPropertyName("on_deploy_update_policy")]
    public TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionOnDeployUpdatePolicyBlock>>? OnDeployUpdatePolicy { get; set; } = new();

    /// <summary>
    /// Block for secret_environment_variables.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secret_environment_variables")]
    public TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionSecretEnvironmentVariablesBlock>>? SecretEnvironmentVariables { get; set; } = new();

    /// <summary>
    /// Block for secret_volumes.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secret_volumes")]
    public TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionSecretVolumesBlock>>? SecretVolumes { get; set; } = new();

    /// <summary>
    /// Block for source_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceRepository block(s) allowed")]
    [TerraformPropertyName("source_repository")]
    public TerraformList<TerraformBlock<GoogleCloudfunctionsFunctionSourceRepositoryBlock>>? SourceRepository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudfunctionsFunctionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

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
    /// The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

}
