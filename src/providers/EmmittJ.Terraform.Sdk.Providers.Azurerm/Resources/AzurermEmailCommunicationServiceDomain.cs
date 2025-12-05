using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEmailCommunicationServiceDomain.
/// Nesting mode: single
/// </summary>
public class AzurermEmailCommunicationServiceDomainTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_email_communication_service_domain Terraform resource.
/// Manages a azurerm_email_communication_service_domain resource.
/// </summary>
public partial class AzurermEmailCommunicationServiceDomain(string name) : TerraformResource("azurerm_email_communication_service_domain", name)
{
    /// <summary>
    /// The domain_management attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainManagement is required")]
    public required TerraformValue<string> DomainManagement
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_management");
        set => SetArgument("domain_management", value);
    }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceId is required")]
    public required TerraformValue<string> EmailServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("email_service_id");
        set => SetArgument("email_service_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserEngagementTrackingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("user_engagement_tracking_enabled");
        set => SetArgument("user_engagement_tracking_enabled", value);
    }

    /// <summary>
    /// The from_sender_domain attribute.
    /// </summary>
    public TerraformValue<string> FromSenderDomain
        => CreateReference("from_sender_domain");

    /// <summary>
    /// The mail_from_sender_domain attribute.
    /// </summary>
    public TerraformValue<string> MailFromSenderDomain
        => CreateReference("mail_from_sender_domain");

    /// <summary>
    /// The verification_records attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VerificationRecords
        => CreateReference("verification_records");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEmailCommunicationServiceDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEmailCommunicationServiceDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
