using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_integration_account_certificate resource.
/// </summary>
public class AzurermLogicAppIntegrationAccountCertificate : TerraformResource
{
    public AzurermLogicAppIntegrationAccountCertificate(string name) : base("azurerm_logic_app_integration_account_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The integration_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The public_certificate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_certificate");
        set => this.WithProperty("public_certificate", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
