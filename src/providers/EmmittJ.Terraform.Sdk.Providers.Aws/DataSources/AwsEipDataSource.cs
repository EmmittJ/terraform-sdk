using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEipDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEipDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEipDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEipDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_eip Terraform data source.
/// Retrieves information about a aws_eip.
/// </summary>
public partial class AwsEipDataSource(string name) : TerraformDataSource("aws_eip", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => GetArgument<TerraformValue<string>>("public_ip") ?? AsReference("public_ip");
        set => SetArgument("public_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => AsReference("association_id");

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformValue<string> CarrierIp
        => AsReference("carrier_ip");

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIp
        => AsReference("customer_owned_ip");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIpv4Pool
        => AsReference("customer_owned_ipv4_pool");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
        => AsReference("instance_id");

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string> IpamPoolId
        => AsReference("ipam_pool_id");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => AsReference("network_interface_id");

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceOwnerId
        => AsReference("network_interface_owner_id");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformValue<string> PrivateDns
        => AsReference("private_dns");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
        => AsReference("private_ip");

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformValue<string> PtrRecord
        => AsReference("ptr_record");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformValue<string> PublicDns
        => AsReference("public_dns");

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> PublicIpv4Pool
        => AsReference("public_ipv4_pool");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEipDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEipDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEipDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEipDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
