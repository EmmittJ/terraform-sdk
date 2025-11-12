using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerStaticMemberTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_network_manager_static_member resource.
/// </summary>
public partial class AzurermNetworkManagerStaticMember : TerraformResource
{
    public AzurermNetworkManagerStaticMember(string name) : base("azurerm_network_manager_static_member", name)
    {
    }

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
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    [TerraformProperty("network_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkGroupId { get; set; }

    /// <summary>
    /// The target_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVirtualNetworkId is required")]
    [TerraformProperty("target_virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetVirtualNetworkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkManagerStaticMemberTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Region { get; }

}
