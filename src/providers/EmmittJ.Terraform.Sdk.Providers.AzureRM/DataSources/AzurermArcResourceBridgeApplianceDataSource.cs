using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcResourceBridgeApplianceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_arc_resource_bridge_appliance.
/// </summary>
public class AzurermArcResourceBridgeApplianceDataSource : TerraformDataSource
{
    public AzurermArcResourceBridgeApplianceDataSource(string name) : base("azurerm_arc_resource_bridge_appliance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermArcResourceBridgeApplianceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The distro attribute.
    /// </summary>
    [TerraformPropertyName("distro")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Distro => new TerraformReference(this, "distro");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The infrastructure_provider attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_provider")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InfrastructureProvider => new TerraformReference(this, "infrastructure_provider");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The public_key_base64 attribute.
    /// </summary>
    [TerraformPropertyName("public_key_base64")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKeyBase64 => new TerraformReference(this, "public_key_base64");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
