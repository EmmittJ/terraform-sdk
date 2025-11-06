using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_network_gateway_nat_rule resource.
/// </summary>
public class AzurermVirtualNetworkGatewayNatRule : TerraformResource
{
    public AzurermVirtualNetworkGatewayNatRule(string name) : base("azurerm_virtual_network_gateway_nat_rule", name)
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
    /// The ip_configuration_id attribute.
    /// </summary>
    public string? IpConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_configuration_id")?.Value;
        set => this.WithProperty("ip_configuration_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public string? VirtualNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_gateway_id")?.Value;
        set => this.WithProperty("virtual_network_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
