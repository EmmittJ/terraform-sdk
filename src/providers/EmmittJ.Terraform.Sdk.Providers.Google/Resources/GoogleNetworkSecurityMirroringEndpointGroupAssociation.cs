using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock : ITerraformBlock
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
    /// The cloud location of the association, currently restricted to &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The endpoint group that this association is connected to, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    [TerraformPropertyName("mirroring_endpoint_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MirroringEndpointGroup { get; set; }

    /// <summary>
    /// The ID to use for the new association, which will become the final
    /// component of the endpoint group&#39;s resource name. If not provided, the
    /// server will generate a unique ID.
    /// </summary>
    [TerraformPropertyName("mirroring_endpoint_group_association_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MirroringEndpointGroupAssociationId { get; set; }

    /// <summary>
    /// The VPC network that is associated. for example:
    /// &#39;projects/123456789/global/networks/my-network&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

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
    public TerraformBlock<GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The list of locations where the association is configured. This information
    /// is retrieved from the linked endpoint group.
    /// </summary>
    [TerraformPropertyName("locations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Locations => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "locations");

    /// <summary>
    /// The list of locations where the association is present. This information
    /// is retrieved from the linked endpoint group, and not configured as part
    /// of the association itself.
    /// </summary>
    [TerraformPropertyName("locations_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LocationsDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "locations_details");

    /// <summary>
    /// The resource name of this endpoint group association, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroupAssociations/my-eg-association&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This part of the normal
    /// operation (e.g. adding a new location to the target deployment group).
    /// See https://google.aip.dev/128.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

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
