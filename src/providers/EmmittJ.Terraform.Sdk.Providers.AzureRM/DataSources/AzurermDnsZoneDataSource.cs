using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDnsZoneDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dns_zone.
/// </summary>
public partial class AzurermDnsZoneDataSource : TerraformDataSource
{
    public AzurermDnsZoneDataSource(string name) : base("azurerm_dns_zone", name)
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
    [TerraformProperty("resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDnsZoneDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformProperty("max_number_of_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxNumberOfRecordSets { get; }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformProperty("name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> NameServers { get; }

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformProperty("number_of_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumberOfRecordSets { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
