using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firebase_app_check_debug_token resource.
/// </summary>
public class GoogleFirebaseAppCheckDebugToken : TerraformResource
{
    public GoogleFirebaseAppCheckDebugToken(string name) : base("google_firebase_app_check_debug_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("debug_token_id");
    }

    /// <summary>
    /// The ID of a
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id),
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id),
    /// or [Android App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.androidApps#AndroidApp.FIELDS.app_id)
    /// </summary>
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// A human readable display name used to identify this debug token.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<string>? Token
    {
        get => GetProperty<TerraformProperty<string>>("token");
        set => this.WithProperty("token", value);
    }

    /// <summary>
    /// The last segment of the resource name of the debug token.
    /// </summary>
    public TerraformExpression DebugTokenId => this["debug_token_id"];

}
