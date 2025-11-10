using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image_versions.
/// </summary>
public class AzurermSharedImageVersionsDataSource : TerraformDataSource
{
    public AzurermSharedImageVersionsDataSource(string name) : base("azurerm_shared_image_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("images");
        SetOutput("gallery_name");
        SetOutput("id");
        SetOutput("image_name");
        SetOutput("resource_group_name");
        SetOutput("tags_filter");
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformProperty<string> GalleryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_name");
        set => SetProperty("gallery_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformProperty<string> ImageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_name");
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags_filter attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsFilter
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_filter");
        set => SetProperty("tags_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSharedImageVersionsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
