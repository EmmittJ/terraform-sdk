using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock
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
/// Manages a google_network_security_mirroring_endpoint_group_association resource.
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupAssociation : TerraformResource
{
    public GoogleNetworkSecurityMirroringEndpointGroupAssociation(string name) : base("google_network_security_mirroring_endpoint_group_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The cloud location of the association, currently restricted to &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The endpoint group that this association is connected to, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    [TerraformPropertyName("mirroring_endpoint_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MirroringEndpointGroup { get; set; }

    /// <summary>
    /// The ID to use for the new association, which will become the final
    /// component of the endpoint group&#39;s resource name. If not provided, the
    /// server will generate a unique ID.
    /// </summary>
    [TerraformPropertyName("mirroring_endpoint_group_association_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MirroringEndpointGroupAssociationId { get; set; }

    /// <summary>
    /// The VPC network that is associated. for example:
    /// &#39;projects/123456789/global/networks/my-network&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// See https://google.aip.dev/148#timestamps.
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
    /// The list of locations where the association is configured. This information
    /// is retrieved from the linked endpoint group.
    /// </summary>
    [TerraformPropertyName("locations")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Locations => new TerraformReference(this, "locations");

    /// <summary>
    /// The list of locations where the association is present. This information
    /// is retrieved from the linked endpoint group, and not configured as part
    /// of the association itself.
    /// </summary>
    [TerraformPropertyName("locations_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LocationsDetails => new TerraformReference(this, "locations_details");

    /// <summary>
    /// The resource name of this endpoint group association, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroupAssociations/my-eg-association&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This part of the normal
    /// operation (e.g. adding a new location to the target deployment group).
    /// See https://google.aip.dev/128.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// Current state of the endpoint group association.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
    /// CLOSED
    /// OUT_OF_SYNC
    /// DELETE_FAILED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
