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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The eula attribute.
    /// </summary>
    public TerraformProperty<string>? Eula
    {
        get => GetProperty<TerraformProperty<string>>("eula");
        set => this.WithProperty("eula", value);
    }

    /// <summary>
    /// The gallery_id attribute.
    /// </summary>
    public TerraformProperty<string>? GalleryId
    {
        get => GetProperty<TerraformProperty<string>>("gallery_id");
        set => this.WithProperty("gallery_id", value);
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
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformProperty<string>? PrivacyStatementUri
    {
        get => GetProperty<TerraformProperty<string>>("privacy_statement_uri");
        set => this.WithProperty("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseNoteUri
    {
        get => GetProperty<TerraformProperty<string>>("release_note_uri");
        set => this.WithProperty("release_note_uri", value);
    }

    /// <summary>
    /// The supported_os_type attribute.
    /// </summary>
    public TerraformProperty<string>? SupportedOsType
    {
        get => GetProperty<TerraformProperty<string>>("supported_os_type");
        set => this.WithProperty("supported_os_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
