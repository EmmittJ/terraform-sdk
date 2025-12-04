using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaseAppCheckDeviceCheckConfig.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_check_device_check_config Terraform resource.
/// Manages a google_firebase_app_check_device_check_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckDeviceCheckConfig(string name) : TerraformResource("google_firebase_app_check_device_check_config", name)
{
    /// <summary>
    /// The ID of an
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => GetArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
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
    /// The key identifier of a private key enabled with DeviceCheck, created in your Apple Developer account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The contents of the private key (.p8) file associated with the key specified by keyId.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from DeviceCheck artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TokenTtl
    {
        get => GetArgument<TerraformValue<string>>("token_ttl");
        set => SetArgument("token_ttl", value);
    }

    /// <summary>
    /// The relative resource name of the DeviceCheck configuration object
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Whether the privateKey field was previously set. Since App Check will never return the
    /// privateKey field, this field is the only way to find out whether it was previously set.
    /// </summary>
    public TerraformValue<bool> PrivateKeySet
        => AsReference("private_key_set");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
