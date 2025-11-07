using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_transit_gateway_registration resource.
/// </summary>
public class AwsNetworkmanagerTransitGatewayRegistration : TerraformResource
{
    public AwsNetworkmanagerTransitGatewayRegistration(string name) : base("aws_networkmanager_transit_gateway_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GlobalNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_network_id");
        set => this.WithProperty("global_network_id", value);
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
    /// The transit_gateway_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_arn");
        set => this.WithProperty("transit_gateway_arn", value);
    }

}
