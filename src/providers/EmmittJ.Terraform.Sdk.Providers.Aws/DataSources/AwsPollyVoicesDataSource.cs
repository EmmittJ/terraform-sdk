using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voices in .
/// Nesting mode: list
/// </summary>
public partial class AwsPollyVoicesDataSourceVoicesBlock : TerraformBlockBase
{







}

/// <summary>
/// Retrieves information about a aws_polly_voices.
/// </summary>
public partial class AwsPollyVoicesDataSource : TerraformDataSource
{
    public AwsPollyVoicesDataSource(string name) : base("aws_polly_voices", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    [TerraformProperty("include_additional_language_codes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeAdditionalLanguageCodes { get; set; }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for voices.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("voices")]
    public TerraformList<TerraformBlock<AwsPollyVoicesDataSourceVoicesBlock>>? Voices { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
