using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gce_setup in .
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlock : TerraformBlock
{
    /// <summary>
    /// Optional. If true, no external IP will be assigned to this VM instance.
    /// </summary>
    public TerraformProperty<bool>? DisablePublicIp
    {
        set => SetProperty("disable_public_ip", value);
    }

    /// <summary>
    /// Optional. Flag to enable ip forwarding or not, default false/off.
    /// https://cloud.google.com/vpc/docs/using-routes#canipforward
    /// </summary>
    public TerraformProperty<bool>? EnableIpForwarding
    {
        set => SetProperty("enable_ip_forwarding", value);
    }

    /// <summary>
    /// Optional. The machine type of the VM instance. https://cloud.google.com/compute/docs/machine-resource
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        set => SetProperty("machine_type", value);
    }

    /// <summary>
    /// Optional. Custom metadata to apply to this instance.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// Optional. The Compute Engine tags to add to instance (see [Tagging
    /// instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleWorkbenchInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_workbench_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleWorkbenchInstance : TerraformResource
{
    public GoogleWorkbenchInstance(string name) : base("google_workbench_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("creator");
        SetOutput("effective_labels");
        SetOutput("health_info");
        SetOutput("health_state");
        SetOutput("proxy_uri");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("upgrade_history");
        SetOutput("desired_state");
        SetOutput("disable_proxy_access");
        SetOutput("enable_managed_euc");
        SetOutput("enable_third_party_identity");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("instance_owners");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// Desired state of the Workbench Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    public TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
    }

    /// <summary>
    /// Optional. If true, the workbench instance will not register with the proxy.
    /// </summary>
    public TerraformProperty<bool> DisableProxyAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_proxy_access");
        set => SetProperty("disable_proxy_access", value);
    }

    /// <summary>
    /// Flag to enable managed end user credentials for the instance.
    /// </summary>
    public TerraformProperty<bool> EnableManagedEuc
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_managed_euc");
        set => SetProperty("enable_managed_euc", value);
    }

    /// <summary>
    /// Flag that specifies that a notebook can be accessed with third party
    /// identity provider.
    /// </summary>
    public TerraformProperty<bool> EnableThirdPartyIdentity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_third_party_identity");
        set => SetProperty("enable_third_party_identity", value);
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
    /// Required. User-defined unique ID of this instance.
    /// </summary>
    public TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// &#39;Optional. Input only. The owner of this instance after creation. Format:
    /// &#39;alias@example.com&#39; Currently supports one owner only. If not specified, all of
    /// the service account users of your VM instance&#39;&#39;s service account can use the instance.
    /// If specified, sets the access mode to &#39;Single user&#39;. For more details, see
    /// https://cloud.google.com/vertex-ai/docs/workbench/instances/manage-access-jupyterlab&#39;
    /// </summary>
    public List<TerraformProperty<string>> InstanceOwners
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("instance_owners");
        set => SetProperty("instance_owners", value);
    }

    /// <summary>
    /// Optional. Labels to apply to this instance. These can be later modified
    /// by the UpdateInstance method.
    /// 
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
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of this workbench instance. Format: &#39;projects/{project_id}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for gce_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GceSetup block(s) allowed")]
    public List<GoogleWorkbenchInstanceGceSetupBlock>? GceSetup
    {
        set => SetProperty("gce_setup", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleWorkbenchInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Email address of entity that sent original CreateInstance request.
    /// </summary>
    public TerraformExpression Creator => this["creator"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// &#39;Output only. Additional information about instance health. Example:
    /// healthInfo&amp;quot;: { &amp;quot;docker_proxy_agent_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;docker_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;jupyterlab_api_status&amp;quot;:
    /// &amp;quot;-1&amp;quot;, &amp;quot;jupyterlab_status&amp;quot;: &amp;quot;-1&amp;quot;, &amp;quot;updated&amp;quot;: &amp;quot;2020-10-18 09:40:03.573409&amp;quot; }&#39;
    /// </summary>
    public TerraformExpression HealthInfo => this["health_info"];

    /// <summary>
    /// Output only. Instance health_state.
    /// </summary>
    public TerraformExpression HealthState => this["health_state"];

    /// <summary>
    /// Output only. The proxy endpoint that is used to access the Jupyter notebook.
    /// </summary>
    public TerraformExpression ProxyUri => this["proxy_uri"];

    /// <summary>
    /// Output only. The state of this instance.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Output only. The upgrade history of this instance.
    /// </summary>
    public TerraformExpression UpgradeHistory => this["upgrade_history"];

}
