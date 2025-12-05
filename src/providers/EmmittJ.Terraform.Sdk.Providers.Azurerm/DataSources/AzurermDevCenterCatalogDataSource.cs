using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevCenterCatalogDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterCatalogDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_catalog Terraform data source.
/// Retrieves information about a azurerm_dev_center_catalog.
/// </summary>
public partial class AzurermDevCenterCatalogDataSource(string name) : TerraformDataSource("azurerm_dev_center_catalog", name)
{
    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformValue<string> DevCenterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dev_center_id");
        set => SetArgument("dev_center_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The catalog_adogit attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CatalogAdogit
        => CreateReference("catalog_adogit");

    /// <summary>
    /// The catalog_github attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CatalogGithub
        => CreateReference("catalog_github");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterCatalogDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterCatalogDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
