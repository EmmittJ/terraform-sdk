using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWorkspacesWorkspaceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for workspace_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesWorkspaceWorkspacePropertiesBlock
{
    /// <summary>
    /// The compute_type_name attribute.
    /// </summary>
    [TerraformPropertyName("compute_type_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComputeTypeName { get; set; }

    /// <summary>
    /// The root_volume_size_gib attribute.
    /// </summary>
    [TerraformPropertyName("root_volume_size_gib")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RootVolumeSizeGib { get; set; }

    /// <summary>
    /// The running_mode attribute.
    /// </summary>
    [TerraformPropertyName("running_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RunningMode { get; set; }

    /// <summary>
    /// The running_mode_auto_stop_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("running_mode_auto_stop_timeout_in_minutes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RunningModeAutoStopTimeoutInMinutes { get; set; } = default!;

    /// <summary>
    /// The user_volume_size_gib attribute.
    /// </summary>
    [TerraformPropertyName("user_volume_size_gib")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UserVolumeSizeGib { get; set; }

}

/// <summary>
/// Manages a aws_workspaces_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWorkspacesWorkspace : TerraformResource
{
    public AwsWorkspacesWorkspace(string name) : base("aws_workspaces_workspace", name)
    {
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformPropertyName("bundle_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformPropertyName("directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("root_volume_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RootVolumeEncryptionEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("user_volume_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UserVolumeEncryptionEnabled { get; set; }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("volume_encryption_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VolumeEncryptionKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsWorkspacesWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for workspace_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceProperties block(s) allowed")]
    [TerraformPropertyName("workspace_properties")]
    public TerraformList<TerraformBlock<AwsWorkspacesWorkspaceWorkspacePropertiesBlock>>? WorkspaceProperties { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformPropertyName("computer_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputerName => new TerraformReference(this, "computer_name");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
