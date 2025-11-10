using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentInstanceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// Target all VM instances in the project. If true, no other criteria is permitted.
    /// </summary>
    [TerraformPropertyName("all")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? All { get; set; }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&amp;quot;prod-&amp;quot;.
    /// </summary>
    [TerraformPropertyName("instance_name_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InstanceNamePrefixes { get; set; }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the &#39;form zones/{{zone}}/instances/{{instance_name}}&#39;,
    /// &#39;projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;, or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;
    /// </summary>
    [TerraformPropertyName("instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Instances { get; set; }

    /// <summary>
    /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Zones { get; set; }

}

/// <summary>
/// Block type for one_time_schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentOneTimeScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecuteTime is required")]
    [TerraformPropertyName("execute_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExecuteTime { get; set; }

}

/// <summary>
/// Block type for patch_config in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Allows the patch job to run on Managed instance groups (MIGs).
    /// </summary>
    [TerraformPropertyName("mig_instances_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MigInstancesAllowed { get; set; }

    /// <summary>
    /// Post-patch reboot settings. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("reboot_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RebootConfig { get; set; }

}

/// <summary>
/// Block type for recurring_schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndTime { get; set; }

    /// <summary>
    /// The time the last patch job ran successfully.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("last_execute_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastExecuteTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_execute_time");

    /// <summary>
    /// The time the next patch job is scheduled to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("next_execute_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextExecuteTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "next_execute_time");

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartTime { get; set; }

}

/// <summary>
/// Block type for rollout in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRolloutBlock : ITerraformBlock
{
    /// <summary>
    /// Mode of the patch rollout. Possible values: [&amp;quot;ZONE_BY_ZONE&amp;quot;, &amp;quot;CONCURRENT_ZONES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigPatchDeploymentTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_os_config_patch_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOsConfigPatchDeployment : TerraformResource
{
    public GoogleOsConfigPatchDeployment(string name) : base("google_os_config_patch_deployment", name)
    {
    }

    /// <summary>
    /// Description of the patch deployment. Length of the description is limited to 1024 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Duration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A name for the patch deployment in the project. When creating a name the following rules apply:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchDeploymentId is required")]
    [TerraformPropertyName("patch_deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PatchDeploymentId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    [TerraformPropertyName("instance_filter")]
    public TerraformList<TerraformBlock<GoogleOsConfigPatchDeploymentInstanceFilterBlock>>? InstanceFilter { get; set; } = new();

    /// <summary>
    /// Block for one_time_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OneTimeSchedule block(s) allowed")]
    [TerraformPropertyName("one_time_schedule")]
    public TerraformList<TerraformBlock<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock>>? OneTimeSchedule { get; set; } = new();

    /// <summary>
    /// Block for patch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PatchConfig block(s) allowed")]
    [TerraformPropertyName("patch_config")]
    public TerraformList<TerraformBlock<GoogleOsConfigPatchDeploymentPatchConfigBlock>>? PatchConfig { get; set; } = new();

    /// <summary>
    /// Block for recurring_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringSchedule block(s) allowed")]
    [TerraformPropertyName("recurring_schedule")]
    public TerraformList<TerraformBlock<GoogleOsConfigPatchDeploymentRecurringScheduleBlock>>? RecurringSchedule { get; set; } = new();

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    [TerraformPropertyName("rollout")]
    public TerraformList<TerraformBlock<GoogleOsConfigPatchDeploymentRolloutBlock>>? Rollout { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOsConfigPatchDeploymentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time the patch deployment was created. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("last_execute_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastExecuteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_execute_time");

    /// <summary>
    /// Unique name for the patch deployment resource in a project.
    /// The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Time the patch deployment was last updated. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
