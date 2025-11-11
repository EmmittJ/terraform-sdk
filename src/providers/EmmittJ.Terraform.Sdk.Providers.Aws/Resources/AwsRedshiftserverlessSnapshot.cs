using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_snapshot resource.
/// </summary>
public partial class AwsRedshiftserverlessSnapshot : TerraformResource
{
    public AwsRedshiftserverlessSnapshot(string name) : base("aws_redshiftserverless_snapshot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformProperty("namespace_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformProperty("retention_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionPeriod { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    [TerraformProperty("snapshot_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SnapshotName { get; set; }

    /// <summary>
    /// The accounts_with_provisioned_restore_access attribute.
    /// </summary>
    [TerraformProperty("accounts_with_provisioned_restore_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AccountsWithProvisionedRestoreAccess { get; }

    /// <summary>
    /// The accounts_with_restore_access attribute.
    /// </summary>
    [TerraformProperty("accounts_with_restore_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AccountsWithRestoreAccess { get; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformProperty("admin_username")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AdminUsername { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The namespace_arn attribute.
    /// </summary>
    [TerraformProperty("namespace_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NamespaceArn { get; }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    [TerraformProperty("owner_account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerAccount { get; }

}
