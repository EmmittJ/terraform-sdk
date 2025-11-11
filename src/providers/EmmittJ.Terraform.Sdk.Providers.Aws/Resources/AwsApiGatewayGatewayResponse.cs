using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_gateway_response resource.
/// </summary>
public class AwsApiGatewayGatewayResponse : TerraformResource
{
    public AwsApiGatewayGatewayResponse(string name) : base("aws_api_gateway_gateway_response", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    [TerraformPropertyName("response_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResponseParameters { get; set; }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    [TerraformPropertyName("response_templates")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResponseTemplates { get; set; }

    /// <summary>
    /// The response_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseType is required")]
    [TerraformPropertyName("response_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResponseType { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [TerraformPropertyName("status_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StatusCode { get; set; }

}
