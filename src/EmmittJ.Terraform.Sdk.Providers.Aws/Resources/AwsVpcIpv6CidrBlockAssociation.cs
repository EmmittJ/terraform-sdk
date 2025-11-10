using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv6CidrBlockAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    public TerraformProperty<bool>? AssignGeneratedIpv6CidrBlock
    {
        get => GetProperty<TerraformProperty<bool>>("assign_generated_ipv6_cidr_block");
        set => this.WithProperty("assign_generated_ipv6_cidr_block", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_cidr_block");
        set => this.WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6IpamPoolId
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_ipam_pool_id");
        set => this.WithProperty("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6NetmaskLength
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_netmask_length");
        set => this.WithProperty("ipv6_netmask_length", value);
    }

    /// <summary>
    /// The ipv6_pool attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6Pool
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_pool");
        set => this.WithProperty("ipv6_pool", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpv6CidrBlockAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcIpv6CidrBlockAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
