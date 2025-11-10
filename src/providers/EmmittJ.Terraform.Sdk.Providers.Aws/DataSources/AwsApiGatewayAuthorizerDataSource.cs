using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_authorizer.
/// </summary>
public class AwsApiGatewayAuthorizerDataSource : TerraformDataSource
{
    public AwsApiGatewayAuthorizerDataSource(string name) : base("aws_api_gateway_authorizer", name)
    {
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerId is required")]
    [TerraformPropertyName("authorizer_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizerId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RestApiId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_credentials")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizerCredentials => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorizer_credentials");

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_result_ttl_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AuthorizerResultTtlInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "authorizer_result_ttl_in_seconds");

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizerUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorizer_uri");

    /// <summary>
    /// The identity_source attribute.
    /// </summary>
    [TerraformPropertyName("identity_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentitySource => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_source");

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    [TerraformPropertyName("identity_validation_expression")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentityValidationExpression => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_validation_expression");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    [TerraformPropertyName("provider_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProviderArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "provider_arns");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
