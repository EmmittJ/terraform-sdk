using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_workspace.
/// </summary>
public class AwsWorkspacesWorkspaceDataSource : TerraformDataSource
{
    public AwsWorkspacesWorkspaceDataSource(string name) : base("aws_workspaces_workspace", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DirectoryId { get; set; } = default!;

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserName { get; set; } = default!;

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WorkspaceId { get; set; } = default!;

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformPropertyName("bundle_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BundleId => new TerraformReference(this, "bundle_id");

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
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("root_volume_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RootVolumeEncryptionEnabled => new TerraformReference(this, "root_volume_encryption_enabled");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("user_volume_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> UserVolumeEncryptionEnabled => new TerraformReference(this, "user_volume_encryption_enabled");

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("volume_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeEncryptionKey => new TerraformReference(this, "volume_encryption_key");

    /// <summary>
    /// The workspace_properties attribute.
    /// </summary>
    [TerraformPropertyName("workspace_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkspaceProperties => new TerraformReference(this, "workspace_properties");

}
