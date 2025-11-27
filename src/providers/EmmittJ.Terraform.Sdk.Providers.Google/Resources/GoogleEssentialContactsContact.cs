using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleEssentialContactsContact.
/// Nesting mode: single
/// </summary>
public class GoogleEssentialContactsContactTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_essential_contacts_contact Terraform resource.
/// Manages a google_essential_contacts_contact resource.
/// </summary>
public partial class GoogleEssentialContactsContact(string name) : TerraformResource("google_essential_contacts_contact", name)
{
    /// <summary>
    /// The email address to send notifications to. This does not need to be a Google account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The preferred language for notifications, as a ISO 639-1 language code. See Supported languages for a list of supported languages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageTag is required")]
    public required TerraformValue<string> LanguageTag
    {
        get => new TerraformReference<string>(this, "language_tag");
        set => SetArgument("language_tag", value);
    }

    /// <summary>
    /// The categories of notifications that the contact will receive communications for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationCategorySubscriptions is required")]
    public TerraformList<string>? NotificationCategorySubscriptions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "notification_category_subscriptions").ResolveNodes(ctx));
        set => SetArgument("notification_category_subscriptions", value);
    }

    /// <summary>
    /// The resource to save this contact for. Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The identifier for the contact. Format: {resourceType}/{resource_id}/contacts/{contact_id}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEssentialContactsContactTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEssentialContactsContactTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
