using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcPeeringConnectionDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcPeeringConnectionDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsVpcPeeringConnectionDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpcPeeringConnectionDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpc_peering_connection Terraform data source.
/// Retrieves information about a aws_vpc_peering_connection.
/// </summary>
public partial class AwsVpcPeeringConnectionDataSource(string name) : TerraformDataSource("aws_vpc_peering_connection", name)
{
    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block") ?? CreateReference("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id") ?? CreateReference("owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> PeerCidrBlock
    {
        get => GetArgument<TerraformValue<string>>("peer_cidr_block") ?? CreateReference("peer_cidr_block");
        set => SetArgument("peer_cidr_block", value);
    }

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformValue<string> PeerOwnerId
    {
        get => GetArgument<TerraformValue<string>>("peer_owner_id") ?? CreateReference("peer_owner_id");
        set => SetArgument("peer_owner_id", value);
    }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    public TerraformValue<string> PeerVpcId
    {
        get => GetArgument<TerraformValue<string>>("peer_vpc_id") ?? CreateReference("peer_vpc_id");
        set => SetArgument("peer_vpc_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? CreateReference("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id") ?? CreateReference("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The accepter attribute.
    /// </summary>
    public TerraformMap<bool> Accepter
        => CreateReference("accepter");

    /// <summary>
    /// The cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CidrBlockSet
        => CreateReference("cidr_block_set");

    /// <summary>
    /// The ipv6_cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ipv6CidrBlockSet
        => CreateReference("ipv6_cidr_block_set");

    /// <summary>
    /// The peer_cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PeerCidrBlockSet
        => CreateReference("peer_cidr_block_set");

    /// <summary>
    /// The peer_ipv6_cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PeerIpv6CidrBlockSet
        => CreateReference("peer_ipv6_cidr_block_set");

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformValue<string> PeerRegion
        => CreateReference("peer_region");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
        => CreateReference("region");

    /// <summary>
    /// The requester attribute.
    /// </summary>
    public TerraformMap<bool> Requester
        => CreateReference("requester");

    /// <summary>
    /// The requester_region attribute.
    /// </summary>
    public TerraformValue<string> RequesterRegion
        => CreateReference("requester_region");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcPeeringConnectionDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcPeeringConnectionDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcPeeringConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcPeeringConnectionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
