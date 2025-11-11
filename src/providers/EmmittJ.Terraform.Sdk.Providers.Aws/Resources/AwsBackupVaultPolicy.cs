using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_policy resource.
/// </summary>
public partial class AwsBackupVaultPolicy : TerraformResource
{
    public AwsBackupVaultPolicy(string name) : base("aws_backup_vault_policy", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    [TerraformProperty("policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Policy { get; set; }

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
