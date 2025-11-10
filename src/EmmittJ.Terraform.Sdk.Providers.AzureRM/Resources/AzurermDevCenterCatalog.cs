using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for catalog_adogit in .
/// Nesting mode: list
/// </summary>
public class AzurermDevCenterCatalogCatalogAdogitBlock : TerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    public required TerraformProperty<string> Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    public required TerraformProperty<string> KeyVaultKeyUrl
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_url");
        set => WithProperty("key_vault_key_url", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for catalog_github in .
/// Nesting mode: list
/// </summary>
public class AzurermDevCenterCatalogCatalogGithubBlock : TerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    public required TerraformProperty<string> Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    public required TerraformProperty<string> KeyVaultKeyUrl
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_url");
        set => WithProperty("key_vault_key_url", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterCatalogTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_dev_center_catalog resource.
/// </summary>
public class AzurermDevCenterCatalog : TerraformResource
{
    public AzurermDevCenterCatalog(string name) : base("azurerm_dev_center_catalog", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformProperty<string> DevCenterId
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_id");
        set => this.WithProperty("dev_center_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for catalog_adogit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogAdogit block(s) allowed")]
    public List<AzurermDevCenterCatalogCatalogAdogitBlock>? CatalogAdogit
    {
        get => GetProperty<List<AzurermDevCenterCatalogCatalogAdogitBlock>>("catalog_adogit");
        set => this.WithProperty("catalog_adogit", value);
    }

    /// <summary>
    /// Block for catalog_github.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogGithub block(s) allowed")]
    public List<AzurermDevCenterCatalogCatalogGithubBlock>? CatalogGithub
    {
        get => GetProperty<List<AzurermDevCenterCatalogCatalogGithubBlock>>("catalog_github");
        set => this.WithProperty("catalog_github", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterCatalogTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevCenterCatalogTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
