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
    public string? ConfigFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_file")?.Value;
        set => this.WithProperty("config_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    public bool? EnableHealthCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_health_check")?.Value;
        set => this.WithProperty("enable_health_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public string? EndOfLifeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_of_life_date")?.Value;
        set => this.WithProperty("end_of_life_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public bool? ExcludeFromLatest
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_from_latest")?.Value;
        set => this.WithProperty("exclude_from_latest", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    public string? GalleryApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_application_id")?.Value;
        set => this.WithProperty("gallery_application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The package_file attribute.
    /// </summary>
    public string? PackageFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_file")?.Value;
        set => this.WithProperty("package_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
