using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermResourcesDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_resources.
/// </summary>
public partial class AzurermResourcesDataSource : TerraformDataSource
{
    public AzurermResourcesDataSource(string name) : base("azurerm_resources", name)
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
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The required_tags attribute.
    /// </summary>
    [TerraformProperty("required_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequiredTags { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformProperty("resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermResourcesDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Resources { get; }

}
