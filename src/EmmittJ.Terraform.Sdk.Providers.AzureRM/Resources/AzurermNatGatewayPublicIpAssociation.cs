using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_nat_gateway_public_ip_association resource.
/// </summary>
public class AzurermNatGatewayPublicIpAssociation : TerraformResource
{
    public AzurermNatGatewayPublicIpAssociation(string name) : base("azurerm_nat_gateway_public_ip_association", name)
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
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_address_id");
        set => this.WithProperty("public_ip_address_id", value);
    }

}
