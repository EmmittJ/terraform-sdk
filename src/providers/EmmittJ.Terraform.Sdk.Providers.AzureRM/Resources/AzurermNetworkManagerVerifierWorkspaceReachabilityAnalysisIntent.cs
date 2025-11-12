using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_traffic in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock() : TerraformBlock("ip_traffic")
{
    /// <summary>
    /// The destination_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIps is required")]
    [TerraformProperty("destination_ips")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationIps { get; set; }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    [TerraformProperty("destination_ports")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DestinationPorts { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    [TerraformProperty("protocols")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Protocols { get; set; }

    /// <summary>
    /// The source_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIps is required")]
    [TerraformProperty("source_ips")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SourceIps { get; set; }

    /// <summary>
    /// The source_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    [TerraformProperty("source_ports")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SourcePorts { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_network_manager_verifier_workspace_reachability_analysis_intent resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent : TerraformResource
{
    public AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent(string name) : base("azurerm_network_manager_verifier_workspace_reachability_analysis_intent", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceId is required")]
    [TerraformProperty("destination_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationResourceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceId is required")]
    [TerraformProperty("source_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceResourceId { get; set; }

    /// <summary>
    /// The verifier_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifierWorkspaceId is required")]
    [TerraformProperty("verifier_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VerifierWorkspaceId { get; set; }

    /// <summary>
    /// Block for ip_traffic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpTraffic is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpTraffic block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpTraffic block(s) allowed")]
    [TerraformProperty("ip_traffic")]
    public required TerraformList<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock> IpTraffic { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock Timeouts { get; set; } = new();

}
