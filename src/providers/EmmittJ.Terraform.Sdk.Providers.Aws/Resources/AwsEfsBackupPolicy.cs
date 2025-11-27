using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for backup_policy in AwsEfsBackupPolicy.
/// Nesting mode: list
/// </summary>
public class AwsEfsBackupPolicyBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_policy";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_efs_backup_policy Terraform resource.
/// Manages a aws_efs_backup_policy resource.
/// </summary>
public partial class AwsEfsBackupPolicy(string name) : TerraformResource("aws_efs_backup_policy", name)
{
    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
        set => SetArgument("file_system_id", value);
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
    /// BackupPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackupPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupPolicy block(s) allowed")]
    public required TerraformList<AwsEfsBackupPolicyBackupPolicyBlock> BackupPolicy
    {
        get => GetRequiredArgument<TerraformList<AwsEfsBackupPolicyBackupPolicyBlock>>("backup_policy");
        set => SetArgument("backup_policy", value);
    }

}
