using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_firebase_app_check_device_check_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckDeviceCheckConfig : TerraformResource
{
    public GoogleFirebaseAppCheckDeviceCheckConfig(string name) : base("google_firebase_app_check_device_check_config", name)
    {
    }

    /// <summary>
    /// The ID of an
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key identifier of a private key enabled with DeviceCheck, created in your Apple Developer account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The contents of the private key (.p8) file associated with the key specified by keyId.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    [TerraformProperty("private_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateKey { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from DeviceCheck artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("token_ttl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TokenTtl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirebaseAppCheckDeviceCheckConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The relative resource name of the DeviceCheck configuration object
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Whether the privateKey field was previously set. Since App Check will never return the
    /// privateKey field, this field is the only way to find out whether it was previously set.
    /// </summary>
    [TerraformProperty("private_key_set")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PrivateKeySet { get; }

}
