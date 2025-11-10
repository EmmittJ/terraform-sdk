using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayRestApiEndpointConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_address_type");

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    [TerraformPropertyName("types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Types { get; set; }

    /// <summary>
    /// The vpc_endpoint_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcEndpointIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "vpc_endpoint_ids");

}

/// <summary>
/// Manages a aws_api_gateway_rest_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayRestApi : TerraformResource
{
    public AwsApiGatewayRestApi(string name) : base("aws_api_gateway_rest_api", name)
    {
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    [TerraformPropertyName("api_key_source")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ApiKeySource { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key_source");

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    [TerraformPropertyName("binary_media_types")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> BinaryMediaTypes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "binary_media_types");

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Body { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("disable_execute_api_endpoint")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableExecuteApiEndpoint { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_execute_api_endpoint");

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    [TerraformPropertyName("fail_on_warnings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FailOnWarnings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    [TerraformPropertyName("minimum_compression_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinimumCompressionSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "minimum_compression_size");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Policy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    [TerraformPropertyName("put_rest_api_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PutRestApiMode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    [TerraformPropertyName("endpoint_configuration")]
    public TerraformList<TerraformBlock<AwsApiGatewayRestApiEndpointConfigurationBlock>>? EndpointConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_arn");

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("root_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_resource_id");

}
