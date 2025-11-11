using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_medtech_service.
/// </summary>
public partial class AzurermHealthcareMedtechServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareMedtechServiceDataSource(string name) : base("azurerm_healthcare_medtech_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    [TerraformProperty("device_mapping_json")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeviceMappingJson { get; }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_consumer_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EventhubConsumerGroupName { get; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EventhubName { get; }

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_namespace_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EventhubNamespaceName { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

}
