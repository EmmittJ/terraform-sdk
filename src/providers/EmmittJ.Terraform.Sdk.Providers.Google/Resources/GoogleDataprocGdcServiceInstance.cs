using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gdce_cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcServiceInstanceGdceClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gdce cluster resource id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GdceCluster is required")]
    public required TerraformProperty<string> GdceCluster
    {
        set => SetProperty("gdce_cluster", value);
    }

}

/// <summary>
/// Block type for spark_service_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcServiceInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataproc_gdc_service_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocGdcServiceInstance : TerraformResource
{
    public GoogleDataprocGdcServiceInstance(string name) : base("google_dataproc_gdc_service_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("effective_service_account");
        SetOutput("name");
        SetOutput("reconciling");
        SetOutput("requested_state");
        SetOutput("state");
        SetOutput("state_message");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
        SetOutput("service_account");
        SetOutput("service_instance_id");
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The labels to associate with this service instance. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Requested service account to associate with ServiceInstance.
    /// </summary>
    public TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Id of the service instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceInstanceId is required")]
    public required TerraformProperty<string> ServiceInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_instance_id");
        set => SetProperty("service_instance_id", value);
    }

    /// <summary>
    /// Block for gdce_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GdceCluster block(s) allowed")]
    public List<GoogleDataprocGdcServiceInstanceGdceClusterBlock>? GdceCluster
    {
        set => SetProperty("gdce_cluster", value);
    }

    /// <summary>
    /// Block for spark_service_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkServiceInstanceConfig block(s) allowed")]
    public List<GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock>? SparkServiceInstanceConfig
    {
        set => SetProperty("spark_service_instance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocGdcServiceInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Effective service account associated with ServiceInstance. This will be the service_account if specified. Otherwise, it will be an automatically created per-resource P4SA that also automatically has Fleet Workload. Identity bindings applied.
    /// </summary>
    public TerraformExpression EffectiveServiceAccount => this["effective_service_account"];

    /// <summary>
    /// Identifier. The name of the service instance.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Whether the service instance is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

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
    public TerraformExpression RequestedState => this["requested_state"];

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
    public TerraformExpression State => this["state"];

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated unique identifier for this service instance, formatted as UUID4.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
