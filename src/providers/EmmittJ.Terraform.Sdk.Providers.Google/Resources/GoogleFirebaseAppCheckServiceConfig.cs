using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaseAppCheckServiceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckServiceConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_firebase_app_check_service_config Terraform resource.
/// Manages a google_firebase_app_check_service_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckServiceConfig(string name) : TerraformResource("google_firebase_app_check_service_config", name)
{
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
    public TerraformValue<string>? EnforcementMode
    {
        get => GetArgument<TerraformValue<string>>("enforcement_mode");
        set => SetArgument("enforcement_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The identifier of the service to configure enforcement. Currently, the following service IDs are supported:
    ///   firebasestorage.googleapis.com (Cloud Storage for Firebase)
    ///   firebasedatabase.googleapis.com (Firebase Realtime Database)
    ///   firestore.googleapis.com (Cloud Firestore)
    ///   identitytoolkit.googleapis.com (Authentication)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// The fully-qualified resource name of the service enforcement configuration.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppCheckServiceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppCheckServiceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
