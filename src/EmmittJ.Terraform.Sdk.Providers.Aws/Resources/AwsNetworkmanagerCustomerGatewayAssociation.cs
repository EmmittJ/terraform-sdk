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
    public TerraformLiteralProperty<string>? CustomerGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_gateway_arn");
        set => this.WithProperty("customer_gateway_arn", value);
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeviceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_id");
        set => this.WithProperty("device_id", value);
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
    /// The link_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LinkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("link_id");
        set => this.WithProperty("link_id", value);
    }

}
