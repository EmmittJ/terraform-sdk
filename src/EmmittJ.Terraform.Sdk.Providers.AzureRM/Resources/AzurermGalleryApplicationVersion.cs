using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_gallery_application_version resource.
/// </summary>
public class AzurermGalleryApplicationVersion : TerraformResource
{
    public AzurermGalleryApplicationVersion(string name) : base("azurerm_gallery_application_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_file");
        set => this.WithProperty("config_file", value);
    }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableHealthCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_health_check");
        set => this.WithProperty("enable_health_check", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndOfLifeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_of_life_date");
        set => this.WithProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExcludeFromLatest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_from_latest");
        set => this.WithProperty("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GalleryApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_application_id");
        set => this.WithProperty("gallery_application_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The package_file attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PackageFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_file");
        set => this.WithProperty("package_file", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
