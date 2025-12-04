using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeBackendServiceSignedUrlKey.
/// Nesting mode: single
/// </summary>
public class GoogleComputeBackendServiceSignedUrlKeyTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_compute_backend_service_signed_url_key Terraform resource.
/// Manages a google_compute_backend_service_signed_url_key resource.
/// </summary>
public partial class GoogleComputeBackendServiceSignedUrlKey(string name) : TerraformResource("google_compute_backend_service_signed_url_key", name)
{
    /// <summary>
    /// The backend service this signed URL key belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// 128-bit key value used for signing the URL. The key value must be a
    /// valid RFC 4648 Section 5 base64url encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValue is required")]
    public required TerraformValue<string> KeyValue
    {
        get => GetArgument<TerraformValue<string>>("key_value");
        set => SetArgument("key_value", value);
    }

    /// <summary>
    /// Name of the signed URL key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeBackendServiceSignedUrlKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeBackendServiceSignedUrlKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
