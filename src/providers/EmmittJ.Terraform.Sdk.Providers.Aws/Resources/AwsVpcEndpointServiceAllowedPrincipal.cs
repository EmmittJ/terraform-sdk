using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_endpoint_service_allowed_principal Terraform resource.
/// Manages a aws_vpc_endpoint_service_allowed_principal resource.
/// </summary>
public partial class AwsVpcEndpointServiceAllowedPrincipal(string name) : TerraformResource("aws_vpc_endpoint_service_allowed_principal", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalArn is required")]
    public required TerraformValue<string> PrincipalArn
    {
        get => GetArgument<TerraformValue<string>>("principal_arn");
        set => SetArgument("principal_arn", value);
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
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointServiceId is required")]
    public required TerraformValue<string> VpcEndpointServiceId
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_service_id");
        set => SetArgument("vpc_endpoint_service_id", value);
    }

}
