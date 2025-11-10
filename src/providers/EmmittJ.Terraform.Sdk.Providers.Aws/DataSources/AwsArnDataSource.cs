using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_arn.
/// </summary>
public class AwsArnDataSource : TerraformDataSource
{
    public AwsArnDataSource(string name) : base("aws_arn", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformPropertyName("account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Account => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Partition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partition");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Region => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Resource => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource");

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformPropertyName("service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Service => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service");

}
