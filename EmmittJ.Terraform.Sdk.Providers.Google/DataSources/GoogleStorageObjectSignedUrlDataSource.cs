using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_object_signed_url.
/// </summary>
public class GoogleStorageObjectSignedUrlDataSource : TerraformDataSource
{
    public GoogleStorageObjectSignedUrlDataSource(string name) : base("google_storage_object_signed_url", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("signed_url");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The credentials attribute.
    /// </summary>
    public string? Credentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials")?.Value;
        set => this.WithProperty("credentials", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public string? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration")?.Value;
        set => this.WithProperty("duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    public Dictionary<string, string>? ExtensionHeaders
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("extension_headers")?.Value;
        set => this.WithProperty("extension_headers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public string? HttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_method")?.Value;
        set => this.WithProperty("http_method", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    public TerraformExpression SignedUrl => this["signed_url"];

}
