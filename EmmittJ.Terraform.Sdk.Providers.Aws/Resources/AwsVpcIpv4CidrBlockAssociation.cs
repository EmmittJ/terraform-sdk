using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipv4_cidr_block_association resource.
/// </summary>
public class AwsVpcIpv4CidrBlockAssociation : TerraformResource
{
    public AwsVpcIpv4CidrBlockAssociation(string name) : base("aws_vpc_ipv4_cidr_block_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public string? CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_block")?.Value;
        set => this.WithProperty("cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    public string? Ipv4IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv4_ipam_pool_id")?.Value;
        set => this.WithProperty("ipv4_ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    public double? Ipv4NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv4_netmask_length")?.Value;
        set => this.WithProperty("ipv4_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
