using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcPeeringConnectionDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcPeeringConnectionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_vpc_peering_connection.
/// </summary>
public class AwsVpcPeeringConnectionDataSource : TerraformDataSource
{
    public AwsVpcPeeringConnectionDataSource(string name) : base("aws_vpc_peering_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("accepter");
        SetOutput("cidr_block_set");
        SetOutput("ipv6_cidr_block_set");
        SetOutput("peer_cidr_block_set");
        SetOutput("peer_ipv6_cidr_block_set");
        SetOutput("peer_region");
        SetOutput("region");
        SetOutput("requester");
        SetOutput("requester_region");
        SetOutput("cidr_block");
        SetOutput("id");
        SetOutput("owner_id");
        SetOutput("peer_cidr_block");
        SetOutput("peer_owner_id");
        SetOutput("peer_vpc_id");
        SetOutput("status");
        SetOutput("tags");
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
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string> OwnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_id");
        set => SetProperty("owner_id", value);
    }

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> PeerCidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_cidr_block");
        set => SetProperty("peer_cidr_block", value);
    }

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformProperty<string> PeerOwnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_owner_id");
        set => SetProperty("peer_owner_id", value);
    }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> PeerVpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_vpc_id");
        set => SetProperty("peer_vpc_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcPeeringConnectionDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcPeeringConnectionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The accepter attribute.
    /// </summary>
    public TerraformExpression Accepter => this["accepter"];

    /// <summary>
    /// The cidr_block_set attribute.
    /// </summary>
    public TerraformExpression CidrBlockSet => this["cidr_block_set"];

    /// <summary>
    /// The ipv6_cidr_block_set attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlockSet => this["ipv6_cidr_block_set"];

    /// <summary>
    /// The peer_cidr_block_set attribute.
    /// </summary>
    public TerraformExpression PeerCidrBlockSet => this["peer_cidr_block_set"];

    /// <summary>
    /// The peer_ipv6_cidr_block_set attribute.
    /// </summary>
    public TerraformExpression PeerIpv6CidrBlockSet => this["peer_ipv6_cidr_block_set"];

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformExpression PeerRegion => this["peer_region"];

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The requester attribute.
    /// </summary>
    public TerraformExpression Requester => this["requester"];

    /// <summary>
    /// The requester_region attribute.
    /// </summary>
    public TerraformExpression RequesterRegion => this["requester_region"];

}
