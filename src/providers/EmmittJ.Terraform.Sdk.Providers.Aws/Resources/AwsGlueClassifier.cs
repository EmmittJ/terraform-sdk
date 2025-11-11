using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for csv_classifier in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueClassifierCsvClassifierBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_single_column attribute.
    /// </summary>
    [TerraformProperty("allow_single_column")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowSingleColumn { get; set; }

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    [TerraformProperty("contains_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainsHeader { get; set; }

    /// <summary>
    /// The custom_datatype_configured attribute.
    /// </summary>
    [TerraformProperty("custom_datatype_configured")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomDatatypeConfigured { get; set; }

    /// <summary>
    /// The custom_datatypes attribute.
    /// </summary>
    [TerraformProperty("custom_datatypes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CustomDatatypes { get; set; }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    [TerraformProperty("delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delimiter { get; set; }

    /// <summary>
    /// The disable_value_trimming attribute.
    /// </summary>
    [TerraformProperty("disable_value_trimming")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableValueTrimming { get; set; }

    /// <summary>
    /// The header attribute.
    /// </summary>
    [TerraformProperty("header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Header { get; set; }

    /// <summary>
    /// The quote_symbol attribute.
    /// </summary>
    [TerraformProperty("quote_symbol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuoteSymbol { get; set; }

    /// <summary>
    /// The serde attribute.
    /// </summary>
    [TerraformProperty("serde")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Serde { get; set; }

}

/// <summary>
/// Block type for grok_classifier in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueClassifierGrokClassifierBlock : TerraformBlockBase
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformProperty("classification")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Classification { get; set; }

    /// <summary>
    /// The custom_patterns attribute.
    /// </summary>
    [TerraformProperty("custom_patterns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomPatterns { get; set; }

    /// <summary>
    /// The grok_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrokPattern is required")]
    [TerraformProperty("grok_pattern")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GrokPattern { get; set; }

}

/// <summary>
/// Block type for json_classifier in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueClassifierJsonClassifierBlock : TerraformBlockBase
{
    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    [TerraformProperty("json_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JsonPath { get; set; }

}

/// <summary>
/// Block type for xml_classifier in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueClassifierXmlClassifierBlock : TerraformBlockBase
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformProperty("classification")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Classification { get; set; }

    /// <summary>
    /// The row_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowTag is required")]
    [TerraformProperty("row_tag")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RowTag { get; set; }

}

/// <summary>
/// Manages a aws_glue_classifier resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueClassifier : TerraformResource
{
    public AwsGlueClassifier(string name) : base("aws_glue_classifier", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for csv_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvClassifier block(s) allowed")]
    [TerraformProperty("csv_classifier")]
    public partial TerraformList<TerraformBlock<AwsGlueClassifierCsvClassifierBlock>>? CsvClassifier { get; set; }

    /// <summary>
    /// Block for grok_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrokClassifier block(s) allowed")]
    [TerraformProperty("grok_classifier")]
    public partial TerraformList<TerraformBlock<AwsGlueClassifierGrokClassifierBlock>>? GrokClassifier { get; set; }

    /// <summary>
    /// Block for json_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonClassifier block(s) allowed")]
    [TerraformProperty("json_classifier")]
    public partial TerraformList<TerraformBlock<AwsGlueClassifierJsonClassifierBlock>>? JsonClassifier { get; set; }

    /// <summary>
    /// Block for xml_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XmlClassifier block(s) allowed")]
    [TerraformProperty("xml_classifier")]
    public partial TerraformList<TerraformBlock<AwsGlueClassifierXmlClassifierBlock>>? XmlClassifier { get; set; }

}
