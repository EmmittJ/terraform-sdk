using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for csv_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierCsvClassifierBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_single_column attribute.
    /// </summary>
    [TerraformPropertyName("allow_single_column")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowSingleColumn { get; set; }

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    [TerraformPropertyName("contains_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainsHeader { get; set; }

    /// <summary>
    /// The custom_datatype_configured attribute.
    /// </summary>
    [TerraformPropertyName("custom_datatype_configured")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomDatatypeConfigured { get; set; }

    /// <summary>
    /// The custom_datatypes attribute.
    /// </summary>
    [TerraformPropertyName("custom_datatypes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CustomDatatypes { get; set; }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    [TerraformPropertyName("delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delimiter { get; set; }

    /// <summary>
    /// The disable_value_trimming attribute.
    /// </summary>
    [TerraformPropertyName("disable_value_trimming")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableValueTrimming { get; set; }

    /// <summary>
    /// The header attribute.
    /// </summary>
    [TerraformPropertyName("header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Header { get; set; }

    /// <summary>
    /// The quote_symbol attribute.
    /// </summary>
    [TerraformPropertyName("quote_symbol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuoteSymbol { get; set; }

    /// <summary>
    /// The serde attribute.
    /// </summary>
    [TerraformPropertyName("serde")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Serde { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "serde");

}

/// <summary>
/// Block type for grok_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierGrokClassifierBlock : ITerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformPropertyName("classification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Classification { get; set; }

    /// <summary>
    /// The custom_patterns attribute.
    /// </summary>
    [TerraformPropertyName("custom_patterns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomPatterns { get; set; }

    /// <summary>
    /// The grok_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrokPattern is required")]
    [TerraformPropertyName("grok_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GrokPattern { get; set; }

}

/// <summary>
/// Block type for json_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierJsonClassifierBlock : ITerraformBlock
{
    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    [TerraformPropertyName("json_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JsonPath { get; set; }

}

/// <summary>
/// Block type for xml_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierXmlClassifierBlock : ITerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    [TerraformPropertyName("classification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Classification { get; set; }

    /// <summary>
    /// The row_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowTag is required")]
    [TerraformPropertyName("row_tag")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RowTag { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for csv_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvClassifier block(s) allowed")]
    [TerraformPropertyName("csv_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierCsvClassifierBlock>>? CsvClassifier { get; set; } = new();

    /// <summary>
    /// Block for grok_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrokClassifier block(s) allowed")]
    [TerraformPropertyName("grok_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierGrokClassifierBlock>>? GrokClassifier { get; set; } = new();

    /// <summary>
    /// Block for json_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonClassifier block(s) allowed")]
    [TerraformPropertyName("json_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierJsonClassifierBlock>>? JsonClassifier { get; set; } = new();

    /// <summary>
    /// Block for xml_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XmlClassifier block(s) allowed")]
    [TerraformPropertyName("xml_classifier")]
    public TerraformList<TerraformBlock<AwsGlueClassifierXmlClassifierBlock>>? XmlClassifier { get; set; } = new();

}
