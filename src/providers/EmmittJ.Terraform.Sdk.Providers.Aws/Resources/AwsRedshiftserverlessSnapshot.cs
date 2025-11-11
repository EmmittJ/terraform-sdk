using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_snapshot resource.
/// </summary>
public class AwsRedshiftserverlessSnapshot : TerraformResource
{
    public AwsRedshiftserverlessSnapshot(string name) : base("aws_redshiftserverless_snapshot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformPropertyName("namespace_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformPropertyName("retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetentionPeriod { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    [TerraformPropertyName("snapshot_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SnapshotName { get; set; }

    /// <summary>
    /// The accounts_with_provisioned_restore_access attribute.
    /// </summary>
    [TerraformPropertyName("accounts_with_provisioned_restore_access")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AccountsWithProvisionedRestoreAccess => new TerraformReference(this, "accounts_with_provisioned_restore_access");

    /// <summary>
    /// The accounts_with_restore_access attribute.
    /// </summary>
    [TerraformPropertyName("accounts_with_restore_access")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AccountsWithRestoreAccess => new TerraformReference(this, "accounts_with_restore_access");

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdminUsername => new TerraformReference(this, "admin_username");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The namespace_arn attribute.
    /// </summary>
    [TerraformPropertyName("namespace_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamespaceArn => new TerraformReference(this, "namespace_arn");

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    [TerraformPropertyName("owner_account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerAccount => new TerraformReference(this, "owner_account");

}
