using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_logging_config in GoogleDnsManagedZone.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneCloudLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_logging_config";

    /// <summary>
    /// If set, enable query logging for this ManagedZone. False by default, making logging opt-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableLogging is required")]
    public required TerraformValue<bool> EnableLogging
    {
        get => new TerraformReference<bool>(this, "enable_logging");
        set => SetArgument("enable_logging", value);
    }

}


/// <summary>
/// Block type for dnssec_config in GoogleDnsManagedZone.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneDnssecConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dnssec_config";

    /// <summary>
    /// Identifies what kind of resource this is
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is &#39;off&#39;. Possible values: [&amp;quot;nsec&amp;quot;, &amp;quot;nsec3&amp;quot;]
    /// </summary>
    public TerraformValue<string> NonExistence
    {
        get => new TerraformReference<string>(this, "non_existence");
        set => SetArgument("non_existence", value);
    }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in Possible values: [&amp;quot;off&amp;quot;, &amp;quot;on&amp;quot;, &amp;quot;transfer&amp;quot;]
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// DefaultKeySpecs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsManagedZoneDnssecConfigBlockDefaultKeySpecsBlock>? DefaultKeySpecs
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZoneDnssecConfigBlockDefaultKeySpecsBlock>>("default_key_specs");
        set => SetArgument("default_key_specs", value);
    }

}

/// <summary>
/// Block type for default_key_specs in GoogleDnsManagedZoneDnssecConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneDnssecConfigBlockDefaultKeySpecsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_key_specs";

    /// <summary>
    /// String mnemonic specifying the DNSSEC algorithm of this key Possible values: [&amp;quot;ecdsap256sha256&amp;quot;, &amp;quot;ecdsap384sha384&amp;quot;, &amp;quot;rsasha1&amp;quot;, &amp;quot;rsasha256&amp;quot;, &amp;quot;rsasha512&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Algorithm
    {
        get => new TerraformReference<string>(this, "algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// Length of the keys in bits
    /// </summary>
    public TerraformValue<double>? KeyLength
    {
        get => new TerraformReference<double>(this, "key_length");
        set => SetArgument("key_length", value);
    }

    /// <summary>
    /// Specifies whether this is a key signing key (KSK) or a zone
    /// signing key (ZSK). Key signing keys have the Secure Entry
    /// Point flag set and, when active, will only be used to sign
    /// resource record sets of type DNSKEY. Zone signing keys do
    /// not have the Secure Entry Point flag set and will be used
    /// to sign all other types of resource record sets. Possible values: [&amp;quot;keySigning&amp;quot;, &amp;quot;zoneSigning&amp;quot;]
    /// </summary>
    public TerraformValue<string>? KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
        set => SetArgument("key_type", value);
    }

    /// <summary>
    /// Identifies what kind of resource this is
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

}


/// <summary>
/// Block type for forwarding_config in GoogleDnsManagedZone.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneForwardingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarding_config";

    /// <summary>
    /// TargetNameServers block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNameServers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetNameServers block(s) required")]
    public required TerraformSet<GoogleDnsManagedZoneForwardingConfigBlockTargetNameServersBlock> TargetNameServers
    {
        get => GetRequiredArgument<TerraformSet<GoogleDnsManagedZoneForwardingConfigBlockTargetNameServersBlock>>("target_name_servers");
        set => SetArgument("target_name_servers", value);
    }

}

/// <summary>
/// Block type for target_name_servers in GoogleDnsManagedZoneForwardingConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDnsManagedZoneForwardingConfigBlockTargetNameServersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_name_servers";

    /// <summary>
    /// Fully qualified domain name for the forwarding target.
    /// </summary>
    public TerraformValue<string>? DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or &#39;default&#39; Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to &#39;private&#39;, Cloud DNS will always send queries through VPC for this target Possible values: [&amp;quot;default&amp;quot;, &amp;quot;private&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ForwardingPath
    {
        get => new TerraformReference<string>(this, "forwarding_path");
        set => SetArgument("forwarding_path", value);
    }

    /// <summary>
    /// IPv4 address of a target name server.
    /// </summary>
    public TerraformValue<string>? Ipv4Address
    {
        get => new TerraformReference<string>(this, "ipv4_address");
        set => SetArgument("ipv4_address", value);
    }

}


/// <summary>
/// Block type for peering_config in GoogleDnsManagedZone.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "peering_config";

    /// <summary>
    /// TargetNetwork block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetNetwork block(s) allowed")]
    public required TerraformList<GoogleDnsManagedZonePeeringConfigBlockTargetNetworkBlock> TargetNetwork
    {
        get => GetRequiredArgument<TerraformList<GoogleDnsManagedZonePeeringConfigBlockTargetNetworkBlock>>("target_network");
        set => SetArgument("target_network", value);
    }

}

/// <summary>
/// Block type for target_network in GoogleDnsManagedZonePeeringConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePeeringConfigBlockTargetNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_network";

    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like &#39;projects/{project}/global/networks/{network}&#39; or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => new TerraformReference<string>(this, "network_url");
        set => SetArgument("network_url", value);
    }

}


/// <summary>
/// Block type for private_visibility_config in GoogleDnsManagedZone.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePrivateVisibilityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_visibility_config";

    /// <summary>
    /// GkeClusters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsManagedZonePrivateVisibilityConfigBlockGkeClustersBlock>? GkeClusters
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZonePrivateVisibilityConfigBlockGkeClustersBlock>>("gke_clusters");
        set => SetArgument("gke_clusters", value);
    }

    /// <summary>
    /// Networks block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDnsManagedZonePrivateVisibilityConfigBlockNetworksBlock>? Networks
    {
        get => GetArgument<TerraformSet<GoogleDnsManagedZonePrivateVisibilityConfigBlockNetworksBlock>>("networks");
        set => SetArgument("networks", value);
    }

}

/// <summary>
/// Block type for gke_clusters in GoogleDnsManagedZonePrivateVisibilityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePrivateVisibilityConfigBlockGkeClustersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_clusters";

    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// &#39;projects/*/locations/*/clusters/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GkeClusterName is required")]
    public required TerraformValue<string> GkeClusterName
    {
        get => new TerraformReference<string>(this, "gke_cluster_name");
        set => SetArgument("gke_cluster_name", value);
    }

}

/// <summary>
/// Block type for networks in GoogleDnsManagedZonePrivateVisibilityConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDnsManagedZonePrivateVisibilityConfigBlockNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networks";

    /// <summary>
    /// The id or fully qualified URL of the VPC network to bind to.
    /// This should be formatted like &#39;projects/{project}/global/networks/{network}&#39; or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => new TerraformReference<string>(this, "network_url");
        set => SetArgument("network_url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDnsManagedZone.
/// Nesting mode: single
/// </summary>
public class GoogleDnsManagedZoneTimeoutsBlock : TerraformBlock
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
/// Represents a google_dns_managed_zone Terraform resource.
/// Manages a google_dns_managed_zone resource.
/// </summary>
public partial class GoogleDnsManagedZone(string name) : TerraformResource("google_dns_managed_zone", name)
{
    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The DNS name of this managed zone, for instance &amp;quot;example.com.&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    public required TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// Set this true to delete all records in the zone.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// A set of key/value label pairs to assign to this ManagedZone.
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
    /// User assigned name for this resource.
    /// Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The zone&#39;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources. Default value: &amp;quot;public&amp;quot; Possible values: [&amp;quot;private&amp;quot;, &amp;quot;public&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Unique identifier for the resource; defined by the server.
    /// </summary>
    public TerraformValue<double> ManagedZoneId
    {
        get => new TerraformReference<double>(this, "managed_zone_id");
    }

    /// <summary>
    /// Delegate your managed_zone to these virtual name servers;
    /// defined by the server
    /// </summary>
    public TerraformList<string> NameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "name_servers").ResolveNodes(ctx));
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
    /// CloudLoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudLoggingConfig block(s) allowed")]
    public TerraformList<GoogleDnsManagedZoneCloudLoggingConfigBlock>? CloudLoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZoneCloudLoggingConfigBlock>>("cloud_logging_config");
        set => SetArgument("cloud_logging_config", value);
    }

    /// <summary>
    /// DnssecConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnssecConfig block(s) allowed")]
    public TerraformList<GoogleDnsManagedZoneDnssecConfigBlock>? DnssecConfig
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZoneDnssecConfigBlock>>("dnssec_config");
        set => SetArgument("dnssec_config", value);
    }

    /// <summary>
    /// ForwardingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardingConfig block(s) allowed")]
    public TerraformList<GoogleDnsManagedZoneForwardingConfigBlock>? ForwardingConfig
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZoneForwardingConfigBlock>>("forwarding_config");
        set => SetArgument("forwarding_config", value);
    }

    /// <summary>
    /// PeeringConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    public TerraformList<GoogleDnsManagedZonePeeringConfigBlock>? PeeringConfig
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZonePeeringConfigBlock>>("peering_config");
        set => SetArgument("peering_config", value);
    }

    /// <summary>
    /// PrivateVisibilityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateVisibilityConfig block(s) allowed")]
    public TerraformList<GoogleDnsManagedZonePrivateVisibilityConfigBlock>? PrivateVisibilityConfig
    {
        get => GetArgument<TerraformList<GoogleDnsManagedZonePrivateVisibilityConfigBlock>>("private_visibility_config");
        set => SetArgument("private_visibility_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDnsManagedZoneTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDnsManagedZoneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
