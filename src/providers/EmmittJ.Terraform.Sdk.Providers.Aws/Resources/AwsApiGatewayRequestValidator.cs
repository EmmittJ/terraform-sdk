using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_request_validator resource.
/// </summary>
public class AwsApiGatewayRequestValidator : TerraformResource
{
    public AwsApiGatewayRequestValidator(string name) : base("aws_api_gateway_request_validator", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The validate_request_body attribute.
    /// </summary>
    [TerraformPropertyName("validate_request_body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ValidateRequestBody { get; set; }

    /// <summary>
    /// The validate_request_parameters attribute.
    /// </summary>
    [TerraformPropertyName("validate_request_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ValidateRequestParameters { get; set; }

}
