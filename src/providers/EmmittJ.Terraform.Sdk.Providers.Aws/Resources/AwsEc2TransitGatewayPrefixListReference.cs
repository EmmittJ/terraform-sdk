using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_prefix_list_reference resource.
/// </summary>
public class AwsEc2TransitGatewayPrefixListReference : TerraformResource
{
    public AwsEc2TransitGatewayPrefixListReference(string name) : base("aws_ec2_transit_gateway_prefix_list_reference", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("prefix_list_owner_id");
    }

    /// <summary>
    /// The blackhole attribute.
    /// </summary>
    public TerraformProperty<bool>? Blackhole
    {
        get => GetProperty<TerraformProperty<bool>>("blackhole");
        set => this.WithProperty("blackhole", value);
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
    /// The prefix_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListId is required")]
    public required TerraformProperty<string> PrefixListId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("prefix_list_id");
        set => this.WithProperty("prefix_list_id", value);
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableId is required")]
    public required TerraformProperty<string> TransitGatewayRouteTableId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("transit_gateway_route_table_id");
        set => this.WithProperty("transit_gateway_route_table_id", value);
    }

    /// <summary>
    /// The prefix_list_owner_id attribute.
    /// </summary>
    public TerraformExpression PrefixListOwnerId => this["prefix_list_owner_id"];

}
