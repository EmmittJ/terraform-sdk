using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointServiceDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_endpoint_service.
/// </summary>
public class AwsVpcEndpointServiceDataSource : TerraformDataSource
{
    public AwsVpcEndpointServiceDataSource(string name) : base("aws_vpc_endpoint_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Service { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_name");

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    [TerraformPropertyName("service_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServiceRegions { get; set; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformPropertyName("service_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcEndpointServiceDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcEndpointServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [TerraformPropertyName("acceptance_required")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AcceptanceRequired => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "acceptance_required");

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
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns_name");

    /// <summary>
    /// The private_dns_names attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> PrivateDnsNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "private_dns_names");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Region => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_id");

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    [TerraformPropertyName("service_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_region");

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_ip_address_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedIpAddressTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_ip_address_types");

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_policy_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> VpcEndpointPolicySupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "vpc_endpoint_policy_supported");

}
