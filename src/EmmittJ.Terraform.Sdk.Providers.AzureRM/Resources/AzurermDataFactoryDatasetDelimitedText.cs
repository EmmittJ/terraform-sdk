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
    public TerraformLiteralProperty<Dictionary<string, string>>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The column_delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ColumnDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("column_delimiter");
        set => this.WithProperty("column_delimiter", value);
    }

    /// <summary>
    /// The compression_codec attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CompressionCodec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_codec");
        set => this.WithProperty("compression_codec", value);
    }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CompressionLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_level");
        set => this.WithProperty("compression_level", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Encoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
    }

    /// <summary>
    /// The escape_character attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EscapeCharacter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("escape_character");
        set => this.WithProperty("escape_character", value);
    }

    /// <summary>
    /// The first_row_as_header attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FirstRowAsHeader
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("first_row_as_header");
        set => this.WithProperty("first_row_as_header", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder");
        set => this.WithProperty("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LinkedServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_service_name");
        set => this.WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The null_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NullValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("null_value");
        set => this.WithProperty("null_value", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The quote_character attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QuoteCharacter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quote_character");
        set => this.WithProperty("quote_character", value);
    }

    /// <summary>
    /// The row_delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RowDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("row_delimiter");
        set => this.WithProperty("row_delimiter", value);
    }

}
