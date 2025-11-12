using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppCheckServiceConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_firebase_app_check_service_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckServiceConfig : TerraformResource
{
    public GoogleFirebaseAppCheckServiceConfig(string name) : base("google_firebase_app_check_service_config", name)
    {
    }

    /// <summary>
    /// The App Check enforcement mode for a service supported by App Check. Valid values are
    /// 
    /// (Unset)
    /// Firebase App Check is not enforced for the service, nor are App Check metrics collected.
    /// Though the service is not protected by App Check in this mode, other applicable protections,
    /// such as user authorization, are still enforced. An unconfigured service is in this mode by default.
    /// This is equivalent to OFF in the REST API. Deleting the Terraform resource will also switch the
    /// enforcement to OFF for this service.
    /// 
    /// UNENFORCED
    /// Firebase App Check is not enforced for the service. App Check metrics are collected to help you
    /// decide when to turn on enforcement for the service. Though the service is not protected by App Check
    /// in this mode, other applicable protections, such as user authorization, are still enforced.
    /// 
    /// ENFORCED
    /// Firebase App Check is enforced for the service. The service will reject any request that attempts to
    /// access your project&#39;s resources if it does not have valid App Check token attached, with some exceptions
    /// depending on the service; for example, some services will still allow requests bearing the developer&#39;s
    /// privileged service account credentials without an App Check token. App Check metrics continue to be
    /// collected to help you detect issues with your App Check integration and monitor the composition of your
    /// callers. While the service is protected by App Check, other applicable protections, such as user
    /// authorization, continue to be enforced at the same time.
    /// 
    /// Use caution when choosing to enforce App Check on a Firebase service. If your users have not updated
    /// to an App Check capable version of your app, their apps will no longer be able to use your Firebase
    /// services that are enforcing App Check. App Check metrics can help you decide whether to enforce App
    /// Check on your Firebase services.
    /// 
    /// If your app has not launched yet, you should enable enforcement immediately, since there are no outdated
    /// clients in use. Possible values: [&amp;quot;UNENFORCED&amp;quot;, &amp;quot;ENFORCED&amp;quot;]
    /// </summary>
    [TerraformProperty("enforcement_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnforcementMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The identifier of the service to configure enforcement. Currently, the following service IDs are supported:
    ///   firebasestorage.googleapis.com (Cloud Storage for Firebase)
    ///   firebasedatabase.googleapis.com (Firebase Realtime Database)
    ///   firestore.googleapis.com (Cloud Firestore)
    ///   identitytoolkit.googleapis.com (Authentication)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    [TerraformProperty("service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirebaseAppCheckServiceConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fully-qualified resource name of the service enforcement configuration.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
