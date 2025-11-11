using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEmailCommunicationServiceDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_email_communication_service_domain resource.
/// </summary>
public partial class AzurermEmailCommunicationServiceDomain : TerraformResource
{
    public AzurermEmailCommunicationServiceDomain(string name) : base("azurerm_email_communication_service_domain", name)
    {
    }

    /// <summary>
    /// The domain_management attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainManagement is required")]
    [TerraformProperty("domain_management")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainManagement { get; set; }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceId is required")]
    [TerraformProperty("email_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailServiceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    [TerraformProperty("user_engagement_tracking_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UserEngagementTrackingEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermEmailCommunicationServiceDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The from_sender_domain attribute.
    /// </summary>
    [TerraformProperty("from_sender_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FromSenderDomain { get; }

    /// <summary>
    /// The mail_from_sender_domain attribute.
    /// </summary>
    [TerraformProperty("mail_from_sender_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MailFromSenderDomain { get; }

    /// <summary>
    /// The verification_records attribute.
    /// </summary>
    [TerraformProperty("verification_records")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VerificationRecords { get; }

}
