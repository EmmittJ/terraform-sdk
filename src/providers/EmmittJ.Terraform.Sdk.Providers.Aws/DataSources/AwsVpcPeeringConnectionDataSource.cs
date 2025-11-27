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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> PeerCidrBlock
    {
        get => new TerraformReference<string>(this, "peer_cidr_block");
        set => SetArgument("peer_cidr_block", value);
    }

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformValue<string> PeerOwnerId
    {
        get => new TerraformReference<string>(this, "peer_owner_id");
        set => SetArgument("peer_owner_id", value);
    }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    public TerraformValue<string> PeerVpcId
    {
        get => new TerraformReference<string>(this, "peer_vpc_id");
        set => SetArgument("peer_vpc_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The accepter attribute.
    /// </summary>
    public TerraformMap<bool> Accepter
    {
        get => TerraformMap<bool>.Lazy(ctx => new TerraformReference<TerraformMap<bool>>(this, "accepter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CidrBlockSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cidr_block_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ipv6_cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ipv6CidrBlockSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ipv6_cidr_block_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The peer_cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PeerCidrBlockSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "peer_cidr_block_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The peer_ipv6_cidr_block_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PeerIpv6CidrBlockSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "peer_ipv6_cidr_block_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformValue<string> PeerRegion
    {
        get => new TerraformReference<string>(this, "peer_region");
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// The requester attribute.
    /// </summary>
    public TerraformMap<bool> Requester
    {
        get => TerraformMap<bool>.Lazy(ctx => new TerraformReference<TerraformMap<bool>>(this, "requester").ResolveNodes(ctx));
    }

    /// <summary>
    /// The requester_region attribute.
    /// </summary>
    public TerraformValue<string> RequesterRegion
    {
        get => new TerraformReference<string>(this, "requester_region");
    }

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
