using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_vpc_endpoint_service resource.
/// </summary>
public class AwsVpcEndpointService : TerraformResource
{
    public AwsVpcEndpointService(string name) : base("aws_vpc_endpoint_service", name)
    {
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptanceRequired is required")]
    [TerraformPropertyName("acceptance_required")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AcceptanceRequired { get; set; }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    [TerraformPropertyName("allowed_principals")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedPrincipals { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_principals");

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("gateway_load_balancer_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? GatewayLoadBalancerArns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The network_load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("network_load_balancer_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NetworkLoadBalancerArns { get; set; }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateDnsName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns_name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_ip_address_types")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedIpAddressTypes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_ip_address_types");

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    [TerraformPropertyName("supported_regions")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedRegions { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_regions");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcEndpointServiceTimeoutsBlock>? Timeouts { get; set; } = new();

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
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    [TerraformPropertyName("base_endpoint_dns_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> BaseEndpointDnsNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "base_endpoint_dns_names");

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("manages_vpc_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ManagesVpcEndpoints => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "manages_vpc_endpoints");

    /// <summary>
    /// The private_dns_name_configuration attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateDnsNameConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_dns_name_configuration");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_name");

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformPropertyName("service_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
