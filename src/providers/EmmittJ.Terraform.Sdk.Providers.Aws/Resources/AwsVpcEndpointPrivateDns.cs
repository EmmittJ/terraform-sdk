using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_endpoint_private_dns Terraform resource.
/// Manages a aws_vpc_endpoint_private_dns resource.
/// </summary>
public partial class AwsVpcEndpointPrivateDns(string name) : TerraformResource("aws_vpc_endpoint_private_dns", name)
{
    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsEnabled is required")]
    public required TerraformValue<bool> PrivateDnsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_dns_enabled");
        set => SetArgument("private_dns_enabled", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformValue<string> VpcEndpointId
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

}
