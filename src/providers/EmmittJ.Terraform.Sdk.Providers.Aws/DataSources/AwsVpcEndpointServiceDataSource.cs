using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointServiceDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceName { get; set; } = default!;

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    [TerraformPropertyName("service_regions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ServiceRegions { get; set; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformPropertyName("service_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceType { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcEndpointServiceDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcEndpointServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [TerraformPropertyName("acceptance_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AcceptanceRequired => new TerraformReference(this, "acceptance_required");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    [TerraformPropertyName("base_endpoint_dns_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> BaseEndpointDnsNames => new TerraformReference(this, "base_endpoint_dns_names");

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("manages_vpc_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ManagesVpcEndpoints => new TerraformReference(this, "manages_vpc_endpoints");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDnsName => new TerraformReference(this, "private_dns_name");

    /// <summary>
    /// The private_dns_names attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> PrivateDnsNames => new TerraformReference(this, "private_dns_names");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Region => new TerraformReference(this, "region");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceId => new TerraformReference(this, "service_id");

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    [TerraformPropertyName("service_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceRegion => new TerraformReference(this, "service_region");

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_ip_address_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedIpAddressTypes => new TerraformReference(this, "supported_ip_address_types");

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_policy_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> VpcEndpointPolicySupported => new TerraformReference(this, "vpc_endpoint_policy_supported");

}
