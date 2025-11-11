using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecurityInterceptEndpointGroupTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_network_security_intercept_endpoint_group resource.
/// </summary>
public partial class GoogleNetworkSecurityInterceptEndpointGroup : TerraformResource
{
    public GoogleNetworkSecurityInterceptEndpointGroup(string name) : base("google_network_security_intercept_endpoint_group", name)
    {
    }

    /// <summary>
    /// User-provided description of the endpoint group.
    /// Used as additional context for the endpoint group.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The deployment group that this endpoint group is connected to, for example:
    /// &#39;projects/123456789/locations/global/interceptDeploymentGroups/my-dg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterceptDeploymentGroup is required")]
    [TerraformProperty("intercept_deployment_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InterceptDeploymentGroup { get; set; }

    /// <summary>
    /// The ID to use for the endpoint group, which will become the final component
    /// of the endpoint group&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterceptEndpointGroupId is required")]
    [TerraformProperty("intercept_endpoint_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InterceptEndpointGroupId { get; set; }

    /// <summary>
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The cloud location of the endpoint group, currently restricted to &#39;global&#39;.
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleNetworkSecurityInterceptEndpointGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// List of associations to this endpoint group.
    /// </summary>
    [TerraformProperty("associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Associations { get; }

    /// <summary>
    /// The endpoint group&#39;s view of a connected deployment group.
    /// </summary>
    [TerraformProperty("connected_deployment_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConnectedDeploymentGroup { get; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// See https://google.aip.dev/148#timestamps.
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
    /// The resource name of this endpoint group, for example:
    /// &#39;projects/123456789/locations/global/interceptEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This is part of the normal
    /// operation (e.g. adding a new association to the group).
    /// See https://google.aip.dev/128.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of the endpoint group.
    /// See https://google.aip.dev/216.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CLOSED
    /// CREATING
    /// DELETING
    /// OUT_OF_SYNC
    /// DELETE_FAILED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
