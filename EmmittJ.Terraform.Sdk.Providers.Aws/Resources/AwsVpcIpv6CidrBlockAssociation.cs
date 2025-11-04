using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipv6_cidr_block_association resource.
/// </summary>
public class AwsVpcIpv6CidrBlockAssociation : TerraformResource
{
    public AwsVpcIpv6CidrBlockAssociation(string name) : base("aws_vpc_ipv6_cidr_block_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ip_source");
        this.DeclareOutput("ipv6_address_attribute");
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public bool? AssignGeneratedIpv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assign_generated_ipv6_cidr_block")?.Value;
        set => this.WithProperty("assign_generated_ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public string? Ipv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block")?.Value;
        set => this.WithProperty("ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public string? Ipv6IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_ipam_pool_id")?.Value;
        set => this.WithProperty("ipv6_ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public double? Ipv6NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_netmask_length")?.Value;
        set => this.WithProperty("ipv6_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ipv6_pool attribute.
    /// </summary>
    public string? Ipv6Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_pool")?.Value;
        set => this.WithProperty("ipv6_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_source attribute.
    /// </summary>
    public TerraformExpression IpSource => this["ip_source"];

    /// <summary>
    /// The ipv6_address_attribute attribute.
    /// </summary>
    public TerraformExpression Ipv6AddressAttribute => this["ipv6_address_attribute"];

}
