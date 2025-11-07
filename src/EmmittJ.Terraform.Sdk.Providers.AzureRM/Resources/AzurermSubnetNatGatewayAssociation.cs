using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subnet_nat_gateway_association resource.
/// </summary>
public class AzurermSubnetNatGatewayAssociation : TerraformResource
{
    public AzurermSubnetNatGatewayAssociation(string name) : base("azurerm_subnet_nat_gateway_association", name)
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
    /// The nat_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? NatGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("nat_gateway_id");
        set => this.WithProperty("nat_gateway_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

}
