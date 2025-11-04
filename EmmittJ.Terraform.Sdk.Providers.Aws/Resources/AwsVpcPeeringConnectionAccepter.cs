using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_peering_connection_accepter resource.
/// </summary>
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
    public bool? AutoAccept
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_accept")?.Value;
        set => this.WithProperty("auto_accept", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public string? VpcPeeringConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_peering_connection_id")?.Value;
        set => this.WithProperty("vpc_peering_connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
