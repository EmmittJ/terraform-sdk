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
        get => GetArgument<TerraformValue<string>>("directory_id") ?? AsReference("directory_id");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name") ?? AsReference("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id") ?? AsReference("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformValue<string> BundleId
        => AsReference("bundle_id");

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
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RootVolumeEncryptionEnabled
        => AsReference("root_volume_encryption_enabled");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> UserVolumeEncryptionEnabled
        => AsReference("user_volume_encryption_enabled");

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformValue<string> VolumeEncryptionKey
        => AsReference("volume_encryption_key");

    /// <summary>
    /// The workspace_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkspaceProperties
        => AsReference("workspace_properties");

}
