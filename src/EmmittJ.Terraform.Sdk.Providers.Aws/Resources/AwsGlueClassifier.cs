using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for csv_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierCsvClassifierBlock : TerraformBlock
{
    /// <summary>
    /// The allow_single_column attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowSingleColumn
    {
        get => GetProperty<TerraformProperty<bool>>("allow_single_column");
        set => WithProperty("allow_single_column", value);
    }

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    public TerraformProperty<string>? ContainsHeader
    {
        get => GetProperty<TerraformProperty<string>>("contains_header");
        set => WithProperty("contains_header", value);
    }

    /// <summary>
    /// The custom_datatype_configured attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomDatatypeConfigured
    {
        get => GetProperty<TerraformProperty<bool>>("custom_datatype_configured");
        set => WithProperty("custom_datatype_configured", value);
    }

    /// <summary>
    /// The custom_datatypes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomDatatypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_datatypes");
        set => WithProperty("custom_datatypes", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? Delimiter
    {
        get => GetProperty<TerraformProperty<string>>("delimiter");
        set => WithProperty("delimiter", value);
    }

    /// <summary>
    /// The disable_value_trimming attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableValueTrimming
    {
        get => GetProperty<TerraformProperty<bool>>("disable_value_trimming");
        set => WithProperty("disable_value_trimming", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Header
    {
        get => GetProperty<List<TerraformProperty<string>>>("header");
        set => WithProperty("header", value);
    }

    /// <summary>
    /// The quote_symbol attribute.
    /// </summary>
    public TerraformProperty<string>? QuoteSymbol
    {
        get => GetProperty<TerraformProperty<string>>("quote_symbol");
        set => WithProperty("quote_symbol", value);
    }

    /// <summary>
    /// The serde attribute.
    /// </summary>
    public TerraformProperty<string>? Serde
    {
        get => GetProperty<TerraformProperty<string>>("serde");
        set => WithProperty("serde", value);
    }

}

/// <summary>
/// Block type for grok_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierGrokClassifierBlock : TerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformProperty<string> Classification
    {
        get => GetProperty<TerraformProperty<string>>("classification");
        set => WithProperty("classification", value);
    }

    /// <summary>
    /// The custom_patterns attribute.
    /// </summary>
    public TerraformProperty<string>? CustomPatterns
    {
        get => GetProperty<TerraformProperty<string>>("custom_patterns");
        set => WithProperty("custom_patterns", value);
    }

    /// <summary>
    /// The grok_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrokPattern is required")]
    public required TerraformProperty<string> GrokPattern
    {
        get => GetProperty<TerraformProperty<string>>("grok_pattern");
        set => WithProperty("grok_pattern", value);
    }

}

/// <summary>
/// Block type for json_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierJsonClassifierBlock : TerraformBlock
{
    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    public required TerraformProperty<string> JsonPath
    {
        get => GetProperty<TerraformProperty<string>>("json_path");
        set => WithProperty("json_path", value);
    }

}

/// <summary>
/// Block type for xml_classifier in .
/// Nesting mode: list
/// </summary>
public class AwsGlueClassifierXmlClassifierBlock : TerraformBlock
{
    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformProperty<string> Classification
    {
        get => GetProperty<TerraformProperty<string>>("classification");
        set => WithProperty("classification", value);
    }

    /// <summary>
    /// The row_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowTag is required")]
    public required TerraformProperty<string> RowTag
    {
        get => GetProperty<TerraformProperty<string>>("row_tag");
        set => WithProperty("row_tag", value);
    }

}

/// <summary>
/// Manages a aws_glue_classifier resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueClassifier : TerraformResource
{
    public AwsGlueClassifier(string name) : base("aws_glue_classifier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for csv_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvClassifier block(s) allowed")]
    public List<AwsGlueClassifierCsvClassifierBlock>? CsvClassifier
    {
        get => GetProperty<List<AwsGlueClassifierCsvClassifierBlock>>("csv_classifier");
        set => this.WithProperty("csv_classifier", value);
    }

    /// <summary>
    /// Block for grok_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrokClassifier block(s) allowed")]
    public List<AwsGlueClassifierGrokClassifierBlock>? GrokClassifier
    {
        get => GetProperty<List<AwsGlueClassifierGrokClassifierBlock>>("grok_classifier");
        set => this.WithProperty("grok_classifier", value);
    }

    /// <summary>
    /// Block for json_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonClassifier block(s) allowed")]
    public List<AwsGlueClassifierJsonClassifierBlock>? JsonClassifier
    {
        get => GetProperty<List<AwsGlueClassifierJsonClassifierBlock>>("json_classifier");
        set => this.WithProperty("json_classifier", value);
    }

    /// <summary>
    /// Block for xml_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XmlClassifier block(s) allowed")]
    public List<AwsGlueClassifierXmlClassifierBlock>? XmlClassifier
    {
        get => GetProperty<List<AwsGlueClassifierXmlClassifierBlock>>("xml_classifier");
        set => this.WithProperty("xml_classifier", value);
    }

}
