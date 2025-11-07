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
    public TerraformProperty<string>? DevCenterId
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The shared_gallery_id attribute.
    /// </summary>
    public TerraformProperty<string>? SharedGalleryId
    {
        get => GetProperty<TerraformProperty<string>>("shared_gallery_id");
        set => this.WithProperty("shared_gallery_id", value);
    }

}
