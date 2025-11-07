using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("association_state");
        this.DeclareOutput("association_transit_gateway_route_table_id");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("resource_owner_id");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("state");
        this.DeclareOutput("transit_gateway_id");
        this.DeclareOutput("transit_gateway_owner_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
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
