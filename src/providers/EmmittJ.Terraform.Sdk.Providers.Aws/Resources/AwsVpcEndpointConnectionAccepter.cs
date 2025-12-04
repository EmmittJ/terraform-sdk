using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_endpoint_connection_accepter Terraform resource.
/// Manages a aws_vpc_endpoint_connection_accepter resource.
/// </summary>
public partial class AwsVpcEndpointConnectionAccepter(string name) : TerraformResource("aws_vpc_endpoint_connection_accepter", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformValue<string> VpcEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointServiceId is required")]
    public required TerraformValue<string> VpcEndpointServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_endpoint_service_id");
        set => SetArgument("vpc_endpoint_service_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_state attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointState
        => AsReference("vpc_endpoint_state");

}
