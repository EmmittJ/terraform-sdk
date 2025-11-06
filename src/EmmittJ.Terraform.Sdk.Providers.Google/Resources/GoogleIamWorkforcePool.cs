using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_workforce_pool resource.
/// </summary>
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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens,
    /// or use existing tokens to access resources. If the pool is re-enabled, existing tokens grant access again.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A user-specified display name of the pool in Google Cloud Console. Cannot exceed 32 characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location for the resource.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Immutable. The resource name of the parent. Format: &#39;organizations/{org-id}&#39;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Duration that the Google Cloud access tokens, console sign-in sessions,
    /// and &#39;gcloud&#39; sign-in sessions from this pool are valid.
    /// Must be greater than 15 minutes (900s) and less than 12 hours (43200s).
    /// If &#39;sessionDuration&#39; is not configured, minted credentials have a default duration of one hour (3600s).
    /// A duration in seconds with up to nine fractional digits, ending with &#39;&#39;s&#39;&#39;. Example: &amp;quot;&#39;3.5s&#39;&amp;quot;.
    /// </summary>
    public string? SessionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_duration")?.Value;
        set => this.WithProperty("session_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the pool. The ID must be a globally unique string of 6 to 63 lowercase letters,
    /// digits, or hyphens. It must start with a letter, and cannot have a trailing hyphen.
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    public string? WorkforcePoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workforce_pool_id")?.Value;
        set => this.WithProperty("workforce_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
