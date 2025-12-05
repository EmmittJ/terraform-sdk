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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ApiEndpoint
        => CreateReference("api_endpoint");

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> ApiKeySelectionExpression
        => CreateReference("api_key_selection_expression");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfiguration
        => CreateReference("cors_configuration");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool> DisableExecuteApiEndpoint
        => CreateReference("disable_execute_api_endpoint");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => CreateReference("execution_arn");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
        => CreateReference("ip_address_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformValue<string> ProtocolType
        => CreateReference("protocol_type");

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> RouteSelectionExpression
        => CreateReference("route_selection_expression");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

}
