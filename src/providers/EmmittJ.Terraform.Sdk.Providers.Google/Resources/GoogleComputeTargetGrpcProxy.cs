using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeTargetGrpcProxy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetGrpcProxyTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_target_grpc_proxy Terraform resource.
/// Manages a google_compute_target_grpc_proxy resource.
/// </summary>
public partial class GoogleComputeTargetGrpcProxy(string name) : TerraformResource("google_compute_target_grpc_proxy", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource
    /// is created. The name must be 1-63 characters long, and comply
    /// with RFC1035. Specifically, the name must be 1-63 characters long
    /// and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which
    /// means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// URL to the UrlMap resource that defines the mapping from URL to
    /// the BackendService. The protocol field in the BackendService
    /// must be set to GRPC.
    /// </summary>
    public TerraformValue<string>? UrlMap
    {
        get => GetArgument<TerraformValue<string>>("url_map");
        set => SetArgument("url_map", value);
    }

    /// <summary>
    /// If true, indicates that the BackendServices referenced by
    /// the urlMap may be accessed by gRPC applications without using
    /// a sidecar proxy. This will enable configuration checks on urlMap
    /// and its referenced BackendServices to not allow unsupported features.
    /// A gRPC application must use &amp;quot;xds:///&amp;quot; scheme in the target URI
    /// of the service it is connecting to. If false, indicates that the
    /// BackendServices referenced by the urlMap will be accessed by gRPC
    /// applications via a sidecar proxy. In this case, a gRPC application
    /// must not use &amp;quot;xds:///&amp;quot; scheme in the target URI of the service
    /// it is connecting to
    /// </summary>
    public TerraformValue<bool>? ValidateForProxyless
    {
        get => GetArgument<TerraformValue<bool>>("validate_for_proxyless");
        set => SetArgument("validate_for_proxyless", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in
    /// this object. This field is used in optimistic locking. This field
    /// will be ignored when inserting a TargetGrpcProxy. An up-to-date
    /// fingerprint must be provided in order to patch/update the
    /// TargetGrpcProxy; otherwise, the request will fail with error
    /// 412 conditionNotMet. To see the latest fingerprint, make a get()
    /// request to retrieve the TargetGrpcProxy. A base64-encoded string.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Server-defined URL with id for the resource.
    /// </summary>
    public TerraformValue<string> SelfLinkWithId
        => AsReference("self_link_with_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeTargetGrpcProxyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeTargetGrpcProxyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
