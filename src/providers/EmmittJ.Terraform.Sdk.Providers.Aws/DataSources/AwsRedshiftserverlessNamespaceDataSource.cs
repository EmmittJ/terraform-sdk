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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdminUsername => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_username");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultIamRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_iam_role_arn");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> IamRoles => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformPropertyName("log_exports")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LogExports => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "log_exports");

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NamespaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "namespace_id");

}
