using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voices in .
/// Nesting mode: list
/// </summary>
public class AwsPollyVoicesDataSourceVoicesBlock
{







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
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    [TerraformPropertyName("include_additional_language_codes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeAdditionalLanguageCodes { get; set; }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformPropertyName("language_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for voices.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("voices")]
    public TerraformList<TerraformBlock<AwsPollyVoicesDataSourceVoicesBlock>>? Voices { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
