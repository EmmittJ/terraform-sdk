using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_notifications resource.
/// </summary>
public partial class AwsBackupVaultNotifications : TerraformResource
{
    public AwsBackupVaultNotifications(string name) : base("aws_backup_vault_notifications", name)
    {
    }

    /// <summary>
    /// The backup_vault_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultEvents is required")]
    [TerraformProperty("backup_vault_events")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> BackupVaultEvents { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopicArn is required")]
    [TerraformProperty("sns_topic_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SnsTopicArn { get; set; }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    [TerraformProperty("backup_vault_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BackupVaultArn { get; }

}
