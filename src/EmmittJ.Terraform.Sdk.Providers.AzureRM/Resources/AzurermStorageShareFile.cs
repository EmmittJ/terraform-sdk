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
    public TerraformLiteralProperty<string>? ContentDisposition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_disposition");
        set => this.WithProperty("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentEncoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_encoding");
        set => this.WithProperty("content_encoding", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentMd5
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_md5");
        set => this.WithProperty("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The storage_share_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageShareId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_share_id");
        set => this.WithProperty("storage_share_id", value);
    }

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    public TerraformExpression ContentLength => this["content_length"];

}
