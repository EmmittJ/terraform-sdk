using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_control.
/// </summary>
public class AwsCloudfrontOriginAccessControlDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessControlDataSource(string name) : base("aws_cloudfront_origin_access_control", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The origin_access_control_origin_type attribute.
    /// </summary>
    [TerraformPropertyName("origin_access_control_origin_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OriginAccessControlOriginType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "origin_access_control_origin_type");

    /// <summary>
    /// The signing_behavior attribute.
    /// </summary>
    [TerraformPropertyName("signing_behavior")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningBehavior => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_behavior");

    /// <summary>
    /// The signing_protocol attribute.
    /// </summary>
    [TerraformPropertyName("signing_protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningProtocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_protocol");

}
