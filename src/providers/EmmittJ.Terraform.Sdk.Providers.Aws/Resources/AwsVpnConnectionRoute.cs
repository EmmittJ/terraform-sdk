using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpn_connection_route Terraform resource.
/// Manages a aws_vpn_connection_route resource.
/// </summary>
public partial class AwsVpnConnectionRoute(string name) : TerraformResource("aws_vpn_connection_route", name)
{
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
    /// The vpn_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnConnectionId is required")]
    public required TerraformValue<string> VpnConnectionId
    {
        get => GetArgument<TerraformValue<string>>("vpn_connection_id");
        set => SetArgument("vpn_connection_id", value);
    }

}
