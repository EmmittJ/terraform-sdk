using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_lock_configuration resource.
/// </summary>
public partial class AwsBackupVaultLockConfiguration : TerraformResource
{
    public AwsBackupVaultLockConfiguration(string name) : base("aws_backup_vault_lock_configuration", name)
    {
    }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    [TerraformProperty("backup_vault_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BackupVaultName { get; set; }

    /// <summary>
    /// The changeable_for_days attribute.
    /// </summary>
    [TerraformProperty("changeable_for_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ChangeableForDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_retention_days attribute.
    /// </summary>
    [TerraformProperty("max_retention_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRetentionDays { get; set; }

    /// <summary>
    /// The min_retention_days attribute.
    /// </summary>
    [TerraformProperty("min_retention_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinRetentionDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    [TerraformProperty("backup_vault_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BackupVaultArn { get; }

}
