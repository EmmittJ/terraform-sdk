using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHealthcareMedtechServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The device_mapping_json attribute.
    /// </summary>
    [TerraformPropertyName("device_mapping_json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceMappingJson => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "device_mapping_json");

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_consumer_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventhubConsumerGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eventhub_consumer_group_name");

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventhubName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eventhub_name");

    /// <summary>
    /// The eventhub_namespace_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_namespace_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventhubNamespaceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eventhub_namespace_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

}
