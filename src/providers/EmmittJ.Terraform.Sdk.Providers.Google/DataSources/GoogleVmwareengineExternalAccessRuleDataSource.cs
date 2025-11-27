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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    public TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// If destination ranges are specified, the external access rule applies only to
    /// traffic that has a destination IP address in these ranges.
    /// </summary>
    public TerraformList<TerraformMap<object>> DestinationIpRanges
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "destination_ip_ranges").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    public TerraformList<string> DestinationPorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_ports").ResolveNodes(ctx));
    }

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    public TerraformValue<string> IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
    }

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
    }

    /// <summary>
    /// If source ranges are specified, the external access rule applies only to
    /// traffic that has a source IP address in these ranges.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceIpRanges
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source_ip_ranges").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    public TerraformList<string> SourcePorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_ports").ResolveNodes(ctx));
    }

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
