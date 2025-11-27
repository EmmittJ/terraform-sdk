using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaseAppCheckDebugToken.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckDebugTokenTimeoutsBlock : TerraformBlock
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
/// Represents a google_firebase_app_check_debug_token Terraform resource.
/// Manages a google_firebase_app_check_debug_token resource.
/// </summary>
public partial class GoogleFirebaseAppCheckDebugToken(string name) : TerraformResource("google_firebase_app_check_debug_token", name)
{
    /// <summary>
    /// The ID of a
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id),
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id),
    /// or [Android App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.androidApps#AndroidApp.FIELDS.app_id)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// A human readable display name used to identify this debug token.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The secret token itself. Must be provided during creation, and must be a UUID4,
    /// case insensitive. You may use a method of your choice such as random/random_uuid
    /// to generate the token.
    /// 
    /// This field is immutable once set, and cannot be updated. You can, however, delete
    /// this debug token to revoke it.
    /// 
    /// For security reasons, this field will never be populated in any response.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// The last segment of the resource name of the debug token.
    /// </summary>
    public TerraformValue<string> DebugTokenId
    {
        get => new TerraformReference<string>(this, "debug_token_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppCheckDebugTokenTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppCheckDebugTokenTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
