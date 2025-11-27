using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_object_signed_url Terraform data source.
/// Retrieves information about a google_storage_object_signed_url.
/// </summary>
public partial class GoogleStorageObjectSignedUrlDataSource(string name) : TerraformDataSource("google_storage_object_signed_url", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformValue<string>? ContentMd5
    {
        get => new TerraformReference<string>(this, "content_md5");
        set => SetArgument("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformValue<string>? Credentials
    {
        get => new TerraformReference<string>(this, "credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The extension_headers attribute.
    /// </summary>
    public TerraformMap<string>? ExtensionHeaders
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "extension_headers").ResolveNodes(ctx));
        set => SetArgument("extension_headers", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The signed_url attribute.
    /// </summary>
    public TerraformValue<string> SignedUrl
    {
        get => new TerraformReference<string>(this, "signed_url");
    }

}
