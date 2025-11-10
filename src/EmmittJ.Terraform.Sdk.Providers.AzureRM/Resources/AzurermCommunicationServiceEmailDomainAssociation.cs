using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_communication_service_email_domain_association resource.
/// </summary>
public class AzurermCommunicationServiceEmailDomainAssociation : TerraformResource
{
    public AzurermCommunicationServiceEmailDomainAssociation(string name) : base("azurerm_communication_service_email_domain_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The communication_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommunicationServiceId is required")]
    public required TerraformProperty<string> CommunicationServiceId
    {
        get => GetProperty<TerraformProperty<string>>("communication_service_id");
        set => this.WithProperty("communication_service_id", value);
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceDomainId is required")]
    public required TerraformProperty<string> EmailServiceDomainId
    {
        get => GetProperty<TerraformProperty<string>>("email_service_domain_id");
        set => this.WithProperty("email_service_domain_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
