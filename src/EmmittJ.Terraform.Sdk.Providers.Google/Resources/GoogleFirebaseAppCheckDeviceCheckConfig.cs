using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firebase_app_check_device_check_config resource.
/// </summary>
public class GoogleFirebaseAppCheckDeviceCheckConfig : TerraformResource
{
    public GoogleFirebaseAppCheckDeviceCheckConfig(string name) : base("google_firebase_app_check_device_check_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("private_key_set");
    }

    /// <summary>
    /// The ID of an
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id).
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key identifier of a private key enabled with DeviceCheck, created in your Apple Developer account.
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The contents of the private key (.p8) file associated with the key specified by keyId.
    /// </summary>
    public string? PrivateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_key")?.Value;
        set => this.WithProperty("private_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Specifies the duration for which App Check tokens exchanged from DeviceCheck artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public string? TokenTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_ttl")?.Value;
        set => this.WithProperty("token_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The relative resource name of the DeviceCheck configuration object
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Whether the privateKey field was previously set. Since App Check will never return the
    /// privateKey field, this field is the only way to find out whether it was previously set.
    /// </summary>
    public TerraformExpression PrivateKeySet => this["private_key_set"];

}
