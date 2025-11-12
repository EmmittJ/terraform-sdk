using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_machine_gallery_application_assignment resource.
/// </summary>
public partial class AzurermVirtualMachineGalleryApplicationAssignment : TerraformResource
{
    public AzurermVirtualMachineGalleryApplicationAssignment(string name) : base("azurerm_virtual_machine_gallery_application_assignment", name)
    {
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformProperty("configuration_blob_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The gallery_application_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationVersionId is required")]
    [TerraformProperty("gallery_application_version_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryApplicationVersionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformProperty("order")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformProperty("virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock Timeouts { get; set; } = new();

}
