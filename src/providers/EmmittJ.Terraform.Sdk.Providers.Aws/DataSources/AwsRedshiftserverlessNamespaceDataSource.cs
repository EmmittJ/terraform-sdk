using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_namespace.
/// </summary>
public partial class AwsRedshiftserverlessNamespaceDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessNamespaceDataSource(string name) : base("aws_redshiftserverless_namespace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The admin_username attribute.
    /// </summary>
    [TerraformProperty("admin_username")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdminUsername { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformProperty("db_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbName { get; }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("default_iam_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultIamRoleArn { get; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformProperty("iam_roles")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> IamRoles { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformProperty("log_exports")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> LogExports { get; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NamespaceId { get; }

}
