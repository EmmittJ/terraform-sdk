using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_subnetwork resource.
/// </summary>
public class GoogleComputeSubnetwork : TerraformResource
{
    public GoogleComputeSubnetwork(string name) : base("google_compute_subnetwork", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("gateway_address");
        this.DeclareOutput("internal_ipv6_prefix");
        this.DeclareOutput("ipv6_cidr_range");
        this.DeclareOutput("ipv6_gce_endpoint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("state");
        this.DeclareOutput("subnetwork_id");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource. This field can be set only at resource
    /// creation time.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The range of external IPv6 addresses that are owned by this subnetwork.
    /// </summary>
    public TerraformProperty<string>? ExternalIpv6Prefix
    {
        get => GetProperty<TerraformProperty<string>>("external_ipv6_prefix");
        set => this.WithProperty("external_ipv6_prefix", value);
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
    /// The range of internal addresses that are owned by this subnetwork.
    /// Provide this property when you create the subnetwork. For example,
    /// 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and
    /// non-overlapping within a network. Only IPv4 is supported.
    /// Field is optional when &#39;reserved_internal_range&#39; is defined, otherwise required.
    /// </summary>
    public TerraformProperty<string>? IpCidrRange
    {
        get => GetProperty<TerraformProperty<string>>("ip_cidr_range");
        set => this.WithProperty("ip_cidr_range", value);
    }

    /// <summary>
    /// Resource reference of a PublicDelegatedPrefix. The PDP must be a sub-PDP
    /// in EXTERNAL_IPV6_SUBNETWORK_CREATION mode.
    /// Use one of the following formats to specify a sub-PDP when creating an
    /// IPv6 NetLB forwarding rule using BYOIP:
    /// Full resource URL, as in:
    ///   * &#39;https://www.googleapis.com/compute/v1/projects/{{projectId}}/regions/{{region}}/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    /// Partial URL, as in:
    ///   * &#39;projects/{{projectId}}/regions/region/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    ///   * &#39;regions/{{region}}/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    /// </summary>
    public TerraformProperty<string>? IpCollection
    {
        get => GetProperty<TerraformProperty<string>>("ip_collection");
        set => this.WithProperty("ip_collection", value);
    }

    /// <summary>
    /// The access type of IPv6 address this subnet holds. It&#39;s immutable and can only be specified during creation
    /// or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet
    /// cannot enable direct path. Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Ipv6AccessType
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_access_type");
        set => this.WithProperty("ipv6_access_type", value);
    }

    /// <summary>
    /// The name of the resource, provided by the client when initially
    /// creating the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which
    /// means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network this subnet belongs to.
    /// Only networks that are in the distributed mode can have subnetworks.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// When enabled, VMs in this subnetwork without external IP addresses can
    /// access Google APIs and services by using Private Google Access.
    /// </summary>
    public TerraformProperty<bool>? PrivateIpGoogleAccess
    {
        get => GetProperty<TerraformProperty<bool>>("private_ip_google_access");
        set => this.WithProperty("private_ip_google_access", value);
    }

    /// <summary>
    /// The private IPv6 google access type for the VMs in this subnet.
    /// </summary>
    public TerraformProperty<string>? PrivateIpv6GoogleAccess
    {
        get => GetProperty<TerraformProperty<string>>("private_ipv6_google_access");
        set => this.WithProperty("private_ipv6_google_access", value);
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
    /// The purpose of the resource. This field can be either &#39;PRIVATE&#39;, &#39;REGIONAL_MANAGED_PROXY&#39;, &#39;GLOBAL_MANAGED_PROXY&#39;, &#39;PRIVATE_SERVICE_CONNECT&#39;, &#39;PEER_MIGRATION&#39; or &#39;PRIVATE_NAT&#39;([Beta](https://terraform.io/docs/providers/google/guides/provider_versions.html)).
    /// A subnet with purpose set to &#39;REGIONAL_MANAGED_PROXY&#39; is a user-created subnetwork that is reserved for regional Envoy-based load balancers.
    /// A subnetwork in a given region with purpose set to &#39;GLOBAL_MANAGED_PROXY&#39; is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers.
    /// A subnetwork with purpose set to &#39;PRIVATE_SERVICE_CONNECT&#39; reserves the subnet for hosting a Private Service Connect published service.
    /// A subnetwork with purpose set to &#39;PEER_MIGRATION&#39; is a user created subnetwork that is reserved for migrating resources from one peered network to another.
    /// A subnetwork with purpose set to &#39;PRIVATE_NAT&#39; is used as source range for Private NAT gateways.
    /// Note that &#39;REGIONAL_MANAGED_PROXY&#39; is the preferred setting for all regional Envoy load balancers.
    /// If unspecified, the purpose defaults to &#39;PRIVATE&#39;.
    /// </summary>
    public TerraformProperty<string>? Purpose
    {
        get => GetProperty<TerraformProperty<string>>("purpose");
        set => this.WithProperty("purpose", value);
    }

    /// <summary>
    /// The GCP region for this subnetwork.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The ID of the reserved internal range. Must be prefixed with &#39;networkconnectivity.googleapis.com&#39;
    /// E.g. &#39;networkconnectivity.googleapis.com/projects/{project}/locations/global/internalRanges/{rangeId}&#39;
    /// </summary>
    public TerraformProperty<string>? ReservedInternalRange
    {
        get => GetProperty<TerraformProperty<string>>("reserved_internal_range");
        set => this.WithProperty("reserved_internal_range", value);
    }

    /// <summary>
    /// The role of subnetwork.
    /// Currently, this field is only used when &#39;purpose&#39; is &#39;REGIONAL_MANAGED_PROXY&#39;.
    /// The value can be set to &#39;ACTIVE&#39; or &#39;BACKUP&#39;.
    /// An &#39;ACTIVE&#39; subnetwork is one that is currently being used for Envoy-based load balancers in a region.
    /// A &#39;BACKUP&#39; subnetwork is one that is ready to be promoted to &#39;ACTIVE&#39; or is currently draining. Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;BACKUP&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// Controls the removal behavior of secondary_ip_range.
    /// When false, removing secondary_ip_range from config will not produce a diff as
    /// the provider will default to the API&#39;s value.
    /// When true, the provider will treat removing secondary_ip_range as sending an
    /// empty list of secondary IP ranges to the API.
    /// Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? SendSecondaryIpRangeIfEmpty
    {
        get => GetProperty<TerraformProperty<bool>>("send_secondary_ip_range_if_empty");
        set => this.WithProperty("send_secondary_ip_range_if_empty", value);
    }

    /// <summary>
    /// The stack type for this subnet to identify whether the IPv6 feature is enabled or not.
    /// If not specified IPV4_ONLY will be used. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? StackType
    {
        get => GetProperty<TerraformProperty<string>>("stack_type");
        set => this.WithProperty("stack_type", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during updates of this resource.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The gateway address for default routes to reach destination addresses
    /// outside this subnetwork.
    /// </summary>
    public TerraformExpression GatewayAddress => this["gateway_address"];

    /// <summary>
    /// The internal IPv6 address range that is assigned to this subnetwork.
    /// </summary>
    public TerraformExpression InternalIpv6Prefix => this["internal_ipv6_prefix"];

    /// <summary>
    /// The range of internal IPv6 addresses that are owned by this subnetwork.
    /// </summary>
    public TerraformExpression Ipv6CidrRange => this["ipv6_cidr_range"];

    /// <summary>
    /// Possible endpoints of this subnetwork. It can be one of the following:
    ///   * VM_ONLY: The subnetwork can be used for creating instances and IPv6 addresses with VM endpoint type. Such a subnetwork
    ///   gets external IPv6 ranges from a public delegated prefix and cannot be used to create NetLb.
    ///   * VM_AND_FR: The subnetwork can be used for creating both VM instances and Forwarding Rules. It can also be used to reserve
    ///   IPv6 addresses with both VM and FR endpoint types. Such a subnetwork gets its IPv6 range from Google IP Pool directly.
    /// </summary>
    public TerraformExpression Ipv6GceEndpoint => this["ipv6_gce_endpoint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// &#39;The state of the subnetwork, which can be one of the following values:
    ///  READY: Subnetwork is created and ready to use DRAINING: only applicable to subnetworks that have the purpose
    ///  set to INTERNAL_HTTPS_LOAD_BALANCER and indicates that connections to the load balancer are being drained.
    ///  A subnetwork that is draining cannot be used or modified until it reaches a status of READY&#39;
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression SubnetworkId => this["subnetwork_id"];

}
