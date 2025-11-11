using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_integration_response resource.
/// </summary>
public partial class AwsApiGatewayIntegrationResponse : TerraformResource
{
    public AwsApiGatewayIntegrationResponse(string name) : base("aws_api_gateway_integration_response", name)
    {
    }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    [TerraformProperty("content_handling")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentHandling { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformProperty("http_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HttpMethod { get; set; }

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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    [TerraformProperty("response_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResponseParameters { get; set; }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    [TerraformProperty("response_templates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResponseTemplates { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The selection_pattern attribute.
    /// </summary>
    [TerraformProperty("selection_pattern")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SelectionPattern { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformProperty("status_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StatusCode { get; set; }

}
