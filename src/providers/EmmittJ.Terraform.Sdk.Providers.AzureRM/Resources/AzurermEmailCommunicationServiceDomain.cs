using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
        get => new TerraformReference<string>(this, "domain_management");
        set => SetArgument("domain_management", value);
    }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceId is required")]
    public required TerraformValue<string> EmailServiceId
    {
        get => new TerraformReference<string>(this, "email_service_id");
        set => SetArgument("email_service_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserEngagementTrackingEnabled
    {
        get => new TerraformReference<bool>(this, "user_engagement_tracking_enabled");
        set => SetArgument("user_engagement_tracking_enabled", value);
    }

    /// <summary>
    /// The from_sender_domain attribute.
    /// </summary>
    public TerraformValue<string> FromSenderDomain
    {
        get => new TerraformReference<string>(this, "from_sender_domain");
    }

    /// <summary>
    /// The mail_from_sender_domain attribute.
    /// </summary>
    public TerraformValue<string> MailFromSenderDomain
    {
        get => new TerraformReference<string>(this, "mail_from_sender_domain");
    }

    /// <summary>
    /// The verification_records attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VerificationRecords
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "verification_records").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEmailCommunicationServiceDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEmailCommunicationServiceDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
