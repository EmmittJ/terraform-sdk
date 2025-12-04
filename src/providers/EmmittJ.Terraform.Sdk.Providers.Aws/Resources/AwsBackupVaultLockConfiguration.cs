using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_backup_vault_lock_configuration Terraform resource.
/// Manages a aws_backup_vault_lock_configuration resource.
/// </summary>
public partial class AwsBackupVaultLockConfiguration(string name) : TerraformResource("aws_backup_vault_lock_configuration", name)
{
    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    public required TerraformValue<string> BackupVaultName
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_vault_name");
        set => SetArgument("backup_vault_name", value);
    }

    /// <summary>
    /// The changeable_for_days attribute.
    /// </summary>
    public TerraformValue<double>? ChangeableForDays
    {
        get => GetArgument<TerraformValue<double>>("changeable_for_days");
        set => SetArgument("changeable_for_days", value);
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
    /// The max_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? MaxRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("max_retention_days");
        set => SetArgument("max_retention_days", value);
    }

    /// <summary>
    /// The min_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? MinRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("min_retention_days");
        set => SetArgument("min_retention_days", value);
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
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformValue<string> BackupVaultArn
        => AsReference("backup_vault_arn");

}
