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
    public TerraformProperty<string>? Address
    {
        get => GetProperty<TerraformProperty<string>>("address");
        set => this.WithProperty("address", value);
    }

    /// <summary>
    /// The type of address to reserve.
    /// Note: if you set this argument&#39;s value as &#39;INTERNAL&#39; you need to leave the &#39;network_tier&#39; argument unset in that resource block. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;INTERNAL&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AddressType
    {
        get => GetProperty<TerraformProperty<string>>("address_type");
        set => this.WithProperty("address_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IpVersion
    {
        get => GetProperty<TerraformProperty<string>>("ip_version");
        set => this.WithProperty("ip_version", value);
    }

    /// <summary>
    /// The endpoint type of this address, which should be VM or NETLB. This is
    /// used for deciding which type of endpoint this address can be used after
    /// the external IPv6 address reservation. Possible values: [&amp;quot;VM&amp;quot;, &amp;quot;NETLB&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Ipv6EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_endpoint_type");
        set => this.WithProperty("ipv6_endpoint_type", value);
    }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The URL of the network in which to reserve the address. This field
    /// can only be used with INTERNAL type with the VPC_PEERING and
    /// IPSEC_INTERCONNECT purposes.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The networking tier used for configuring this address. If this field is not
    /// specified, it is assumed to be PREMIUM.
    /// This argument should not be used when configuring Internal addresses, because [network tier cannot be set for internal traffic; it&#39;s always Premium](https://cloud.google.com/network-tiers/docs/overview). Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NetworkTier
    {
        get => GetProperty<TerraformProperty<string>>("network_tier");
        set => this.WithProperty("network_tier", value);
    }

    /// <summary>
    /// The prefix length if the resource represents an IP range.
    /// </summary>
    public TerraformProperty<double>? PrefixLength
    {
        get => GetProperty<TerraformProperty<double>>("prefix_length");
        set => this.WithProperty("prefix_length", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<string>? Purpose
    {
        get => GetProperty<TerraformProperty<string>>("purpose");
        set => this.WithProperty("purpose", value);
    }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The URL of the subnetwork in which to reserve the address. If an IP
    /// address is specified, it must be within the subnetwork&#39;s IP range.
    /// This field can only be used with INTERNAL type with
    /// GCE_ENDPOINT/DNS_RESOLVER purposes.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => this.WithProperty("subnetwork", value);
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
