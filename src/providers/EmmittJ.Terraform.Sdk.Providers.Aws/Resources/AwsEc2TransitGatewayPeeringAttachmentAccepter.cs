using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_peering_attachment_accepter resource.
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentAccepter : TerraformResource
{
    public AwsEc2TransitGatewayPeeringAttachmentAccepter(string name) : base("aws_ec2_transit_gateway_peering_attachment_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("peer_account_id");
        SetOutput("peer_region");
        SetOutput("peer_transit_gateway_id");
        SetOutput("transit_gateway_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_attachment_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformProperty<string> TransitGatewayAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => SetProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformExpression PeerAccountId => this["peer_account_id"];

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformExpression PeerRegion => this["peer_region"];

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression PeerTransitGatewayId => this["peer_transit_gateway_id"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

}
