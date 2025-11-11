using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_external_access_rule.
/// </summary>
public partial class GoogleVmwareengineExternalAccessRuleDataSource : TerraformDataSource
{
    public GoogleVmwareengineExternalAccessRuleDataSource(string name) : base("google_vmwareengine_external_access_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [TerraformProperty("action")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Action { get; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// If destination ranges are specified, the external access rule applies only to
    /// traffic that has a destination IP address in these ranges.
    /// </summary>
    [TerraformProperty("destination_ip_ranges")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DestinationIpRanges { get; }

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    [TerraformProperty("destination_ports")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DestinationPorts { get; }

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    [TerraformProperty("ip_protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpProtocol { get; }

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    [TerraformProperty("priority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Priority { get; }

    /// <summary>
    /// If source ranges are specified, the external access rule applies only to
    /// traffic that has a source IP address in these ranges.
    /// </summary>
    [TerraformProperty("source_ip_ranges")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SourceIpRanges { get; }

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    [TerraformProperty("source_ports")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SourcePorts { get; }

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
