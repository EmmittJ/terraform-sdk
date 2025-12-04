using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermGalleryApplication.
/// Nesting mode: single
/// </summary>
public class AzurermGalleryApplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_gallery_application Terraform resource.
/// Manages a azurerm_gallery_application resource.
/// </summary>
public partial class AzurermGalleryApplication(string name) : TerraformResource("azurerm_gallery_application", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformValue<string>? EndOfLifeDate
    {
        get => GetArgument<TerraformValue<string>>("end_of_life_date");
        set => SetArgument("end_of_life_date", value);
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformValue<string>? Eula
    {
        get => GetArgument<TerraformValue<string>>("eula");
        set => SetArgument("eula", value);
    }

    /// <summary>
    /// The gallery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryId is required")]
    public required TerraformValue<string> GalleryId
    {
        get => GetArgument<TerraformValue<string>>("gallery_id");
        set => SetArgument("gallery_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformValue<string>? PrivacyStatementUri
    {
        get => GetArgument<TerraformValue<string>>("privacy_statement_uri");
        set => SetArgument("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformValue<string>? ReleaseNoteUri
    {
        get => GetArgument<TerraformValue<string>>("release_note_uri");
        set => SetArgument("release_note_uri", value);
    }

    /// <summary>
    /// The supported_os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedOsType is required")]
    public required TerraformValue<string> SupportedOsType
    {
        get => GetArgument<TerraformValue<string>>("supported_os_type");
        set => SetArgument("supported_os_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermGalleryApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermGalleryApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
