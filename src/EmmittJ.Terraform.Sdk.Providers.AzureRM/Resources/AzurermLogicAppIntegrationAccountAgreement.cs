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
    public string? AgreementType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agreement_type")?.Value;
        set => this.WithProperty("agreement_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public string? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content")?.Value;
        set => this.WithProperty("content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The guest_partner_name attribute.
    /// </summary>
    public string? GuestPartnerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("guest_partner_name")?.Value;
        set => this.WithProperty("guest_partner_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_partner_name attribute.
    /// </summary>
    public string? HostPartnerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_partner_name")?.Value;
        set => this.WithProperty("host_partner_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_account_name attribute.
    /// </summary>
    public string? IntegrationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_account_name")?.Value;
        set => this.WithProperty("integration_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
