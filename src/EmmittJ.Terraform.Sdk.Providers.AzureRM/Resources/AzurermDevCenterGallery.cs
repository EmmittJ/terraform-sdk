using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterGalleryTimeoutsBlock : TerraformBlock
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

}

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
    /// The shared_gallery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedGalleryId is required")]
    public required TerraformProperty<string> SharedGalleryId
    {
        get => GetProperty<TerraformProperty<string>>("shared_gallery_id");
        set => this.WithProperty("shared_gallery_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterGalleryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevCenterGalleryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
