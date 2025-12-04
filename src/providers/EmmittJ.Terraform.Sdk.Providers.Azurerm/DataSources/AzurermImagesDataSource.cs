using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermImagesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermImagesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_images Terraform data source.
/// Retrieves information about a azurerm_images.
/// </summary>
public partial class AzurermImagesDataSource(string name) : TerraformDataSource("azurerm_images", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags_filter attribute.
    /// </summary>
    public TerraformMap<string>? TagsFilter
    {
        get => GetArgument<TerraformMap<string>>("tags_filter");
        set => SetArgument("tags_filter", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Images
        => AsReference("images");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermImagesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermImagesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
