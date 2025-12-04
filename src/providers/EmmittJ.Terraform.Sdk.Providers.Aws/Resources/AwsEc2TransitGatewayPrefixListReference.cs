using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_transit_gateway_prefix_list_reference Terraform resource.
/// Manages a aws_ec2_transit_gateway_prefix_list_reference resource.
/// </summary>
public partial class AwsEc2TransitGatewayPrefixListReference(string name) : TerraformResource("aws_ec2_transit_gateway_prefix_list_reference", name)
{
    /// <summary>
    /// The blackhole attribute.
    /// </summary>
    public TerraformValue<bool>? Blackhole
    {
        get => GetArgument<TerraformValue<bool>>("blackhole");
        set => SetArgument("blackhole", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListId is required")]
    public required TerraformValue<string> PrefixListId
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix_list_id");
        set => SetArgument("prefix_list_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableId is required")]
    public required TerraformValue<string> TransitGatewayRouteTableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("transit_gateway_route_table_id");
        set => SetArgument("transit_gateway_route_table_id", value);
    }

    /// <summary>
    /// The prefix_list_owner_id attribute.
    /// </summary>
    public TerraformValue<string> PrefixListOwnerId
        => AsReference("prefix_list_owner_id");

}
