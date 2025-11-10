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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AdminPasswordSecretKmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_password_secret_kms_key_id");

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminUserPassword { get; set; }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminUserPasswordWo { get; set; }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AdminUserPasswordWoVersion { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AdminUsername { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_username");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultIamRoleArn { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> IamRoles { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "iam_roles");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformPropertyName("log_exports")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? LogExports { get; set; }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManageAdminPassword { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformPropertyName("namespace_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NamespaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The admin_password_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("admin_password_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdminPasswordSecretArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_password_secret_arn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NamespaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "namespace_id");

}
