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
public class AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_communication_service_email_domain_association resource.
/// </summary>
public class AzurermCommunicationServiceEmailDomainAssociation : TerraformResource
{
    public AzurermCommunicationServiceEmailDomainAssociation(string name) : base("azurerm_communication_service_email_domain_association", name)
    {
    }

    /// <summary>
    /// The communication_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommunicationServiceId is required")]
    [TerraformArgument("communication_service_id")]
    public required TerraformValue<string> CommunicationServiceId
    {
        get => new TerraformReference<string>(this, "communication_service_id");
        set => SetArgument("communication_service_id", value);
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceDomainId is required")]
    [TerraformArgument("email_service_domain_id")]
    public required TerraformValue<string> EmailServiceDomainId
    {
        get => new TerraformReference<string>(this, "email_service_domain_id");
        set => SetArgument("email_service_domain_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
