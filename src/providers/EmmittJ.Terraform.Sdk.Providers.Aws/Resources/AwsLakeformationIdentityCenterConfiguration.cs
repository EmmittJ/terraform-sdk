using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_identity_center_configuration resource.
/// </summary>
public class AwsLakeformationIdentityCenterConfiguration : TerraformResource
{
    public AwsLakeformationIdentityCenterConfiguration(string name) : base("aws_lakeformation_identity_center_configuration", name)
    {
    }

    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CatalogId { get; set; } = default!;

    /// <summary>
    /// The ARN of the Identity Center instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformPropertyName("instance_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationArn => new TerraformReference(this, "application_arn");

    /// <summary>
    /// The resource_share attribute.
    /// </summary>
    [TerraformPropertyName("resource_share")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceShare => new TerraformReference(this, "resource_share");

}
