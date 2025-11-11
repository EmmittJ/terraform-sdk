using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetGrpcProxyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_target_grpc_proxy resource.
/// </summary>
public class GoogleComputeTargetGrpcProxy : TerraformResource
{
    public GoogleComputeTargetGrpcProxy(string name) : base("google_compute_target_grpc_proxy", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// URL to the UrlMap resource that defines the mapping from URL to
    /// the BackendService. The protocol field in the BackendService
    /// must be set to GRPC.
    /// </summary>
    [TerraformPropertyName("url_map")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UrlMap { get; set; }

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
    [TerraformPropertyName("validate_for_proxyless")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ValidateForProxyless { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeTargetGrpcProxyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in
    /// this object. This field is used in optimistic locking. This field
    /// will be ignored when inserting a TargetGrpcProxy. An up-to-date
    /// fingerprint must be provided in order to patch/update the
    /// TargetGrpcProxy; otherwise, the request will fail with error
    /// 412 conditionNotMet. To see the latest fingerprint, make a get()
    /// request to retrieve the TargetGrpcProxy. A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fingerprint => new TerraformReference(this, "fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Server-defined URL with id for the resource.
    /// </summary>
    [TerraformPropertyName("self_link_with_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLinkWithId => new TerraformReference(this, "self_link_with_id");

}
