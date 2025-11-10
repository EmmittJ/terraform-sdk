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
        set => SetProperty("access_type", value);
    }

    /// <summary>
    /// The proxy endpoint that is used to access the runtime.
    /// </summary>
    public TerraformProperty<string>? ProxyUri
    {
        set => SetProperty("proxy_uri", value);
    }

    /// <summary>
    /// The owner of this runtime after creation. Format: &#39;alias@example.com&#39;.
    /// Currently supports one owner only.
    /// </summary>
    public TerraformProperty<string>? RuntimeOwner
    {
        set => SetProperty("runtime_owner", value);
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
        set => SetProperty("custom_gpu_driver_path", value);
    }

    /// <summary>
    /// Verifies core internal services are running. Default: True.
    /// </summary>
    public TerraformProperty<bool>? EnableHealthMonitoring
    {
        set => SetProperty("enable_health_monitoring", value);
    }

    /// <summary>
    /// Runtime will automatically shutdown after idle_shutdown_time.
    /// Default: True
    /// </summary>
    public TerraformProperty<bool>? IdleShutdown
    {
        set => SetProperty("idle_shutdown", value);
    }

    /// <summary>
    /// Time in minutes to wait before shuting down runtime.
    /// Default: 180 minutes
    /// </summary>
    public TerraformProperty<double>? IdleShutdownTimeout
    {
        set => SetProperty("idle_shutdown_timeout", value);
    }

    /// <summary>
    /// Install Nvidia Driver automatically.
    /// </summary>
    public TerraformProperty<bool>? InstallGpuDriver
    {
        set => SetProperty("install_gpu_driver", value);
    }

    /// <summary>
    /// Cron expression in UTC timezone for schedule instance auto upgrade.
    /// Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
    /// </summary>
    public TerraformProperty<string>? NotebookUpgradeSchedule
    {
        set => SetProperty("notebook_upgrade_schedule", value);
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance
    /// fully boots up. The path must be a URL or
    /// Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    public TerraformProperty<string>? PostStartupScript
    {
        set => SetProperty("post_startup_script", value);
    }

    /// <summary>
    /// Behavior for the post startup script. Possible values: [&amp;quot;POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED&amp;quot;, &amp;quot;RUN_EVERY_START&amp;quot;, &amp;quot;DOWNLOAD_AND_RUN_EVERY_START&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PostStartupScriptBehavior
    {
        set => SetProperty("post_startup_script_behavior", value);
    }

    /// <summary>
    /// Bool indicating whether an newer image is available in an image family.
    /// </summary>
    public TerraformProperty<bool>? Upgradeable
    {
        set => SetProperty("upgradeable", value);
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
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The user-friendly name of the Managed Compute Engine instance.
    /// </summary>
    public TerraformProperty<string>? InstanceName
    {
        set => SetProperty("instance_name", value);
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
        SetOutput("effective_labels");
        SetOutput("health_state");
        SetOutput("metrics");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
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
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name specified for the Notebook runtime.
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
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public List<GoogleNotebooksRuntimeAccessConfigBlock>? AccessConfig
    {
        set => SetProperty("access_config", value);
    }

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public List<GoogleNotebooksRuntimeSoftwareConfigBlock>? SoftwareConfig
    {
        set => SetProperty("software_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNotebooksRuntimeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    public List<GoogleNotebooksRuntimeVirtualMachineBlock>? VirtualMachine
    {
        set => SetProperty("virtual_machine", value);
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
