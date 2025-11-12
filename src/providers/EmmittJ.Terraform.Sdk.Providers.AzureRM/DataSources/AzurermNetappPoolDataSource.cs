using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappPoolDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_pool.
/// </summary>
public partial class AzurermNetappPoolDataSource : TerraformDataSource
{
    public AzurermNetappPoolDataSource(string name) : base("azurerm_netapp_pool", name)
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
    public AzurermNetappPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    [TerraformProperty("cool_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> CoolAccessEnabled { get; }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    [TerraformProperty("custom_throughput_mibps")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CustomThroughputMibps { get; }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionType { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformProperty("service_level")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceLevel { get; }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    [TerraformProperty("size_in_tb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SizeInTb { get; }

}
