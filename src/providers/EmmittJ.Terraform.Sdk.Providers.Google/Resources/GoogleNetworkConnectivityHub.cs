using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityHubTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_connectivity_hub resource.
/// </summary>
public class GoogleNetworkConnectivityHub : TerraformResource
{
    public GoogleNetworkConnectivityHub(string name) : base("google_network_connectivity_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("routing_vpcs");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("unique_id");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("export_psc");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("policy_mode");
        SetOutput("preset_topology");
        SetOutput("project");
    }

    /// <summary>
    /// An optional description of the hub.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Whether Private Service Connect transitivity is enabled for the hub. If true, Private Service Connect endpoints in VPC spokes attached to the hub are made accessible to other VPC spokes attached to the hub. The default value is false.
    /// </summary>
    public TerraformProperty<bool> ExportPsc
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_psc");
        set => SetProperty("export_psc", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Immutable. The name of the hub. Hub names must be unique. They use the following form: &#39;projects/{project_number}/locations/global/hubs/{hub_id}&#39;
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Optional. The policy mode of this hub. This field can be either PRESET or CUSTOM. If unspecified, the policyMode defaults to PRESET. Possible values: [&amp;quot;CUSTOM&amp;quot;, &amp;quot;PRESET&amp;quot;]
    /// </summary>
    public TerraformProperty<string> PolicyMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_mode");
        set => SetProperty("policy_mode", value);
    }

    /// <summary>
    /// Optional. The topology implemented in this hub. Currently, this field is only used when policyMode = PRESET. The available preset topologies are MESH and STAR. If presetTopology is unspecified and policyMode = PRESET, the presetTopology defaults to MESH. When policyMode = CUSTOM, the presetTopology is set to PRESET_TOPOLOGY_UNSPECIFIED. Possible values: [&amp;quot;MESH&amp;quot;, &amp;quot;STAR&amp;quot;, &amp;quot;HYBRID_INSPECTION&amp;quot;]
    /// </summary>
    public TerraformProperty<string> PresetTopology
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preset_topology");
        set => SetProperty("preset_topology", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkConnectivityHubTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time the hub was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The VPC network associated with this hub&#39;s spokes. All of the VPN tunnels, VLAN attachments, and router appliance instances referenced by this hub&#39;s spokes must belong to this VPC network. This field is read-only. Network Connectivity Center automatically populates it based on the set of spokes attached to the hub.
    /// </summary>
    public TerraformExpression RoutingVpcs => this["routing_vpcs"];

    /// <summary>
    /// Output only. The current lifecycle state of this hub.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The Google-generated UUID for the hub. This value is unique across all hub resources. If a hub is deleted and another with the same name is created, the new hub is assigned a different unique_id.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

    /// <summary>
    /// Output only. The time the hub was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
