using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppCheckDebugTokenTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_firebase_app_check_debug_token resource.
/// </summary>
public partial class GoogleFirebaseAppCheckDebugToken : TerraformResource
{
    public GoogleFirebaseAppCheckDebugToken(string name) : base("google_firebase_app_check_debug_token", name)
    {
    }

    /// <summary>
    /// The ID of a
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id),
    /// [Apple App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.iosApps#IosApp.FIELDS.app_id),
    /// or [Android App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.androidApps#AndroidApp.FIELDS.app_id)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// A human readable display name used to identify this debug token.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

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
    [TerraformProperty("token")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Token { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleFirebaseAppCheckDebugTokenTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The last segment of the resource name of the debug token.
    /// </summary>
    [TerraformProperty("debug_token_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DebugTokenId { get; }

}
