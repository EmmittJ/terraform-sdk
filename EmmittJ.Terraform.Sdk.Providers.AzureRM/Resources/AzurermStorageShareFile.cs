using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_share_file resource.
/// </summary>
public class AzurermStorageShareFile : TerraformResource
{
    public AzurermStorageShareFile(string name) : base("azurerm_storage_share_file", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("content_length");
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public string? ContentDisposition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_disposition")?.Value;
        set => this.WithProperty("content_disposition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public string? ContentEncoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_encoding")?.Value;
        set => this.WithProperty("content_encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public string? ContentMd5
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_md5")?.Value;
        set => this.WithProperty("content_md5", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public string? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type")?.Value;
        set => this.WithProperty("content_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_share_id attribute.
    /// </summary>
    public string? StorageShareId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_share_id")?.Value;
        set => this.WithProperty("storage_share_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    public TerraformExpression ContentLength => this["content_length"];

}
