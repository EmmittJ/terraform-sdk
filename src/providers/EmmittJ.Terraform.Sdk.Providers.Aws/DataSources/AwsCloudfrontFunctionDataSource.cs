using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_function.
/// </summary>
public class AwsCloudfrontFunctionDataSource : TerraformDataSource
{
    public AwsCloudfrontFunctionDataSource(string name) : base("aws_cloudfront_function", name)
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
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [TerraformPropertyName("stage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Stage { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformPropertyName("code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Code => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "code");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Comment => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "comment");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    [TerraformPropertyName("key_value_store_associations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> KeyValueStoreAssociations => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "key_value_store_associations");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_time");

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Runtime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "runtime");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
