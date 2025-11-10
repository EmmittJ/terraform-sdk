using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The dynamic_routing attribute.
    /// </summary>
    public TerraformProperty<string>? DynamicRouting
    {
        get => GetProperty<TerraformProperty<string>>("dynamic_routing");
        set => WithProperty("dynamic_routing", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerRegion is required")]
    public required TerraformProperty<string> PeerRegion
    {
        get => GetProperty<TerraformProperty<string>>("peer_region");
        set => this.WithProperty("peer_region", value);
    }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerTransitGatewayId is required")]
    public required TerraformProperty<string> PeerTransitGatewayId
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
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformProperty<string> TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsEc2TransitGatewayPeeringAttachmentOptionsBlock>? Options
    {
        get => GetProperty<List<AwsEc2TransitGatewayPeeringAttachmentOptionsBlock>>("options");
        set => this.WithProperty("options", value);
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
