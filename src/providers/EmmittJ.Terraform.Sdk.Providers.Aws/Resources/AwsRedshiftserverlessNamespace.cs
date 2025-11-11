using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_namespace resource.
/// </summary>
public partial class AwsRedshiftserverlessNamespace : TerraformResource
{
    public AwsRedshiftserverlessNamespace(string name) : base("aws_redshiftserverless_namespace", name)
    {
    }

    /// <summary>
    /// The admin_password_secret_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("admin_password_secret_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdminPasswordSecretKmsKeyId { get; set; }

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    [TerraformProperty("admin_user_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdminUserPassword { get; set; }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    [TerraformProperty("admin_user_password_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdminUserPasswordWo { get; set; }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("admin_user_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdminUserPasswordWoVersion { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformProperty("admin_username")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformProperty("db_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbName { get; set; }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("default_iam_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultIamRoleArn { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformProperty("iam_roles")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> IamRoles { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformProperty("log_exports")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? LogExports { get; set; }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    [TerraformProperty("manage_admin_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManageAdminPassword { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformProperty("namespace_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The admin_password_secret_arn attribute.
    /// </summary>
    [TerraformProperty("admin_password_secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdminPasswordSecretArn { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NamespaceId { get; }

}
