using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkConnectivityHub.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityHubTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_connectivity_hub Terraform resource.
/// Manages a google_network_connectivity_hub resource.
/// </summary>
public partial class GoogleNetworkConnectivityHub(string name) : TerraformResource("google_network_connectivity_hub", name)
{
    /// <summary>
    /// An optional description of the hub.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether Private Service Connect transitivity is enabled for the hub. If true, Private Service Connect endpoints in VPC spokes attached to the hub are made accessible to other VPC spokes attached to the hub. The default value is false.
    /// </summary>
    public TerraformValue<bool> ExportPsc
    {
        get => new TerraformReference<bool>(this, "export_psc");
        set => SetArgument("export_psc", value);
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
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
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
    /// Immutable. The name of the hub. Hub names must be unique. They use the following form: &#39;projects/{project_number}/locations/global/hubs/{hub_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional. The policy mode of this hub. This field can be either PRESET or CUSTOM. If unspecified, the policyMode defaults to PRESET. Possible values: [&amp;quot;CUSTOM&amp;quot;, &amp;quot;PRESET&amp;quot;]
    /// </summary>
    public TerraformValue<string> PolicyMode
    {
        get => new TerraformReference<string>(this, "policy_mode");
        set => SetArgument("policy_mode", value);
    }

    /// <summary>
    /// Optional. The topology implemented in this hub. Currently, this field is only used when policyMode = PRESET. The available preset topologies are MESH and STAR. If presetTopology is unspecified and policyMode = PRESET, the presetTopology defaults to MESH. When policyMode = CUSTOM, the presetTopology is set to PRESET_TOPOLOGY_UNSPECIFIED. Possible values: [&amp;quot;MESH&amp;quot;, &amp;quot;STAR&amp;quot;, &amp;quot;HYBRID_INSPECTION&amp;quot;]
    /// </summary>
    public TerraformValue<string> PresetTopology
    {
        get => new TerraformReference<string>(this, "preset_topology");
        set => SetArgument("preset_topology", value);
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
    /// Output only. The time the hub was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The VPC network associated with this hub&#39;s spokes. All of the VPN tunnels, VLAN attachments, and router appliance instances referenced by this hub&#39;s spokes must belong to this VPC network. This field is read-only. Network Connectivity Center automatically populates it based on the set of spokes attached to the hub.
    /// </summary>
    public TerraformList<TerraformMap<object>> RoutingVpcs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "routing_vpcs").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The current lifecycle state of this hub.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
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
    /// Output only. The Google-generated UUID for the hub. This value is unique across all hub resources. If a hub is deleted and another with the same name is created, the new hub is assigned a different unique_id.
    /// </summary>
    public TerraformValue<string> UniqueId
    {
        get => new TerraformReference<string>(this, "unique_id");
    }

    /// <summary>
    /// Output only. The time the hub was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkConnectivityHubTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkConnectivityHubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
