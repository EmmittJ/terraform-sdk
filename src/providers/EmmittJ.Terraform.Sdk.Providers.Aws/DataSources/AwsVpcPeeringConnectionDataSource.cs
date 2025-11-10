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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("accepter");
        this.WithOutput("cidr_block_set");
        this.WithOutput("ipv6_cidr_block_set");
        this.WithOutput("peer_cidr_block_set");
        this.WithOutput("peer_ipv6_cidr_block_set");
        this.WithOutput("peer_region");
        this.WithOutput("region");
        this.WithOutput("requester");
        this.WithOutput("requester_region");
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => this.WithProperty("cidr_block", value);
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
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerId
    {
        get => GetProperty<TerraformProperty<string>>("owner_id");
        set => this.WithProperty("owner_id", value);
    }

    /// <summary>
    /// The peer_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? PeerCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("peer_cidr_block");
        set => this.WithProperty("peer_cidr_block", value);
    }

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerOwnerId
    {
        get => GetProperty<TerraformProperty<string>>("peer_owner_id");
        set => this.WithProperty("peer_owner_id", value);
    }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerVpcId
    {
        get => GetProperty<TerraformProperty<string>>("peer_vpc_id");
        set => this.WithProperty("peer_vpc_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcPeeringConnectionDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsVpcPeeringConnectionDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcPeeringConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcPeeringConnectionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
