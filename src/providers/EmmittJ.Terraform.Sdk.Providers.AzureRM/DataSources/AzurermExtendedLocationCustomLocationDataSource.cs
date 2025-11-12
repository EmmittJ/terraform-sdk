using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_extended_location_custom_location.
/// </summary>
public partial class AzurermExtendedLocationCustomLocationDataSource : TerraformDataSource
{
    public AzurermExtendedLocationCustomLocationDataSource(string name) : base("azurerm_extended_location_custom_location", name)
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
    public AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformProperty("authentication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Authentication { get; }

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    [TerraformProperty("cluster_extension_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ClusterExtensionIds { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The host_resource_id attribute.
    /// </summary>
    [TerraformProperty("host_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostResourceId { get; }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    [TerraformProperty("host_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostType { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Namespace { get; }

}
