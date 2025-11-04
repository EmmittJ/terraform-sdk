using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_address resource.
/// </summary>
public class GoogleComputeAddress : TerraformResource
{
    public GoogleComputeAddress(string name) : base("google_compute_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("users");
    }

    /// <summary>
    /// The static external IP address represented by this resource.
    /// The IP address must be inside the specified subnetwork,
    /// if any. Set by the API if undefined.
    /// </summary>
    public string? Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address")?.Value;
        set => this.WithProperty("address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of address to reserve.
    /// Note: if you set this argument&#39;s value as &#39;INTERNAL&#39; you need to leave the &#39;network_tier&#39; argument unset in that resource block. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;INTERNAL&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public string? AddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_type")?.Value;
        set => this.WithProperty("address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public string? IpVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_version")?.Value;
        set => this.WithProperty("ip_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint type of this address, which should be VM or NETLB. This is
    /// used for deciding which type of endpoint this address can be used after
    /// the external IPv6 address reservation. Possible values: [&amp;quot;VM&amp;quot;, &amp;quot;NETLB&amp;quot;]
    /// </summary>
    public string? Ipv6EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_endpoint_type")?.Value;
        set => this.WithProperty("ipv6_endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URL of the network in which to reserve the address. This field
    /// can only be used with INTERNAL type with the VPC_PEERING and
    /// IPSEC_INTERCONNECT purposes.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The networking tier used for configuring this address. If this field is not
    /// specified, it is assumed to be PREMIUM.
    /// This argument should not be used when configuring Internal addresses, because [network tier cannot be set for internal traffic; it&#39;s always Premium](https://cloud.google.com/network-tiers/docs/overview). Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public string? NetworkTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_tier")?.Value;
        set => this.WithProperty("network_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prefix length if the resource represents an IP range.
    /// </summary>
    public double? PrefixLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("prefix_length")?.Value;
        set => this.WithProperty("prefix_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The purpose of this resource, which can be one of the following values.
    /// 
    /// * GCE_ENDPOINT for addresses that are used by VM instances, alias IP
    /// ranges, load balancers, and similar resources.
    /// 
    /// * SHARED_LOADBALANCER_VIP for an address that can be used by multiple
    /// internal load balancers.
    /// 
    /// * VPC_PEERING for addresses that are reserved for VPC peer networks.
    /// 
    /// * IPSEC_INTERCONNECT for addresses created from a private IP range that
    /// are reserved for a VLAN attachment in an HA VPN over Cloud Interconnect
    /// configuration. These addresses are regional resources.
    /// 
    /// * PRIVATE_SERVICE_CONNECT for a private network address that is used to
    /// configure Private Service Connect. Only global internal addresses can use
    /// this purpose.
    /// 
    /// This should only be set when using an Internal address.
    /// </summary>
    public string? Purpose
    {
        get => GetProperty<TerraformLiteralProperty<string>>("purpose")?.Value;
        set => this.WithProperty("purpose", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URL of the subnetwork in which to reserve the address. If an IP
    /// address is specified, it must be within the subnetwork&#39;s IP range.
    /// This field can only be used with INTERNAL type with
    /// GCE_ENDPOINT/DNS_RESOLVER purposes.
    /// </summary>
    public string? Subnetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnetwork")?.Value;
        set => this.WithProperty("subnetwork", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The URLs of the resources that are using this address.
    /// </summary>
    public TerraformExpression Users => this["users"];

}
