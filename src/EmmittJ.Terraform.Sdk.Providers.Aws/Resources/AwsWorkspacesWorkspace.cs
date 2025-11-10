using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWorkspacesWorkspaceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for workspace_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesWorkspaceWorkspacePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The compute_type_name attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeTypeName
    {
        get => GetProperty<TerraformProperty<string>>("compute_type_name");
        set => WithProperty("compute_type_name", value);
    }

    /// <summary>
    /// The root_volume_size_gib attribute.
    /// </summary>
    public TerraformProperty<double>? RootVolumeSizeGib
    {
        get => GetProperty<TerraformProperty<double>>("root_volume_size_gib");
        set => WithProperty("root_volume_size_gib", value);
    }

    /// <summary>
    /// The running_mode attribute.
    /// </summary>
    public TerraformProperty<string>? RunningMode
    {
        get => GetProperty<TerraformProperty<string>>("running_mode");
        set => WithProperty("running_mode", value);
    }

    /// <summary>
    /// The running_mode_auto_stop_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? RunningModeAutoStopTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("running_mode_auto_stop_timeout_in_minutes");
        set => WithProperty("running_mode_auto_stop_timeout_in_minutes", value);
    }

    /// <summary>
    /// The user_volume_size_gib attribute.
    /// </summary>
    public TerraformProperty<double>? UserVolumeSizeGib
    {
        get => GetProperty<TerraformProperty<double>>("user_volume_size_gib");
        set => WithProperty("user_volume_size_gib", value);
    }

}

/// <summary>
/// Manages a aws_workspaces_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWorkspacesWorkspace : TerraformResource
{
    public AwsWorkspacesWorkspace(string name) : base("aws_workspaces_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("computer_name");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformProperty<string> BundleId
    {
        get => GetProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RootVolumeEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("root_volume_encryption_enabled");
        set => this.WithProperty("root_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserVolumeEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("user_volume_encryption_enabled");
        set => this.WithProperty("user_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeEncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("volume_encryption_key");
        set => this.WithProperty("volume_encryption_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsWorkspacesWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsWorkspacesWorkspaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workspace_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceProperties block(s) allowed")]
    public List<AwsWorkspacesWorkspaceWorkspacePropertiesBlock>? WorkspaceProperties
    {
        get => GetProperty<List<AwsWorkspacesWorkspaceWorkspacePropertiesBlock>>("workspace_properties");
        set => this.WithProperty("workspace_properties", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformExpression ComputerName => this["computer_name"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
