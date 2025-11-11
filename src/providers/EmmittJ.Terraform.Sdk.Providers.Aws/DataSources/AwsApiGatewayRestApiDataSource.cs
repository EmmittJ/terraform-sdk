using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_rest_api.
/// </summary>
public partial class AwsApiGatewayRestApiDataSource : TerraformDataSource
{
    public AwsApiGatewayRestApiDataSource(string name) : base("aws_api_gateway_rest_api", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// The api_key_source attribute.
    /// </summary>
    [TerraformProperty("api_key_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApiKeySource { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    [TerraformProperty("binary_media_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> BinaryMediaTypes { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    [TerraformProperty("endpoint_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EndpointConfiguration { get; }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformProperty("execution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExecutionArn { get; }

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    [TerraformProperty("minimum_compression_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MinimumCompressionSize { get; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Policy { get; }

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    [TerraformProperty("root_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootResourceId { get; }

}
