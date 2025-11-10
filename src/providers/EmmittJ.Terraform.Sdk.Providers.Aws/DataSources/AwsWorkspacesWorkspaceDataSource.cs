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
        SetOutput("bundle_id");
        SetOutput("computer_name");
        SetOutput("ip_address");
        SetOutput("root_volume_encryption_enabled");
        SetOutput("state");
        SetOutput("user_volume_encryption_enabled");
        SetOutput("volume_encryption_key");
        SetOutput("workspace_properties");
        SetOutput("directory_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("user_name");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string> DirectoryId
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
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
