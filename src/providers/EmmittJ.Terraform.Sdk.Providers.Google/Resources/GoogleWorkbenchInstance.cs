using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gce_setup in .
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlock
{
    /// <summary>
    /// Optional. If true, no external IP will be assigned to this VM instance.
    /// </summary>
    [TerraformPropertyName("disable_public_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DisablePublicIp { get; set; } = default!;

    /// <summary>
    /// Optional. Flag to enable ip forwarding or not, default false/off.
    /// https://cloud.google.com/vpc/docs/using-routes#canipforward
    /// </summary>
    [TerraformPropertyName("enable_ip_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableIpForwarding { get; set; }

    /// <summary>
    /// Optional. The machine type of the VM instance. https://cloud.google.com/compute/docs/machine-resource
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MachineType { get; set; } = default!;

    /// <summary>
    /// Optional. Custom metadata to apply to this instance.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Metadata { get; set; } = default!;

    /// <summary>
    /// Optional. The Compute Engine tags to add to instance (see [Tagging
    /// instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Tags { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleWorkbenchInstanceTimeoutsBlock
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
/// Manages a google_workbench_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleWorkbenchInstance : TerraformResource
{
    public GoogleWorkbenchInstance(string name) : base("google_workbench_instance", name)
    {
    }

    /// <summary>
    /// Desired state of the Workbench Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Optional. If true, the workbench instance will not register with the proxy.
    /// </summary>
    [TerraformPropertyName("disable_proxy_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableProxyAccess { get; set; }

    /// <summary>
    /// Flag to enable managed end user credentials for the instance.
    /// </summary>
    [TerraformPropertyName("enable_managed_euc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableManagedEuc { get; set; }

    /// <summary>
    /// Flag that specifies that a notebook can be accessed with third party
    /// identity provider.
    /// </summary>
    [TerraformPropertyName("enable_third_party_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableThirdPartyIdentity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Required. User-defined unique ID of this instance.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceId { get; set; }

    /// <summary>
    /// &#39;Optional. Input only. The owner of this instance after creation. Format:
    /// &#39;alias@example.com&#39; Currently supports one owner only. If not specified, all of
    /// the service account users of your VM instance&#39;&#39;s service account can use the instance.
    /// If specified, sets the access mode to &#39;Single user&#39;. For more details, see
    /// https://cloud.google.com/vertex-ai/docs/workbench/instances/manage-access-jupyterlab&#39;
    /// </summary>
    [TerraformPropertyName("instance_owners")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? InstanceOwners { get; set; }

    /// <summary>
    /// Optional. Labels to apply to this instance. These can be later modified
    /// by the UpdateInstance method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of this workbench instance. Format: &#39;projects/{project_id}/locations/{location}/instances/{instance_id}&#39;
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
    /// Block for gce_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GceSetup block(s) allowed")]
    [TerraformPropertyName("gce_setup")]
    public TerraformList<TerraformBlock<GoogleWorkbenchInstanceGceSetupBlock>>? GceSetup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleWorkbenchInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Output only. Email address of entity that sent original CreateInstance request.
    /// </summary>
    [TerraformPropertyName("creator")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Creator => new TerraformReference(this, "creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// &#39;Output only. Additional information about instance health. Example:
    /// healthInfo&amp;quot;: { &amp;quot;docker_proxy_agent_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;docker_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;jupyterlab_api_status&amp;quot;:
    /// &amp;quot;-1&amp;quot;, &amp;quot;jupyterlab_status&amp;quot;: &amp;quot;-1&amp;quot;, &amp;quot;updated&amp;quot;: &amp;quot;2020-10-18 09:40:03.573409&amp;quot; }&#39;
    /// </summary>
    [TerraformPropertyName("health_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HealthInfo => new TerraformReference(this, "health_info");

    /// <summary>
    /// Output only. Instance health_state.
    /// </summary>
    [TerraformPropertyName("health_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HealthState => new TerraformReference(this, "health_state");

    /// <summary>
    /// Output only. The proxy endpoint that is used to access the Jupyter notebook.
    /// </summary>
    [TerraformPropertyName("proxy_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProxyUri => new TerraformReference(this, "proxy_uri");

    /// <summary>
    /// Output only. The state of this instance.
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
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// Output only. The upgrade history of this instance.
    /// </summary>
    [TerraformPropertyName("upgrade_history")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UpgradeHistory => new TerraformReference(this, "upgrade_history");

}
