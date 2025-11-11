using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for csv_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierCsvClassifierBlock
{
    /// <summary>
    /// The allow_single_column attribute.
    /// </summary>
    [TerraformPropertyName("allow_single_column")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowSingleColumn { get; set; }

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    [TerraformPropertyName("contains_header")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainsHeader { get; set; }

    /// <summary>
    /// The custom_datatype_configured attribute.
    /// </summary>
    [TerraformPropertyName("custom_datatype_configured")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomDatatypeConfigured { get; set; }

    /// <summary>
    /// The custom_datatypes attribute.
    /// </summary>
    [TerraformPropertyName("custom_datatypes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CustomDatatypes { get; set; }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    [TerraformPropertyName("delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delimiter { get; set; }

    /// <summary>
    /// The disable_value_trimming attribute.
    /// </summary>
    [TerraformPropertyName("disable_value_trimming")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableValueTrimming { get; set; }

    /// <summary>
    /// The header attribute.
    /// </summary>
    [TerraformPropertyName("header")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Header { get; set; }

    /// <summary>
    /// The quote_symbol attribute.
    /// </summary>
    [TerraformPropertyName("quote_symbol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QuoteSymbol { get; set; }

    /// <summary>
    /// The serde attribute.
    /// </summary>
    [TerraformPropertyName("serde")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Serde { get; set; } = default!;

}

/// <summary>
/// Block type for grok_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierGrokClassifierBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformPropertyName("classification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Classification { get; set; }

    /// <summary>
    /// The custom_patterns attribute.
    /// </summary>
    [TerraformPropertyName("custom_patterns")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomPatterns { get; set; }

    /// <summary>
    /// The grok_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrokPattern is required")]
    [TerraformPropertyName("grok_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GrokPattern { get; set; }

}

/// <summary>
/// Block type for json_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierJsonClassifierBlock
{
    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    [TerraformPropertyName("json_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> JsonPath { get; set; }

}

/// <summary>
/// Block type for xml_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierXmlClassifierBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformPropertyName("classification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Classification { get; set; }

    /// <summary>
    /// The row_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowTag is required")]
    [TerraformPropertyName("row_tag")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RowTag { get; set; }

}

/// <summary>
/// Manages a aws_glue_classifier resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueClassifier : TerraformResource
{
    public AwsGlueClassifier(string name) : base("aws_glue_classifier", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for csv_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvClassifier block(s) allowed")]
    [TerraformPropertyName("csv_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierCsvClassifierBlock>>? CsvClassifier { get; set; }

    /// <summary>
    /// Block for grok_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrokClassifier block(s) allowed")]
    [TerraformPropertyName("grok_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierGrokClassifierBlock>>? GrokClassifier { get; set; }

    /// <summary>
    /// Block for json_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonClassifier block(s) allowed")]
    [TerraformPropertyName("json_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierJsonClassifierBlock>>? JsonClassifier { get; set; }

    /// <summary>
    /// Block for xml_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XmlClassifier block(s) allowed")]
    [TerraformPropertyName("xml_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierXmlClassifierBlock>>? XmlClassifier { get; set; }

}
