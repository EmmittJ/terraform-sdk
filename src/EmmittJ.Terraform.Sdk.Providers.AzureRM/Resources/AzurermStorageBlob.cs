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
    public string? AccessTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_tier")?.Value;
        set => this.WithProperty("access_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public string? CacheControl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_control")?.Value;
        set => this.WithProperty("cache_control", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The encryption_scope attribute.
    /// </summary>
    public string? EncryptionScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_scope")?.Value;
        set => this.WithProperty("encryption_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parallelism attribute.
    /// </summary>
    public double? Parallelism
    {
        get => GetProperty<TerraformLiteralProperty<double>>("parallelism")?.Value;
        set => this.WithProperty("parallelism", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public double? Size
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size")?.Value;
        set => this.WithProperty("size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The source_content attribute.
    /// </summary>
    public string? SourceContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_content")?.Value;
        set => this.WithProperty("source_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public string? SourceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_uri")?.Value;
        set => this.WithProperty("source_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public string? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name")?.Value;
        set => this.WithProperty("storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public string? StorageContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_name")?.Value;
        set => this.WithProperty("storage_container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
