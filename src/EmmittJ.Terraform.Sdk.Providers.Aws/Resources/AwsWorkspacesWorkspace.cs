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
    public TerraformProperty<string>? BundleId
    {
        get => GetProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The root_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RootVolumeEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("root_volume_encryption_enabled");
        set => this.WithProperty("root_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The user_volume_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserVolumeEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("user_volume_encryption_enabled");
        set => this.WithProperty("user_volume_encryption_enabled", value);
    }

    /// <summary>
    /// The volume_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeEncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("volume_encryption_key");
        set => this.WithProperty("volume_encryption_key", value);
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
