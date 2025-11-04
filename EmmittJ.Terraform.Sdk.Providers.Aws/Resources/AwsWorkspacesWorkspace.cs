using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspaces_workspace resource.
/// </summary>
public class AwsWorkspacesWorkspace : TerraformResource
{
    public AwsWorkspacesWorkspace(string name) : base("aws_workspaces_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("computer_name");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public string? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id")?.Value;
        set => this.WithProperty("bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public bool? RootVolumeEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("root_volume_encryption_enabled")?.Value;
        set => this.WithProperty("root_volume_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public bool? UserVolumeEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_volume_encryption_enabled")?.Value;
        set => this.WithProperty("user_volume_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public string? VolumeEncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_encryption_key")?.Value;
        set => this.WithProperty("volume_encryption_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
