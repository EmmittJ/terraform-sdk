using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_lock_configuration resource.
/// </summary>
public class AwsBackupVaultLockConfiguration : TerraformResource
{
    public AwsBackupVaultLockConfiguration(string name) : base("aws_backup_vault_lock_configuration", name)
    {
    }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    [TerraformPropertyName("backup_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BackupVaultName { get; set; }

    /// <summary>
    /// The changeable_for_days attribute.
    /// </summary>
    [TerraformPropertyName("changeable_for_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ChangeableForDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("max_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxRetentionDays { get; set; }

    /// <summary>
    /// The min_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("min_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinRetentionDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    [TerraformPropertyName("backup_vault_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupVaultArn => new TerraformReference(this, "backup_vault_arn");

}
