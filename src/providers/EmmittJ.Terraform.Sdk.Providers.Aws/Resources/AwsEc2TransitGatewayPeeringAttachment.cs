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
        set => SetProperty("dynamic_routing", value);
    }

}

/// <summary>
/// Manages a aws_ec2_transit_gateway_peering_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2TransitGatewayPeeringAttachment : TerraformResource
{
    public AwsEc2TransitGatewayPeeringAttachment(string name) : base("aws_ec2_transit_gateway_peering_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("state");
        SetOutput("id");
        SetOutput("peer_account_id");
        SetOutput("peer_region");
        SetOutput("peer_transit_gateway_id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_id");
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
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformProperty<string> PeerAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_account_id");
        set => SetProperty("peer_account_id", value);
    }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerRegion is required")]
    public required TerraformProperty<string> PeerRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_region");
        set => SetProperty("peer_region", value);
    }

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerTransitGatewayId is required")]
    public required TerraformProperty<string> PeerTransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_transit_gateway_id");
        set => SetProperty("peer_transit_gateway_id", value);
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
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_id");
        set => SetProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsEc2TransitGatewayPeeringAttachmentOptionsBlock>? Options
    {
        set => SetProperty("options", value);
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
