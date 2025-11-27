using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_restrictions in GoogleIamWorkforcePool.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolAccessRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_restrictions";

    /// <summary>
    /// Disable programmatic sign-in by disabling token issue via the Security Token API endpoint.
    /// See [Security Token Service API](https://cloud.google.com/iam/docs/reference/sts/rest).
    /// </summary>
    public TerraformValue<bool>? DisableProgrammaticSignin
    {
        get => new TerraformReference<bool>(this, "disable_programmatic_signin");
        set => SetArgument("disable_programmatic_signin", value);
    }

    /// <summary>
    /// AllowedServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIamWorkforcePoolAccessRestrictionsBlockAllowedServicesBlock>? AllowedServices
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolAccessRestrictionsBlockAllowedServicesBlock>>("allowed_services");
        set => SetArgument("allowed_services", value);
    }

}

/// <summary>
/// Block type for allowed_services in GoogleIamWorkforcePoolAccessRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolAccessRestrictionsBlockAllowedServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_services";

    /// <summary>
    /// Domain name of the service.
    /// Example: console.cloud.google
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIamWorkforcePool.
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolTimeoutsBlock : TerraformBlock
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
/// Represents a google_iam_workforce_pool Terraform resource.
/// Manages a google_iam_workforce_pool resource.
/// </summary>
public partial class GoogleIamWorkforcePool(string name) : TerraformResource("google_iam_workforce_pool", name)
{
    /// <summary>
    /// A user-specified description of the pool. Cannot exceed 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens,
    /// or use existing tokens to access resources. If the pool is re-enabled, existing tokens grant access again.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// A user-specified display name of the pool in Google Cloud Console. Cannot exceed 32 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Immutable. The resource name of the parent. Format: &#39;organizations/{org-id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Duration that the Google Cloud access tokens, console sign-in sessions,
    /// and &#39;gcloud&#39; sign-in sessions from this pool are valid.
    /// Must be greater than 15 minutes (900s) and less than 12 hours (43200s).
    /// If &#39;sessionDuration&#39; is not configured, minted credentials have a default duration of one hour (3600s).
    /// A duration in seconds with up to nine fractional digits, ending with &#39;&#39;s&#39;&#39;. Example: &amp;quot;&#39;3.5s&#39;&amp;quot;.
    /// </summary>
    public TerraformValue<string>? SessionDuration
    {
        get => new TerraformReference<string>(this, "session_duration");
        set => SetArgument("session_duration", value);
    }

    /// <summary>
    /// The name of the pool. The ID must be a globally unique string of 6 to 63 lowercase letters,
    /// digits, or hyphens. It must start with a letter, and cannot have a trailing hyphen.
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformValue<string> WorkforcePoolId
    {
        get => new TerraformReference<string>(this, "workforce_pool_id");
        set => SetArgument("workforce_pool_id", value);
    }

    /// <summary>
    /// Output only. The resource name of the pool.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The state of the pool.
    ///  * STATE_UNSPECIFIED: State unspecified.
    ///  * ACTIVE: The pool is active, and may be used in Google Cloud policies.
    ///  * DELETED: The pool is soft-deleted. Soft-deleted pools are permanently deleted
    ///    after approximately 30 days. You can restore a soft-deleted pool using
    ///    [workforcePools.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/locations.workforcePools/undelete#google.iam.admin.v1.WorkforcePools.UndeleteWorkforcePool).
    ///    You cannot reuse the ID of a soft-deleted pool until it is permanently deleted.
    ///    While a pool is deleted, you cannot use it to exchange tokens, or use
    ///    existing tokens to access resources. If the pool is undeleted, existing
    ///    tokens grant access again.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// AccessRestrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessRestrictions block(s) allowed")]
    public TerraformList<GoogleIamWorkforcePoolAccessRestrictionsBlock>? AccessRestrictions
    {
        get => GetArgument<TerraformList<GoogleIamWorkforcePoolAccessRestrictionsBlock>>("access_restrictions");
        set => SetArgument("access_restrictions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamWorkforcePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamWorkforcePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
