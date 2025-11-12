using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStackHciClusterDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_stack_hci_cluster.
/// </summary>
public partial class AzurermStackHciClusterDataSource : TerraformDataSource
{
    public AzurermStackHciClusterDataSource(string name) : base("azurerm_stack_hci_cluster", name)
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
    public AzurermStackHciClusterDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The automanage_configuration_id attribute.
    /// </summary>
    [TerraformProperty("automanage_configuration_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AutomanageConfigurationId { get; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientId { get; }

    /// <summary>
    /// The cloud_id attribute.
    /// </summary>
    [TerraformProperty("cloud_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudId { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The resource_provider_object_id attribute.
    /// </summary>
    [TerraformProperty("resource_provider_object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceProviderObjectId { get; }

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    [TerraformProperty("service_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceEndpoint { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
