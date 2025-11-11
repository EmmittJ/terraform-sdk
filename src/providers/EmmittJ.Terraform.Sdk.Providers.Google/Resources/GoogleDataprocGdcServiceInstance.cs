using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gdce_cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcServiceInstanceGdceClusterBlock
{
    /// <summary>
    /// Gdce cluster resource id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GdceCluster is required")]
    [TerraformPropertyName("gdce_cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GdceCluster { get; set; }

}

/// <summary>
/// Block type for spark_service_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcServiceInstanceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_gdc_service_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocGdcServiceInstance : TerraformResource
{
    public GoogleDataprocGdcServiceInstance(string name) : base("google_dataproc_gdc_service_instance", name)
    {
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The labels to associate with this service instance. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Requested service account to associate with ServiceInstance.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Id of the service instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceInstanceId is required")]
    [TerraformPropertyName("service_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceInstanceId { get; set; }

    /// <summary>
    /// Block for gdce_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GdceCluster block(s) allowed")]
    [TerraformPropertyName("gdce_cluster")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcServiceInstanceGdceClusterBlock>>? GdceCluster { get; set; }

    /// <summary>
    /// Block for spark_service_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkServiceInstanceConfig block(s) allowed")]
    [TerraformPropertyName("spark_service_instance_config")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcServiceInstanceSparkServiceInstanceConfigBlock>>? SparkServiceInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocGdcServiceInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Effective service account associated with ServiceInstance. This will be the service_account if specified. Otherwise, it will be an automatically created per-resource P4SA that also automatically has Fleet Workload. Identity bindings applied.
    /// </summary>
    [TerraformPropertyName("effective_service_account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EffectiveServiceAccount => new TerraformReference(this, "effective_service_account");

    /// <summary>
    /// Identifier. The name of the service instance.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Whether the service instance is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

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
    [TerraformPropertyName("requested_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RequestedState => new TerraformReference(this, "requested_state");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateMessage => new TerraformReference(this, "state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// System generated unique identifier for this service instance, formatted as UUID4.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
