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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_configuration_name attribute.
    /// </summary>
    public string? IpConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_configuration_name")?.Value;
        set => this.WithProperty("ip_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nat_rule_id attribute.
    /// </summary>
    public string? NatRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nat_rule_id")?.Value;
        set => this.WithProperty("nat_rule_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
