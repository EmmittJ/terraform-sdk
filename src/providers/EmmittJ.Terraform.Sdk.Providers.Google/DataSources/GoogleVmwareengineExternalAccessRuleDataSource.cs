using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_vmwareengine_external_access_rule Terraform data source.
/// Retrieves information about a google_vmwareengine_external_access_rule.
/// </summary>
public partial class GoogleVmwareengineExternalAccessRuleDataSource(string name) : TerraformDataSource("google_vmwareengine_external_access_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    public TerraformValue<string> Action
        => AsReference("action");

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// If destination ranges are specified, the external access rule applies only to
    /// traffic that has a destination IP address in these ranges.
    /// </summary>
    public TerraformList<TerraformMap<object>> DestinationIpRanges
        => AsReference("destination_ip_ranges");

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    public TerraformList<string> DestinationPorts
        => AsReference("destination_ports");

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    public TerraformValue<string> IpProtocol
        => AsReference("ip_protocol");

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    public TerraformValue<double> Priority
        => AsReference("priority");

    /// <summary>
    /// If source ranges are specified, the external access rule applies only to
    /// traffic that has a source IP address in these ranges.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceIpRanges
        => AsReference("source_ip_ranges");

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    public TerraformList<string> SourcePorts
        => AsReference("source_ports");

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
