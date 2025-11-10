using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayAttachmentDataSourceFilterBlock : TerraformBlock
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
/// Retrieves information about a aws_ec2_transit_gateway_attachment.
/// </summary>
public class AwsEc2TransitGatewayAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("association_state");
        this.WithOutput("association_transit_gateway_route_table_id");
        this.WithOutput("resource_id");
        this.WithOutput("resource_owner_id");
        this.WithOutput("resource_type");
        this.WithOutput("state");
        this.WithOutput("transit_gateway_id");
        this.WithOutput("transit_gateway_owner_id");
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2TransitGatewayAttachmentDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2TransitGatewayAttachmentDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_state attribute.
    /// </summary>
    public TerraformExpression AssociationState => this["association_state"];

    /// <summary>
    /// The association_transit_gateway_route_table_id attribute.
    /// </summary>
    public TerraformExpression AssociationTransitGatewayRouteTableId => this["association_transit_gateway_route_table_id"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_owner_id attribute.
    /// </summary>
    public TerraformExpression ResourceOwnerId => this["resource_owner_id"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

    /// <summary>
    /// The transit_gateway_owner_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayOwnerId => this["transit_gateway_owner_id"];

}
