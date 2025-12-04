using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2ClientVpnRoute.
/// Nesting mode: single
/// </summary>
public class AwsEc2ClientVpnRouteTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ec2_client_vpn_route Terraform resource.
/// Manages a aws_ec2_client_vpn_route resource.
/// </summary>
public partial class AwsEc2ClientVpnRoute(string name) : TerraformResource("aws_ec2_client_vpn_route", name)
{
    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientVpnEndpointId is required")]
    public required TerraformValue<string> ClientVpnEndpointId
    {
        get => GetArgument<TerraformValue<string>>("client_vpn_endpoint_id");
        set => SetArgument("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    public required TerraformValue<string> DestinationCidrBlock
    {
        get => GetArgument<TerraformValue<string>>("destination_cidr_block");
        set => SetArgument("destination_cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The target_vpc_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVpcSubnetId is required")]
    public required TerraformValue<string> TargetVpcSubnetId
    {
        get => GetArgument<TerraformValue<string>>("target_vpc_subnet_id");
        set => SetArgument("target_vpc_subnet_id", value);
    }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformValue<string> Origin
        => AsReference("origin");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2ClientVpnRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2ClientVpnRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
