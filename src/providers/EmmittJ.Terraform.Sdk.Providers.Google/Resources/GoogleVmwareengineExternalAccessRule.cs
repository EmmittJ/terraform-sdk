using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_ip_ranges in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// The name of an &#39;ExternalAddress&#39; resource.
    /// </summary>
    public TerraformProperty<string>? ExternalAddress
    {
        set => SetProperty("external_address", value);
    }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    public TerraformProperty<string>? IpAddressRange
    {
        set => SetProperty("ip_address_range", value);
    }

}

/// <summary>
/// Block type for source_ip_ranges in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// A single IP address.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    public TerraformProperty<string>? IpAddressRange
    {
        set => SetProperty("ip_address_range", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineExternalAccessRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_vmwareengine_external_access_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVmwareengineExternalAccessRule : TerraformResource
{
    public GoogleVmwareengineExternalAccessRule(string name) : base("google_vmwareengine_external_access_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("state");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("action");
        SetOutput("description");
        SetOutput("destination_ports");
        SetOutput("id");
        SetOutput("ip_protocol");
        SetOutput("name");
        SetOutput("parent");
        SetOutput("priority");
        SetOutput("source_ports");
    }

    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    public List<TerraformProperty<string>> DestinationPorts
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("destination_ports");
        set => SetProperty("destination_ports", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformProperty<string> IpProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_protocol");
        set => SetProperty("ip_protocol", value);
    }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    public List<TerraformProperty<string>> SourcePorts
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("source_ports");
        set => SetProperty("source_ports", value);
    }

    /// <summary>
    /// Block for destination_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationIpRanges block(s) required")]
    public List<GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock>? DestinationIpRanges
    {
        set => SetProperty("destination_ip_ranges", value);
    }

    /// <summary>
    /// Block for source_ip_ranges.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceIpRanges block(s) required")]
    public List<GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock>? SourceIpRanges
    {
        set => SetProperty("source_ip_ranges", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVmwareengineExternalAccessRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

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
