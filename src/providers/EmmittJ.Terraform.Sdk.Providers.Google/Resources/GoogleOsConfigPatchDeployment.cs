using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in GoogleOsConfigPatchDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentInstanceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_filter";

    /// <summary>
    /// Target all VM instances in the project. If true, no other criteria is permitted.
    /// </summary>
    public TerraformValue<bool>? All
    {
        get => GetArgument<TerraformValue<bool>>("all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
    /// VMs when targeting configs, for example prefix=&amp;quot;prod-&amp;quot;.
    /// </summary>
    public TerraformList<string>? InstanceNamePrefixes
    {
        get => GetArgument<TerraformList<string>>("instance_name_prefixes");
        set => SetArgument("instance_name_prefixes", value);
    }

    /// <summary>
    /// Targets any of the VM instances specified. Instances are specified by their URI in the &#39;form zones/{{zone}}/instances/{{instance_name}}&#39;,
    /// &#39;projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;, or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{{project_id}}/zones/{{zone}}/instances/{{instance_name}}&#39;
    /// </summary>
    public TerraformList<string>? Instances
    {
        get => GetArgument<TerraformList<string>>("instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
    /// </summary>
    public TerraformList<string>? Zones
    {
        get => GetArgument<TerraformList<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// GroupLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigPatchDeploymentInstanceFilterBlockGroupLabelsBlock>? GroupLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentInstanceFilterBlockGroupLabelsBlock>>("group_labels");
        set => SetArgument("group_labels", value);
    }

}

/// <summary>
/// Block type for group_labels in GoogleOsConfigPatchDeploymentInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentInstanceFilterBlockGroupLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_labels";

    /// <summary>
    /// Compute Engine instance labels that must be present for a VM instance to be targeted by this filter
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Labels is required")]
    public required TerraformMap<string> Labels
    {
        get => GetRequiredArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}


/// <summary>
/// Block type for one_time_schedule in GoogleOsConfigPatchDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentOneTimeScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "one_time_schedule";

    /// <summary>
    /// The desired patch job execution time. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecuteTime is required")]
    public required TerraformValue<string> ExecuteTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("execute_time");
        set => SetArgument("execute_time", value);
    }

}


/// <summary>
/// Block type for patch_config in GoogleOsConfigPatchDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patch_config";

    /// <summary>
    /// Allows the patch job to run on Managed instance groups (MIGs).
    /// </summary>
    public TerraformValue<bool>? MigInstancesAllowed
    {
        get => GetArgument<TerraformValue<bool>>("mig_instances_allowed");
        set => SetArgument("mig_instances_allowed", value);
    }

    /// <summary>
    /// Post-patch reboot settings. Possible values: [&amp;quot;DEFAULT&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RebootConfig
    {
        get => GetArgument<TerraformValue<string>>("reboot_config");
        set => SetArgument("reboot_config", value);
    }

    /// <summary>
    /// Apt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Apt block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Goo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Goo block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockGooBlock>? Goo
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockGooBlock>>("goo");
        set => SetArgument("goo", value);
    }

    /// <summary>
    /// PostStep block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostStep block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlock>? PostStep
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlock>>("post_step");
        set => SetArgument("post_step", value);
    }

    /// <summary>
    /// PreStep block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreStep block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlock>? PreStep
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlock>>("pre_step");
        set => SetArgument("pre_step", value);
    }

    /// <summary>
    /// WindowsUpdate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsUpdate block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockWindowsUpdateBlock>? WindowsUpdate
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockWindowsUpdateBlock>>("windows_update");
        set => SetArgument("windows_update", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockAptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt";

    /// <summary>
    /// List of packages to exclude from update. These packages will be excluded.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => GetArgument<TerraformList<string>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    public TerraformList<string>? ExclusivePackages
    {
        get => GetArgument<TerraformList<string>>("exclusive_packages");
        set => SetArgument("exclusive_packages", value);
    }

    /// <summary>
    /// By changing the type to DIST, the patching is performed using apt-get dist-upgrade instead. Possible values: [&amp;quot;DIST&amp;quot;, &amp;quot;UPGRADE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for goo in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockGooBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "goo";

    /// <summary>
    /// goo update settings. Use this setting to override the default goo patch rules.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for post_step in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_step";

    /// <summary>
    /// LinuxExecStepConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxExecStepConfig block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlock>? LinuxExecStepConfig
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlock>>("linux_exec_step_config");
        set => SetArgument("linux_exec_step_config", value);
    }

    /// <summary>
    /// WindowsExecStepConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsExecStepConfig block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlock>? WindowsExecStepConfig
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlock>>("windows_exec_step_config");
        set => SetArgument("windows_exec_step_config", value);
    }

}

/// <summary>
/// Block type for linux_exec_step_config in GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_exec_step_config";

    /// <summary>
    /// Defaults to [0]. A list of possible return values that the execution can return to indicate a success.
    /// </summary>
    public TerraformList<double>? AllowedSuccessCodes
    {
        get => GetArgument<TerraformList<double>>("allowed_success_codes");
        set => SetArgument("allowed_success_codes", value);
    }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: [&amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// An absolute path to the executable on the VM.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// GcsObject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsObject block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlockGcsObjectBlock>? GcsObject
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlockGcsObjectBlock>>("gcs_object");
        set => SetArgument("gcs_object", value);
    }

}

/// <summary>
/// Block type for gcs_object in GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockLinuxExecStepConfigBlockGcsObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_object";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GenerationNumber is required")]
    public required TerraformValue<string> GenerationNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("generation_number");
        set => SetArgument("generation_number", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for windows_exec_step_config in GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_exec_step_config";

    /// <summary>
    /// Defaults to [0]. A list of possible return values that the execution can return to indicate a success.
    /// </summary>
    public TerraformList<double>? AllowedSuccessCodes
    {
        get => GetArgument<TerraformList<double>>("allowed_success_codes");
        set => SetArgument("allowed_success_codes", value);
    }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: [&amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// An absolute path to the executable on the VM.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// GcsObject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsObject block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlockGcsObjectBlock>? GcsObject
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlockGcsObjectBlock>>("gcs_object");
        set => SetArgument("gcs_object", value);
    }

}

/// <summary>
/// Block type for gcs_object in GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPostStepBlockWindowsExecStepConfigBlockGcsObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_object";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GenerationNumber is required")]
    public required TerraformValue<string> GenerationNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("generation_number");
        set => SetArgument("generation_number", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for pre_step in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_step";

    /// <summary>
    /// LinuxExecStepConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinuxExecStepConfig block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlock>? LinuxExecStepConfig
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlock>>("linux_exec_step_config");
        set => SetArgument("linux_exec_step_config", value);
    }

    /// <summary>
    /// WindowsExecStepConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsExecStepConfig block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlock>? WindowsExecStepConfig
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlock>>("windows_exec_step_config");
        set => SetArgument("windows_exec_step_config", value);
    }

}

/// <summary>
/// Block type for linux_exec_step_config in GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_exec_step_config";

    /// <summary>
    /// Defaults to [0]. A list of possible return values that the execution can return to indicate a success.
    /// </summary>
    public TerraformList<double>? AllowedSuccessCodes
    {
        get => GetArgument<TerraformList<double>>("allowed_success_codes");
        set => SetArgument("allowed_success_codes", value);
    }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: [&amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// An absolute path to the executable on the VM.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// GcsObject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsObject block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlockGcsObjectBlock>? GcsObject
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlockGcsObjectBlock>>("gcs_object");
        set => SetArgument("gcs_object", value);
    }

}

/// <summary>
/// Block type for gcs_object in GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockLinuxExecStepConfigBlockGcsObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_object";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GenerationNumber is required")]
    public required TerraformValue<string> GenerationNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("generation_number");
        set => SetArgument("generation_number", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for windows_exec_step_config in GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_exec_step_config";

    /// <summary>
    /// Defaults to [0]. A list of possible return values that the execution can return to indicate a success.
    /// </summary>
    public TerraformList<double>? AllowedSuccessCodes
    {
        get => GetArgument<TerraformList<double>>("allowed_success_codes");
        set => SetArgument("allowed_success_codes", value);
    }

    /// <summary>
    /// The script interpreter to use to run the script. If no interpreter is specified the script will
    /// be executed directly, which will likely only succeed for scripts with shebang lines. Possible values: [&amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// An absolute path to the executable on the VM.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// GcsObject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsObject block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlockGcsObjectBlock>? GcsObject
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlockGcsObjectBlock>>("gcs_object");
        set => SetArgument("gcs_object", value);
    }

}

/// <summary>
/// Block type for gcs_object in GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockPreStepBlockWindowsExecStepConfigBlockGcsObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_object";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified by this PatchJob does not change.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GenerationNumber is required")]
    public required TerraformValue<string> GenerationNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("generation_number");
        set => SetArgument("generation_number", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for windows_update in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockWindowsUpdateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_update";

    /// <summary>
    /// Only apply updates of these windows update classifications. If empty, all updates are applied. Possible values: [&amp;quot;CRITICAL&amp;quot;, &amp;quot;SECURITY&amp;quot;, &amp;quot;DEFINITION&amp;quot;, &amp;quot;DRIVER&amp;quot;, &amp;quot;FEATURE_PACK&amp;quot;, &amp;quot;SERVICE_PACK&amp;quot;, &amp;quot;TOOL&amp;quot;, &amp;quot;UPDATE_ROLLUP&amp;quot;, &amp;quot;UPDATE&amp;quot;]
    /// </summary>
    public TerraformList<string>? Classifications
    {
        get => GetArgument<TerraformList<string>>("classifications");
        set => SetArgument("classifications", value);
    }

    /// <summary>
    /// List of KBs to exclude from update.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => GetArgument<TerraformList<string>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// An exclusive list of kbs to be updated. These are the only patches that will be updated.
    /// This field must not be used with other patch configurations.
    /// </summary>
    public TerraformList<string>? ExclusivePatches
    {
        get => GetArgument<TerraformList<string>>("exclusive_patches");
        set => SetArgument("exclusive_patches", value);
    }

}

/// <summary>
/// Block type for yum in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockYumBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yum";

    /// <summary>
    /// List of packages to exclude from update. These packages will be excluded.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => GetArgument<TerraformList<string>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// An exclusive list of packages to be updated. These are the only packages that will be updated.
    /// If these packages are not installed, they will be ignored. This field cannot be specified with
    /// any other patch configuration fields.
    /// </summary>
    public TerraformList<string>? ExclusivePackages
    {
        get => GetArgument<TerraformList<string>>("exclusive_packages");
        set => SetArgument("exclusive_packages", value);
    }

    /// <summary>
    /// Will cause patch to run yum update-minimal instead.
    /// </summary>
    public TerraformValue<bool>? Minimal
    {
        get => GetArgument<TerraformValue<bool>>("minimal");
        set => SetArgument("minimal", value);
    }

    /// <summary>
    /// Adds the --security flag to yum update. Not supported on all platforms.
    /// </summary>
    public TerraformValue<bool>? Security
    {
        get => GetArgument<TerraformValue<bool>>("security");
        set => SetArgument("security", value);
    }

}

/// <summary>
/// Block type for zypper in GoogleOsConfigPatchDeploymentPatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentPatchConfigBlockZypperBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zypper";

    /// <summary>
    /// Install only patches with these categories. Common categories include security, recommended, and feature.
    /// </summary>
    public TerraformList<string>? Categories
    {
        get => GetArgument<TerraformList<string>>("categories");
        set => SetArgument("categories", value);
    }

    /// <summary>
    /// List of packages to exclude from update.
    /// </summary>
    public TerraformList<string>? Excludes
    {
        get => GetArgument<TerraformList<string>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// An exclusive list of patches to be updated. These are the only patches that will be installed using &#39;zypper patch patch:&#39; command.
    /// This field must not be used with any other patch configuration fields.
    /// </summary>
    public TerraformList<string>? ExclusivePatches
    {
        get => GetArgument<TerraformList<string>>("exclusive_patches");
        set => SetArgument("exclusive_patches", value);
    }

    /// <summary>
    /// Install only patches with these severities. Common severities include critical, important, moderate, and low.
    /// </summary>
    public TerraformList<string>? Severities
    {
        get => GetArgument<TerraformList<string>>("severities");
        set => SetArgument("severities", value);
    }

    /// <summary>
    /// Adds the --with-optional flag to zypper patch.
    /// </summary>
    public TerraformValue<bool>? WithOptional
    {
        get => GetArgument<TerraformValue<bool>>("with_optional");
        set => SetArgument("with_optional", value);
    }

    /// <summary>
    /// Adds the --with-update flag, to zypper patch.
    /// </summary>
    public TerraformValue<bool>? WithUpdate
    {
        get => GetArgument<TerraformValue<bool>>("with_update");
        set => SetArgument("with_update", value);
    }

}


/// <summary>
/// Block type for recurring_schedule in GoogleOsConfigPatchDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurring_schedule";

    /// <summary>
    /// The end time at which a recurring patch deployment schedule is no longer active.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The time the last patch job ran successfully.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> LastExecuteTime
        => AsReference("last_execute_time");

    /// <summary>
    /// The time the next patch job is scheduled to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> NextExecuteTime
        => AsReference("next_execute_time");

    /// <summary>
    /// The time that the recurring schedule becomes effective. Defaults to createTime of the patch deployment.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// Monthly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monthly block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlock>? Monthly
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlock>>("monthly");
        set => SetArgument("monthly", value);
    }

    /// <summary>
    /// TimeOfDay block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimeOfDay block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeOfDay block(s) allowed")]
    public required TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockTimeOfDayBlock> TimeOfDay
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockTimeOfDayBlock>>("time_of_day");
        set => SetArgument("time_of_day", value);
    }

    /// <summary>
    /// TimeZone block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimeZone block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZone block(s) allowed")]
    public required TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockTimeZoneBlock> TimeZone
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockTimeZoneBlock>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// Weekly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Weekly block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockWeeklyBlock>? Weekly
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockWeeklyBlock>>("weekly");
        set => SetArgument("weekly", value);
    }

}

/// <summary>
/// Block type for monthly in GoogleOsConfigPatchDeploymentRecurringScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly";

    /// <summary>
    /// One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the month.
    /// Months without the target day will be skipped. For example, a schedule to run &amp;quot;every month on the 31st&amp;quot;
    /// will not run in February, April, June, etc.
    /// </summary>
    public TerraformValue<double>? MonthDay
    {
        get => GetArgument<TerraformValue<double>>("month_day");
        set => SetArgument("month_day", value);
    }

    /// <summary>
    /// WeekDayOfMonth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeekDayOfMonth block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlockWeekDayOfMonthBlock>? WeekDayOfMonth
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlockWeekDayOfMonthBlock>>("week_day_of_month");
        set => SetArgument("week_day_of_month", value);
    }

}

/// <summary>
/// Block type for week_day_of_month in GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlockMonthlyBlockWeekDayOfMonthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "week_day_of_month";

    /// <summary>
    /// A day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// Represents the number of days before or after the given week day of month that the patch deployment is scheduled for.
    /// </summary>
    public TerraformValue<double>? DayOffset
    {
        get => GetArgument<TerraformValue<double>>("day_offset");
        set => SetArgument("day_offset", value);
    }

    /// <summary>
    /// Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week of the month.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeekOrdinal is required")]
    public required TerraformValue<double> WeekOrdinal
    {
        get => GetRequiredArgument<TerraformValue<double>>("week_ordinal");
        set => SetArgument("week_ordinal", value);
    }

}

/// <summary>
/// Block type for time_of_day in GoogleOsConfigPatchDeploymentRecurringScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlockTimeOfDayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_of_day";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for time_zone in GoogleOsConfigPatchDeploymentRecurringScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlockTimeZoneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_zone";

    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &amp;quot;America/New_York&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// IANA Time Zone Database version number, e.g. &amp;quot;2019a&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for weekly in GoogleOsConfigPatchDeploymentRecurringScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRecurringScheduleBlockWeeklyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly";

    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &amp;quot;America/New_York&amp;quot;. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

}


/// <summary>
/// Block type for rollout in GoogleOsConfigPatchDeployment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRolloutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout";

    /// <summary>
    /// Mode of the patch rollout. Possible values: [&amp;quot;ZONE_BY_ZONE&amp;quot;, &amp;quot;CONCURRENT_ZONES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// DisruptionBudget block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisruptionBudget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DisruptionBudget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DisruptionBudget block(s) allowed")]
    public required TerraformList<GoogleOsConfigPatchDeploymentRolloutBlockDisruptionBudgetBlock> DisruptionBudget
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigPatchDeploymentRolloutBlockDisruptionBudgetBlock>>("disruption_budget");
        set => SetArgument("disruption_budget", value);
    }

}

/// <summary>
/// Block type for disruption_budget in GoogleOsConfigPatchDeploymentRolloutBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigPatchDeploymentRolloutBlockDisruptionBudgetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disruption_budget";

    /// <summary>
    /// Specifies a fixed value.
    /// </summary>
    public TerraformValue<double>? FixedAttribute
    {
        get => GetArgument<TerraformValue<double>>("fixed");
        set => SetArgument("fixed", value);
    }

    /// <summary>
    /// Specifies the relative value defined as a percentage, which will be multiplied by a reference value.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOsConfigPatchDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigPatchDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_os_config_patch_deployment Terraform resource.
/// Manages a google_os_config_patch_deployment resource.
/// </summary>
public partial class GoogleOsConfigPatchDeployment(string name) : TerraformResource("google_os_config_patch_deployment", name)
{
    /// <summary>
    /// Description of the patch deployment. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> PatchDeploymentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("patch_deployment_id");
        set => SetArgument("patch_deployment_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time the patch deployment was created. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> LastExecuteTime
        => AsReference("last_execute_time");

    /// <summary>
    /// Unique name for the patch deployment resource in a project.
    /// The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Time the patch deployment was last updated. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// InstanceFilter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    public required TerraformList<GoogleOsConfigPatchDeploymentInstanceFilterBlock> InstanceFilter
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigPatchDeploymentInstanceFilterBlock>>("instance_filter");
        set => SetArgument("instance_filter", value);
    }

    /// <summary>
    /// OneTimeSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OneTimeSchedule block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock>? OneTimeSchedule
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentOneTimeScheduleBlock>>("one_time_schedule");
        set => SetArgument("one_time_schedule", value);
    }

    /// <summary>
    /// PatchConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PatchConfig block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlock>? PatchConfig
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentPatchConfigBlock>>("patch_config");
        set => SetArgument("patch_config", value);
    }

    /// <summary>
    /// RecurringSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecurringSchedule block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlock>? RecurringSchedule
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentRecurringScheduleBlock>>("recurring_schedule");
        set => SetArgument("recurring_schedule", value);
    }

    /// <summary>
    /// Rollout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public TerraformList<GoogleOsConfigPatchDeploymentRolloutBlock>? Rollout
    {
        get => GetArgument<TerraformList<GoogleOsConfigPatchDeploymentRolloutBlock>>("rollout");
        set => SetArgument("rollout", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOsConfigPatchDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOsConfigPatchDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
