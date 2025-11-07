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
    public TerraformProperty<string>? ConfigFile
    {
        get => GetProperty<TerraformProperty<string>>("config_file");
        set => this.WithProperty("config_file", value);
    }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableHealthCheck
    {
        get => GetProperty<TerraformProperty<bool>>("enable_health_check");
        set => this.WithProperty("enable_health_check", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndOfLifeDate
    {
        get => GetProperty<TerraformProperty<string>>("end_of_life_date");
        set => this.WithProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeFromLatest
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_from_latest");
        set => this.WithProperty("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    public TerraformProperty<string>? GalleryApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("gallery_application_id");
        set => this.WithProperty("gallery_application_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The package_file attribute.
    /// </summary>
    public TerraformProperty<string>? PackageFile
    {
        get => GetProperty<TerraformProperty<string>>("package_file");
        set => this.WithProperty("package_file", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
