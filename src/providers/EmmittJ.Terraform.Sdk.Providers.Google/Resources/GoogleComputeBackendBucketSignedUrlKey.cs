using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeBackendBucketSignedUrlKey.
/// Nesting mode: single
/// </summary>
public class GoogleComputeBackendBucketSignedUrlKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_compute_backend_bucket_signed_url_key Terraform resource.
/// Manages a google_compute_backend_bucket_signed_url_key resource.
/// </summary>
public partial class GoogleComputeBackendBucketSignedUrlKey(string name) : TerraformResource("google_compute_backend_bucket_signed_url_key", name)
{
    /// <summary>
    /// The backend bucket this signed URL key belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendBucket is required")]
    public required TerraformValue<string> BackendBucket
    {
        get => new TerraformReference<string>(this, "backend_bucket");
        set => SetArgument("backend_bucket", value);
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
    /// 128-bit key value used for signing the URL. The key value must be a
    /// valid RFC 4648 Section 5 base64url encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValue is required")]
    public required TerraformValue<string> KeyValue
    {
        get => new TerraformReference<string>(this, "key_value");
        set => SetArgument("key_value", value);
    }

    /// <summary>
    /// Name of the signed URL key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeBackendBucketSignedUrlKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeBackendBucketSignedUrlKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
