using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_ip_ranges in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of an &#39;ExternalAddress&#39; resource.
    /// </summary>
    [TerraformProperty("external_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExternalAddress { get; set; }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    [TerraformProperty("ip_address_range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddressRange { get; set; }

}

/// <summary>
/// Block type for source_ip_ranges in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock : TerraformBlockBase
{
    /// <summary>
    /// A single IP address.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    [TerraformProperty("ip_address_range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddressRange { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVmwareengineExternalAccessRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_vmwareengine_external_access_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVmwareengineExternalAccessRule : TerraformResource
{
    public GoogleVmwareengineExternalAccessRule(string name) : base("google_vmwareengine_external_access_rule", name)
    {
    }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    [TerraformProperty("destination_ports")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? DestinationPorts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    [TerraformProperty("ip_protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IpProtocol { get; set; }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    [TerraformProperty("source_ports")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? SourcePorts { get; set; }

    /// <summary>
    /// Block for destination_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationIpRanges block(s) required")]
    [TerraformProperty("destination_ip_ranges")]
    public TerraformList<TerraformBlock<GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock>>? DestinationIpRanges { get; set; }

    /// <summary>
    /// Block for source_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceIpRanges block(s) required")]
    [TerraformProperty("source_ip_ranges")]
    public TerraformList<TerraformBlock<GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock>>? SourceIpRanges { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleVmwareengineExternalAccessRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
