using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceDnsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformPropertyName("namespace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NamespaceId { get; set; }

    /// <summary>
    /// The routing_policy attribute.
    /// </summary>
    [TerraformPropertyName("routing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoutingPolicy { get; set; }

}

/// <summary>
/// Block type for health_check_config in .
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceHealthCheckConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [TerraformPropertyName("failure_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureThreshold { get; set; }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    [TerraformPropertyName("resource_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourcePath { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for health_check_custom_config in .
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("failure_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureThreshold { get; set; }

}

/// <summary>
/// Manages a aws_service_discovery_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsServiceDiscoveryService : TerraformResource
{
    public AwsServiceDiscoveryService(string name) : base("aws_service_discovery_service", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamespaceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "namespace_id");

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
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Type { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformPropertyName("dns_config")]
    public TerraformList<TerraformBlock<AwsServiceDiscoveryServiceDnsConfigBlock>>? DnsConfig { get; set; } = new();

    /// <summary>
    /// Block for health_check_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfig block(s) allowed")]
    [TerraformPropertyName("health_check_config")]
    public TerraformList<TerraformBlock<AwsServiceDiscoveryServiceHealthCheckConfigBlock>>? HealthCheckConfig { get; set; } = new();

    /// <summary>
    /// Block for health_check_custom_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckCustomConfig block(s) allowed")]
    [TerraformPropertyName("health_check_custom_config")]
    public TerraformList<TerraformBlock<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock>>? HealthCheckCustomConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
