using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_efs_backup_policy resource.
/// </summary>
public class AwsEfsBackupPolicy : TerraformResource
{
    public AwsEfsBackupPolicy(string name) : base("aws_efs_backup_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public string? FileSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_id")?.Value;
        set => this.WithProperty("file_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
