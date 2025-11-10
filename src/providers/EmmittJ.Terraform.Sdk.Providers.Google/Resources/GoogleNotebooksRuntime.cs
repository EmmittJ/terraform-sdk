using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeAccessConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The type of access mode this instance. For valid values, see
    /// &#39;https://cloud.google.com/vertex-ai/docs/workbench/reference/
    /// rest/v1/projects.locations.runtimes#RuntimeAccessType&#39;.
    /// </summary>
    [TerraformPropertyName("access_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccessType { get; set; }

    /// <summary>
    /// The proxy endpoint that is used to access the runtime.
    /// </summary>
    [TerraformPropertyName("proxy_uri")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProxyUri => new TerraformReferenceProperty<TerraformProperty<string>>("", "proxy_uri");

    /// <summary>
    /// The owner of this runtime after creation. Format: &#39;alias@example.com&#39;.
    /// Currently supports one owner only.
    /// </summary>
    [TerraformPropertyName("runtime_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuntimeOwner { get; set; }

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeSoftwareConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    [TerraformPropertyName("custom_gpu_driver_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomGpuDriverPath { get; set; }

    /// <summary>
    /// Verifies core internal services are running. Default: True.
    /// </summary>
    [TerraformPropertyName("enable_health_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableHealthMonitoring { get; set; }

    /// <summary>
    /// Runtime will automatically shutdown after idle_shutdown_time.
    /// Default: True
    /// </summary>
    [TerraformPropertyName("idle_shutdown")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IdleShutdown { get; set; }

    /// <summary>
    /// Time in minutes to wait before shuting down runtime.
    /// Default: 180 minutes
    /// </summary>
    [TerraformPropertyName("idle_shutdown_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IdleShutdownTimeout { get; set; }

    /// <summary>
    /// Install Nvidia Driver automatically.
    /// </summary>
    [TerraformPropertyName("install_gpu_driver")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InstallGpuDriver { get; set; }

    /// <summary>
    /// Cron expression in UTC timezone for schedule instance auto upgrade.
    /// Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
    /// </summary>
    [TerraformPropertyName("notebook_upgrade_schedule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotebookUpgradeSchedule { get; set; }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance
    /// fully boots up. The path must be a URL or
    /// Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    [TerraformPropertyName("post_startup_script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostStartupScript { get; set; }

    /// <summary>
    /// Behavior for the post startup script. Possible values: [&amp;quot;POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED&amp;quot;, &amp;quot;RUN_EVERY_START&amp;quot;, &amp;quot;DOWNLOAD_AND_RUN_EVERY_START&amp;quot;]
    /// </summary>
    [TerraformPropertyName("post_startup_script_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostStartupScriptBehavior { get; set; }

    /// <summary>
    /// Bool indicating whether an newer image is available in an image family.
    /// </summary>
    [TerraformPropertyName("upgradeable")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Upgradeable => new TerraformReferenceProperty<TerraformProperty<bool>>("", "upgradeable");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksRuntimeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_machine in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlock : ITerraformBlock
{
    /// <summary>
    /// The unique identifier of the Managed Compute Engine instance.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceId => new TerraformReferenceProperty<TerraformProperty<string>>("", "instance_id");

    /// <summary>
    /// The user-friendly name of the Managed Compute Engine instance.
    /// </summary>
    [TerraformPropertyName("instance_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceName => new TerraformReferenceProperty<TerraformProperty<string>>("", "instance_name");

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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name specified for the Notebook runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    [TerraformPropertyName("access_config")]
    public TerraformList<TerraformBlock<GoogleNotebooksRuntimeAccessConfigBlock>>? AccessConfig { get; set; } = new();

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    [TerraformPropertyName("software_config")]
    public TerraformList<TerraformBlock<GoogleNotebooksRuntimeSoftwareConfigBlock>>? SoftwareConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNotebooksRuntimeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    [TerraformPropertyName("virtual_machine")]
    public TerraformList<TerraformBlock<GoogleNotebooksRuntimeVirtualMachineBlock>>? VirtualMachine { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The health state of this runtime. For a list of possible output
    /// values, see &#39;https://cloud.google.com/vertex-ai/docs/workbench/
    /// reference/rest/v1/projects.locations.runtimes#healthstate&#39;.
    /// </summary>
    [TerraformPropertyName("health_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HealthState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "health_state");

    /// <summary>
    /// Contains Runtime daemon metrics such as Service status and JupyterLab
    /// status
    /// </summary>
    [TerraformPropertyName("metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Metrics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "metrics");

    /// <summary>
    /// The state of this runtime.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
