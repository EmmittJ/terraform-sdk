using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_external_access_rule.
/// </summary>
public class GoogleVmwareengineExternalAccessRuleDataSource : TerraformDataSource
{
    public GoogleVmwareengineExternalAccessRuleDataSource(string name) : base("google_vmwareengine_external_access_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("action");
        this.DeclareOutput("create_time");
        this.DeclareOutput("description");
        this.DeclareOutput("destination_ip_ranges");
        this.DeclareOutput("destination_ports");
        this.DeclareOutput("ip_protocol");
        this.DeclareOutput("priority");
        this.DeclareOutput("source_ip_ranges");
        this.DeclareOutput("source_ports");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    public TerraformExpression Action => this["action"];

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// If destination ranges are specified, the external access rule applies only to
    /// traffic that has a destination IP address in these ranges.
    /// </summary>
    public TerraformExpression DestinationIpRanges => this["destination_ip_ranges"];

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    public TerraformExpression DestinationPorts => this["destination_ports"];

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    public TerraformExpression IpProtocol => this["ip_protocol"];

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    public TerraformExpression Priority => this["priority"];

    /// <summary>
    /// If source ranges are specified, the external access rule applies only to
    /// traffic that has a source IP address in these ranges.
    /// </summary>
    public TerraformExpression SourceIpRanges => this["source_ip_ranges"];

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    public TerraformExpression SourcePorts => this["source_ports"];

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
