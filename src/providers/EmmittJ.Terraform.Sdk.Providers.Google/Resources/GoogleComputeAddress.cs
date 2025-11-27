using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeAddress.
/// Nesting mode: single
/// </summary>
public class GoogleComputeAddressTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_address Terraform resource.
/// Manages a google_compute_address resource.
/// </summary>
public partial class GoogleComputeAddress(string name) : TerraformResource("google_compute_address", name)
{
    /// <summary>
    /// The static external IP address represented by this resource.
    /// The IP address must be inside the specified subnetwork,
    /// if any. Set by the API if undefined.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => new TerraformReference<string>(this, "address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type of address to reserve.
    /// Note: if you set this argument&#39;s value as &#39;INTERNAL&#39; you need to leave the &#39;network_tier&#39; argument unset in that resource block. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;INTERNAL&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AddressType
    {
        get => new TerraformReference<string>(this, "address_type");
        set => SetArgument("address_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpVersion
    {
        get => new TerraformReference<string>(this, "ip_version");
        set => SetArgument("ip_version", value);
    }

    /// <summary>
    /// The endpoint type of this address, which should be VM or NETLB. This is
    /// used for deciding which type of endpoint this address can be used after
    /// the external IPv6 address reservation. Possible values: [&amp;quot;VM&amp;quot;, &amp;quot;NETLB&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Ipv6EndpointType
    {
        get => new TerraformReference<string>(this, "ipv6_endpoint_type");
        set => SetArgument("ipv6_endpoint_type", value);
    }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The URL of the network in which to reserve the address. This field
    /// can only be used with INTERNAL type with the VPC_PEERING and
    /// IPSEC_INTERCONNECT purposes.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The networking tier used for configuring this address. If this field is not
    /// specified, it is assumed to be PREMIUM.
    /// This argument should not be used when configuring Internal addresses, because [network tier cannot be set for internal traffic; it&#39;s always Premium](https://cloud.google.com/network-tiers/docs/overview). Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformValue<string> NetworkTier
    {
        get => new TerraformReference<string>(this, "network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The prefix length if the resource represents an IP range.
    /// </summary>
    public TerraformValue<double> PrefixLength
    {
        get => new TerraformReference<double>(this, "prefix_length");
        set => SetArgument("prefix_length", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
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
    public TerraformValue<string> Purpose
    {
        get => new TerraformReference<string>(this, "purpose");
        set => SetArgument("purpose", value);
    }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The URL of the subnetwork in which to reserve the address. If an IP
    /// address is specified, it must be within the subnetwork&#39;s IP range.
    /// This field can only be used with INTERNAL type with
    /// GCE_ENDPOINT/DNS_RESOLVER purposes.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
    {
        get => new TerraformReference<string>(this, "label_fingerprint");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URLs of the resources that are using this address.
    /// </summary>
    public TerraformList<string> Users
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "users").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeAddressTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeAddressTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
