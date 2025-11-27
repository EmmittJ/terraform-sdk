using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleKmsAutokeyConfig.
/// Nesting mode: single
/// </summary>
public class GoogleKmsAutokeyConfigTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_kms_autokey_config Terraform resource.
/// Manages a google_kms_autokey_config resource.
/// </summary>
public partial class GoogleKmsAutokeyConfig(string name) : TerraformResource("google_kms_autokey_config", name)
{
    /// <summary>
    /// The folder for which to retrieve config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformValue<string> Folder
    {
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The target key project for a given folder where KMS Autokey will provision a
    /// CryptoKey for any new KeyHandle the Developer creates. Should have the form
    /// &#39;projects/&amp;lt;project_id_or_number&amp;gt;&#39;.
    /// </summary>
    public TerraformValue<string>? KeyProject
    {
        get => new TerraformReference<string>(this, "key_project");
        set => SetArgument("key_project", value);
    }

    /// <summary>
    /// The etag of the AutokeyConfig for optimistic concurrency control.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleKmsAutokeyConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleKmsAutokeyConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
