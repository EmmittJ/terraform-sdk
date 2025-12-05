using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_authorizer Terraform data source.
/// Retrieves information about a aws_api_gateway_authorizer.
/// </summary>
public partial class AwsApiGatewayAuthorizerDataSource(string name) : TerraformDataSource("aws_api_gateway_authorizer", name)
{
    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerId is required")]
    public required TerraformValue<string> AuthorizerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("authorizer_id");
        set => SetArgument("authorizer_id", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => GetRequiredArgument<TerraformValue<string>>("rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public TerraformValue<string> AuthorizerCredentials
        => CreateReference("authorizer_credentials");

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> AuthorizerResultTtlInSeconds
        => CreateReference("authorizer_result_ttl_in_seconds");

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformValue<string> AuthorizerUri
        => CreateReference("authorizer_uri");

    /// <summary>
    /// The identity_source attribute.
    /// </summary>
    public TerraformValue<string> IdentitySource
        => CreateReference("identity_source");

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformValue<string> IdentityValidationExpression
        => CreateReference("identity_validation_expression");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    public TerraformList<string> ProviderArns
        => CreateReference("provider_arns");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

}
