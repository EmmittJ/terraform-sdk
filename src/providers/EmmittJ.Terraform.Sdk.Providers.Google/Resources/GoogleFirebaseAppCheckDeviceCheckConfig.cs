using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("name");
        this.WithOutput("private_key_set");
    }

    /// <summary>
    /// The ID of an
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_id");
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
    /// The key identifier of a private key enabled with DeviceCheck, created in your Apple Developer account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The contents of the private key (.p8) file associated with the key specified by keyId.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformProperty<string> PrivateKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_key");
        set => this.WithProperty("private_key", value);
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
    /// Specifies the duration for which App Check tokens exchanged from DeviceCheck artifacts will be valid.
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
