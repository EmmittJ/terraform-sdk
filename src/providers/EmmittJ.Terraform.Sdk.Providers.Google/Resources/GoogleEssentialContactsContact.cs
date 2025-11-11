using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEssentialContactsContactTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_essential_contacts_contact resource.
/// </summary>
public class GoogleEssentialContactsContact : TerraformResource
{
    public GoogleEssentialContactsContact(string name) : base("google_essential_contacts_contact", name)
    {
    }

    /// <summary>
    /// The email address to send notifications to. This does not need to be a Google account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The preferred language for notifications, as a ISO 639-1 language code. See Supported languages for a list of supported languages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageTag is required")]
    [TerraformPropertyName("language_tag")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LanguageTag { get; set; }

    /// <summary>
    /// The categories of notifications that the contact will receive communications for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationCategorySubscriptions is required")]
    [TerraformPropertyName("notification_category_subscriptions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? NotificationCategorySubscriptions { get; set; }

    /// <summary>
    /// The resource to save this contact for. Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleEssentialContactsContactTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The identifier for the contact. Format: {resourceType}/{resource_id}/contacts/{contact_id}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
