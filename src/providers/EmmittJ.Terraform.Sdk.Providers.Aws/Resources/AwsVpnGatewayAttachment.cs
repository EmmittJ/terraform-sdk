using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpn_gateway_attachment Terraform resource.
/// Manages a aws_vpn_gateway_attachment resource.
/// </summary>
public partial class AwsVpnGatewayAttachment(string name) : TerraformResource("aws_vpn_gateway_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformValue<string> VpnGatewayId
    {
        get => new TerraformReference<string>(this, "vpn_gateway_id");
        set => SetArgument("vpn_gateway_id", value);
    }

}
