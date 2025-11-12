using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ace in .
/// Nesting mode: set
/// </summary>
public partial class AzurermStorageDataLakeGen2FilesystemAceBlock() : TerraformBlock("ace")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformProperty("permissions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Permissions { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageDataLakeGen2FilesystemTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_data_lake_gen2_filesystem resource.
/// </summary>
public partial class AzurermStorageDataLakeGen2Filesystem : TerraformResource
{
    public AzurermStorageDataLakeGen2Filesystem(string name) : base("azurerm_storage_data_lake_gen2_filesystem", name)
    {
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformProperty("default_encryption_scope")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultEncryptionScope { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Group { get; set; }

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
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for ace.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ace")]
    public TerraformSet<AzurermStorageDataLakeGen2FilesystemAceBlock> Ace { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageDataLakeGen2FilesystemTimeoutsBlock Timeouts { get; set; } = new();

}
