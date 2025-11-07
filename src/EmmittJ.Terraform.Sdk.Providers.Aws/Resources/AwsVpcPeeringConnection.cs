using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? PeerVpcId
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
    /// The accept_status attribute.
    /// </summary>
    public TerraformExpression AcceptStatus => this["accept_status"];

}
