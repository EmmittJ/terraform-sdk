using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_blob resource.
/// </summary>
public class AzurermStorageBlob : TerraformResource
{
    public AzurermStorageBlob(string name) : base("azurerm_storage_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccessTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_tier");
        set => this.WithProperty("access_tier", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CacheControl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_control");
        set => this.WithProperty("cache_control", value);
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
    /// The encryption_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_scope");
        set => this.WithProperty("encryption_scope", value);
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
    /// The parallelism attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Parallelism
    {
        get => GetProperty<TerraformLiteralProperty<double>>("parallelism");
        set => this.WithProperty("parallelism", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Size
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size");
        set => this.WithProperty("size", value);
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
    /// The source_content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_content");
        set => this.WithProperty("source_content", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_uri");
        set => this.WithProperty("source_uri", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_name");
        set => this.WithProperty("storage_container_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
