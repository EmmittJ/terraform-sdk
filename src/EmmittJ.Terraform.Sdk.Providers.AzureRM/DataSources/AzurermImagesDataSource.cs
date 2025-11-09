using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_images.
/// </summary>
public class AzurermImagesDataSource : TerraformDataSource
{
    public AzurermImagesDataSource(string name) : base("azurerm_images", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("images");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags_filter attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsFilter
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_filter");
        set => this.WithProperty("tags_filter", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
