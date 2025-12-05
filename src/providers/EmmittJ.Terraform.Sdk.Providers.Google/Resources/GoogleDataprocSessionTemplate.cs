using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in GoogleDataprocSessionTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_config";

    /// <summary>
    /// ExecutionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionConfig block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlock>? ExecutionConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlock>>("execution_config");
        set => SetArgument("execution_config", value);
    }

    /// <summary>
    /// PeripheralsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeripheralsConfig block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlock>? PeripheralsConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlock>>("peripherals_config");
        set => SetArgument("peripherals_config", value);
    }

}

/// <summary>
/// Block type for execution_config in GoogleDataprocSessionTemplateEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_config";

    /// <summary>
    /// The duration to keep the session alive while it&#39;s idling.
    /// Exceeding this threshold causes the session to terminate. Minimum value is 10 minutes; maximum value is 14 day.
    /// Defaults to 1 hour if not set. If both ttl and idleTtl are specified for an interactive session, the conditions
    /// are treated as OR conditions: the workload will be terminated when it has been idle for idleTtl or when ttl has
    /// been exceeded, whichever occurs first.
    /// </summary>
    public TerraformValue<string>? IdleTtl
    {
        get => GetArgument<TerraformValue<string>>("idle_ttl");
        set => SetArgument("idle_ttl", value);
    }

    /// <summary>
    /// The Cloud KMS key to use for encryption.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Tags used for network traffic control.
    /// </summary>
    public TerraformList<string>? NetworkTags
    {
        get => GetArgument<TerraformList<string>>("network_tags");
        set => SetArgument("network_tags", value);
    }

    /// <summary>
    /// Service account that used to execute workload.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? CreateReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// A Cloud Storage bucket used to stage workload dependencies, config files, and store
    /// workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket,
    /// Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running,
    /// and then create and manage project-level, per-location staging and temporary buckets.
    /// This field requires a Cloud Storage bucket name, not a gs://... URI to a Cloud Storage bucket.
    /// </summary>
    public TerraformValue<string>? StagingBucket
    {
        get => GetArgument<TerraformValue<string>>("staging_bucket");
        set => SetArgument("staging_bucket", value);
    }

    /// <summary>
    /// Subnetwork configuration for workload execution.
    /// </summary>
    public TerraformValue<string>? SubnetworkUri
    {
        get => GetArgument<TerraformValue<string>>("subnetwork_uri");
        set => SetArgument("subnetwork_uri", value);
    }

    /// <summary>
    /// The duration after which the workload will be terminated.
    /// When the workload exceeds this duration, it will be unconditionally terminated without waiting for ongoing
    /// work to finish. If ttl is not specified for a session workload, the workload will be allowed to run until it
    /// exits naturally (or run forever without exiting). If ttl is not specified for an interactive session,
    /// it defaults to 24 hours. If ttl is not specified for a batch that uses 2.1+ runtime version, it defaults to 4 hours.
    /// Minimum value is 10 minutes; maximum value is 14 days. If both ttl and idleTtl are specified (for an interactive session),
    /// the conditions are treated as OR conditions: the workload will be terminated when it has been idle for idleTtl or
    /// when ttl has been exceeded, whichever occurs first.
    /// </summary>
    public TerraformValue<string> Ttl
    {
        get => GetArgument<TerraformValue<string>>("ttl") ?? CreateReference("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// AuthenticationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfig block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlockAuthenticationConfigBlock>? AuthenticationConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlockAuthenticationConfigBlock>>("authentication_config");
        set => SetArgument("authentication_config", value);
    }

}

/// <summary>
/// Block type for authentication_config in GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlockExecutionConfigBlockAuthenticationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_config";

    /// <summary>
    /// Authentication type for the user workload running in containers. Possible values: [&amp;quot;SERVICE_ACCOUNT&amp;quot;, &amp;quot;END_USER_CREDENTIALS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? UserWorkloadAuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("user_workload_authentication_type");
        set => SetArgument("user_workload_authentication_type", value);
    }

}

/// <summary>
/// Block type for peripherals_config in GoogleDataprocSessionTemplateEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "peripherals_config";

    /// <summary>
    /// Resource name of an existing Dataproc Metastore service.
    /// </summary>
    public TerraformValue<string>? MetastoreService
    {
        get => GetArgument<TerraformValue<string>>("metastore_service");
        set => SetArgument("metastore_service", value);
    }

    /// <summary>
    /// SparkHistoryServerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkHistoryServerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlockSparkHistoryServerConfigBlock>? SparkHistoryServerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlockSparkHistoryServerConfigBlock>>("spark_history_server_config");
        set => SetArgument("spark_history_server_config", value);
    }

}

/// <summary>
/// Block type for spark_history_server_config in GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlockPeripheralsConfigBlockSparkHistoryServerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_history_server_config";

    /// <summary>
    /// Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.
    /// </summary>
    public TerraformValue<string>? DataprocCluster
    {
        get => GetArgument<TerraformValue<string>>("dataproc_cluster");
        set => SetArgument("dataproc_cluster", value);
    }

}


/// <summary>
/// Block type for jupyter_session in GoogleDataprocSessionTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateJupyterSessionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_session";

    /// <summary>
    /// Display name, shown in the Jupyter kernelspec card.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Kernel to be used with Jupyter interactive session. Possible values: [&amp;quot;PYTHON&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Kernel
    {
        get => GetArgument<TerraformValue<string>>("kernel");
        set => SetArgument("kernel", value);
    }

}


/// <summary>
/// Block type for runtime_config in GoogleDataprocSessionTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateRuntimeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime_config";

    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    public TerraformValue<string>? ContainerImage
    {
        get => GetArgument<TerraformValue<string>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public TerraformMap<string> EffectiveProperties
        => CreateReference("effective_properties");

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Version of the session runtime.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for spark_connect_session in GoogleDataprocSessionTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateSparkConnectSessionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_connect_session";

}


/// <summary>
/// Block type for timeouts in GoogleDataprocSessionTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocSessionTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dataproc_session_template Terraform resource.
/// Manages a google_dataproc_session_template resource.
/// </summary>
public partial class GoogleDataprocSessionTemplate(string name) : TerraformResource("google_dataproc_session_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels to associate with this session template.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location in which the session template will be created in.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the session template in the following format:
    /// projects/{project}/locations/{location}/sessionTemplates/{template_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time when the session template was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The email address of the user who created the session template.
    /// </summary>
    public TerraformValue<string> Creator
        => CreateReference("creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The time when the session template was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// A session template UUID (Unique Universal Identifier). The service generates this value when it creates the session template.
    /// </summary>
    public TerraformValue<string> Uuid
        => CreateReference("uuid");

    /// <summary>
    /// EnvironmentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlock>? EnvironmentConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateEnvironmentConfigBlock>>("environment_config");
        set => SetArgument("environment_config", value);
    }

    /// <summary>
    /// JupyterSession block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterSession block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateJupyterSessionBlock>? JupyterSession
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateJupyterSessionBlock>>("jupyter_session");
        set => SetArgument("jupyter_session", value);
    }

    /// <summary>
    /// RuntimeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateRuntimeConfigBlock>? RuntimeConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateRuntimeConfigBlock>>("runtime_config");
        set => SetArgument("runtime_config", value);
    }

    /// <summary>
    /// SparkConnectSession block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConnectSession block(s) allowed")]
    public TerraformList<GoogleDataprocSessionTemplateSparkConnectSessionBlock>? SparkConnectSession
    {
        get => GetArgument<TerraformList<GoogleDataprocSessionTemplateSparkConnectSessionBlock>>("spark_connect_session");
        set => SetArgument("spark_connect_session", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocSessionTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocSessionTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
