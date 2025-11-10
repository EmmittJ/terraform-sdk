using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_route_table_propagation resource.
/// </summary>
public class AwsEc2TransitGatewayRouteTablePropagation : TerraformResource
{
    public AwsEc2TransitGatewayRouteTablePropagation(string name) : base("aws_ec2_transit_gateway_route_table_propagation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("resource_id");
        SetOutput("resource_type");
        SetOutput("id");
        SetOutput("region");
        SetOutput("transit_gateway_attachment_id");
        SetOutput("transit_gateway_route_table_id");
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformProperty<string> TransitGatewayAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => SetProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableId is required")]
    public required TerraformProperty<string> TransitGatewayRouteTableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_route_table_id");
        set => SetProperty("transit_gateway_route_table_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

}
