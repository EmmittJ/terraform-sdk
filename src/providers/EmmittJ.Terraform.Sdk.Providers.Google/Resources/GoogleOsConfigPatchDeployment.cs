using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigPatchDeploymentInstanceFilterBlock() : TerraformBlock("instance_filter")
{
    /// <summary>
    /// Target all VM instances in the project. If true, no other criteria is permitted.
    /// </summary>
    [TerraformProperty("all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? All { get; set; }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&amp;quot;prod-&amp;quot;.
    /// </summary>
    [TerraformProperty("instance_name_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? InstanceNamePrefixes { get; set; }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the &#39;form zones/{{zone}}/instances/{{instance_name}}&#39;,
    /// &#39;projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;, or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;
    /// </summary>
    [TerraformProperty("instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Instances { get; set; }

    /// <summary>
    /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Zones { get; set; }

}

/// <summary>
/// Block type for one_time_schedule in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigPatchDeploymentOneTimeScheduleBlock() : TerraformBlock("one_time_schedule")
{
    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecuteTime is required")]
    [TerraformProperty("execute_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExecuteTime { get; set; }

}

/// <summary>
/// Block type for patch_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigPatchDeploymentPatchConfigBlock() : TerraformBlock("patch_config")
{
    /// <summary>
    /// Allows the patch job to run on Managed instance groups (MIGs).
    /// </summary>
    [TerraformProperty("mig_instances_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MigInstancesAllowed { get; set; }

    /// <summary>
    /// Post-patch reboot settings. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    [TerraformProperty("reboot_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RebootConfig { get; set; }

}

/// <summary>
/// Block type for recurring_schedule in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigPatchDeploymentRecurringScheduleBlock() : TerraformBlock("recurring_schedule")
{
    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndTime { get; set; }



    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartTime { get; set; }

}

/// <summary>
/// Block type for rollout in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigPatchDeploymentRolloutBlock() : TerraformBlock("rollout")
{
    /// <summary>
    /// Mode of the patch rollout. Possible values: [&amp;quot;ZONE_BY_ZONE&amp;quot;, &amp;quot;CONCURRENT_ZONES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOsConfigPatchDeploymentTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_os_config_patch_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOsConfigPatchDeployment : TerraformResource
{
    public GoogleOsConfigPatchDeployment(string name) : base("google_os_config_patch_deployment", name)
    {
    }

    /// <summary>
    /// Description of the patch deployment. Length of the description is limited to 1024 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    [TerraformProperty("duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A name for the patch deployment in the project. When creating a name the following rules apply:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchDeploymentId is required")]
    [TerraformProperty("patch_deployment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PatchDeploymentId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    [TerraformProperty("instance_filter")]
    public required TerraformList<GoogleOsConfigPatchDeploymentInstanceFilterBlock> InstanceFilter { get; set; } = new();

    /// <summary>
    /// Block for one_time_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OneTimeSchedule block(s) allowed")]
    [TerraformProperty("one_time_schedule")]
    public TerraformList<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock> OneTimeSchedule { get; set; } = new();

    /// <summary>
    /// Block for patch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PatchConfig block(s) allowed")]
    [TerraformProperty("patch_config")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlock> PatchConfig { get; set; } = new();

    /// <summary>
    /// Block for recurring_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringSchedule block(s) allowed")]
    [TerraformProperty("recurring_schedule")]
    public TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlock> RecurringSchedule { get; set; } = new();

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    [TerraformProperty("rollout")]
    public TerraformList<GoogleOsConfigPatchDeploymentRolloutBlock> Rollout { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleOsConfigPatchDeploymentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Time the patch deployment was created. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("last_execute_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastExecuteTime { get; }

    /// <summary>
    /// Unique name for the patch deployment resource in a project.
    /// The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Time the patch deployment was last updated. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
