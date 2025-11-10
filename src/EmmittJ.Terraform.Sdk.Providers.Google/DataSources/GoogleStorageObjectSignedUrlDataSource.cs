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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformProperty<string>? ContentMd5
    {
        get => GetProperty<TerraformProperty<string>>("content_md5");
        set => this.WithProperty("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformProperty<string>? Credentials
    {
        get => GetProperty<TerraformProperty<string>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtensionHeaders
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("extension_headers");
        set => this.WithProperty("extension_headers", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformProperty<string>? HttpMethod
    {
        get => GetProperty<TerraformProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
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
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    public TerraformExpression SignedUrl => this["signed_url"];

}
