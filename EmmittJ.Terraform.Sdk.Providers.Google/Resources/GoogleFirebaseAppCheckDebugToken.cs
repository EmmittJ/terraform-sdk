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
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A human readable display name used to identify this debug token.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Token
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token")?.Value;
        set => this.WithProperty("token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The last segment of the resource name of the debug token.
    /// </summary>
    public TerraformExpression DebugTokenId => this["debug_token_id"];

}
