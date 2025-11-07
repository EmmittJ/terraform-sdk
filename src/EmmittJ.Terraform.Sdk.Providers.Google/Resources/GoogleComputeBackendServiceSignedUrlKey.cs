using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_backend_service_signed_url_key resource.
/// </summary>
public class GoogleComputeBackendServiceSignedUrlKey : TerraformResource
{
    public GoogleComputeBackendServiceSignedUrlKey(string name) : base("google_compute_backend_service_signed_url_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backend service this signed URL key belongs.
    /// </summary>
    public TerraformProperty<string>? BackendService
    {
        get => GetProperty<TerraformProperty<string>>("backend_service");
        set => this.WithProperty("backend_service", value);
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
    /// 128-bit key value used for signing the URL. The key value must be a
    /// valid RFC 4648 Section 5 base64url encoded string.
    /// </summary>
    public TerraformProperty<string>? KeyValue
    {
        get => GetProperty<TerraformProperty<string>>("key_value");
        set => this.WithProperty("key_value", value);
    }

    /// <summary>
    /// Name of the signed URL key.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

}
