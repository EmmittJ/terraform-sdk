using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gdce_cluster in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocGdcServiceInstanceGdceClusterBlock : TerraformBlockBase
{
    /// <summary>
    /// Gdce cluster resource id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GdceCluster is required")]
    [TerraformProperty("gdce_cluster")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GdceCluster { get; set; }

}

/// <summary>
/// Block type for spark_service_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocGdcServiceInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_gdc_service_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocGdcServiceInstance : TerraformResource
{
    public GoogleDataprocGdcServiceInstance(string name) : base("google_dataproc_gdc_service_instance", name)
    {
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels to associate with this service instance. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Requested service account to associate with ServiceInstance.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Id of the service instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceInstanceId is required")]
    [TerraformProperty("service_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceInstanceId { get; set; }

    /// <summary>
    /// Block for gdce_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GdceCluster block(s) allowed")]
    [TerraformProperty("gdce_cluster")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcServiceInstanceGdceClusterBlock>>? GdceCluster { get; set; }

    /// <summary>
    /// Block for spark_service_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkServiceInstanceConfig block(s) allowed")]
    [TerraformProperty("spark_service_instance_config")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock>>? SparkServiceInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataprocGdcServiceInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Effective service account associated with ServiceInstance. This will be the service_account if specified. Otherwise, it will be an automatically created per-resource P4SA that also automatically has Fleet Workload. Identity bindings applied.
    /// </summary>
    [TerraformProperty("effective_service_account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EffectiveServiceAccount { get; }

    /// <summary>
    /// Identifier. The name of the service instance.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Whether the service instance is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

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
    [TerraformProperty("requested_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RequestedState { get; }

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
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// System generated unique identifier for this service instance, formatted as UUID4.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
