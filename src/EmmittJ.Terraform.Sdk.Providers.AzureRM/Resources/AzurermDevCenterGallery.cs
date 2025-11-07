using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_center_gallery resource.
/// </summary>
public class AzurermDevCenterGallery : TerraformResource
{
    public AzurermDevCenterGallery(string name) : base("azurerm_dev_center_gallery", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DevCenterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_id");
        set => this.WithProperty("dev_center_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The shared_gallery_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedGalleryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_gallery_id");
        set => this.WithProperty("shared_gallery_id", value);
    }

}
