using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_email_communication_service_domain resource.
/// </summary>
public class AzurermEmailCommunicationServiceDomain : TerraformResource
{
    public AzurermEmailCommunicationServiceDomain(string name) : base("azurerm_email_communication_service_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("from_sender_domain");
        this.DeclareOutput("mail_from_sender_domain");
        this.DeclareOutput("verification_records");
    }

    /// <summary>
    /// The domain_management attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainManagement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_management");
        set => this.WithProperty("domain_management", value);
    }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_service_id");
        set => this.WithProperty("email_service_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UserEngagementTrackingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_engagement_tracking_enabled");
        set => this.WithProperty("user_engagement_tracking_enabled", value);
    }

    /// <summary>
    /// The from_sender_domain attribute.
    /// </summary>
    public TerraformExpression FromSenderDomain => this["from_sender_domain"];

    /// <summary>
    /// The mail_from_sender_domain attribute.
    /// </summary>
    public TerraformExpression MailFromSenderDomain => this["mail_from_sender_domain"];

    /// <summary>
    /// The verification_records attribute.
    /// </summary>
    public TerraformExpression VerificationRecords => this["verification_records"];

}
