using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspaces_workspace Terraform data source.
/// Retrieves information about a aws_workspaces_workspace.
/// </summary>
public partial class AwsWorkspacesWorkspaceDataSource(string name) : TerraformDataSource("aws_workspaces_workspace", name)
{
    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformValue<string> DirectoryId
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformValue<string> BundleId
    {
        get => new TerraformReference<string>(this, "bundle_id");
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
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RootVolumeEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "root_volume_encryption_enabled");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> UserVolumeEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "user_volume_encryption_enabled");
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformValue<string> VolumeEncryptionKey
    {
        get => new TerraformReference<string>(this, "volume_encryption_key");
    }

    /// <summary>
    /// The workspace_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkspaceProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workspace_properties").ResolveNodes(ctx));
    }

}
