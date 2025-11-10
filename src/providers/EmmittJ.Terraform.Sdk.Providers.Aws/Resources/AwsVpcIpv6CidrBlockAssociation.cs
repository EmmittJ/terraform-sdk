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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("ip_source");
        SetOutput("ipv6_address_attribute");
        SetOutput("assign_generated_ipv6_cidr_block");
        SetOutput("id");
        SetOutput("ipv6_cidr_block");
        SetOutput("ipv6_ipam_pool_id");
        SetOutput("ipv6_netmask_length");
        SetOutput("ipv6_pool");
        SetOutput("region");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<bool> AssignGeneratedIpv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("assign_generated_ipv6_cidr_block");
        set => SetProperty("assign_generated_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_cidr_block");
        set => SetProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6IpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_ipam_pool_id");
        set => SetProperty("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> Ipv6NetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv6_netmask_length");
        set => SetProperty("ipv6_netmask_length", value);
    }

    /// <summary>
    /// The ipv6_pool attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6Pool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_pool");
        set => SetProperty("ipv6_pool", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcIpv6CidrBlockAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
