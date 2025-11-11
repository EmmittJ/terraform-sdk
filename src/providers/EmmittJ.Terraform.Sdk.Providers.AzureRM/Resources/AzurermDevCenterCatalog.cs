using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for catalog_adogit in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevCenterCatalogCatalogAdogitBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    [TerraformProperty("branch")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Branch { get; set; }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    [TerraformProperty("key_vault_key_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultKeyUrl { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for catalog_github in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevCenterCatalogCatalogGithubBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    [TerraformProperty("branch")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Branch { get; set; }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    [TerraformProperty("key_vault_key_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultKeyUrl { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterCatalogTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_dev_center_catalog resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDevCenterCatalog : TerraformResource
{
    public AzurermDevCenterCatalog(string name) : base("azurerm_dev_center_catalog", name)
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    [TerraformProperty("dev_center_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DevCenterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for catalog_adogit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogAdogit block(s) allowed")]
    [TerraformProperty("catalog_adogit")]
    public TerraformList<TerraformBlock<AzurermDevCenterCatalogCatalogAdogitBlock>>? CatalogAdogit { get; set; }

    /// <summary>
    /// Block for catalog_github.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogGithub block(s) allowed")]
    [TerraformProperty("catalog_github")]
    public TerraformList<TerraformBlock<AzurermDevCenterCatalogCatalogGithubBlock>>? CatalogGithub { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDevCenterCatalogTimeoutsBlock>? Timeouts { get; set; }

}
