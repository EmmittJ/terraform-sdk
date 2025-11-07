using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_pool_cidr resource.
/// </summary>
public class AwsVpcIpamPoolCidr : TerraformResource
{
    public AwsVpcIpamPoolCidr(string name) : base("aws_vpc_ipam_pool_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ipam_pool_cidr_id");
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
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
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? IpamPoolId
    {
        get => GetProperty<TerraformProperty<string>>("ipam_pool_id");
        set => this.WithProperty("ipam_pool_id", value);
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? NetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("netmask_length");
        set => this.WithProperty("netmask_length", value);
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
    /// The ipam_pool_cidr_id attribute.
    /// </summary>
    public TerraformExpression IpamPoolCidrId => this["ipam_pool_cidr_id"];

}
