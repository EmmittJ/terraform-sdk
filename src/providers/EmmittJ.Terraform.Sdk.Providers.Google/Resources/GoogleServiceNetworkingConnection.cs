using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingConnectionTimeoutsBlock : ITerraformBlock
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
/// Manages a google_service_networking_connection resource.
/// </summary>
public class GoogleServiceNetworkingConnection : TerraformResource
{
    public GoogleServiceNetworkingConnection(string name) : base("google_service_networking_connection", name)
    {
    }

    /// <summary>
    /// When set to ABANDON, terraform will abandon management of the resource instead of deleting it. Prevents terraform apply failures with CloudSQL. Note: The resource will still exist.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of VPC network connected with service producers using VPC peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Network { get; set; }

    /// <summary>
    /// Named IP address range(s) of PEERING type reserved for this service provider. Note that invoking this method with a different range when connection is already established will not reallocate already provisioned service producer subnetworks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedPeeringRanges is required")]
    [TerraformPropertyName("reserved_peering_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ReservedPeeringRanges { get; set; }

    /// <summary>
    /// Provider peering service that is managing peering connectivity for a service provider organization. For Google services that support this functionality it is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// When set to true, enforce an update of the reserved peering ranges on the existing service networking connection in case of a new connection creation failure.
    /// </summary>
    [TerraformPropertyName("update_on_creation_fail")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UpdateOnCreationFail { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleServiceNetworkingConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The peering attribute.
    /// </summary>
    [TerraformPropertyName("peering")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Peering => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peering");

}
