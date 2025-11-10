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
        set => SetProperty("allow_single_column", value);
    }

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    public TerraformProperty<string>? ContainsHeader
    {
        set => SetProperty("contains_header", value);
    }

    /// <summary>
    /// The custom_datatype_configured attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomDatatypeConfigured
    {
        set => SetProperty("custom_datatype_configured", value);
    }

    /// <summary>
    /// The custom_datatypes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomDatatypes
    {
        set => SetProperty("custom_datatypes", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? Delimiter
    {
        set => SetProperty("delimiter", value);
    }

    /// <summary>
    /// The disable_value_trimming attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableValueTrimming
    {
        set => SetProperty("disable_value_trimming", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Header
    {
        set => SetProperty("header", value);
    }

    /// <summary>
    /// The quote_symbol attribute.
    /// </summary>
    public TerraformProperty<string>? QuoteSymbol
    {
        set => SetProperty("quote_symbol", value);
    }

    /// <summary>
    /// The serde attribute.
    /// </summary>
    public TerraformProperty<string>? Serde
    {
        set => SetProperty("serde", value);
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
        set => SetProperty("classification", value);
    }

    /// <summary>
    /// The custom_patterns attribute.
    /// </summary>
    public TerraformProperty<string>? CustomPatterns
    {
        set => SetProperty("custom_patterns", value);
    }

    /// <summary>
    /// The grok_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrokPattern is required")]
    public required TerraformProperty<string> GrokPattern
    {
        set => SetProperty("grok_pattern", value);
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
        set => SetProperty("json_path", value);
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
        set => SetProperty("classification", value);
    }

    /// <summary>
    /// The row_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowTag is required")]
    public required TerraformProperty<string> RowTag
    {
        set => SetProperty("row_tag", value);
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for csv_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvClassifier block(s) allowed")]
    public List<AwsGlueClassifierCsvClassifierBlock>? CsvClassifier
    {
        set => SetProperty("csv_classifier", value);
    }

    /// <summary>
    /// Block for grok_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrokClassifier block(s) allowed")]
    public List<AwsGlueClassifierGrokClassifierBlock>? GrokClassifier
    {
        set => SetProperty("grok_classifier", value);
    }

    /// <summary>
    /// Block for json_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonClassifier block(s) allowed")]
    public List<AwsGlueClassifierJsonClassifierBlock>? JsonClassifier
    {
        set => SetProperty("json_classifier", value);
    }

    /// <summary>
    /// Block for xml_classifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XmlClassifier block(s) allowed")]
    public List<AwsGlueClassifierXmlClassifierBlock>? XmlClassifier
    {
        set => SetProperty("xml_classifier", value);
    }

}
