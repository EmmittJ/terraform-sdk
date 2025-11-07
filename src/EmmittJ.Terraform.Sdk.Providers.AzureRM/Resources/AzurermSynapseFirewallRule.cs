using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_firewall_rule resource.
/// </summary>
public class AzurermSynapseFirewallRule : TerraformResource
{
    public AzurermSynapseFirewallRule(string name) : base("azurerm_synapse_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The end_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_ip_address");
        set => this.WithProperty("end_ip_address", value);
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
    /// The start_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_ip_address");
        set => this.WithProperty("start_ip_address", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

}
