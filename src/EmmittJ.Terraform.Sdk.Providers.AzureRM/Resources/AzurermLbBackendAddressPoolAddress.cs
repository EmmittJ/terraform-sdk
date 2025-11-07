using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lb_backend_address_pool_address resource.
/// </summary>
public class AzurermLbBackendAddressPoolAddress : TerraformResource
{
    public AzurermLbBackendAddressPoolAddress(string name) : base("azurerm_lb_backend_address_pool_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("inbound_nat_rule_port_mapping");
    }

    /// <summary>
    /// For global load balancer, user needs to specify the `backend_address_ip_configuration_id` of the added regional load balancers
    /// </summary>
    public TerraformProperty<string>? BackendAddressIpConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("backend_address_ip_configuration_id");
        set => this.WithProperty("backend_address_ip_configuration_id", value);
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackendAddressPoolId
    {
        get => GetProperty<TerraformProperty<string>>("backend_address_pool_id");
        set => this.WithProperty("backend_address_pool_id", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The inbound_nat_rule_port_mapping attribute.
    /// </summary>
    public TerraformExpression InboundNatRulePortMapping => this["inbound_nat_rule_port_mapping"];

}
