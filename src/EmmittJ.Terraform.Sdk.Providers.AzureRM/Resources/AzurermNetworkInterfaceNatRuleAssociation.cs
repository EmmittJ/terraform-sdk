using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_interface_nat_rule_association resource.
/// </summary>
public class AzurermNetworkInterfaceNatRuleAssociation : TerraformResource
{
    public AzurermNetworkInterfaceNatRuleAssociation(string name) : base("azurerm_network_interface_nat_rule_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The ip_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? IpConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("ip_configuration_name");
        set => this.WithProperty("ip_configuration_name", value);
    }

    /// <summary>
    /// The nat_rule_id attribute.
    /// </summary>
    public TerraformProperty<string>? NatRuleId
    {
        get => GetProperty<TerraformProperty<string>>("nat_rule_id");
        set => this.WithProperty("nat_rule_id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

}
