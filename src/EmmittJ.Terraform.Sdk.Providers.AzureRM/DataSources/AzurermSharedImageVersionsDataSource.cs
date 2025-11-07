using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("images");
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GalleryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_name");
        set => this.WithProperty("gallery_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags_filter attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsFilter
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_filter");
        set => this.WithProperty("tags_filter", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
