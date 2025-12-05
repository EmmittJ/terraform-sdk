using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_gateway_response Terraform resource.
/// Manages a aws_api_gateway_gateway_response resource.
/// </summary>
public partial class AwsApiGatewayGatewayResponse(string name) : TerraformResource("aws_api_gateway_gateway_response", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public TerraformMap<string>? ResponseParameters
    {
        get => GetArgument<TerraformMap<string>>("response_parameters");
        set => SetArgument("response_parameters", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public TerraformMap<string>? ResponseTemplates
    {
        get => GetArgument<TerraformMap<string>>("response_templates");
        set => SetArgument("response_templates", value);
    }

    /// <summary>
    /// The response_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseType is required")]
    public required TerraformValue<string> ResponseType
    {
        get => GetRequiredArgument<TerraformValue<string>>("response_type");
        set => SetArgument("response_type", value);
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
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string>? StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}
