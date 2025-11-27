using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in AwsVpcPeeringConnection.
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionAccepterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accepter";

    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformValue<bool>? AllowRemoteVpcDnsResolution
    {
        get => new TerraformReference<bool>(this, "allow_remote_vpc_dns_resolution");
        set => SetArgument("allow_remote_vpc_dns_resolution", value);
    }

}


/// <summary>
/// Block type for requester in AwsVpcPeeringConnection.
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionRequesterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requester";

    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformValue<bool>? AllowRemoteVpcDnsResolution
    {
        get => new TerraformReference<bool>(this, "allow_remote_vpc_dns_resolution");
        set => SetArgument("allow_remote_vpc_dns_resolution", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcPeeringConnection.
/// Nesting mode: single
/// </summary>
public class AwsVpcPeeringConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpc_peering_connection Terraform resource.
/// Manages a aws_vpc_peering_connection resource.
/// </summary>
public partial class AwsVpcPeeringConnection(string name) : TerraformResource("aws_vpc_peering_connection", name)
{
    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformValue<bool>? AutoAccept
    {
        get => new TerraformReference<bool>(this, "auto_accept");
        set => SetArgument("auto_accept", value);
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
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformValue<string> PeerOwnerId
    {
        get => new TerraformReference<string>(this, "peer_owner_id");
        set => SetArgument("peer_owner_id", value);
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformValue<string> PeerRegion
    {
        get => new TerraformReference<string>(this, "peer_region");
        set => SetArgument("peer_region", value);
    }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerVpcId is required")]
    public required TerraformValue<string> PeerVpcId
    {
        get => new TerraformReference<string>(this, "peer_vpc_id");
        set => SetArgument("peer_vpc_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The accept_status attribute.
    /// </summary>
    public TerraformValue<string> AcceptStatus
    {
        get => new TerraformReference<string>(this, "accept_status");
    }

    /// <summary>
    /// Accepter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    public TerraformList<AwsVpcPeeringConnectionAccepterBlock>? Accepter
    {
        get => GetArgument<TerraformList<AwsVpcPeeringConnectionAccepterBlock>>("accepter");
        set => SetArgument("accepter", value);
    }

    /// <summary>
    /// Requester block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    public TerraformList<AwsVpcPeeringConnectionRequesterBlock>? Requester
    {
        get => GetArgument<TerraformList<AwsVpcPeeringConnectionRequesterBlock>>("requester");
        set => SetArgument("requester", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcPeeringConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcPeeringConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
