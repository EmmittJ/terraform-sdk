using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method resource.
/// </summary>
public partial class AwsApiGatewayMethod : TerraformResource
{
    public AwsApiGatewayMethod(string name) : base("aws_api_gateway_method", name)
    {
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    [TerraformProperty("api_key_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ApiKeyRequired { get; set; }

    /// <summary>
    /// The authorization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [TerraformProperty("authorization")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Authorization { get; set; }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    [TerraformProperty("authorization_scopes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AuthorizationScopes { get; set; }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [TerraformProperty("authorizer_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthorizerId { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformProperty("http_method")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformProperty("operation_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OperationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    [TerraformProperty("request_models")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? RequestModels { get; set; }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    [TerraformProperty("request_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<bool>? RequestParameters { get; set; }

    /// <summary>
    /// The request_validator_id attribute.
    /// </summary>
    [TerraformProperty("request_validator_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestValidatorId { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RestApiId { get; set; }

}
