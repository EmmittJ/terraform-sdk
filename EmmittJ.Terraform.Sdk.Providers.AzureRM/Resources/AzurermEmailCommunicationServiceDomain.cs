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
    public string? DomainManagement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_management")?.Value;
        set => this.WithProperty("domain_management", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    public string? EmailServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_service_id")?.Value;
        set => this.WithProperty("email_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    public bool? UserEngagementTrackingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_engagement_tracking_enabled")?.Value;
        set => this.WithProperty("user_engagement_tracking_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
