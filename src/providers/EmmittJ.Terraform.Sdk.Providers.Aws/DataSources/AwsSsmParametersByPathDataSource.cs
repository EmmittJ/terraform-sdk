using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_parameters_by_path.
/// </summary>
public class AwsSsmParametersByPathDataSource : TerraformDataSource
{
    public AwsSsmParametersByPathDataSource(string name) : base("aws_ssm_parameters_by_path", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Path { get; set; }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    [TerraformPropertyName("recursive")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Recursive { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The with_decryption attribute.
    /// </summary>
    [TerraformPropertyName("with_decryption")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WithDecryption { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Arns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Names => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "names");

    /// <summary>
    /// The types attribute.
    /// </summary>
    [TerraformPropertyName("types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Types => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "types");

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformPropertyName("values")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Values => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "values");

}
