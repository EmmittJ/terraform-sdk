using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcEndpointServiceDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcEndpointServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_endpoint_service.
/// </summary>
public partial class AwsVpcEndpointServiceDataSource : TerraformDataSource
{
    public AwsVpcEndpointServiceDataSource(string name) : base("aws_vpc_endpoint_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformProperty("service")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformProperty("service_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    [TerraformProperty("service_regions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ServiceRegions { get; set; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformProperty("service_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsVpcEndpointServiceDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcEndpointServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [TerraformProperty("acceptance_required")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AcceptanceRequired { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AvailabilityZones { get; }

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    [TerraformProperty("base_endpoint_dns_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> BaseEndpointDnsNames { get; }

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    [TerraformProperty("manages_vpc_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ManagesVpcEndpoints { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Owner { get; }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformProperty("private_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateDnsName { get; }

    /// <summary>
    /// The private_dns_names attribute.
    /// </summary>
    [TerraformProperty("private_dns_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> PrivateDnsNames { get; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Region { get; }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformProperty("service_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceId { get; }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    [TerraformProperty("service_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceRegion { get; }

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    [TerraformProperty("supported_ip_address_types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SupportedIpAddressTypes { get; }

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_policy_supported")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> VpcEndpointPolicySupported { get; }

}
