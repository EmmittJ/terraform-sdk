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
    public TerraformProperty<string>? ClientVpnEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("client_vpn_endpoint_id");
        set => this.WithProperty("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("destination_cidr_block");
        set => this.WithProperty("destination_cidr_block", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_vpc_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVpcSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("target_vpc_subnet_id");
        set => this.WithProperty("target_vpc_subnet_id", value);
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
