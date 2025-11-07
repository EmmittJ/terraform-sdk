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
    public TerraformProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => this.WithProperty("cidr_block", value);
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
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv4IpamPoolId
    {
        get => GetProperty<TerraformProperty<string>>("ipv4_ipam_pool_id");
        set => this.WithProperty("ipv4_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv4NetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("ipv4_netmask_length");
        set => this.WithProperty("ipv4_netmask_length", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

}
