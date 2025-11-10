using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProductDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_servicecatalog_product.
/// </summary>
public class AwsServicecatalogProductDataSource : TerraformDataSource
{
    public AwsServicecatalogProductDataSource(string name) : base("aws_servicecatalog_product", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformPropertyName("accept_language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceptLanguage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsServicecatalogProductDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    [TerraformPropertyName("distributor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Distributor => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "distributor");

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    [TerraformPropertyName("has_default_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasDefaultPath => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_default_path");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    [TerraformPropertyName("support_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SupportDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "support_description");

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    [TerraformPropertyName("support_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SupportEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "support_email");

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    [TerraformPropertyName("support_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SupportUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "support_url");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
