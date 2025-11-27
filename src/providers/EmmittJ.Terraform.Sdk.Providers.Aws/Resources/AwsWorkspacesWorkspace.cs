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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "compute_type_name");
        set => SetArgument("compute_type_name", value);
    }

    /// <summary>
    /// The root_volume_size_gib attribute.
    /// </summary>
    public TerraformValue<double>? RootVolumeSizeGib
    {
        get => new TerraformReference<double>(this, "root_volume_size_gib");
        set => SetArgument("root_volume_size_gib", value);
    }

    /// <summary>
    /// The running_mode attribute.
    /// </summary>
    public TerraformValue<string>? RunningMode
    {
        get => new TerraformReference<string>(this, "running_mode");
        set => SetArgument("running_mode", value);
    }

    /// <summary>
    /// The running_mode_auto_stop_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> RunningModeAutoStopTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "running_mode_auto_stop_timeout_in_minutes");
        set => SetArgument("running_mode_auto_stop_timeout_in_minutes", value);
    }

    /// <summary>
    /// The user_volume_size_gib attribute.
    /// </summary>
    public TerraformValue<double>? UserVolumeSizeGib
    {
        get => new TerraformReference<double>(this, "user_volume_size_gib");
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
        get => new TerraformReference<string>(this, "bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RootVolumeEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "root_volume_encryption_enabled");
        set => SetArgument("root_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserVolumeEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "user_volume_encryption_enabled");
        set => SetArgument("user_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformValue<string>? VolumeEncryptionKey
    {
        get => new TerraformReference<string>(this, "volume_encryption_key");
        set => SetArgument("volume_encryption_key", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformValue<string> ComputerName
    {
        get => new TerraformReference<string>(this, "computer_name");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

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
