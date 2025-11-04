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
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred language for notifications, as a ISO 639-1 language code. See Supported languages for a list of supported languages.
    /// </summary>
    public string? LanguageTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_tag")?.Value;
        set => this.WithProperty("language_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The categories of notifications that the contact will receive communications for.
    /// </summary>
    public List<string>? NotificationCategorySubscriptions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("notification_category_subscriptions")?.Value;
        set => this.WithProperty("notification_category_subscriptions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The resource to save this contact for. Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier for the contact. Format: {resourceType}/{resource_id}/contacts/{contact_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

}
