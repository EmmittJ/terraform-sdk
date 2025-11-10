using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpn_gateway_attachment resource.
/// </summary>
public class AwsVpnGatewayAttachment : TerraformResource
{
    public AwsVpnGatewayAttachment(string name) : base("aws_vpn_gateway_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformProperty<string> VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

}
