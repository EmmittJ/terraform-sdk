using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lakeformation_resource.
/// </summary>
public class AwsLakeformationResourceDataSource : TerraformDataSource
{
    public AwsLakeformationResourceDataSource(string name) : base("aws_lakeformation_resource", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hybrid_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HybridAccessEnabled => new TerraformReference(this, "hybrid_access_enabled");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    [TerraformPropertyName("with_federation")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> WithFederation => new TerraformReference(this, "with_federation");

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    [TerraformPropertyName("with_privileged_access")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> WithPrivilegedAccess => new TerraformReference(this, "with_privileged_access");

}
