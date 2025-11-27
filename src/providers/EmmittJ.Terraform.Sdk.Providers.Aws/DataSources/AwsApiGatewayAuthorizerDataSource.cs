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
        get => new TerraformReference<string>(this, "authorizer_id");
        set => SetArgument("authorizer_id", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public TerraformValue<string> AuthorizerCredentials
    {
        get => new TerraformReference<string>(this, "authorizer_credentials");
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> AuthorizerResultTtlInSeconds
    {
        get => new TerraformReference<double>(this, "authorizer_result_ttl_in_seconds");
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformValue<string> AuthorizerUri
    {
        get => new TerraformReference<string>(this, "authorizer_uri");
    }

    /// <summary>
    /// The identity_source attribute.
    /// </summary>
    public TerraformValue<string> IdentitySource
    {
        get => new TerraformReference<string>(this, "identity_source");
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformValue<string> IdentityValidationExpression
    {
        get => new TerraformReference<string>(this, "identity_validation_expression");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    public TerraformList<string> ProviderArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "provider_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
