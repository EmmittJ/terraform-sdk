using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for linked_interconnect_attachments in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    [TerraformPropertyName("include_import_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludeImportRanges { get; set; }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    [TerraformPropertyName("site_to_site_data_transfer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> SiteToSiteDataTransfer { get; set; }

    /// <summary>
    /// The URIs of linked interconnect attachment resources
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformPropertyName("uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Uris { get; set; }

}

/// <summary>
/// Block type for linked_producer_vpc_network in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock
{
    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    [TerraformPropertyName("exclude_export_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludeExportRanges { get; set; }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    [TerraformPropertyName("include_export_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludeExportRanges { get; set; }

    /// <summary>
    /// The URI of the Service Consumer VPC that the Producer VPC is peered with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The name of the VPC peering between the Service Consumer VPC and the Producer VPC (defined in the Tenant project) which is added to the NCC hub. This peering must be in ACTIVE state.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    [TerraformPropertyName("peering")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Peering { get; set; }


}

/// <summary>
/// Block type for linked_router_appliance_instances in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    [TerraformPropertyName("include_import_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludeImportRanges { get; set; }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    [TerraformPropertyName("site_to_site_data_transfer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> SiteToSiteDataTransfer { get; set; }

}

/// <summary>
/// Block type for linked_vpc_network in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock
{
    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    [TerraformPropertyName("exclude_export_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludeExportRanges { get; set; }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    [TerraformPropertyName("include_export_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludeExportRanges { get; set; }

    /// <summary>
    /// The URI of the VPC network resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for linked_vpn_tunnels in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    [TerraformPropertyName("include_import_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludeImportRanges { get; set; }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    [TerraformPropertyName("site_to_site_data_transfer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> SiteToSiteDataTransfer { get; set; }

    /// <summary>
    /// The URIs of linked VPN tunnel resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformPropertyName("uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Uris { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivitySpokeTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_connectivity_spoke resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkConnectivitySpoke : TerraformResource
{
    public GoogleNetworkConnectivitySpoke(string name) : base("google_network_connectivity_spoke", name)
    {
    }

    /// <summary>
    /// An optional description of the spoke.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name of the group that this spoke is associated with.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Group { get; set; } = default!;

    /// <summary>
    /// Immutable. The URI of the hub that this spoke is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hub is required")]
    [TerraformPropertyName("hub")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Hub { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The name of the spoke. Spoke names must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for linked_interconnect_attachments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedInterconnectAttachments block(s) allowed")]
    [TerraformPropertyName("linked_interconnect_attachments")]
    public TerraformList<TerraformBlock<GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock>>? LinkedInterconnectAttachments { get; set; }

    /// <summary>
    /// Block for linked_producer_vpc_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedProducerVpcNetwork block(s) allowed")]
    [TerraformPropertyName("linked_producer_vpc_network")]
    public TerraformList<TerraformBlock<GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock>>? LinkedProducerVpcNetwork { get; set; }

    /// <summary>
    /// Block for linked_router_appliance_instances.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedRouterApplianceInstances block(s) allowed")]
    [TerraformPropertyName("linked_router_appliance_instances")]
    public TerraformList<TerraformBlock<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock>>? LinkedRouterApplianceInstances { get; set; }

    /// <summary>
    /// Block for linked_vpc_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpcNetwork block(s) allowed")]
    [TerraformPropertyName("linked_vpc_network")]
    public TerraformList<TerraformBlock<GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock>>? LinkedVpcNetwork { get; set; }

    /// <summary>
    /// Block for linked_vpn_tunnels.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpnTunnels block(s) allowed")]
    [TerraformPropertyName("linked_vpn_tunnels")]
    public TerraformList<TerraformBlock<GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock>>? LinkedVpnTunnels { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkConnectivitySpokeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The time the spoke was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The reasons for the current state in the lifecycle
    /// </summary>
    [TerraformPropertyName("reasons")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Reasons => new TerraformReference(this, "reasons");

    /// <summary>
    /// Output only. The current lifecycle state of this spoke.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Output only. The Google-generated UUID for the spoke. This value is unique across all spoke resources. If a spoke is deleted and another with the same name is created, the new spoke is assigned a different unique_id.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UniqueId => new TerraformReference(this, "unique_id");

    /// <summary>
    /// Output only. The time the spoke was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
