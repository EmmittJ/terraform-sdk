using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_export.
/// </summary>
public class AwsCloudformationExportDataSource : TerraformDataSource
{
    public AwsCloudformationExportDataSource(string name) : base("aws_cloudformation_export", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The exporting_stack_id attribute.
    /// </summary>
    [TerraformPropertyName("exporting_stack_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExportingStackId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "exporting_stack_id");

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Value => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "value");

}
