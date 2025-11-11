using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_api.
/// </summary>
public partial class AwsApigatewayv2ApiDataSource : TerraformDataSource
{
    public AwsApigatewayv2ApiDataSource(string name) : base("aws_apigatewayv2_api", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    [TerraformProperty("api_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApiEndpoint { get; }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    [TerraformProperty("api_key_selection_expression")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApiKeySelectionExpression { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    [TerraformProperty("cors_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CorsConfiguration { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformProperty("disable_execute_api_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DisableExecuteApiEndpoint { get; }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformProperty("execution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExecutionArn { get; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddressType { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformProperty("protocol_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProtocolType { get; }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    [TerraformProperty("route_selection_expression")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RouteSelectionExpression { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
