using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkConnectivityHubTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_connectivity_hub resource.
/// </summary>
public partial class GoogleNetworkConnectivityHub : TerraformResource
{
    public GoogleNetworkConnectivityHub(string name) : base("google_network_connectivity_hub", name)
    {
    }

    /// <summary>
    /// An optional description of the hub.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether Private Service Connect transitivity is enabled for the hub. If true, Private Service Connect endpoints in VPC spokes attached to the hub are made accessible to other VPC spokes attached to the hub. The default value is false.
    /// </summary>
    [TerraformProperty("export_psc")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ExportPsc { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Immutable. The name of the hub. Hub names must be unique. They use the following form: &#39;projects/{project_number}/locations/global/hubs/{hub_id}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Optional. The policy mode of this hub. This field can be either PRESET or CUSTOM. If unspecified, the policyMode defaults to PRESET. Possible values: [&amp;quot;CUSTOM&amp;quot;, &amp;quot;PRESET&amp;quot;]
    /// </summary>
    [TerraformProperty("policy_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PolicyMode { get; set; }

    /// <summary>
    /// Optional. The topology implemented in this hub. Currently, this field is only used when policyMode = PRESET. The available preset topologies are MESH and STAR. If presetTopology is unspecified and policyMode = PRESET, the presetTopology defaults to MESH. When policyMode = CUSTOM, the presetTopology is set to PRESET_TOPOLOGY_UNSPECIFIED. Possible values: [&amp;quot;MESH&amp;quot;, &amp;quot;STAR&amp;quot;, &amp;quot;HYBRID_INSPECTION&amp;quot;]
    /// </summary>
    [TerraformProperty("preset_topology")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PresetTopology { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkConnectivityHubTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time the hub was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The VPC network associated with this hub&#39;s spokes. All of the VPN tunnels, VLAN attachments, and router appliance instances referenced by this hub&#39;s spokes must belong to this VPC network. This field is read-only. Network Connectivity Center automatically populates it based on the set of spokes attached to the hub.
    /// </summary>
    [TerraformProperty("routing_vpcs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RoutingVpcs { get; }

    /// <summary>
    /// Output only. The current lifecycle state of this hub.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The Google-generated UUID for the hub. This value is unique across all hub resources. If a hub is deleted and another with the same name is created, the new hub is assigned a different unique_id.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueId { get; }

    /// <summary>
    /// Output only. The time the hub was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
