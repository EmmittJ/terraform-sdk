using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_gateway_response resource.
/// </summary>
public partial class AwsApiGatewayGatewayResponse : TerraformResource
{
    public AwsApiGatewayGatewayResponse(string name) : base("aws_api_gateway_gateway_response", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    [TerraformProperty("response_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResponseParameters { get; set; }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    [TerraformProperty("response_templates")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResponseTemplates { get; set; }

    /// <summary>
    /// The response_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseType is required")]
    [TerraformProperty("response_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResponseType { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [TerraformProperty("status_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StatusCode { get; set; }

}
