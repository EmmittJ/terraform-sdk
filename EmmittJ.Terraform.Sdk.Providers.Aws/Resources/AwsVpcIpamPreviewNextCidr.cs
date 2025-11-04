using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_preview_next_cidr resource.
/// </summary>
public class AwsVpcIpamPreviewNextCidr : TerraformResource
{
    public AwsVpcIpamPreviewNextCidr(string name) : base("aws_vpc_ipam_preview_next_cidr", name)
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
    public HashSet<string>? DisallowedCidrs
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disallowed_cidrs")?.Value;
        set => this.WithProperty("disallowed_cidrs", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The ipam_pool_id attribute.
    /// </summary>
    public string? IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_pool_id")?.Value;
        set => this.WithProperty("ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    public double? NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("netmask_length")?.Value;
        set => this.WithProperty("netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The cidr attribute.
    /// </summary>
    public TerraformExpression Cidr => this["cidr"];

}
