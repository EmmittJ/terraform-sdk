using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_workspace.
/// </summary>
public partial class AwsWorkspacesWorkspaceDataSource : TerraformDataSource
{
    public AwsWorkspacesWorkspaceDataSource(string name) : base("aws_workspaces_workspace", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformProperty("directory_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DirectoryId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformProperty("bundle_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BundleId { get; }

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
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("root_volume_encryption_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RootVolumeEncryptionEnabled { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("user_volume_encryption_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> UserVolumeEncryptionEnabled { get; }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    [TerraformProperty("volume_encryption_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeEncryptionKey { get; }

    /// <summary>
    /// The workspace_properties attribute.
    /// </summary>
    [TerraformProperty("workspace_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WorkspaceProperties { get; }

}
