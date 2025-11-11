using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_group_sap_hana.
/// </summary>
public partial class AzurermNetappVolumeGroupSapHanaDataSource : TerraformDataSource
{
    public AzurermNetappVolumeGroupSapHanaDataSource(string name) : base("azurerm_netapp_volume_group_sap_hana", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

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
    public partial TerraformBlock<AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    [TerraformProperty("application_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationIdentifier { get; }

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    [TerraformProperty("group_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GroupDescription { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The volume attribute.
    /// </summary>
    [TerraformProperty("volume")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Volume { get; }

}
