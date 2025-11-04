using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_client_vpn_route resource.
/// </summary>
public class AwsEc2ClientVpnRoute : TerraformResource
{
    public AwsEc2ClientVpnRoute(string name) : base("aws_ec2_client_vpn_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("origin");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public string? ClientVpnEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_vpn_endpoint_id")?.Value;
        set => this.WithProperty("client_vpn_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public string? DestinationCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_cidr_block")?.Value;
        set => this.WithProperty("destination_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_vpc_subnet_id attribute.
    /// </summary>
    public string? TargetVpcSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_vpc_subnet_id")?.Value;
        set => this.WithProperty("target_vpc_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformExpression Origin => this["origin"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
