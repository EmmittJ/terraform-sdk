using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// The type of access mode this instance. For valid values, see
    /// &#39;https://cloud.google.com/vertex-ai/docs/workbench/reference/
    /// rest/v1/projects.locations.runtimes#RuntimeAccessType&#39;.
    /// </summary>
    public TerraformProperty<string>? AccessType
    {
        get => GetProperty<TerraformProperty<string>>("access_type");
        set => WithProperty("access_type", value);
    }

    /// <summary>
    /// The proxy endpoint that is used to access the runtime.
    /// </summary>
    public TerraformProperty<string>? ProxyUri
    {
        get => GetProperty<TerraformProperty<string>>("proxy_uri");
        set => WithProperty("proxy_uri", value);
    }

    /// <summary>
    /// The owner of this runtime after creation. Format: &#39;alias@example.com&#39;.
    /// Currently supports one owner only.
    /// </summary>
    public TerraformProperty<string>? RuntimeOwner
    {
        get => GetProperty<TerraformProperty<string>>("runtime_owner");
        set => WithProperty("runtime_owner", value);
    }

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    public TerraformProperty<string>? CustomGpuDriverPath
    {
        get => GetProperty<TerraformProperty<string>>("custom_gpu_driver_path");
        set => WithProperty("custom_gpu_driver_path", value);
    }

    /// <summary>
    /// Verifies core internal services are running. Default: True.
    /// </summary>
    public TerraformProperty<bool>? EnableHealthMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("enable_health_monitoring");
        set => WithProperty("enable_health_monitoring", value);
    }

    /// <summary>
    /// Runtime will automatically shutdown after idle_shutdown_time.
    /// Default: True
    /// </summary>
    public TerraformProperty<bool>? IdleShutdown
    {
        get => GetProperty<TerraformProperty<bool>>("idle_shutdown");
        set => WithProperty("idle_shutdown", value);
    }

    /// <summary>
    /// Time in minutes to wait before shuting down runtime.
    /// Default: 180 minutes
    /// </summary>
    public TerraformProperty<double>? IdleShutdownTimeout
    {
        get => GetProperty<TerraformProperty<double>>("idle_shutdown_timeout");
        set => WithProperty("idle_shutdown_timeout", value);
    }

    /// <summary>
    /// Install Nvidia Driver automatically.
    /// </summary>
    public TerraformProperty<bool>? InstallGpuDriver
    {
        get => GetProperty<TerraformProperty<bool>>("install_gpu_driver");
        set => WithProperty("install_gpu_driver", value);
    }

    /// <summary>
    /// Cron expression in UTC timezone for schedule instance auto upgrade.
    /// Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
    /// </summary>
    public TerraformProperty<string>? NotebookUpgradeSchedule
    {
        get => GetProperty<TerraformProperty<string>>("notebook_upgrade_schedule");
        set => WithProperty("notebook_upgrade_schedule", value);
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance
    /// fully boots up. The path must be a URL or
    /// Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    public TerraformProperty<string>? PostStartupScript
    {
        get => GetProperty<TerraformProperty<string>>("post_startup_script");
        set => WithProperty("post_startup_script", value);
    }

    /// <summary>
    /// Behavior for the post startup script. Possible values: [&amp;quot;POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED&amp;quot;, &amp;quot;RUN_EVERY_START&amp;quot;, &amp;quot;DOWNLOAD_AND_RUN_EVERY_START&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PostStartupScriptBehavior
    {
        get => GetProperty<TerraformProperty<string>>("post_startup_script_behavior");
        set => WithProperty("post_startup_script_behavior", value);
    }

    /// <summary>
    /// Bool indicating whether an newer image is available in an image family.
    /// </summary>
    public TerraformProperty<bool>? Upgradeable
    {
        get => GetProperty<TerraformProperty<bool>>("upgradeable");
        set => WithProperty("upgradeable", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksRuntimeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for virtual_machine in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// The unique identifier of the Managed Compute Engine instance.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => WithProperty("instance_id", value);
    }

    /// <summary>
    /// The user-friendly name of the Managed Compute Engine instance.
    /// </summary>
    public TerraformProperty<string>? InstanceName
    {
        get => GetProperty<TerraformProperty<string>>("instance_name");
        set => WithProperty("instance_name", value);
    }

}

/// <summary>
/// Manages a google_notebooks_runtime resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNotebooksRuntime : TerraformResource
{
    public GoogleNotebooksRuntime(string name) : base("google_notebooks_runtime", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("health_state");
        this.DeclareOutput("metrics");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The labels to associate with this runtime. Label **keys** must
    /// contain 1 to 63 characters, and must conform to [RFC 1035]
    /// (https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be
    /// empty, but, if present, must contain 1 to 63 characters, and must
    /// conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No
    /// more than 32 labels can be associated with a cluster.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name specified for the Notebook runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public List<GoogleNotebooksRuntimeAccessConfigBlock>? AccessConfig
    {
        get => GetProperty<List<GoogleNotebooksRuntimeAccessConfigBlock>>("access_config");
        set => this.WithProperty("access_config", value);
    }

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public List<GoogleNotebooksRuntimeSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetProperty<List<GoogleNotebooksRuntimeSoftwareConfigBlock>>("software_config");
        set => this.WithProperty("software_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNotebooksRuntimeTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNotebooksRuntimeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    public List<GoogleNotebooksRuntimeVirtualMachineBlock>? VirtualMachine
    {
        get => GetProperty<List<GoogleNotebooksRuntimeVirtualMachineBlock>>("virtual_machine");
        set => this.WithProperty("virtual_machine", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The health state of this runtime. For a list of possible output
    /// values, see &#39;https://cloud.google.com/vertex-ai/docs/workbench/
    /// reference/rest/v1/projects.locations.runtimes#healthstate&#39;.
    /// </summary>
    public TerraformExpression HealthState => this["health_state"];

    /// <summary>
    /// Contains Runtime daemon metrics such as Service status and JupyterLab
    /// status
    /// </summary>
    public TerraformExpression Metrics => this["metrics"];

    /// <summary>
    /// The state of this runtime.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
