using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apigatewayv2_api Terraform data source.
/// Retrieves information about a aws_apigatewayv2_api.
/// </summary>
public partial class AwsApigatewayv2ApiDataSource(string name) : TerraformDataSource("aws_apigatewayv2_api", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ApiEndpoint
        => AsReference("api_endpoint");

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> ApiKeySelectionExpression
        => AsReference("api_key_selection_expression");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfiguration
        => AsReference("cors_configuration");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool> DisableExecuteApiEndpoint
        => AsReference("disable_execute_api_endpoint");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => AsReference("execution_arn");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
        => AsReference("ip_address_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformValue<string> ProtocolType
        => AsReference("protocol_type");

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> RouteSelectionExpression
        => AsReference("route_selection_expression");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}
