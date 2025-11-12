using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for peering_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeDnsZonePeeringConfigBlock() : TerraformBlock("peering_config")
{
    /// <summary>
    /// The name of the producer VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    [TerraformProperty("target_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetNetworkId { get; set; }

    /// <summary>
    /// The ID of the project that contains the producer VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetProjectId is required")]
    [TerraformProperty("target_project_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetProjectId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeDnsZoneTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_apigee_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeDnsZone : TerraformResource
{
    public GoogleApigeeDnsZone(string name) : base("google_apigee_dns_zone", name)
    {
    }

    /// <summary>
    /// Description for the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// ID of the dns zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsZoneId is required")]
    [TerraformProperty("dns_zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DnsZoneId { get; set; }

    /// <summary>
    /// Doamin for the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Block for peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PeeringConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    [TerraformProperty("peering_config")]
    public required TerraformList<GoogleApigeeDnsZonePeeringConfigBlock> PeeringConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeDnsZoneTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Name of the Dns Zone in the following format:
    /// organizations/{organization}/dnsZones/{dnsZone}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
