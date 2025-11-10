using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionAccepterAccepterBlock : TerraformBlock
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
public class AwsVpcPeeringConnectionAccepterRequesterBlock : TerraformBlock
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
public class AwsVpcPeeringConnectionAccepterTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_vpc_peering_connection_accepter resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcPeeringConnectionAccepter : TerraformResource
{
    public AwsVpcPeeringConnectionAccepter(string name) : base("aws_vpc_peering_connection_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accept_status");
        this.DeclareOutput("peer_owner_id");
        this.DeclareOutput("peer_region");
        this.DeclareOutput("peer_vpc_id");
        this.DeclareOutput("vpc_id");
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
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConnectionId is required")]
    public required TerraformProperty<string> VpcPeeringConnectionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpc_peering_connection_id");
        set => this.WithProperty("vpc_peering_connection_id", value);
    }

    /// <summary>
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    public List<AwsVpcPeeringConnectionAccepterAccepterBlock>? Accepter
    {
        get => GetProperty<List<AwsVpcPeeringConnectionAccepterAccepterBlock>>("accepter");
        set => this.WithProperty("accepter", value);
    }

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    public List<AwsVpcPeeringConnectionAccepterRequesterBlock>? Requester
    {
        get => GetProperty<List<AwsVpcPeeringConnectionAccepterRequesterBlock>>("requester");
        set => this.WithProperty("requester", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcPeeringConnectionAccepterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcPeeringConnectionAccepterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The accept_status attribute.
    /// </summary>
    public TerraformExpression AcceptStatus => this["accept_status"];

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    public TerraformExpression PeerOwnerId => this["peer_owner_id"];

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformExpression PeerRegion => this["peer_region"];

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    public TerraformExpression PeerVpcId => this["peer_vpc_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
