using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_ipam_preview_next_cidr.
/// </summary>
public class AwsVpcIpamPreviewNextCidrDataSource : TerraformDataSource
{
    public AwsVpcIpamPreviewNextCidrDataSource(string name) : base("aws_vpc_ipam_preview_next_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cidr");
    }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DisallowedCidrs
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disallowed_cidrs");
        set => this.WithProperty("disallowed_cidrs", value);
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
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_pool_id");
        set => this.WithProperty("ipam_pool_id", value);
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("netmask_length");
        set => this.WithProperty("netmask_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformExpression Cidr => this["cidr"];

}
