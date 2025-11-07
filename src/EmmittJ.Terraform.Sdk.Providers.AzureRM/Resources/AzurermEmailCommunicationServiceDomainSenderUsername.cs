using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_email_communication_service_domain_sender_username resource.
/// </summary>
public class AzurermEmailCommunicationServiceDomainSenderUsername : TerraformResource
{
    public AzurermEmailCommunicationServiceDomainSenderUsername(string name) : base("azurerm_email_communication_service_domain_sender_username", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailServiceDomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_service_domain_id");
        set => this.WithProperty("email_service_domain_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
