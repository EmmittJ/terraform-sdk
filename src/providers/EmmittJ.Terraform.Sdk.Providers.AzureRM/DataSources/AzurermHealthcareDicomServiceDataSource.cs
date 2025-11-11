using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareDicomServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_dicom_service.
/// </summary>
public partial class AzurermHealthcareDicomServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareDicomServiceDataSource(string name) : base("azurerm_healthcare_dicom_service", name)
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermHealthcareDicomServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformProperty("authentication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Authentication { get; }

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformProperty("cors")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Cors { get; }

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    [TerraformProperty("data_partitions_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DataPartitionsEnabled { get; }

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    [TerraformProperty("encryption_key_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionKeyUrl { get; }

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
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformProperty("private_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrivateEndpoint { get; }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformProperty("service_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceUrl { get; }

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformProperty("storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Storage { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
