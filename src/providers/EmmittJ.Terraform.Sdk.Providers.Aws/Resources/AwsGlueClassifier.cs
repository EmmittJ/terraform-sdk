using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for csv_classifier in AwsGlueClassifier.
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierCsvClassifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_classifier";

    /// <summary>
    /// The allow_single_column attribute.
    /// </summary>
    public TerraformValue<bool>? AllowSingleColumn
    {
        get => GetArgument<TerraformValue<bool>>("allow_single_column");
        set => SetArgument("allow_single_column", value);
    }

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    public TerraformValue<string>? ContainsHeader
    {
        get => GetArgument<TerraformValue<string>>("contains_header");
        set => SetArgument("contains_header", value);
    }

    /// <summary>
    /// The custom_datatype_configured attribute.
    /// </summary>
    public TerraformValue<bool>? CustomDatatypeConfigured
    {
        get => GetArgument<TerraformValue<bool>>("custom_datatype_configured");
        set => SetArgument("custom_datatype_configured", value);
    }

    /// <summary>
    /// The custom_datatypes attribute.
    /// </summary>
    public TerraformList<string>? CustomDatatypes
    {
        get => GetArgument<TerraformList<string>>("custom_datatypes");
        set => SetArgument("custom_datatypes", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => GetArgument<TerraformValue<string>>("delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The disable_value_trimming attribute.
    /// </summary>
    public TerraformValue<bool>? DisableValueTrimming
    {
        get => GetArgument<TerraformValue<bool>>("disable_value_trimming");
        set => SetArgument("disable_value_trimming", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    public TerraformList<string>? Header
    {
        get => GetArgument<TerraformList<string>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The quote_symbol attribute.
    /// </summary>
    public TerraformValue<string>? QuoteSymbol
    {
        get => GetArgument<TerraformValue<string>>("quote_symbol");
        set => SetArgument("quote_symbol", value);
    }

    /// <summary>
    /// The serde attribute.
    /// </summary>
    public TerraformValue<string>? Serde
    {
        get => GetArgument<TerraformValue<string>>("serde");
        set => SetArgument("serde", value);
    }

}


/// <summary>
/// Block type for grok_classifier in AwsGlueClassifier.
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierGrokClassifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grok_classifier";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformValue<string> Classification
    {
        get => GetArgument<TerraformValue<string>>("classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The custom_patterns attribute.
    /// </summary>
    public TerraformValue<string>? CustomPatterns
    {
        get => GetArgument<TerraformValue<string>>("custom_patterns");
        set => SetArgument("custom_patterns", value);
    }

    /// <summary>
    /// The grok_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrokPattern is required")]
    public required TerraformValue<string> GrokPattern
    {
        get => GetArgument<TerraformValue<string>>("grok_pattern");
        set => SetArgument("grok_pattern", value);
    }

}


/// <summary>
/// Block type for json_classifier in AwsGlueClassifier.
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierJsonClassifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_classifier";

    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    public required TerraformValue<string> JsonPath
    {
        get => GetArgument<TerraformValue<string>>("json_path");
        set => SetArgument("json_path", value);
    }

}


/// <summary>
/// Block type for xml_classifier in AwsGlueClassifier.
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierXmlClassifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "xml_classifier";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformValue<string> Classification
    {
        get => GetArgument<TerraformValue<string>>("classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The row_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowTag is required")]
    public required TerraformValue<string> RowTag
    {
        get => GetArgument<TerraformValue<string>>("row_tag");
        set => SetArgument("row_tag", value);
    }

}


/// <summary>
/// Represents a aws_glue_classifier Terraform resource.
/// Manages a aws_glue_classifier resource.
/// </summary>
public partial class AwsGlueClassifier(string name) : TerraformResource("aws_glue_classifier", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// CsvClassifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvClassifier block(s) allowed")]
    public TerraformList<AwsGlueClassifierCsvClassifierBlock>? CsvClassifier
    {
        get => GetArgument<TerraformList<AwsGlueClassifierCsvClassifierBlock>>("csv_classifier");
        set => SetArgument("csv_classifier", value);
    }

    /// <summary>
    /// GrokClassifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrokClassifier block(s) allowed")]
    public TerraformList<AwsGlueClassifierGrokClassifierBlock>? GrokClassifier
    {
        get => GetArgument<TerraformList<AwsGlueClassifierGrokClassifierBlock>>("grok_classifier");
        set => SetArgument("grok_classifier", value);
    }

    /// <summary>
    /// JsonClassifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonClassifier block(s) allowed")]
    public TerraformList<AwsGlueClassifierJsonClassifierBlock>? JsonClassifier
    {
        get => GetArgument<TerraformList<AwsGlueClassifierJsonClassifierBlock>>("json_classifier");
        set => SetArgument("json_classifier", value);
    }

    /// <summary>
    /// XmlClassifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XmlClassifier block(s) allowed")]
    public TerraformList<AwsGlueClassifierXmlClassifierBlock>? XmlClassifier
    {
        get => GetArgument<TerraformList<AwsGlueClassifierXmlClassifierBlock>>("xml_classifier");
        set => SetArgument("xml_classifier", value);
    }

}
