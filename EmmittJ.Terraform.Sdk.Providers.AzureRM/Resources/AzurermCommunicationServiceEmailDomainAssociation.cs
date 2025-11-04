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
    public string? CommunicationServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("communication_service_id")?.Value;
        set => this.WithProperty("communication_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    public string? EmailServiceDomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_service_domain_id")?.Value;
        set => this.WithProperty("email_service_domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
