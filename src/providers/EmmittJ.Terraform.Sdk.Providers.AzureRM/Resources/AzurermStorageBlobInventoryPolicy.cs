using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rules in .
/// Nesting mode: set
/// </summary>
public partial class AzurermStorageBlobInventoryPolicyRulesBlock() : TerraformBlock("rules")
{
    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformProperty("schedule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Schedule { get; set; }

    /// <summary>
    /// The schema_fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaFields is required")]
    [TerraformProperty("schema_fields")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SchemaFields { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    [TerraformProperty("storage_container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageContainerName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageBlobInventoryPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_storage_blob_inventory_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStorageBlobInventoryPolicy : TerraformResource
{
    public AzurermStorageBlobInventoryPolicy(string name) : base("azurerm_storage_blob_inventory_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    [TerraformProperty("rules")]
    public required TerraformSet<AzurermStorageBlobInventoryPolicyRulesBlock> Rules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageBlobInventoryPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
