using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_ipam_pool_cidrs.
/// </summary>
public class AwsVpcIpamPoolCidrsDataSource : TerraformDataSource
{
    public AwsVpcIpamPoolCidrsDataSource(string name) : base("aws_vpc_ipam_pool_cidrs", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ipam_pool_cidrs");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The ipam_pool_cidrs attribute.
    /// </summary>
    public TerraformExpression IpamPoolCidrs => this["ipam_pool_cidrs"];

}
