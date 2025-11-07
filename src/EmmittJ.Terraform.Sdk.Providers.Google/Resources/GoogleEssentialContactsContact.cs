using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The email address to send notifications to. This does not need to be a Google account.
    /// </summary>
    public TerraformLiteralProperty<string>? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email");
        set => this.WithProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The preferred language for notifications, as a ISO 639-1 language code. See Supported languages for a list of supported languages.
    /// </summary>
    public TerraformLiteralProperty<string>? LanguageTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_tag");
        set => this.WithProperty("language_tag", value);
    }

    /// <summary>
    /// The categories of notifications that the contact will receive communications for.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NotificationCategorySubscriptions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_category_subscriptions");
        set => this.WithProperty("notification_category_subscriptions", value);
    }

    /// <summary>
    /// The resource to save this contact for. Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
    /// </summary>
    public TerraformLiteralProperty<string>? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The identifier for the contact. Format: {resourceType}/{resource_id}/contacts/{contact_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

}
