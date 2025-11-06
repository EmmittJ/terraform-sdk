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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    public string? NatGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nat_gateway_id")?.Value;
        set => this.WithProperty("nat_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
