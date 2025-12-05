using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_request_validator Terraform resource.
/// Manages a aws_api_gateway_request_validator resource.
/// </summary>
public partial class AwsApiGatewayRequestValidator(string name) : TerraformResource("aws_api_gateway_request_validator", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => GetRequiredArgument<TerraformValue<string>>("rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The validate_request_body attribute.
    /// </summary>
    public TerraformValue<bool>? ValidateRequestBody
    {
        get => GetArgument<TerraformValue<bool>>("validate_request_body");
        set => SetArgument("validate_request_body", value);
    }

    /// <summary>
    /// The validate_request_parameters attribute.
    /// </summary>
    public TerraformValue<bool>? ValidateRequestParameters
    {
        get => GetArgument<TerraformValue<bool>>("validate_request_parameters");
        set => SetArgument("validate_request_parameters", value);
    }

}
