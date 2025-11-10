using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_security_mirroring_endpoint_group resource.
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroup : TerraformResource
{
    public GoogleNetworkSecurityMirroringEndpointGroup(string name) : base("google_network_security_mirroring_endpoint_group", name)
    {
    }

    /// <summary>
    /// User-provided description of the endpoint group.
    /// Used as additional context for the endpoint group.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The cloud location of the endpoint group, currently restricted to &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The deployment group that this DIRECT endpoint group is connected to, for example:
    /// &#39;projects/123456789/locations/global/mirroringDeploymentGroups/my-dg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [TerraformPropertyName("mirroring_deployment_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MirroringDeploymentGroup { get; set; }

    /// <summary>
    /// The ID to use for the endpoint group, which will become the final component
    /// of the endpoint group&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroupId is required")]
    [TerraformPropertyName("mirroring_endpoint_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MirroringEndpointGroupId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkSecurityMirroringEndpointGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// List of associations to this endpoint group.
    /// </summary>
    [TerraformPropertyName("associations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Associations => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "associations");

    /// <summary>
    /// List of details about the connected deployment groups to this endpoint
    /// group.
    /// </summary>
    [TerraformPropertyName("connected_deployment_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ConnectedDeploymentGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "connected_deployment_groups");

    /// <summary>
    /// The timestamp when the resource was created.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The resource name of this endpoint group, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This is part of the normal
    /// operation (e.g. adding a new association to the group).
    /// See https://google.aip.dev/128.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
