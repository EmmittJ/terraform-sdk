using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_namespace resource.
/// </summary>
public class AwsRedshiftserverlessNamespace : TerraformResource
{
    public AwsRedshiftserverlessNamespace(string name) : base("aws_redshiftserverless_namespace", name)
    {
    }

    /// <summary>
    /// The admin_password_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("admin_password_secret_kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AdminPasswordSecretKmsKeyId { get; set; } = default!;

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdminUserPassword { get; set; }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdminUserPasswordWo { get; set; }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AdminUserPasswordWoVersion { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AdminUsername { get; set; } = default!;

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbName { get; set; } = default!;

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultIamRoleArn { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> IamRoles { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformPropertyName("log_exports")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? LogExports { get; set; }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManageAdminPassword { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The admin_password_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("admin_password_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdminPasswordSecretArn => new TerraformReference(this, "admin_password_secret_arn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamespaceId => new TerraformReference(this, "namespace_id");

}
