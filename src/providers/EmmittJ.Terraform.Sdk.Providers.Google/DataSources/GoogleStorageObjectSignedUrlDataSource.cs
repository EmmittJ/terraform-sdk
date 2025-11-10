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
        SetOutput("signed_url");
        SetOutput("bucket");
        SetOutput("content_md5");
        SetOutput("content_type");
        SetOutput("credentials");
        SetOutput("duration");
        SetOutput("extension_headers");
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("path");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformProperty<string> ContentMd5
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_md5");
        set => SetProperty("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string> ContentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_type");
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformProperty<string> Credentials
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credentials");
        set => SetProperty("credentials", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string> Duration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ExtensionHeaders
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("extension_headers");
        set => SetProperty("extension_headers", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformProperty<string> HttpMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_method");
        set => SetProperty("http_method", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    public TerraformExpression SignedUrl => this["signed_url"];

}
