using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsServiceDiscoveryServiceDnsConfigBlock() : TerraformBlock("dns_config")
{
    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformProperty("namespace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespaceId { get; set; }

    /// <summary>
    /// The routing_policy attribute.
    /// </summary>
    [TerraformProperty("routing_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoutingPolicy { get; set; }

}

/// <summary>
/// Block type for health_check_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsServiceDiscoveryServiceHealthCheckConfigBlock() : TerraformBlock("health_check_config")
{
    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [TerraformProperty("failure_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureThreshold { get; set; }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    [TerraformProperty("resource_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourcePath { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for health_check_custom_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock() : TerraformBlock("health_check_custom_config")
{
    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("failure_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureThreshold { get; set; }

}

/// <summary>
/// Manages a aws_service_discovery_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsServiceDiscoveryService : TerraformResource
{
    public AwsServiceDiscoveryService(string name) : base("aws_service_discovery_service", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

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
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamespaceId { get; set; }

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
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformProperty("dns_config")]
    public TerraformList<AwsServiceDiscoveryServiceDnsConfigBlock> DnsConfig { get; set; } = new();

    /// <summary>
    /// Block for health_check_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfig block(s) allowed")]
    [TerraformProperty("health_check_config")]
    public TerraformList<AwsServiceDiscoveryServiceHealthCheckConfigBlock> HealthCheckConfig { get; set; } = new();

    /// <summary>
    /// Block for health_check_custom_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckCustomConfig block(s) allowed")]
    [TerraformProperty("health_check_custom_config")]
    public TerraformList<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock> HealthCheckCustomConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
