using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_peering_attachment resource.
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachment : TerraformResource
{
    public AwsEc2TransitGatewayPeeringAttachment(string name) : base("aws_ec2_transit_gateway_peering_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("state");
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
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerAccountId
    {
        get => GetProperty<TerraformProperty<string>>("peer_account_id");
        set => this.WithProperty("peer_account_id", value);
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
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerTransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("peer_transit_gateway_id");
        set => this.WithProperty("peer_transit_gateway_id", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
