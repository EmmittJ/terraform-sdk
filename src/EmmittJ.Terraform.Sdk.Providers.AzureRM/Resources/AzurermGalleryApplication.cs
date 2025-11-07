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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The eula attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Eula
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eula");
        set => this.WithProperty("eula", value);
    }

    /// <summary>
    /// The gallery_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GalleryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_id");
        set => this.WithProperty("gallery_id", value);
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
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivacyStatementUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_uri");
        set => this.WithProperty("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReleaseNoteUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_note_uri");
        set => this.WithProperty("release_note_uri", value);
    }

    /// <summary>
    /// The supported_os_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SupportedOsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("supported_os_type");
        set => this.WithProperty("supported_os_type", value);
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
