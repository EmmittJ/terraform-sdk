using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareDicomServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_dicom_service.
/// </summary>
public class AzurermHealthcareDicomServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareDicomServiceDataSource(string name) : base("azurerm_healthcare_dicom_service", name)
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
    public TerraformBlock<AzurermHealthcareDicomServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformPropertyName("authentication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Authentication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authentication");

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformPropertyName("cors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Cors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cors");

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_partitions_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DataPartitionsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "data_partitions_enabled");

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptionKeyUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_key_url");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateEndpoint => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_endpoint");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_url");

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformPropertyName("storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Storage => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
