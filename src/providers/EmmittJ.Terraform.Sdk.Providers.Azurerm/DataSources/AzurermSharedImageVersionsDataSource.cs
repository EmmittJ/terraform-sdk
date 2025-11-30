using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSharedImageVersionsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionsDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_shared_image_versions Terraform data source.
/// Retrieves information about a azurerm_shared_image_versions.
/// </summary>
public partial class AzurermSharedImageVersionsDataSource(string name) : TerraformDataSource("azurerm_shared_image_versions", name)
{
    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformValue<string> GalleryName
    {
        get => new TerraformReference<string>(this, "gallery_name");
        set => SetArgument("gallery_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => new TerraformReference<string>(this, "image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags_filter attribute.
    /// </summary>
    public TerraformMap<string>? TagsFilter
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_filter").ResolveNodes(ctx));
        set => SetArgument("tags_filter", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Images
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "images").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageVersionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageVersionsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
