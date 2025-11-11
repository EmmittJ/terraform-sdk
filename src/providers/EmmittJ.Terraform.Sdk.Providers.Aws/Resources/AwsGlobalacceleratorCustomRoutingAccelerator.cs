using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock
{
    /// <summary>
    /// The flow_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("flow_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FlowLogsEnabled { get; set; }

    /// <summary>
    /// The flow_logs_s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("flow_logs_s3_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FlowLogsS3Bucket { get; set; }

    /// <summary>
    /// The flow_logs_s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("flow_logs_s3_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FlowLogsS3Prefix { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorCustomRoutingAccelerator : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingAccelerator(string name) : base("aws_globalaccelerator_custom_routing_accelerator", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    [TerraformPropertyName("attributes")]
    public TerraformList<TerraformBlock<AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock>>? Attributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostedZoneId => new TerraformReference(this, "hosted_zone_id");

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    [TerraformPropertyName("ip_sets")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpSets => new TerraformReference(this, "ip_sets");

}
