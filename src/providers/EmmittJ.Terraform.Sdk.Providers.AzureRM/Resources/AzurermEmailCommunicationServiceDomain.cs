using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEmailCommunicationServiceDomainTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("from_sender_domain");
        SetOutput("mail_from_sender_domain");
        SetOutput("verification_records");
        SetOutput("domain_management");
        SetOutput("email_service_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("user_engagement_tracking_enabled");
    }

    /// <summary>
    /// The domain_management attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainManagement is required")]
    public required TerraformProperty<string> DomainManagement
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_management");
        set => SetProperty("domain_management", value);
    }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceId is required")]
    public required TerraformProperty<string> EmailServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_service_id");
        set => SetProperty("email_service_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> UserEngagementTrackingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("user_engagement_tracking_enabled");
        set => SetProperty("user_engagement_tracking_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEmailCommunicationServiceDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
