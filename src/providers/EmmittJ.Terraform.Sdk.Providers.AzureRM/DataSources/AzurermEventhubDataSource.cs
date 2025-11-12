using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventhubDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventhub.
/// </summary>
public partial class AzurermEventhubDataSource : TerraformDataSource
{
    public AzurermEventhubDataSource(string name) : base("azurerm_eventhub", name)
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformProperty("namespace_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespaceName { get; set; }

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
    public AzurermEventhubDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [TerraformProperty("partition_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PartitionCount { get; }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    [TerraformProperty("partition_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PartitionIds { get; }

}
