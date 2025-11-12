using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRouterNatAddressTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_compute_router_nat_address resource.
/// </summary>
public partial class GoogleComputeRouterNatAddress : TerraformResource
{
    public GoogleComputeRouterNatAddress(string name) : base("google_compute_router_nat_address", name)
    {
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    [TerraformProperty("drain_nat_ips")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DrainNatIps { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Self-links of NAT IPs to be used in a Nat service. Only valid if the referenced RouterNat
    /// natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatIps is required")]
    [TerraformProperty("nat_ips")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> NatIps { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the NAT service reside.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The name of the Cloud Router in which the referenced NAT service is configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformProperty("router")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Router { get; set; }

    /// <summary>
    /// The name of the Nat service in which this address will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouterNat is required")]
    [TerraformProperty("router_nat")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RouterNat { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeRouterNatAddressTimeoutsBlock Timeouts { get; set; } = new();

}
