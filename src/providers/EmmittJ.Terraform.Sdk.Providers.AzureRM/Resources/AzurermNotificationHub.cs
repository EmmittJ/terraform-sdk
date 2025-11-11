using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for apns_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNotificationHubApnsCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationMode is required")]
    [TerraformProperty("application_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationMode { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformProperty("bundle_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TeamId is required")]
    [TerraformProperty("team_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TeamId { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    [TerraformProperty("token")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Token { get; set; }

}

/// <summary>
/// Block type for browser_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNotificationHubBrowserCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [TerraformProperty("subject")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Subject { get; set; }

    /// <summary>
    /// The vapid_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VapidPrivateKey is required")]
    [TerraformProperty("vapid_private_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VapidPrivateKey { get; set; }

    /// <summary>
    /// The vapid_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VapidPublicKey is required")]
    [TerraformProperty("vapid_public_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VapidPublicKey { get; set; }

}

/// <summary>
/// Block type for gcm_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNotificationHubGcmCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [TerraformProperty("api_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNotificationHubTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_notification_hub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNotificationHub : TerraformResource
{
    public AzurermNotificationHub(string name) : base("azurerm_notification_hub", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformProperty("namespace_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for apns_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApnsCredential block(s) allowed")]
    [TerraformProperty("apns_credential")]
    public TerraformList<TerraformBlock<AzurermNotificationHubApnsCredentialBlock>>? ApnsCredential { get; set; }

    /// <summary>
    /// Block for browser_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrowserCredential block(s) allowed")]
    [TerraformProperty("browser_credential")]
    public TerraformList<TerraformBlock<AzurermNotificationHubBrowserCredentialBlock>>? BrowserCredential { get; set; }

    /// <summary>
    /// Block for gcm_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcmCredential block(s) allowed")]
    [TerraformProperty("gcm_credential")]
    public TerraformList<TerraformBlock<AzurermNotificationHubGcmCredentialBlock>>? GcmCredential { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNotificationHubTimeoutsBlock>? Timeouts { get; set; }

}
