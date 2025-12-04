using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for catalog_adogit in AzurermDevCenterCatalog.
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
    public required TerraformValue<string> Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    public required TerraformValue<string> KeyVaultKeyUrl
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_url");
        set => SetArgument("key_vault_key_url", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for catalog_github in AzurermDevCenterCatalog.
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
    public required TerraformValue<string> Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The key_vault_key_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyUrl is required")]
    public required TerraformValue<string> KeyVaultKeyUrl
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_url");
        set => SetArgument("key_vault_key_url", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDevCenterCatalog.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_catalog Terraform resource.
/// Manages a azurerm_dev_center_catalog resource.
/// </summary>
public partial class AzurermDevCenterCatalog(string name) : TerraformResource("azurerm_dev_center_catalog", name)
{
    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformValue<string> DevCenterId
    {
        get => GetArgument<TerraformValue<string>>("dev_center_id");
        set => SetArgument("dev_center_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// CatalogAdogit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogAdogit block(s) allowed")]
    public TerraformList<AzurermDevCenterCatalogCatalogAdogitBlock>? CatalogAdogit
    {
        get => GetArgument<TerraformList<AzurermDevCenterCatalogCatalogAdogitBlock>>("catalog_adogit");
        set => SetArgument("catalog_adogit", value);
    }

    /// <summary>
    /// CatalogGithub block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogGithub block(s) allowed")]
    public TerraformList<AzurermDevCenterCatalogCatalogGithubBlock>? CatalogGithub
    {
        get => GetArgument<TerraformList<AzurermDevCenterCatalogCatalogGithubBlock>>("catalog_github");
        set => SetArgument("catalog_github", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterCatalogTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterCatalogTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
