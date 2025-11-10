using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_securityhub_standards_control_associations.
/// </summary>
public class AwsSecurityhubStandardsControlAssociationsDataSource : TerraformDataSource
{
    public AwsSecurityhubStandardsControlAssociationsDataSource(string name) : base("aws_securityhub_standards_control_associations", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    [TerraformPropertyName("security_control_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityControlId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The standards_control_associations attribute.
    /// </summary>
    [TerraformPropertyName("standards_control_associations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StandardsControlAssociations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "standards_control_associations");

}
