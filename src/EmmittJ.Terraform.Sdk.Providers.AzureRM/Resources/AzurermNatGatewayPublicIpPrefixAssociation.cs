using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_nat_gateway_public_ip_prefix_association resource.
/// </summary>
public class AzurermNatGatewayPublicIpPrefixAssociation : TerraformResource
{
    public AzurermNatGatewayPublicIpPrefixAssociation(string name) : base("azurerm_nat_gateway_public_ip_prefix_association", name)
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
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public string? PublicIpPrefixId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_prefix_id")?.Value;
        set => this.WithProperty("public_ip_prefix_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
