using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_workspace.
/// </summary>
public class AwsWorkspacesWorkspaceDataSource : TerraformDataSource
{
    public AwsWorkspacesWorkspaceDataSource(string name) : base("aws_workspaces_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bundle_id");
        this.DeclareOutput("computer_name");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("root_volume_encryption_enabled");
        this.DeclareOutput("state");
        this.DeclareOutput("user_volume_encryption_enabled");
        this.DeclareOutput("volume_encryption_key");
        this.DeclareOutput("workspace_properties");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformExpression BundleId => this["bundle_id"];

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformExpression ComputerName => this["computer_name"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformExpression RootVolumeEncryptionEnabled => this["root_volume_encryption_enabled"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformExpression UserVolumeEncryptionEnabled => this["user_volume_encryption_enabled"];

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformExpression VolumeEncryptionKey => this["volume_encryption_key"];

    /// <summary>
    /// The workspace_properties attribute.
    /// </summary>
    public TerraformExpression WorkspaceProperties => this["workspace_properties"];

}
