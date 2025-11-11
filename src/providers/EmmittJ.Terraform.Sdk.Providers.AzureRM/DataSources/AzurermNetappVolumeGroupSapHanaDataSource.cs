using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_group_sap_hana.
/// </summary>
public class AzurermNetappVolumeGroupSapHanaDataSource : TerraformDataSource
{
    public AzurermNetappVolumeGroupSapHanaDataSource(string name) : base("azurerm_netapp_volume_group_sap_hana", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

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
    public TerraformBlock<AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    [TerraformPropertyName("application_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationIdentifier => new TerraformReference(this, "application_identifier");

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    [TerraformPropertyName("group_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GroupDescription => new TerraformReference(this, "group_description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The volume attribute.
    /// </summary>
    [TerraformPropertyName("volume")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Volume => new TerraformReference(this, "volume");

}
