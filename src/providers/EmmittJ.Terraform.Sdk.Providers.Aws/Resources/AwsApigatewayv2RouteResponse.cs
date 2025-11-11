using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_route_response resource.
/// </summary>
public partial class AwsApigatewayv2RouteResponse : TerraformResource
{
    public AwsApigatewayv2RouteResponse(string name) : base("aws_apigatewayv2_route_response", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    [TerraformProperty("model_selection_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ModelSelectionExpression { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The response_models attribute.
    /// </summary>
    [TerraformProperty("response_models")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResponseModels { get; set; }

    /// <summary>
    /// The route_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteId is required")]
    [TerraformProperty("route_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RouteId { get; set; }

    /// <summary>
    /// The route_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteResponseKey is required")]
    [TerraformProperty("route_response_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RouteResponseKey { get; set; }

}
