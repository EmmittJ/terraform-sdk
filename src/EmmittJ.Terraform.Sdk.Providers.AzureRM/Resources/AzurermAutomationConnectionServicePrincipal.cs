using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_connection_service_principal resource.
/// </summary>
public class AzurermAutomationConnectionServicePrincipal : TerraformResource
{
    public AzurermAutomationConnectionServicePrincipal(string name) : base("azurerm_automation_connection_service_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// The certificate_thumbprint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateThumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_thumbprint");
        set => this.WithProperty("certificate_thumbprint", value);
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
    /// The tenant_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
