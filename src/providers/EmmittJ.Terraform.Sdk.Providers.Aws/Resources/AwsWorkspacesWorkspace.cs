using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsWorkspacesWorkspace.
/// Nesting mode: single
/// </summary>
public class AwsWorkspacesWorkspaceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for workspace_properties in AwsWorkspacesWorkspace.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesWorkspaceWorkspacePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workspace_properties";

    /// <summary>
    /// The compute_type_name attribute.
    /// </summary>
    public TerraformValue<string>? ComputeTypeName
    {
        get => GetArgument<TerraformValue<string>>("compute_type_name");
        set => SetArgument("compute_type_name", value);
    }

    /// <summary>
    /// The root_volume_size_gib attribute.
    /// </summary>
    public TerraformValue<double>? RootVolumeSizeGib
    {
        get => GetArgument<TerraformValue<double>>("root_volume_size_gib");
        set => SetArgument("root_volume_size_gib", value);
    }

    /// <summary>
    /// The running_mode attribute.
    /// </summary>
    public TerraformValue<string>? RunningMode
    {
        get => GetArgument<TerraformValue<string>>("running_mode");
        set => SetArgument("running_mode", value);
    }

    /// <summary>
    /// The running_mode_auto_stop_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> RunningModeAutoStopTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("running_mode_auto_stop_timeout_in_minutes") ?? AsReference("running_mode_auto_stop_timeout_in_minutes");
        set => SetArgument("running_mode_auto_stop_timeout_in_minutes", value);
    }

    /// <summary>
    /// The user_volume_size_gib attribute.
    /// </summary>
    public TerraformValue<double>? UserVolumeSizeGib
    {
        get => GetArgument<TerraformValue<double>>("user_volume_size_gib");
        set => SetArgument("user_volume_size_gib", value);
    }

}


/// <summary>
/// Represents a aws_workspaces_workspace Terraform resource.
/// Manages a aws_workspaces_workspace resource.
/// </summary>
public partial class AwsWorkspacesWorkspace(string name) : TerraformResource("aws_workspaces_workspace", name)
{
    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformValue<string> BundleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RootVolumeEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("root_volume_encryption_enabled");
        set => SetArgument("root_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserVolumeEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("user_volume_encryption_enabled");
        set => SetArgument("user_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformValue<string>? VolumeEncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("volume_encryption_key");
        set => SetArgument("volume_encryption_key", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformValue<string> ComputerName
        => AsReference("computer_name");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsWorkspacesWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsWorkspacesWorkspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkspaceProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceProperties block(s) allowed")]
    public TerraformList<AwsWorkspacesWorkspaceWorkspacePropertiesBlock>? WorkspaceProperties
    {
        get => GetArgument<TerraformList<AwsWorkspacesWorkspaceWorkspacePropertiesBlock>>("workspace_properties");
        set => SetArgument("workspace_properties", value);
    }

}
