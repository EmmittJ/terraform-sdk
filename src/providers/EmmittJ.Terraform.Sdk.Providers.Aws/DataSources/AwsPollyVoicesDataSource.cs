using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voices in .
/// Nesting mode: list
/// </summary>
public partial class AwsPollyVoicesDataSourceVoicesBlock() : TerraformBlock("voices")
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
    public partial TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    [TerraformProperty("include_additional_language_codes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeAdditionalLanguageCodes { get; set; }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [TerraformProperty("language_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LanguageCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for voices.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("voices")]
    public TerraformList<AwsPollyVoicesDataSourceVoicesBlock> Voices { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
