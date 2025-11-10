using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_ip_ranges in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock : ITerraformBlock
{
    /// <summary>
    /// The name of an &#39;ExternalAddress&#39; resource.
    /// </summary>
    [TerraformPropertyName("external_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExternalAddress { get; set; }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    [TerraformPropertyName("ip_address_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddressRange { get; set; }

}

/// <summary>
/// Block type for source_ip_ranges in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock : ITerraformBlock
{
    /// <summary>
    /// A single IP address.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddress { get; set; }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    [TerraformPropertyName("ip_address_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddressRange { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineExternalAccessRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a google_vmwareengine_external_access_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVmwareengineExternalAccessRule : TerraformResource
{
    public GoogleVmwareengineExternalAccessRule(string name) : base("google_vmwareengine_external_access_rule", name)
    {
    }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    [TerraformPropertyName("destination_ports")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? DestinationPorts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    [TerraformPropertyName("ip_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpProtocol { get; set; }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    [TerraformPropertyName("source_ports")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SourcePorts { get; set; }

    /// <summary>
    /// Block for destination_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationIpRanges block(s) required")]
    [TerraformPropertyName("destination_ip_ranges")]
    public TerraformList<TerraformBlock<GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock>>? DestinationIpRanges { get; set; } = new();

    /// <summary>
    /// Block for source_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceIpRanges block(s) required")]
    [TerraformPropertyName("source_ip_ranges")]
    public TerraformList<TerraformBlock<GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock>>? SourceIpRanges { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVmwareengineExternalAccessRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
