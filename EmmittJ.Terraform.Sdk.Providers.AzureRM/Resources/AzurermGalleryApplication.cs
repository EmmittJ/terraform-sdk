using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_gallery_application resource.
/// </summary>
public class AzurermGalleryApplication : TerraformResource
{
    public AzurermGalleryApplication(string name) : base("azurerm_gallery_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The eula attribute.
    /// </summary>
    public string? Eula
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eula")?.Value;
        set => this.WithProperty("eula", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gallery_id attribute.
    /// </summary>
    public string? GalleryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_id")?.Value;
        set => this.WithProperty("gallery_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The privacy_statement_uri attribute.
    /// </summary>
    public string? PrivacyStatementUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_uri")?.Value;
        set => this.WithProperty("privacy_statement_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public string? ReleaseNoteUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_note_uri")?.Value;
        set => this.WithProperty("release_note_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The supported_os_type attribute.
    /// </summary>
    public string? SupportedOsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("supported_os_type")?.Value;
        set => this.WithProperty("supported_os_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
