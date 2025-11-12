using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsWorkspacesWorkspaceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for workspace_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesWorkspaceWorkspacePropertiesBlock() : TerraformBlock("workspace_properties")
{
    /// <summary>
    /// The compute_type_name attribute.
    /// </summary>
    [TerraformProperty("compute_type_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputeTypeName { get; set; }

    /// <summary>
    /// The root_volume_size_gib attribute.
    /// </summary>
    [TerraformProperty("root_volume_size_gib")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RootVolumeSizeGib { get; set; }

    /// <summary>
    /// The running_mode attribute.
    /// </summary>
    [TerraformProperty("running_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RunningMode { get; set; }

    /// <summary>
    /// The running_mode_auto_stop_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("running_mode_auto_stop_timeout_in_minutes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RunningModeAutoStopTimeoutInMinutes { get; set; }

    /// <summary>
    /// The user_volume_size_gib attribute.
    /// </summary>
    [TerraformProperty("user_volume_size_gib")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UserVolumeSizeGib { get; set; }

}

/// <summary>
/// Manages a aws_workspaces_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsWorkspacesWorkspace : TerraformResource
{
    public AwsWorkspacesWorkspace(string name) : base("aws_workspaces_workspace", name)
    {
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformProperty("bundle_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformProperty("directory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("root_volume_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RootVolumeEncryptionEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("user_volume_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UserVolumeEncryptionEnabled { get; set; }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    [TerraformProperty("volume_encryption_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VolumeEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsWorkspacesWorkspaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workspace_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceProperties block(s) allowed")]
    [TerraformProperty("workspace_properties")]
    public TerraformList<AwsWorkspacesWorkspaceWorkspacePropertiesBlock> WorkspaceProperties { get; set; } = new();

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformProperty("computer_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComputerName { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
