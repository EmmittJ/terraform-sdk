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
        get => new TerraformReference<bool>(this, "allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public TerraformSet<string>? AllowHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allow_headers").ResolveNodes(ctx));
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public TerraformSet<string>? AllowMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allow_methods").ResolveNodes(ctx));
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public TerraformSet<string>? AllowOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allow_origins").ResolveNodes(ctx));
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public TerraformSet<string>? ExposeHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "expose_headers").ResolveNodes(ctx));
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => new TerraformReference<double>(this, "max_age");
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
        get => new TerraformReference<string>(this, "api_key_selection_expression");
        set => SetArgument("api_key_selection_expression", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformValue<string>? CredentialsArn
    {
        get => new TerraformReference<string>(this, "credentials_arn");
        set => SetArgument("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? DisableExecuteApiEndpoint
    {
        get => new TerraformReference<bool>(this, "disable_execute_api_endpoint");
        set => SetArgument("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnWarnings
    {
        get => new TerraformReference<bool>(this, "fail_on_warnings");
        set => SetArgument("fail_on_warnings", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
        set => SetArgument("protocol_type", value);
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
    /// The route_key attribute.
    /// </summary>
    public TerraformValue<string>? RouteKey
    {
        get => new TerraformReference<string>(this, "route_key");
        set => SetArgument("route_key", value);
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? RouteSelectionExpression
    {
        get => new TerraformReference<string>(this, "route_selection_expression");
        set => SetArgument("route_selection_expression", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ApiEndpoint
    {
        get => new TerraformReference<string>(this, "api_endpoint");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
    {
        get => new TerraformReference<string>(this, "execution_arn");
    }

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
