using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for jwt_configuration in AwsApigatewayv2Authorizer.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2AuthorizerJwtConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jwt_configuration";

    /// <summary>
    /// The audience attribute.
    /// </summary>
    public TerraformSet<string>? Audience
    {
        get => GetArgument<TerraformSet<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsApigatewayv2Authorizer.
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2AuthorizerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_apigatewayv2_authorizer Terraform resource.
/// Manages a aws_apigatewayv2_authorizer resource.
/// </summary>
public partial class AwsApigatewayv2Authorizer(string name) : TerraformResource("aws_apigatewayv2_authorizer", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerCredentialsArn
    {
        get => GetArgument<TerraformValue<string>>("authorizer_credentials_arn");
        set => SetArgument("authorizer_credentials_arn", value);
    }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerPayloadFormatVersion
    {
        get => GetArgument<TerraformValue<string>>("authorizer_payload_format_version");
        set => SetArgument("authorizer_payload_format_version", value);
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? AuthorizerResultTtlInSeconds
    {
        get => GetArgument<TerraformValue<double>>("authorizer_result_ttl_in_seconds");
        set => SetArgument("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    public required TerraformValue<string> AuthorizerType
    {
        get => GetArgument<TerraformValue<string>>("authorizer_type");
        set => SetArgument("authorizer_type", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerUri
    {
        get => GetArgument<TerraformValue<string>>("authorizer_uri");
        set => SetArgument("authorizer_uri", value);
    }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    public TerraformValue<bool>? EnableSimpleResponses
    {
        get => GetArgument<TerraformValue<bool>>("enable_simple_responses");
        set => SetArgument("enable_simple_responses", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_sources attribute.
    /// </summary>
    public TerraformSet<string>? IdentitySources
    {
        get => GetArgument<TerraformSet<string>>("identity_sources");
        set => SetArgument("identity_sources", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// JwtConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtConfiguration block(s) allowed")]
    public TerraformList<AwsApigatewayv2AuthorizerJwtConfigurationBlock>? JwtConfiguration
    {
        get => GetArgument<TerraformList<AwsApigatewayv2AuthorizerJwtConfigurationBlock>>("jwt_configuration");
        set => SetArgument("jwt_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsApigatewayv2AuthorizerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsApigatewayv2AuthorizerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
