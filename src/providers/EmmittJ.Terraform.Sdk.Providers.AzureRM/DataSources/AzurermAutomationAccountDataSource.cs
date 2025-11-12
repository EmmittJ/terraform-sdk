using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationAccountDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_automation_account.
/// </summary>
public partial class AzurermAutomationAccountDataSource : TerraformDataSource
{
    public AzurermAutomationAccountDataSource(string name) : base("azurerm_automation_account", name)
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
    public AzurermAutomationAccountDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The hybrid_service_url attribute.
    /// </summary>
    [TerraformProperty("hybrid_service_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HybridServiceUrl { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_connection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrivateEndpointConnection { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryKey { get; }

}
