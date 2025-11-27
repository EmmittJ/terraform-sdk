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
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
    }

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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ApiEndpoint
    {
        get => new TerraformReference<string>(this, "api_endpoint");
    }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> ApiKeySelectionExpression
    {
        get => new TerraformReference<string>(this, "api_key_selection_expression");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cors_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool> DisableExecuteApiEndpoint
    {
        get => new TerraformReference<bool>(this, "disable_execute_api_endpoint");
    }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
    {
        get => new TerraformReference<string>(this, "execution_arn");
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> RouteSelectionExpression
    {
        get => new TerraformReference<string>(this, "route_selection_expression");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
