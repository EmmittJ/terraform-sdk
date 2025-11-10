using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicequotas_templates.
/// </summary>
public class AwsServicequotasTemplatesDataSource : TerraformDataSource
{
    public AwsServicequotasTemplatesDataSource(string name) : base("aws_servicequotas_templates", name)
    {
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformPropertyName("aws_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AwsRegion { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The templates attribute.
    /// </summary>
    [TerraformPropertyName("templates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Templates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "templates");

}
