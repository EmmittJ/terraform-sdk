using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsNatGatewayDataSource.
/// Nesting mode: set
/// </summary>
public class AwsNatGatewayDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsNatGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AwsNatGatewayDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_nat_gateway Terraform data source.
/// Retrieves information about a aws_nat_gateway.
/// </summary>
public partial class AwsNatGatewayDataSource(string name) : TerraformDataSource("aws_nat_gateway", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state") ?? AsReference("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id") ?? AsReference("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id") ?? AsReference("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string> AllocationId
        => AsReference("allocation_id");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => AsReference("association_id");

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformValue<string> ConnectivityType
        => AsReference("connectivity_type");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => AsReference("network_interface_id");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
        => AsReference("private_ip");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformValue<string> PublicIp
        => AsReference("public_ip");

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public TerraformList<string> SecondaryAllocationIds
        => AsReference("secondary_allocation_ids");

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformValue<double> SecondaryPrivateIpAddressCount
        => AsReference("secondary_private_ip_address_count");

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> SecondaryPrivateIpAddresses
        => AsReference("secondary_private_ip_addresses");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNatGatewayDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsNatGatewayDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNatGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNatGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
