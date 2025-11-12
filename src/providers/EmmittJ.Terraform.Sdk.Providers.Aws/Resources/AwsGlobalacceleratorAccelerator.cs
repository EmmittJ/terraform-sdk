using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlobalacceleratorAcceleratorAttributesBlock() : TerraformBlock("attributes")
{
    /// <summary>
    /// The flow_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("flow_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FlowLogsEnabled { get; set; }

    /// <summary>
    /// The flow_logs_s3_bucket attribute.
    /// </summary>
    [TerraformProperty("flow_logs_s3_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FlowLogsS3Bucket { get; set; }

    /// <summary>
    /// The flow_logs_s3_prefix attribute.
    /// </summary>
    [TerraformProperty("flow_logs_s3_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FlowLogsS3Prefix { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGlobalacceleratorAcceleratorTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlobalacceleratorAccelerator : TerraformResource
{
    public AwsGlobalacceleratorAccelerator(string name) : base("aws_globalaccelerator_accelerator", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformProperty("ip_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    [TerraformProperty("attributes")]
    public TerraformList<AwsGlobalacceleratorAcceleratorAttributesBlock> Attributes { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsGlobalacceleratorAcceleratorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The dual_stack_dns_name attribute.
    /// </summary>
    [TerraformProperty("dual_stack_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DualStackDnsName { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    [TerraformProperty("ip_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IpSets { get; }

}
