using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleServiceNetworkingConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_service_networking_connection resource.
/// </summary>
public partial class GoogleServiceNetworkingConnection : TerraformResource
{
    public GoogleServiceNetworkingConnection(string name) : base("google_service_networking_connection", name)
    {
    }

    /// <summary>
    /// When set to ABANDON, terraform will abandon management of the resource instead of deleting it. Prevents terraform apply failures with CloudSQL. Note: The resource will still exist.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of VPC network connected with service producers using VPC peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Named IP address range(s) of PEERING type reserved for this service provider. Note that invoking this method with a different range when connection is already established will not reallocate already provisioned service producer subnetworks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedPeeringRanges is required")]
    [TerraformProperty("reserved_peering_ranges")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? ReservedPeeringRanges { get; set; }

    /// <summary>
    /// Provider peering service that is managing peering connectivity for a service provider organization. For Google services that support this functionality it is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

    /// <summary>
    /// When set to true, enforce an update of the reserved peering ranges on the existing service networking connection in case of a new connection creation failure.
    /// </summary>
    [TerraformProperty("update_on_creation_fail")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UpdateOnCreationFail { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleServiceNetworkingConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The peering attribute.
    /// </summary>
    [TerraformProperty("peering")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Peering { get; }

}
