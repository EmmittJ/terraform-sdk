using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageShareFileTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_share_file resource.
/// </summary>
public partial class AzurermStorageShareFile : TerraformResource
{
    public AzurermStorageShareFile(string name) : base("azurerm_storage_share_file", name)
    {
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentDisposition { get; set; }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformProperty("content_encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentEncoding { get; set; }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformProperty("content_md5")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentMd5 { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// The storage_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageShareId is required")]
    [TerraformProperty("storage_share_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageShareId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageShareFileTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    [TerraformProperty("content_length")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ContentLength { get; }

}
