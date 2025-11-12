using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksRuntimeAccessConfigBlock() : TerraformBlock("access_config")
{
    /// <summary>
    /// The type of access mode this instance. For valid values, see
    /// &#39;https://cloud.google.com/vertex-ai/docs/workbench/reference/
    /// rest/v1/projects.locations.runtimes#RuntimeAccessType&#39;.
    /// </summary>
    [TerraformProperty("access_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessType { get; set; }


    /// <summary>
    /// The owner of this runtime after creation. Format: &#39;alias@example.com&#39;.
    /// Currently supports one owner only.
    /// </summary>
    [TerraformProperty("runtime_owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeOwner { get; set; }

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksRuntimeSoftwareConfigBlock() : TerraformBlock("software_config")
{
    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    [TerraformProperty("custom_gpu_driver_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomGpuDriverPath { get; set; }

    /// <summary>
    /// Verifies core internal services are running. Default: True.
    /// </summary>
    [TerraformProperty("enable_health_monitoring")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableHealthMonitoring { get; set; }

    /// <summary>
    /// Runtime will automatically shutdown after idle_shutdown_time.
    /// Default: True
    /// </summary>
    [TerraformProperty("idle_shutdown")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IdleShutdown { get; set; }

    /// <summary>
    /// Time in minutes to wait before shuting down runtime.
    /// Default: 180 minutes
    /// </summary>
    [TerraformProperty("idle_shutdown_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleShutdownTimeout { get; set; }

    /// <summary>
    /// Install Nvidia Driver automatically.
    /// </summary>
    [TerraformProperty("install_gpu_driver")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InstallGpuDriver { get; set; }

    /// <summary>
    /// Cron expression in UTC timezone for schedule instance auto upgrade.
    /// Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
    /// </summary>
    [TerraformProperty("notebook_upgrade_schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NotebookUpgradeSchedule { get; set; }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance
    /// fully boots up. The path must be a URL or
    /// Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    [TerraformProperty("post_startup_script")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostStartupScript { get; set; }

    /// <summary>
    /// Behavior for the post startup script. Possible values: [&amp;quot;POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED&amp;quot;, &amp;quot;RUN_EVERY_START&amp;quot;, &amp;quot;DOWNLOAD_AND_RUN_EVERY_START&amp;quot;]
    /// </summary>
    [TerraformProperty("post_startup_script_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostStartupScriptBehavior { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNotebooksRuntimeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for virtual_machine in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksRuntimeVirtualMachineBlock() : TerraformBlock("virtual_machine")
{


}

/// <summary>
/// Manages a google_notebooks_runtime resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNotebooksRuntime : TerraformResource
{
    public GoogleNotebooksRuntime(string name) : base("google_notebooks_runtime", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name specified for the Notebook runtime.
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
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    [TerraformProperty("access_config")]
    public TerraformList<GoogleNotebooksRuntimeAccessConfigBlock> AccessConfig { get; set; } = new();

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    [TerraformProperty("software_config")]
    public TerraformList<GoogleNotebooksRuntimeSoftwareConfigBlock> SoftwareConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNotebooksRuntimeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_machine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    [TerraformProperty("virtual_machine")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlock> VirtualMachine { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The health state of this runtime. For a list of possible output
    /// values, see &#39;https://cloud.google.com/vertex-ai/docs/workbench/
    /// reference/rest/v1/projects.locations.runtimes#healthstate&#39;.
    /// </summary>
    [TerraformProperty("health_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HealthState { get; }

    /// <summary>
    /// Contains Runtime daemon metrics such as Service status and JupyterLab
    /// status
    /// </summary>
    [TerraformProperty("metrics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Metrics { get; }

    /// <summary>
    /// The state of this runtime.
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

}
