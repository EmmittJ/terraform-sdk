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
        set => SetProperty("all", value);
    }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&amp;quot;prod-&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? InstanceNamePrefixes
    {
        set => SetProperty("instance_name_prefixes", value);
    }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the &#39;form zones/{{zone}}/instances/{{instance_name}}&#39;,
    /// &#39;projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;, or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;
    /// </summary>
    public List<TerraformProperty<string>>? Instances
    {
        set => SetProperty("instances", value);
    }

    /// <summary>
    /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
    /// </summary>
    public List<TerraformProperty<string>>? Zones
    {
        set => SetProperty("zones", value);
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
        set => SetProperty("execute_time", value);
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
        set => SetProperty("mig_instances_allowed", value);
    }

    /// <summary>
    /// Post-patch reboot settings. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RebootConfig
    {
        set => SetProperty("reboot_config", value);
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
        set => SetProperty("end_time", value);
    }

    /// <summary>
    /// The time the last patch job ran successfully.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? LastExecuteTime
    {
        set => SetProperty("last_execute_time", value);
    }

    /// <summary>
    /// The time the next patch job is scheduled to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? NextExecuteTime
    {
        set => SetProperty("next_execute_time", value);
    }

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        set => SetProperty("start_time", value);
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
        set => SetProperty("mode", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_os_config_patch_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOsConfigPatchDeployment : TerraformResource
{
    public GoogleOsConfigPatchDeployment(string name) : base("google_os_config_patch_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("last_execute_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("duration");
        SetOutput("id");
        SetOutput("patch_deployment_id");
        SetOutput("project");
    }

    /// <summary>
    /// Description of the patch deployment. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    public TerraformProperty<string> Duration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("duration");
        set => SetProperty("duration", value);
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
        get => GetRequiredOutput<TerraformProperty<string>>("patch_deployment_id");
        set => SetProperty("patch_deployment_id", value);
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
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentInstanceFilterBlock>? InstanceFilter
    {
        set => SetProperty("instance_filter", value);
    }

    /// <summary>
    /// Block for one_time_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OneTimeSchedule block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock>? OneTimeSchedule
    {
        set => SetProperty("one_time_schedule", value);
    }

    /// <summary>
    /// Block for patch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PatchConfig block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentPatchConfigBlock>? PatchConfig
    {
        set => SetProperty("patch_config", value);
    }

    /// <summary>
    /// Block for recurring_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringSchedule block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentRecurringScheduleBlock>? RecurringSchedule
    {
        set => SetProperty("recurring_schedule", value);
    }

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public List<GoogleOsConfigPatchDeploymentRolloutBlock>? Rollout
    {
        set => SetProperty("rollout", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOsConfigPatchDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
