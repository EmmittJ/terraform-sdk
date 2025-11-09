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
    public TerraformMapProperty<string>? AdditionalProperties
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The column_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? ColumnDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("column_delimiter");
        set => this.WithProperty("column_delimiter", value);
    }

    /// <summary>
    /// The compression_codec attribute.
    /// </summary>
    public TerraformProperty<string>? CompressionCodec
    {
        get => GetProperty<TerraformProperty<string>>("compression_codec");
        set => this.WithProperty("compression_codec", value);
    }

    /// <summary>
    /// The compression_level attribute.
    /// </summary>
    public TerraformProperty<string>? CompressionLevel
    {
        get => GetProperty<TerraformProperty<string>>("compression_level");
        set => this.WithProperty("compression_level", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
    }

    /// <summary>
    /// The escape_character attribute.
    /// </summary>
    public TerraformProperty<string>? EscapeCharacter
    {
        get => GetProperty<TerraformProperty<string>>("escape_character");
        set => this.WithProperty("escape_character", value);
    }

    /// <summary>
    /// The first_row_as_header attribute.
    /// </summary>
    public TerraformProperty<bool>? FirstRowAsHeader
    {
        get => GetProperty<TerraformProperty<bool>>("first_row_as_header");
        set => this.WithProperty("first_row_as_header", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// The linked_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => this.WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The null_value attribute.
    /// </summary>
    public TerraformProperty<string>? NullValue
    {
        get => GetProperty<TerraformProperty<string>>("null_value");
        set => this.WithProperty("null_value", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The quote_character attribute.
    /// </summary>
    public TerraformProperty<string>? QuoteCharacter
    {
        get => GetProperty<TerraformProperty<string>>("quote_character");
        set => this.WithProperty("quote_character", value);
    }

    /// <summary>
    /// The row_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? RowDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("row_delimiter");
        set => this.WithProperty("row_delimiter", value);
    }

}
