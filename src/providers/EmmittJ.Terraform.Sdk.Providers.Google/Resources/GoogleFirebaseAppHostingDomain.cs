using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for serve in GoogleFirebaseAppHostingDomain.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingDomainServeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serve";

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingDomainServeBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingDomainServeBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for redirect in GoogleFirebaseAppHostingDomainServeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingDomainServeBlockRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect";

    /// <summary>
    /// The status code to use in a redirect response. Must be a valid HTTP 3XX
    /// status code. Defaults to 302 if not present.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The URI of the redirect&#39;s intended destination. This URI will be
    /// prepended to the original request path. URI without a scheme are
    /// assumed to be HTTPS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFirebaseAppHostingDomain.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingDomainTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_hosting_domain Terraform resource.
/// Manages a google_firebase_app_hosting_domain resource.
/// </summary>
public partial class GoogleFirebaseAppHostingDomain(string name) : TerraformResource("google_firebase_app_hosting_domain", name)
{
    /// <summary>
    /// The ID of the Backend that this Domain is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformValue<string> Backend
    {
        get => new TerraformReference<string>(this, "backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// Id of the domain to create.
    /// Must be a valid domain name, such as &amp;quot;foo.com&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformValue<string> DomainId
    {
        get => new TerraformReference<string>(this, "domain_id");
        set => SetArgument("domain_id", value);
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
    /// The location of the Backend that this Domain is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// Time at which the domain was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The status of a custom domain&#39;s linkage to the Backend.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomDomainStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_domain_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time at which the domain was deleted.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Identifier. The resource name of the domain, e.g.
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/domains/{domainId}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Time at which a soft-deleted domain will be purged, rendering in
    /// permanently deleted.
    /// </summary>
    public TerraformValue<string> PurgeTime
    {
        get => new TerraformReference<string>(this, "purge_time");
    }

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time at which the domain was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Serve block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serve block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingDomainServeBlock>? Serve
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingDomainServeBlock>>("serve");
        set => SetArgument("serve", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppHostingDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppHostingDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
