using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentInstanceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Target all VM instances in the project. If true, no other criteria is permitted.
    /// </summary>
    public TerraformProperty<bool>? All
    {
        get => GetProperty<TerraformProperty<bool>>("all");
        set => WithProperty("all", value);
    }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&amp;quot;prod-&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? InstanceNamePrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("instance_name_prefixes");
        set => WithProperty("instance_name_prefixes", value);
    }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the &#39;form zones/{{zone}}/instances/{{instance_name}}&#39;,
    /// &#39;projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;, or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;
    /// </summary>
    public List<TerraformProperty<string>>? Instances
    {
        get => GetProperty<List<TerraformProperty<string>>>("instances");
        set => WithProperty("instances", value);
    }

    /// <summary>
    /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
    /// </summary>
    public List<TerraformProperty<string>>? Zones
    {
        get => GetProperty<List<TerraformProperty<string>>>("zones");
        set => WithProperty("zones", value);
    }

}

/// <summary>
/// Block type for one_time_schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentOneTimeScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecuteTime is required")]
    public required TerraformProperty<string> ExecuteTime
    {
        get => GetProperty<TerraformProperty<string>>("execute_time");
        set => WithProperty("execute_time", value);
    }

}

/// <summary>
/// Block type for patch_config in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Allows the patch job to run on Managed instance groups (MIGs).
    /// </summary>
    public TerraformProperty<bool>? MigInstancesAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("mig_instances_allowed");
        set => WithProperty("mig_instances_allowed", value);
    }

    /// <summary>
    /// Post-patch reboot settings. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RebootConfig
    {
        get => GetProperty<TerraformProperty<string>>("reboot_config");
        set => WithProperty("reboot_config", value);
    }

}

/// <summary>
/// Block type for recurring_schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => WithProperty("end_time", value);
    }

    /// <summary>
    /// The time the last patch job ran successfully.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? LastExecuteTime
    {
        get => GetProperty<TerraformProperty<string>>("last_execute_time");
        set => WithProperty("last_execute_time", value);
    }

    /// <summary>
    /// The time the next patch job is scheduled to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? NextExecuteTime
    {
        get => GetProperty<TerraformProperty<string>>("next_execute_time");
        set => WithProperty("next_execute_time", value);
    }

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

}

/// <summary>
/// Block type for rollout in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRolloutBlock : TerraformBlock
{
    /// <summary>
    /// Mode of the patch rollout. Possible values: [&amp;quot;ZONE_BY_ZONE&amp;quot;, &amp;quot;CONCURRENT_ZONES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigPatchDeploymentTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_os_config_patch_deployment resource.
/// </summary>
public class GoogleOsConfigPatchDeployment : TerraformResource
{
    public GoogleOsConfigPatchDeployment(string name) : base("google_os_config_patch_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("last_execute_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the patch deployment. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => this.WithProperty("duration", value);
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
    /// A name for the patch deployment in the project. When creating a name the following rules apply:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchDeploymentId is required")]
    public required TerraformProperty<string> PatchDeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("patch_deployment_id");
        set => this.WithProperty("patch_deployment_id", value);
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
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentInstanceFilterBlock>? InstanceFilter
    {
        get => GetProperty<List<GoogleOsConfigPatchDeploymentInstanceFilterBlock>>("instance_filter");
        set => this.WithProperty("instance_filter", value);
    }

    /// <summary>
    /// Block for one_time_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OneTimeSchedule block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock>? OneTimeSchedule
    {
        get => GetProperty<List<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock>>("one_time_schedule");
        set => this.WithProperty("one_time_schedule", value);
    }

    /// <summary>
    /// Block for patch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PatchConfig block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentPatchConfigBlock>? PatchConfig
    {
        get => GetProperty<List<GoogleOsConfigPatchDeploymentPatchConfigBlock>>("patch_config");
        set => this.WithProperty("patch_config", value);
    }

    /// <summary>
    /// Block for recurring_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringSchedule block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentRecurringScheduleBlock>? RecurringSchedule
    {
        get => GetProperty<List<GoogleOsConfigPatchDeploymentRecurringScheduleBlock>>("recurring_schedule");
        set => this.WithProperty("recurring_schedule", value);
    }

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentRolloutBlock>? Rollout
    {
        get => GetProperty<List<GoogleOsConfigPatchDeploymentRolloutBlock>>("rollout");
        set => this.WithProperty("rollout", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOsConfigPatchDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOsConfigPatchDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the patch deployment was created. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression LastExecuteTime => this["last_execute_time"];

    /// <summary>
    /// Unique name for the patch deployment resource in a project.
    /// The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Time the patch deployment was last updated. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
