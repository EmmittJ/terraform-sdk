using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_authorizer.
/// </summary>
public partial class AwsApiGatewayAuthorizerDataSource : TerraformDataSource
{
    public AwsApiGatewayAuthorizerDataSource(string name) : base("aws_api_gateway_authorizer", name)
    {
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerId is required")]
    [TerraformProperty("authorizer_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizerId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    [TerraformProperty("authorizer_credentials")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizerCredentials { get; }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("authorizer_result_ttl_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AuthorizerResultTtlInSeconds { get; }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [TerraformProperty("authorizer_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizerUri { get; }

    /// <summary>
    /// The identity_source attribute.
    /// </summary>
    [TerraformProperty("identity_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdentitySource { get; }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    [TerraformProperty("identity_validation_expression")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdentityValidationExpression { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    [TerraformProperty("provider_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ProviderArns { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
