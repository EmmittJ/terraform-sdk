using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_connection_classic_certificate resource.
/// </summary>
public class AzurermAutomationConnectionClassicCertificate : TerraformResource
{
    public AzurermAutomationConnectionClassicCertificate(string name) : base("azurerm_automation_connection_classic_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The certificate_asset_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateAssetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_asset_name");
        set => this.WithProperty("certificate_asset_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The subscription_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_name");
        set => this.WithProperty("subscription_name", value);
    }

}
