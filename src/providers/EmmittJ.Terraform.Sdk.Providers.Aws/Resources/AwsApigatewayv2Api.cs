using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_configuration in AwsApigatewayv2Api.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2ApiCorsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_configuration";

    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public TerraformSet<string>? AllowHeaders
    {
        get => GetArgument<TerraformSet<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public TerraformSet<string>? AllowMethods
    {
        get => GetArgument<TerraformSet<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public TerraformSet<string>? AllowOrigins
    {
        get => GetArgument<TerraformSet<string>>("allow_origins");
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public TerraformSet<string>? ExposeHeaders
    {
        get => GetArgument<TerraformSet<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => GetArgument<TerraformValue<double>>("max_age");
        set => SetArgument("max_age", value);
    }

}


/// <summary>
/// Represents a aws_apigatewayv2_api Terraform resource.
/// Manages a aws_apigatewayv2_api resource.
/// </summary>
public partial class AwsApigatewayv2Api(string name) : TerraformResource("aws_apigatewayv2_api", name)
{
    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? ApiKeySelectionExpression
    {
        get => GetArgument<TerraformValue<string>>("api_key_selection_expression");
        set => SetArgument("api_key_selection_expression", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformValue<string>? CredentialsArn
    {
        get => GetArgument<TerraformValue<string>>("credentials_arn");
        set => SetArgument("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? DisableExecuteApiEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("disable_execute_api_endpoint");
        set => SetArgument("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnWarnings
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_warnings");
        set => SetArgument("fail_on_warnings", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type") ?? CreateReference("ip_address_type");
        set => SetArgument("ip_address_type", value);
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
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformValue<string> ProtocolType
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol_type");
        set => SetArgument("protocol_type", value);
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
    /// The route_key attribute.
    /// </summary>
    public TerraformValue<string>? RouteKey
    {
        get => GetArgument<TerraformValue<string>>("route_key");
        set => SetArgument("route_key", value);
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? RouteSelectionExpression
    {
        get => GetArgument<TerraformValue<string>>("route_selection_expression");
        set => SetArgument("route_selection_expression", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ApiEndpoint
        => CreateReference("api_endpoint");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => CreateReference("execution_arn");

    /// <summary>
    /// CorsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    public TerraformList<AwsApigatewayv2ApiCorsConfigurationBlock>? CorsConfiguration
    {
        get => GetArgument<TerraformList<AwsApigatewayv2ApiCorsConfigurationBlock>>("cors_configuration");
        set => SetArgument("cors_configuration", value);
    }

}
