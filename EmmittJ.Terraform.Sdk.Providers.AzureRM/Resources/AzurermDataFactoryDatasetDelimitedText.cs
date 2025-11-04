using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_dataset_delimited_text resource.
/// </summary>
public class AzurermDataFactoryDatasetDelimitedText : TerraformResource
{
    public AzurermDataFactoryDatasetDelimitedText(string name) : base("azurerm_data_factory_dataset_delimited_text", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties")?.Value;
        set => this.WithProperty("additional_properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The column_delimiter attribute.
    /// </summary>
    public string? ColumnDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("column_delimiter")?.Value;
        set => this.WithProperty("column_delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compression_codec attribute.
    /// </summary>
    public string? CompressionCodec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_codec")?.Value;
        set => this.WithProperty("compression_codec", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    public string? CompressionLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_level")?.Value;
        set => this.WithProperty("compression_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public string? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id")?.Value;
        set => this.WithProperty("data_factory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public string? Encoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding")?.Value;
        set => this.WithProperty("encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The escape_character attribute.
    /// </summary>
    public string? EscapeCharacter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("escape_character")?.Value;
        set => this.WithProperty("escape_character", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The first_row_as_header attribute.
    /// </summary>
    public bool? FirstRowAsHeader
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("first_row_as_header")?.Value;
        set => this.WithProperty("first_row_as_header", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public string? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder")?.Value;
        set => this.WithProperty("folder", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    public string? LinkedServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_service_name")?.Value;
        set => this.WithProperty("linked_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The null_value attribute.
    /// </summary>
    public string? NullValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("null_value")?.Value;
        set => this.WithProperty("null_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The quote_character attribute.
    /// </summary>
    public string? QuoteCharacter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quote_character")?.Value;
        set => this.WithProperty("quote_character", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The row_delimiter attribute.
    /// </summary>
    public string? RowDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("row_delimiter")?.Value;
        set => this.WithProperty("row_delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
