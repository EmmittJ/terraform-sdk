using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gdce_cluster in GoogleDataprocGdcServiceInstance.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcServiceInstanceGdceClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gdce_cluster";

    /// <summary>
    /// Gdce cluster resource id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GdceCluster is required")]
    public required TerraformValue<string> GdceCluster
    {
        get => GetArgument<TerraformValue<string>>("gdce_cluster");
        set => SetArgument("gdce_cluster", value);
    }

}


/// <summary>
/// Block type for spark_service_instance_config in GoogleDataprocGdcServiceInstance.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_service_instance_config";

}


/// <summary>
/// Block type for timeouts in GoogleDataprocGdcServiceInstance.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcServiceInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataproc_gdc_service_instance Terraform resource.
/// Manages a google_dataproc_gdc_service_instance resource.
/// </summary>
public partial class GoogleDataprocGdcServiceInstance(string name) : TerraformResource("google_dataproc_gdc_service_instance", name)
{
    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels to associate with this service instance. Labels may be used for filtering and billing tracking. 
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
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Requested service account to associate with ServiceInstance.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Id of the service instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceInstanceId is required")]
    public required TerraformValue<string> ServiceInstanceId
    {
        get => GetArgument<TerraformValue<string>>("service_instance_id");
        set => SetArgument("service_instance_id", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Effective service account associated with ServiceInstance. This will be the service_account if specified. Otherwise, it will be an automatically created per-resource P4SA that also automatically has Fleet Workload. Identity bindings applied.
    /// </summary>
    public TerraformValue<string> EffectiveServiceAccount
        => AsReference("effective_service_account");

    /// <summary>
    /// Identifier. The name of the service instance.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Whether the service instance is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The intended state to which the service instance is reconciling. Possible values:
    /// * &#39;CREATING&#39;
    /// * &#39;ACTIVE&#39;
    /// * &#39;DISCONNECTED&#39;
    /// * &#39;DELETING&#39;
    /// * &#39;STOPPING&#39;
    /// * &#39;STOPPED&#39;
    /// * &#39;STARTING&#39;
    /// * &#39;UPDATING&#39;
    /// * &#39;FAILED&#39;
    /// </summary>
    public TerraformValue<string> RequestedState
        => AsReference("requested_state");

    /// <summary>
    /// The current state. Possible values:
    /// * &#39;CREATING&#39;
    /// * &#39;ACTIVE&#39;
    /// * &#39;DISCONNECTED&#39;
    /// * &#39;DELETING&#39;
    /// * &#39;STOPPING&#39;
    /// * &#39;STOPPED&#39;
    /// * &#39;STARTING&#39;
    /// * &#39;UPDATING&#39;
    /// * &#39;FAILED&#39;
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    public TerraformValue<string> StateMessage
        => AsReference("state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// System generated unique identifier for this service instance, formatted as UUID4.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// GdceCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GdceCluster block(s) allowed")]
    public TerraformList<GoogleDataprocGdcServiceInstanceGdceClusterBlock>? GdceCluster
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcServiceInstanceGdceClusterBlock>>("gdce_cluster");
        set => SetArgument("gdce_cluster", value);
    }

    /// <summary>
    /// SparkServiceInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkServiceInstanceConfig block(s) allowed")]
    public TerraformList<GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock>? SparkServiceInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock>>("spark_service_instance_config");
        set => SetArgument("spark_service_instance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocGdcServiceInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocGdcServiceInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
