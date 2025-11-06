using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_backend_bucket_signed_url_key resource.
/// </summary>
public class GoogleComputeBackendBucketSignedUrlKey : TerraformResource
{
    public GoogleComputeBackendBucketSignedUrlKey(string name) : base("google_compute_backend_bucket_signed_url_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backend bucket this signed URL key belongs.
    /// </summary>
    public string? BackendBucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backend_bucket")?.Value;
        set => this.WithProperty("backend_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// 128-bit key value used for signing the URL. The key value must be a
    /// valid RFC 4648 Section 5 base64url encoded string.
    /// </summary>
    public string? KeyValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_value")?.Value;
        set => this.WithProperty("key_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the signed URL key.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
