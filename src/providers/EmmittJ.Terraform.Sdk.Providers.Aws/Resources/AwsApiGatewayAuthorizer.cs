using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_authorizer Terraform resource.
/// Manages a aws_api_gateway_authorizer resource.
/// </summary>
public partial class AwsApiGatewayAuthorizer(string name) : TerraformResource("aws_api_gateway_authorizer", name)
{
    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerCredentials
    {
        get => GetArgument<TerraformValue<string>>("authorizer_credentials");
        set => SetArgument("authorizer_credentials", value);
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
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerUri
    {
        get => GetArgument<TerraformValue<string>>("authorizer_uri");
        set => SetArgument("authorizer_uri", value);
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
    /// The identity_source attribute.
    /// </summary>
    public TerraformValue<string>? IdentitySource
    {
        get => GetArgument<TerraformValue<string>>("identity_source");
        set => SetArgument("identity_source", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformValue<string>? IdentityValidationExpression
    {
        get => GetArgument<TerraformValue<string>>("identity_validation_expression");
        set => SetArgument("identity_validation_expression", value);
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
    /// The provider_arns attribute.
    /// </summary>
    public TerraformSet<string>? ProviderArns
    {
        get => GetArgument<TerraformSet<string>>("provider_arns");
        set => SetArgument("provider_arns", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => GetArgument<TerraformValue<string>>("rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
