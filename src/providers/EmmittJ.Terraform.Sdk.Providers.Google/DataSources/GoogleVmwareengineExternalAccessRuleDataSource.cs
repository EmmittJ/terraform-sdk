using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_external_access_rule.
/// </summary>
public class GoogleVmwareengineExternalAccessRuleDataSource : TerraformDataSource
{
    public GoogleVmwareengineExternalAccessRuleDataSource(string name) : base("google_vmwareengine_external_access_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("action")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Action => new TerraformReference(this, "action");

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// If destination ranges are specified, the external access rule applies only to
    /// traffic that has a destination IP address in these ranges.
    /// </summary>
    [TerraformPropertyName("destination_ip_ranges")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DestinationIpRanges => new TerraformReference(this, "destination_ip_ranges");

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    [TerraformPropertyName("destination_ports")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DestinationPorts => new TerraformReference(this, "destination_ports");

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    [TerraformPropertyName("ip_protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpProtocol => new TerraformReference(this, "ip_protocol");

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Priority => new TerraformReference(this, "priority");

    /// <summary>
    /// If source ranges are specified, the external access rule applies only to
    /// traffic that has a source IP address in these ranges.
    /// </summary>
    [TerraformPropertyName("source_ip_ranges")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SourceIpRanges => new TerraformReference(this, "source_ip_ranges");

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    [TerraformPropertyName("source_ports")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SourcePorts => new TerraformReference(this, "source_ports");

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
