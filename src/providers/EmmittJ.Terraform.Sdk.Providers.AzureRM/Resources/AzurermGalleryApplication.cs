using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermGalleryApplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("description");
        SetOutput("end_of_life_date");
        SetOutput("eula");
        SetOutput("gallery_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("privacy_statement_uri");
        SetOutput("release_note_uri");
        SetOutput("supported_os_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string> EndOfLifeDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_of_life_date");
        set => SetProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformProperty<string> Eula
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eula");
        set => SetProperty("eula", value);
    }

    /// <summary>
    /// The gallery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryId is required")]
    public required TerraformProperty<string> GalleryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_id");
        set => SetProperty("gallery_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformProperty<string> PrivacyStatementUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("privacy_statement_uri");
        set => SetProperty("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformProperty<string> ReleaseNoteUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_note_uri");
        set => SetProperty("release_note_uri", value);
    }

    /// <summary>
    /// The supported_os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedOsType is required")]
    public required TerraformProperty<string> SupportedOsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("supported_os_type");
        set => SetProperty("supported_os_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermGalleryApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
