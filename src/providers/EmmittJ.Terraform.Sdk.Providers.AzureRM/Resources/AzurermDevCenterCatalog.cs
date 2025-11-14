using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for catalog_adogit in .
/// Nesting mode: list
/// </summary>
public class AzurermDevCenterCatalogCatalogAdogitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "catalog_adogit";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    [TerraformArgument("branch")]
    public required TerraformValue<string> Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    [TerraformArgument("key_vault_key_url")]
    public required TerraformValue<string> KeyVaultKeyUrl
    {
        get => new TerraformReference<string>(this, "key_vault_key_url");
        set => SetArgument("key_vault_key_url", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformArgument("path")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformArgument("uri")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for catalog_github in .
/// Nesting mode: list
/// </summary>
public class AzurermDevCenterCatalogCatalogGithubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "catalog_github";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    [TerraformArgument("branch")]
    public required TerraformValue<string> Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    [TerraformArgument("key_vault_key_url")]
    public required TerraformValue<string> KeyVaultKeyUrl
    {
        get => new TerraformReference<string>(this, "key_vault_key_url");
        set => SetArgument("key_vault_key_url", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformArgument("path")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformArgument("uri")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterCatalogTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_dev_center_catalog resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDevCenterCatalog : TerraformResource
{
    public AzurermDevCenterCatalog(string name) : base("azurerm_dev_center_catalog", name)
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    [TerraformArgument("dev_center_id")]
    public required TerraformValue<string> DevCenterId
    {
        get => new TerraformReference<string>(this, "dev_center_id");
        set => SetArgument("dev_center_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for catalog_adogit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogAdogit block(s) allowed")]
    [TerraformArgument("catalog_adogit")]
    public TerraformList<AzurermDevCenterCatalogCatalogAdogitBlock> CatalogAdogit { get; set; } = new();

    /// <summary>
    /// Block for catalog_github.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogGithub block(s) allowed")]
    [TerraformArgument("catalog_github")]
    public TerraformList<AzurermDevCenterCatalogCatalogGithubBlock> CatalogGithub { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevCenterCatalogTimeoutsBlock Timeouts { get; set; } = new();

}
