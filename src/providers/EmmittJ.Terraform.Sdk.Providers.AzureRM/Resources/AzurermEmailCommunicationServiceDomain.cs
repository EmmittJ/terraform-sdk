using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEmailCommunicationServiceDomainTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_email_communication_service_domain resource.
/// </summary>
public class AzurermEmailCommunicationServiceDomain : TerraformResource
{
    public AzurermEmailCommunicationServiceDomain(string name) : base("azurerm_email_communication_service_domain", name)
    {
    }

    /// <summary>
    /// The domain_management attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainManagement is required")]
    [TerraformPropertyName("domain_management")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainManagement { get; set; }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceId is required")]
    [TerraformPropertyName("email_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EmailServiceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    [TerraformPropertyName("user_engagement_tracking_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UserEngagementTrackingEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermEmailCommunicationServiceDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The from_sender_domain attribute.
    /// </summary>
    [TerraformPropertyName("from_sender_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FromSenderDomain => new TerraformReference(this, "from_sender_domain");

    /// <summary>
    /// The mail_from_sender_domain attribute.
    /// </summary>
    [TerraformPropertyName("mail_from_sender_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MailFromSenderDomain => new TerraformReference(this, "mail_from_sender_domain");

    /// <summary>
    /// The verification_records attribute.
    /// </summary>
    [TerraformPropertyName("verification_records")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VerificationRecords => new TerraformReference(this, "verification_records");

}
