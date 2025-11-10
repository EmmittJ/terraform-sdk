using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterGalleryDataSourceTimeoutsBlock : TerraformBlock
{
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
/// Retrieves information about a azurerm_dev_center_gallery.
/// </summary>
public class AzurermDevCenterGalleryDataSource : TerraformDataSource
{
    public AzurermDevCenterGalleryDataSource(string name) : base("azurerm_dev_center_gallery", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("shared_gallery_id");
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformProperty<string> DevCenterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dev_center_id");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterGalleryDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevCenterGalleryDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The shared_gallery_id attribute.
    /// </summary>
    public TerraformExpression SharedGalleryId => this["shared_gallery_id"];

}
