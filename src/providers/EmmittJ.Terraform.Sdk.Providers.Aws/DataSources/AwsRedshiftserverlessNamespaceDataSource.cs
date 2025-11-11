using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_namespace.
/// </summary>
public class AwsRedshiftserverlessNamespaceDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessNamespaceDataSource(string name) : base("aws_redshiftserverless_namespace", name)
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
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbName => new TerraformReference(this, "db_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultIamRoleArn => new TerraformReference(this, "default_iam_role_arn");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> IamRoles => new TerraformReference(this, "iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformPropertyName("log_exports")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LogExports => new TerraformReference(this, "log_exports");

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamespaceId => new TerraformReference(this, "namespace_id");

}
