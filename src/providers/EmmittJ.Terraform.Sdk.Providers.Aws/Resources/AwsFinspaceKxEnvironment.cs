using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_dns_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_dns_server_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerIp is required")]
    [TerraformPropertyName("custom_dns_server_ip")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomDnsServerIp { get; set; }

    /// <summary>
    /// The custom_dns_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerName is required")]
    [TerraformPropertyName("custom_dns_server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomDnsServerName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxEnvironmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for transit_gateway_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The routable_cidr_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutableCidrSpace is required")]
    [TerraformPropertyName("routable_cidr_space")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoutableCidrSpace { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    [TerraformPropertyName("transit_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TransitGatewayId { get; set; }

}

/// <summary>
/// Manages a aws_finspace_kx_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFinspaceKxEnvironment : TerraformResource
{
    public AwsFinspaceKxEnvironment(string name) : base("aws_finspace_kx_environment", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformPropertyName("kms_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    /// Block for custom_dns_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_dns_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock>>? CustomDnsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFinspaceKxEnvironmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for transit_gateway_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransitGatewayConfiguration block(s) allowed")]
    [TerraformPropertyName("transit_gateway_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock>>? TransitGatewayConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("created_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_timestamp");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The infrastructure_account_id attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InfrastructureAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "infrastructure_account_id");

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
