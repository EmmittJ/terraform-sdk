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
    public string? GlobalNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_network_id")?.Value;
        set => this.WithProperty("global_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The transit_gateway_arn attribute.
    /// </summary>
    public string? TransitGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_arn")?.Value;
        set => this.WithProperty("transit_gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
