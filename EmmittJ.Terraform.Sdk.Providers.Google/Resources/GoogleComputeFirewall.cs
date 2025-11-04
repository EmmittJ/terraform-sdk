using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_firewall resource.
/// </summary>
public class GoogleComputeFirewall : TerraformResource
{
    public GoogleComputeFirewall(string name) : base("google_compute_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    public HashSet<string>? DestinationRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("destination_ranges")?.Value;
        set => this.WithProperty("destination_ranges", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of &#39;source_ranges&#39;,
    /// &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public string? Direction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direction")?.Value;
        set => this.WithProperty("direction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule. If logging is enabled, logs will be exported to Stackdriver.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_logging")?.Value;
        set => this.WithProperty("enable_logging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name or self_link of the network to attach this firewall to.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If source ranges are specified, the firewall will apply only to
    /// traffic that has source IP address in these ranges. These ranges must
    /// be expressed in CIDR format. One or both of sourceRanges and
    /// sourceTags may be set. If both properties are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP that belongs to a tag listed in the sourceTags property. The
    /// connection does not need to match both properties for the firewall to
    /// apply. IPv4 or IPv6 ranges are supported. For INGRESS traffic, one of
    /// &#39;source_ranges&#39;, &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required.
    /// </summary>
    public HashSet<string>? SourceRanges
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_ranges")?.Value;
        set => this.WithProperty("source_ranges", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// If source service accounts are specified, the firewall will apply only
    /// to traffic originating from an instance with a service account in this
    /// list. Source service accounts cannot be used to control traffic to an
    /// instance&#39;s external IP address because service accounts are associated
    /// with an instance, not an IP address. sourceRanges can be set at the
    /// same time as sourceServiceAccounts. If both are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP belongs to an instance with service account listed in
    /// sourceServiceAccount. The connection does not need to match both
    /// properties for the firewall to apply. sourceServiceAccounts cannot be
    /// used at the same time as sourceTags or targetTags. For INGRESS traffic,
    /// one of &#39;source_ranges&#39;, &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required.
    /// </summary>
    public HashSet<string>? SourceServiceAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_service_accounts")?.Value;
        set => this.WithProperty("source_service_accounts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// If source tags are specified, the firewall will apply only to traffic
    /// with source IP that belongs to a tag listed in source tags. Source
    /// tags cannot be used to control traffic to an instance&#39;s external IP
    /// address. Because tags are associated with an instance, not an IP
    /// address. One or both of sourceRanges and sourceTags may be set. If
    /// both properties are set, the firewall will apply to traffic that has
    /// source IP address within sourceRanges OR the source IP that belongs to
    /// a tag listed in the sourceTags property. The connection does not need
    /// to match both properties for the firewall to apply. For INGRESS traffic,
    /// one of &#39;source_ranges&#39;, &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required.
    /// </summary>
    public HashSet<string>? SourceTags
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("source_tags")?.Value;
        set => this.WithProperty("source_tags", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    public HashSet<string>? TargetServiceAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_service_accounts")?.Value;
        set => this.WithProperty("target_service_accounts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    public HashSet<string>? TargetTags
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_tags")?.Value;
        set => this.WithProperty("target_tags", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
