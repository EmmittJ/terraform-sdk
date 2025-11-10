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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DirectoryId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_name");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_id");

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformPropertyName("bundle_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BundleId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bundle_id");

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformPropertyName("computer_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "computer_name");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address");

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("root_volume_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RootVolumeEncryptionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "root_volume_encryption_enabled");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("user_volume_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> UserVolumeEncryptionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "user_volume_encryption_enabled");

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("volume_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeEncryptionKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_encryption_key");

    /// <summary>
    /// The workspace_properties attribute.
    /// </summary>
    [TerraformPropertyName("workspace_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkspaceProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workspace_properties");

}
