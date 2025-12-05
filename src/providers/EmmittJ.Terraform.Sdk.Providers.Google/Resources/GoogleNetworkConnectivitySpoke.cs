using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for linked_interconnect_attachments in GoogleNetworkConnectivitySpoke.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_interconnect_attachments";

    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    public TerraformList<string>? IncludeImportRanges
    {
        get => GetArgument<TerraformList<string>>("include_import_ranges");
        set => SetArgument("include_import_ranges", value);
    }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    public required TerraformValue<bool> SiteToSiteDataTransfer
    {
        get => GetRequiredArgument<TerraformValue<bool>>("site_to_site_data_transfer");
        set => SetArgument("site_to_site_data_transfer", value);
    }

    /// <summary>
    /// The URIs of linked interconnect attachment resources
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public TerraformList<string>? Uris
    {
        get => GetArgument<TerraformList<string>>("uris");
        set => SetArgument("uris", value);
    }

}


/// <summary>
/// Block type for linked_producer_vpc_network in GoogleNetworkConnectivitySpoke.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_producer_vpc_network";

    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    public TerraformList<string>? ExcludeExportRanges
    {
        get => GetArgument<TerraformList<string>>("exclude_export_ranges");
        set => SetArgument("exclude_export_ranges", value);
    }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    public TerraformList<string>? IncludeExportRanges
    {
        get => GetArgument<TerraformList<string>>("include_export_ranges");
        set => SetArgument("include_export_ranges", value);
    }

    /// <summary>
    /// The URI of the Service Consumer VPC that the Producer VPC is peered with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The name of the VPC peering between the Service Consumer VPC and the Producer VPC (defined in the Tenant project) which is added to the NCC hub. This peering must be in ACTIVE state.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformValue<string> Peering
    {
        get => GetRequiredArgument<TerraformValue<string>>("peering");
        set => SetArgument("peering", value);
    }

    /// <summary>
    /// The URI of the Producer VPC.
    /// </summary>
    public TerraformValue<string> ProducerNetwork
        => CreateReference("producer_network");

}


/// <summary>
/// Block type for linked_router_appliance_instances in GoogleNetworkConnectivitySpoke.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_router_appliance_instances";

    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    public TerraformList<string>? IncludeImportRanges
    {
        get => GetArgument<TerraformList<string>>("include_import_ranges");
        set => SetArgument("include_import_ranges", value);
    }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    public required TerraformValue<bool> SiteToSiteDataTransfer
    {
        get => GetRequiredArgument<TerraformValue<bool>>("site_to_site_data_transfer");
        set => SetArgument("site_to_site_data_transfer", value);
    }

    /// <summary>
    /// Instances block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instances is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Instances block(s) required")]
    public required TerraformList<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlockInstancesBlock> Instances
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlockInstancesBlock>>("instances");
        set => SetArgument("instances", value);
    }

}

/// <summary>
/// Block type for instances in GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlockInstancesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instances";

    /// <summary>
    /// The IP address on the VM to use for peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The URI of the virtual machine resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachine is required")]
    public required TerraformValue<string> VirtualMachine
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

}


/// <summary>
/// Block type for linked_vpc_network in GoogleNetworkConnectivitySpoke.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_vpc_network";

    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    public TerraformList<string>? ExcludeExportRanges
    {
        get => GetArgument<TerraformList<string>>("exclude_export_ranges");
        set => SetArgument("exclude_export_ranges", value);
    }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    public TerraformList<string>? IncludeExportRanges
    {
        get => GetArgument<TerraformList<string>>("include_export_ranges");
        set => SetArgument("include_export_ranges", value);
    }

    /// <summary>
    /// The URI of the VPC network resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for linked_vpn_tunnels in GoogleNetworkConnectivitySpoke.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_vpn_tunnels";

    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    public TerraformList<string>? IncludeImportRanges
    {
        get => GetArgument<TerraformList<string>>("include_import_ranges");
        set => SetArgument("include_import_ranges", value);
    }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    public required TerraformValue<bool> SiteToSiteDataTransfer
    {
        get => GetRequiredArgument<TerraformValue<bool>>("site_to_site_data_transfer");
        set => SetArgument("site_to_site_data_transfer", value);
    }

    /// <summary>
    /// The URIs of linked VPN tunnel resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public TerraformList<string>? Uris
    {
        get => GetArgument<TerraformList<string>>("uris");
        set => SetArgument("uris", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkConnectivitySpoke.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivitySpokeTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_connectivity_spoke Terraform resource.
/// Manages a google_network_connectivity_spoke resource.
/// </summary>
public partial class GoogleNetworkConnectivitySpoke(string name) : TerraformResource("google_network_connectivity_spoke", name)
{
    /// <summary>
    /// An optional description of the spoke.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name of the group that this spoke is associated with.
    /// </summary>
    public TerraformValue<string> Group
    {
        get => GetArgument<TerraformValue<string>>("group") ?? CreateReference("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// Immutable. The URI of the hub that this spoke is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hub is required")]
    public required TerraformValue<string> Hub
    {
        get => GetRequiredArgument<TerraformValue<string>>("hub");
        set => SetArgument("hub", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Immutable. The name of the spoke. Spoke names must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The time the spoke was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The reasons for the current state in the lifecycle
    /// </summary>
    public TerraformList<TerraformMap<object>> Reasons
        => CreateReference("reasons");

    /// <summary>
    /// Output only. The current lifecycle state of this spoke.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Output only. The Google-generated UUID for the spoke. This value is unique across all spoke resources. If a spoke is deleted and another with the same name is created, the new spoke is assigned a different unique_id.
    /// </summary>
    public TerraformValue<string> UniqueId
        => CreateReference("unique_id");

    /// <summary>
    /// Output only. The time the spoke was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// LinkedInterconnectAttachments block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedInterconnectAttachments block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock>? LinkedInterconnectAttachments
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock>>("linked_interconnect_attachments");
        set => SetArgument("linked_interconnect_attachments", value);
    }

    /// <summary>
    /// LinkedProducerVpcNetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedProducerVpcNetwork block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock>? LinkedProducerVpcNetwork
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock>>("linked_producer_vpc_network");
        set => SetArgument("linked_producer_vpc_network", value);
    }

    /// <summary>
    /// LinkedRouterApplianceInstances block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedRouterApplianceInstances block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock>? LinkedRouterApplianceInstances
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock>>("linked_router_appliance_instances");
        set => SetArgument("linked_router_appliance_instances", value);
    }

    /// <summary>
    /// LinkedVpcNetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpcNetwork block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock>? LinkedVpcNetwork
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock>>("linked_vpc_network");
        set => SetArgument("linked_vpc_network", value);
    }

    /// <summary>
    /// LinkedVpnTunnels block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpnTunnels block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock>? LinkedVpnTunnels
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock>>("linked_vpn_tunnels");
        set => SetArgument("linked_vpn_tunnels", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkConnectivitySpokeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkConnectivitySpokeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
