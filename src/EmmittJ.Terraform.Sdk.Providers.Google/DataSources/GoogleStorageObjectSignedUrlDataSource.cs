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
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
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
    /// The credentials attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Credentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ExtensionHeaders
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("extension_headers");
        set => this.WithProperty("extension_headers", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    public TerraformExpression SignedUrl => this["signed_url"];

}
