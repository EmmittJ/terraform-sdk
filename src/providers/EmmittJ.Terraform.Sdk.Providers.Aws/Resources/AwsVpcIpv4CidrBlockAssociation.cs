using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv4CidrBlockAssociationTimeoutsBlock : TerraformBlock
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
        SetOutput("cidr_block");
        SetOutput("id");
        SetOutput("ipv4_ipam_pool_id");
        SetOutput("ipv4_netmask_length");
        SetOutput("region");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr_block");
        set => SetProperty("cidr_block", value);
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
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> Ipv4IpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv4_ipam_pool_id");
        set => SetProperty("ipv4_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> Ipv4NetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv4_netmask_length");
        set => SetProperty("ipv4_netmask_length", value);
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
    public AwsVpcIpv4CidrBlockAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
