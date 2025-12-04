using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_local_gateway_route Terraform resource.
/// Manages a aws_ec2_local_gateway_route resource.
/// </summary>
public partial class AwsEc2LocalGatewayRoute(string name) : TerraformResource("aws_ec2_local_gateway_route", name)
{
    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    public required TerraformValue<string> DestinationCidrBlock
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_cidr_block");
        set => SetArgument("destination_cidr_block", value);
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
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayRouteTableId is required")]
    public required TerraformValue<string> LocalGatewayRouteTableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("local_gateway_route_table_id");
        set => SetArgument("local_gateway_route_table_id", value);
    }

    /// <summary>
    /// The local_gateway_virtual_interface_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayVirtualInterfaceGroupId is required")]
    public required TerraformValue<string> LocalGatewayVirtualInterfaceGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("local_gateway_virtual_interface_group_id");
        set => SetArgument("local_gateway_virtual_interface_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
