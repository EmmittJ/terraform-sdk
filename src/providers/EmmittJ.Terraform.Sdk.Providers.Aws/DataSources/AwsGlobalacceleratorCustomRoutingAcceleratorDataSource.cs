using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_globalaccelerator_custom_routing_accelerator.
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingAcceleratorDataSource : TerraformDataSource
{
    public AwsGlobalacceleratorCustomRoutingAcceleratorDataSource(string name) : base("aws_globalaccelerator_custom_routing_accelerator", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformProperty("attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Attributes { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpAddressType { get; }

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    [TerraformProperty("ip_sets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpSets { get; }

}
