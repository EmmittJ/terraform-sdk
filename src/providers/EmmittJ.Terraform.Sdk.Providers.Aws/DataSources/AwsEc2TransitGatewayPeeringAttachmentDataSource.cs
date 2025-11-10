using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentDataSourceFilterBlock : TerraformBlock
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
public class AwsEc2TransitGatewayPeeringAttachmentDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_ec2_transit_gateway_peering_attachment.
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayPeeringAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_peering_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("peer_account_id");
        this.WithOutput("peer_region");
        this.WithOutput("peer_transit_gateway_id");
        this.WithOutput("state");
        this.WithOutput("transit_gateway_id");
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2TransitGatewayPeeringAttachmentDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2TransitGatewayPeeringAttachmentDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2TransitGatewayPeeringAttachmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2TransitGatewayPeeringAttachmentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

}
