using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_notifications resource.
/// </summary>
public class AwsBackupVaultNotifications : TerraformResource
{
    public AwsBackupVaultNotifications(string name) : base("aws_backup_vault_notifications", name)
    {
    }

    /// <summary>
    /// The backup_vault_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultEvents is required")]
    [TerraformPropertyName("backup_vault_events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? BackupVaultEvents { get; set; }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    [TerraformPropertyName("backup_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupVaultName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopicArn is required")]
    [TerraformPropertyName("sns_topic_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SnsTopicArn { get; set; }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    [TerraformPropertyName("backup_vault_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupVaultArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_vault_arn");

}
