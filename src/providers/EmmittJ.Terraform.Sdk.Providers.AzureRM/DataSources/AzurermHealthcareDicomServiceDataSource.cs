using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareDicomServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermHealthcareDicomServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformPropertyName("authentication")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Authentication => new TerraformReference(this, "authentication");

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformPropertyName("cors")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Cors => new TerraformReference(this, "cors");

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_partitions_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DataPartitionsEnabled => new TerraformReference(this, "data_partitions_enabled");

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptionKeyUrl => new TerraformReference(this, "encryption_key_url");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateEndpoint => new TerraformReference(this, "private_endpoint");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceUrl => new TerraformReference(this, "service_url");

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformPropertyName("storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Storage => new TerraformReference(this, "storage");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
