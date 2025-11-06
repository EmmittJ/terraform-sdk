using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_customer_gateway_association resource.
/// </summary>
public class AwsNetworkmanagerCustomerGatewayAssociation : TerraformResource
{
    public AwsNetworkmanagerCustomerGatewayAssociation(string name) : base("aws_networkmanager_customer_gateway_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The customer_gateway_arn attribute.
    /// </summary>
    public string? CustomerGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_gateway_arn")?.Value;
        set => this.WithProperty("customer_gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    public string? DeviceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_id")?.Value;
        set => this.WithProperty("device_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The link_id attribute.
    /// </summary>
    public string? LinkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("link_id")?.Value;
        set => this.WithProperty("link_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
