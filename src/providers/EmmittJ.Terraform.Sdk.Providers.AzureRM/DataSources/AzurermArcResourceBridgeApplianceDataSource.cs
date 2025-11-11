using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermArcResourceBridgeApplianceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_arc_resource_bridge_appliance.
/// </summary>
public partial class AzurermArcResourceBridgeApplianceDataSource : TerraformDataSource
{
    public AzurermArcResourceBridgeApplianceDataSource(string name) : base("azurerm_arc_resource_bridge_appliance", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermArcResourceBridgeApplianceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The distro attribute.
    /// </summary>
    [TerraformProperty("distro")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Distro { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The infrastructure_provider attribute.
    /// </summary>
    [TerraformProperty("infrastructure_provider")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InfrastructureProvider { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The public_key_base64 attribute.
    /// </summary>
    [TerraformProperty("public_key_base64")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKeyBase64 { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
