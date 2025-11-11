using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ace in .
/// Nesting mode: set
/// </summary>
public partial class AzurermStorageDataLakeGen2PathAceBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformProperty("permissions")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Permissions { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageDataLakeGen2PathTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_data_lake_gen2_path resource.
/// </summary>
public partial class AzurermStorageDataLakeGen2Path : TerraformResource
{
    public AzurermStorageDataLakeGen2Path(string name) : base("azurerm_storage_data_lake_gen2_path", name)
    {
    }

    /// <summary>
    /// The filesystem_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemName is required")]
    [TerraformProperty("filesystem_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FilesystemName { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [TerraformProperty("resource")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Resource { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for ace.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ace")]
    public TerraformSet<TerraformBlock<AzurermStorageDataLakeGen2PathAceBlock>>? Ace { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageDataLakeGen2PathTimeoutsBlock>? Timeouts { get; set; }

}
