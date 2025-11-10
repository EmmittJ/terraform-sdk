using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voices in .
/// Nesting mode: list
/// </summary>
public class AwsPollyVoicesDataSourceVoicesBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_language_codes attribute.
    /// </summary>
    [TerraformPropertyName("additional_language_codes")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AdditionalLanguageCodes => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "additional_language_codes");

    /// <summary>
    /// The gender attribute.
    /// </summary>
    [TerraformPropertyName("gender")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Gender => new TerraformReferenceProperty<TerraformProperty<string>>("", "gender");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LanguageCode => new TerraformReferenceProperty<TerraformProperty<string>>("", "language_code");

    /// <summary>
    /// The language_name attribute.
    /// </summary>
    [TerraformPropertyName("language_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LanguageName => new TerraformReferenceProperty<TerraformProperty<string>>("", "language_name");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The supported_engines attribute.
    /// </summary>
    [TerraformPropertyName("supported_engines")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedEngines => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "supported_engines");

}

/// <summary>
/// Retrieves information about a aws_polly_voices.
/// </summary>
public class AwsPollyVoicesDataSource : TerraformDataSource
{
    public AwsPollyVoicesDataSource(string name) : base("aws_polly_voices", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Engine { get; set; }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    [TerraformPropertyName("include_additional_language_codes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeAdditionalLanguageCodes { get; set; }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LanguageCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for voices.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("voices")]
    public TerraformList<TerraformBlock<AwsPollyVoicesDataSourceVoicesBlock>>? Voices { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
