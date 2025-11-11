using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermGalleryApplicationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_gallery_application resource.
/// </summary>
public partial class AzurermGalleryApplication : TerraformResource
{
    public AzurermGalleryApplication(string name) : base("azurerm_gallery_application", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    [TerraformProperty("end_of_life_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndOfLifeDate { get; set; }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformProperty("eula")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Eula { get; set; }

    /// <summary>
    /// The gallery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryId is required")]
    [TerraformProperty("gallery_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformProperty("privacy_statement_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivacyStatementUri { get; set; }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformProperty("release_note_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReleaseNoteUri { get; set; }

    /// <summary>
    /// The supported_os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedOsType is required")]
    [TerraformProperty("supported_os_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SupportedOsType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermGalleryApplicationTimeoutsBlock>? Timeouts { get; set; }

}
