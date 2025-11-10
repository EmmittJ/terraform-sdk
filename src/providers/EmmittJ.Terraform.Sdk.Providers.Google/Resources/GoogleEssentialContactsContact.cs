using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEssentialContactsContactTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_essential_contacts_contact resource.
/// </summary>
public class GoogleEssentialContactsContact : TerraformResource
{
    public GoogleEssentialContactsContact(string name) : base("google_essential_contacts_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("email");
        SetOutput("id");
        SetOutput("language_tag");
        SetOutput("notification_category_subscriptions");
        SetOutput("parent");
    }

    /// <summary>
    /// The email address to send notifications to. This does not need to be a Google account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The preferred language for notifications, as a ISO 639-1 language code. See Supported languages for a list of supported languages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageTag is required")]
    public required TerraformProperty<string> LanguageTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_tag");
        set => SetProperty("language_tag", value);
    }

    /// <summary>
    /// The categories of notifications that the contact will receive communications for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationCategorySubscriptions is required")]
    public List<TerraformProperty<string>> NotificationCategorySubscriptions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("notification_category_subscriptions");
        set => SetProperty("notification_category_subscriptions", value);
    }

    /// <summary>
    /// The resource to save this contact for. Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEssentialContactsContactTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The identifier for the contact. Format: {resourceType}/{resource_id}/contacts/{contact_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

}
