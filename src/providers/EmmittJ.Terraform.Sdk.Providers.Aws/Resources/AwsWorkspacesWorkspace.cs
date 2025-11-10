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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("compute_type_name", value);
    }

    /// <summary>
    /// The root_volume_size_gib attribute.
    /// </summary>
    public TerraformProperty<double>? RootVolumeSizeGib
    {
        set => SetProperty("root_volume_size_gib", value);
    }

    /// <summary>
    /// The running_mode attribute.
    /// </summary>
    public TerraformProperty<string>? RunningMode
    {
        set => SetProperty("running_mode", value);
    }

    /// <summary>
    /// The running_mode_auto_stop_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? RunningModeAutoStopTimeoutInMinutes
    {
        set => SetProperty("running_mode_auto_stop_timeout_in_minutes", value);
    }

    /// <summary>
    /// The user_volume_size_gib attribute.
    /// </summary>
    public TerraformProperty<double>? UserVolumeSizeGib
    {
        set => SetProperty("user_volume_size_gib", value);
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
        SetOutput("computer_name");
        SetOutput("ip_address");
        SetOutput("state");
        SetOutput("bundle_id");
        SetOutput("directory_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("root_volume_encryption_enabled");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_name");
        SetOutput("user_volume_encryption_enabled");
        SetOutput("volume_encryption_key");
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformProperty<string> BundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bundle_id");
        set => SetProperty("bundle_id", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RootVolumeEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("root_volume_encryption_enabled");
        set => SetProperty("root_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> UserVolumeEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("user_volume_encryption_enabled");
        set => SetProperty("user_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string> VolumeEncryptionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_encryption_key");
        set => SetProperty("volume_encryption_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsWorkspacesWorkspaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workspace_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceProperties block(s) allowed")]
    public List<AwsWorkspacesWorkspaceWorkspacePropertiesBlock>? WorkspaceProperties
    {
        set => SetProperty("workspace_properties", value);
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
