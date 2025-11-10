using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_restrictions in .
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolAccessRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Disable programmatic sign-in by disabling token issue via the Security Token API endpoint.
    /// See [Security Token Service API](https://cloud.google.com/iam/docs/reference/sts/rest).
    /// </summary>
    public TerraformProperty<bool>? DisableProgrammaticSignin
    {
        get => GetProperty<TerraformProperty<bool>>("disable_programmatic_signin");
        set => WithProperty("disable_programmatic_signin", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_iam_workforce_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIamWorkforcePool : TerraformResource
{
    public GoogleIamWorkforcePool(string name) : base("google_iam_workforce_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// A user-specified description of the pool. Cannot exceed 256 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens,
    /// or use existing tokens to access resources. If the pool is re-enabled, existing tokens grant access again.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// A user-specified display name of the pool in Google Cloud Console. Cannot exceed 32 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Immutable. The resource name of the parent. Format: &#39;organizations/{org-id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Duration that the Google Cloud access tokens, console sign-in sessions,
    /// and &#39;gcloud&#39; sign-in sessions from this pool are valid.
    /// Must be greater than 15 minutes (900s) and less than 12 hours (43200s).
    /// If &#39;sessionDuration&#39; is not configured, minted credentials have a default duration of one hour (3600s).
    /// A duration in seconds with up to nine fractional digits, ending with &#39;&#39;s&#39;&#39;. Example: &amp;quot;&#39;3.5s&#39;&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? SessionDuration
    {
        get => GetProperty<TerraformProperty<string>>("session_duration");
        set => this.WithProperty("session_duration", value);
    }

    /// <summary>
    /// The name of the pool. The ID must be a globally unique string of 6 to 63 lowercase letters,
    /// digits, or hyphens. It must start with a letter, and cannot have a trailing hyphen.
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformProperty<string> WorkforcePoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workforce_pool_id");
        set => this.WithProperty("workforce_pool_id", value);
    }

    /// <summary>
    /// Block for access_restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessRestrictions block(s) allowed")]
    public List<GoogleIamWorkforcePoolAccessRestrictionsBlock>? AccessRestrictions
    {
        get => GetProperty<List<GoogleIamWorkforcePoolAccessRestrictionsBlock>>("access_restrictions");
        set => this.WithProperty("access_restrictions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamWorkforcePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIamWorkforcePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The resource name of the pool.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

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
    public TerraformExpression State => this["state"];

}
