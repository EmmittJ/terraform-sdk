using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("domain_management")]
    public required TerraformValue<string> DomainManagement
    {
        get => new TerraformReference<string>(this, "domain_management");
        set => SetArgument("domain_management", value);
    }

    /// <summary>
    /// The email_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceId is required")]
    [TerraformArgument("email_service_id")]
    public required TerraformValue<string> EmailServiceId
    {
        get => new TerraformReference<string>(this, "email_service_id");
        set => SetArgument("email_service_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_engagement_tracking_enabled attribute.
    /// </summary>
    [TerraformArgument("user_engagement_tracking_enabled")]
    public TerraformValue<bool>? UserEngagementTrackingEnabled
    {
        get => new TerraformReference<bool>(this, "user_engagement_tracking_enabled");
        set => SetArgument("user_engagement_tracking_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEmailCommunicationServiceDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The from_sender_domain attribute.
    /// </summary>
    [TerraformArgument("from_sender_domain")]
    public TerraformValue<string> FromSenderDomain
    {
        get => new TerraformReference<string>(this, "from_sender_domain");
    }

    /// <summary>
    /// The mail_from_sender_domain attribute.
    /// </summary>
    [TerraformArgument("mail_from_sender_domain")]
    public TerraformValue<string> MailFromSenderDomain
    {
        get => new TerraformReference<string>(this, "mail_from_sender_domain");
    }

    /// <summary>
    /// The verification_records attribute.
    /// </summary>
    [TerraformArgument("verification_records")]
    public TerraformList<object> VerificationRecords
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "verification_records").ResolveNodes(ctx));
    }

}
