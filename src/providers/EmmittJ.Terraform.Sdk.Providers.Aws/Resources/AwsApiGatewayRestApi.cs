using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayRestApiEndpointConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    [TerraformProperty("types")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Types { get; set; }

    /// <summary>
    /// The vpc_endpoint_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcEndpointIds { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_rest_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApiGatewayRestApi : TerraformResource
{
    public AwsApiGatewayRestApi(string name) : base("aws_api_gateway_rest_api", name)
    {
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    [TerraformProperty("api_key_source")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ApiKeySource { get; set; }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    [TerraformProperty("binary_media_types")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> BinaryMediaTypes { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformProperty("disable_execute_api_endpoint")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisableExecuteApiEndpoint { get; set; }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    [TerraformProperty("fail_on_warnings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FailOnWarnings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    [TerraformProperty("minimum_compression_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinimumCompressionSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    [TerraformProperty("put_rest_api_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PutRestApiMode { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    [TerraformProperty("endpoint_configuration")]
    public partial TerraformList<TerraformBlock<AwsApiGatewayRestApiEndpointConfigurationBlock>>? EndpointConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformProperty("execution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExecutionArn { get; }

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    [TerraformProperty("root_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootResourceId { get; }

}
