using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_connection_certificate resource.
/// </summary>
public class AzurermAutomationConnectionCertificate : TerraformResource
{
    public AzurermAutomationConnectionCertificate(string name) : base("azurerm_automation_connection_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    public string? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name")?.Value;
        set => this.WithProperty("automation_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The automation_certificate_name attribute.
    /// </summary>
    public string? AutomationCertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_certificate_name")?.Value;
        set => this.WithProperty("automation_certificate_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
