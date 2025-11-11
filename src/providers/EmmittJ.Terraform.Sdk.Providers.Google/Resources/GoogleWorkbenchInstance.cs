using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gce_setup in .
/// Nesting mode: list
/// </summary>
public partial class GoogleWorkbenchInstanceGceSetupBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. If true, no external IP will be assigned to this VM instance.
    /// </summary>
    [TerraformProperty("disable_public_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisablePublicIp { get; set; }

    /// <summary>
    /// Optional. Flag to enable ip forwarding or not, default false/off.
    /// https://cloud.google.com/vpc/docs/using-routes#canipforward
    /// </summary>
    [TerraformProperty("enable_ip_forwarding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableIpForwarding { get; set; }

    /// <summary>
    /// Optional. The machine type of the VM instance. https://cloud.google.com/compute/docs/machine-resource
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// Optional. Custom metadata to apply to this instance.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// Optional. The Compute Engine tags to add to instance (see [Tagging
    /// instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Tags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleWorkbenchInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_workbench_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleWorkbenchInstance : TerraformResource
{
    public GoogleWorkbenchInstance(string name) : base("google_workbench_instance", name)
    {
    }

    /// <summary>
    /// Desired state of the Workbench Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Optional. If true, the workbench instance will not register with the proxy.
    /// </summary>
    [TerraformProperty("disable_proxy_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableProxyAccess { get; set; }

    /// <summary>
    /// Flag to enable managed end user credentials for the instance.
    /// </summary>
    [TerraformProperty("enable_managed_euc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableManagedEuc { get; set; }

    /// <summary>
    /// Flag that specifies that a notebook can be accessed with third party
    /// identity provider.
    /// </summary>
    [TerraformProperty("enable_third_party_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableThirdPartyIdentity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Required. User-defined unique ID of this instance.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceId { get; set; }

    /// <summary>
    /// &#39;Optional. Input only. The owner of this instance after creation. Format:
    /// &#39;alias@example.com&#39; Currently supports one owner only. If not specified, all of
    /// the service account users of your VM instance&#39;&#39;s service account can use the instance.
    /// If specified, sets the access mode to &#39;Single user&#39;. For more details, see
    /// https://cloud.google.com/vertex-ai/docs/workbench/instances/manage-access-jupyterlab&#39;
    /// </summary>
    [TerraformProperty("instance_owners")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? InstanceOwners { get; set; }

    /// <summary>
    /// Optional. Labels to apply to this instance. These can be later modified
    /// by the UpdateInstance method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of this workbench instance. Format: &#39;projects/{project_id}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for gce_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GceSetup block(s) allowed")]
    [TerraformProperty("gce_setup")]
    public partial TerraformList<TerraformBlock<GoogleWorkbenchInstanceGceSetupBlock>>? GceSetup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleWorkbenchInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. Email address of entity that sent original CreateInstance request.
    /// </summary>
    [TerraformProperty("creator")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Creator { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// &#39;Output only. Additional information about instance health. Example:
    /// healthInfo&amp;quot;: { &amp;quot;docker_proxy_agent_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;docker_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;jupyterlab_api_status&amp;quot;:
    /// &amp;quot;-1&amp;quot;, &amp;quot;jupyterlab_status&amp;quot;: &amp;quot;-1&amp;quot;, &amp;quot;updated&amp;quot;: &amp;quot;2020-10-18 09:40:03.573409&amp;quot; }&#39;
    /// </summary>
    [TerraformProperty("health_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HealthInfo { get; }

    /// <summary>
    /// Output only. Instance health_state.
    /// </summary>
    [TerraformProperty("health_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HealthState { get; }

    /// <summary>
    /// Output only. The proxy endpoint that is used to access the Jupyter notebook.
    /// </summary>
    [TerraformProperty("proxy_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProxyUri { get; }

    /// <summary>
    /// Output only. The state of this instance.
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
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Output only. The upgrade history of this instance.
    /// </summary>
    [TerraformProperty("upgrade_history")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UpgradeHistory { get; }

}
