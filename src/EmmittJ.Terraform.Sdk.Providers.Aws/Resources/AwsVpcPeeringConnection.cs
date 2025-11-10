using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionAccepterBlock : TerraformBlock
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowRemoteVpcDnsResolution
    {
        get => GetProperty<TerraformProperty<bool>>("allow_remote_vpc_dns_resolution");
        set => WithProperty("allow_remote_vpc_dns_resolution", value);
    }

}

/// <summary>
/// Block type for requester in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionRequesterBlock : TerraformBlock
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowRemoteVpcDnsResolution
    {
        get => GetProperty<TerraformProperty<bool>>("allow_remote_vpc_dns_resolution");
        set => WithProperty("allow_remote_vpc_dns_resolution", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcPeeringConnectionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_vpc_peering_connection resource.
/// </summary>
public class AwsVpcPeeringConnection : TerraformResource
{
    public AwsVpcPeeringConnection(string name) : base("aws_vpc_peering_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accept_status");
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoAccept
    {
        get => GetProperty<TerraformProperty<bool>>("auto_accept");
        set => this.WithProperty("auto_accept", value);
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
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerOwnerId
    {
        get => GetProperty<TerraformProperty<string>>("peer_owner_id");
        set => this.WithProperty("peer_owner_id", value);
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformProperty<string>? PeerRegion
    {
        get => GetProperty<TerraformProperty<string>>("peer_region");
        set => this.WithProperty("peer_region", value);
    }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerVpcId is required")]
    public required TerraformProperty<string> PeerVpcId
    {
        get => GetProperty<TerraformProperty<string>>("peer_vpc_id");
        set => this.WithProperty("peer_vpc_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    public List<AwsVpcPeeringConnectionAccepterBlock>? Accepter
    {
        get => GetProperty<List<AwsVpcPeeringConnectionAccepterBlock>>("accepter");
        set => this.WithProperty("accepter", value);
    }

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    public List<AwsVpcPeeringConnectionRequesterBlock>? Requester
    {
        get => GetProperty<List<AwsVpcPeeringConnectionRequesterBlock>>("requester");
        set => this.WithProperty("requester", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcPeeringConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcPeeringConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The accept_status attribute.
    /// </summary>
    public TerraformExpression AcceptStatus => this["accept_status"];

}
