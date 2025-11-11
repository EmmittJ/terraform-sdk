using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_medtech_service.
/// </summary>
public class AzurermHealthcareMedtechServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareMedtechServiceDataSource(string name) : base("azurerm_healthcare_medtech_service", name)
    {
    }

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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    [TerraformPropertyName("device_mapping_json")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeviceMappingJson => new TerraformReference(this, "device_mapping_json");

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_consumer_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventhubConsumerGroupName => new TerraformReference(this, "eventhub_consumer_group_name");

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventhubName => new TerraformReference(this, "eventhub_name");

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_namespace_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventhubNamespaceName => new TerraformReference(this, "eventhub_namespace_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

}
