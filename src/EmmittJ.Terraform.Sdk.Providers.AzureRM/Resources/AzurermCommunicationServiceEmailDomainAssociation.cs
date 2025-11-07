using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? CommunicationServiceId
    {
        get => GetProperty<TerraformProperty<string>>("communication_service_id");
        set => this.WithProperty("communication_service_id", value);
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    public TerraformProperty<string>? EmailServiceDomainId
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

}
