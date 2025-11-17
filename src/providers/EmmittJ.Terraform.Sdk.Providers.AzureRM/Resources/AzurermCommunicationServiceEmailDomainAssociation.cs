using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCommunicationServiceEmailDomainAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_communication_service_email_domain_association Terraform resource.
/// Manages a azurerm_communication_service_email_domain_association resource.
/// </summary>
public partial class AzurermCommunicationServiceEmailDomainAssociation(string name) : TerraformResource("azurerm_communication_service_email_domain_association", name)
{
    /// <summary>
    /// The communication_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommunicationServiceId is required")]
    public required TerraformValue<string> CommunicationServiceId
    {
        get => new TerraformReference<string>(this, "communication_service_id");
        set => SetArgument("communication_service_id", value);
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceDomainId is required")]
    public required TerraformValue<string> EmailServiceDomainId
    {
        get => new TerraformReference<string>(this, "email_service_domain_id");
        set => SetArgument("email_service_domain_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
