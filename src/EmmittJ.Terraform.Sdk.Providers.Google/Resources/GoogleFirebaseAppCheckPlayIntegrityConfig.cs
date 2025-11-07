using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firebase_app_check_play_integrity_config resource.
/// </summary>
public class GoogleFirebaseAppCheckPlayIntegrityConfig : TerraformResource
{
    public GoogleFirebaseAppCheckPlayIntegrityConfig(string name) : base("google_firebase_app_check_play_integrity_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The ID of an
    /// [Android App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.androidApps#AndroidApp.FIELDS.app_id).
    /// </summary>
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
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
    /// Specifies the duration for which App Check tokens exchanged from Play Integrity artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? TokenTtl
    {
        get => GetProperty<TerraformProperty<string>>("token_ttl");
        set => this.WithProperty("token_ttl", value);
    }

    /// <summary>
    /// The relative resource name of the Play Integrity configuration object
    /// </summary>
    public TerraformExpression Name => this["name"];

}
