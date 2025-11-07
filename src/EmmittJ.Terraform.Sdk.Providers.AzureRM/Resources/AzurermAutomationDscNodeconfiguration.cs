using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_dsc_nodeconfiguration resource.
/// </summary>
public class AzurermAutomationDscNodeconfiguration : TerraformResource
{
    public AzurermAutomationDscNodeconfiguration(string name) : base("azurerm_automation_dsc_nodeconfiguration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("configuration_name");
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
    /// The content_embedded attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentEmbedded
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_embedded");
        set => this.WithProperty("content_embedded", value);
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
    /// The configuration_name attribute.
    /// </summary>
    public TerraformExpression ConfigurationName => this["configuration_name"];

}
