using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_integration_account_agreement resource.
/// </summary>
public class AzurermLogicAppIntegrationAccountAgreement : TerraformResource
{
    public AzurermLogicAppIntegrationAccountAgreement(string name) : base("azurerm_logic_app_integration_account_agreement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The agreement_type attribute.
    /// </summary>
    public TerraformProperty<string>? AgreementType
    {
        get => GetProperty<TerraformProperty<string>>("agreement_type");
        set => this.WithProperty("agreement_type", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string>? Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The guest_partner_name attribute.
    /// </summary>
    public TerraformProperty<string>? GuestPartnerName
    {
        get => GetProperty<TerraformProperty<string>>("guest_partner_name");
        set => this.WithProperty("guest_partner_name", value);
    }

    /// <summary>
    /// The host_partner_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostPartnerName
    {
        get => GetProperty<TerraformProperty<string>>("host_partner_name");
        set => this.WithProperty("host_partner_name", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
