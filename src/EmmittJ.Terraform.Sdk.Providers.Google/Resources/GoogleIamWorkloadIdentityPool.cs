using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_workload_identity_pool resource.
/// </summary>
public class GoogleIamWorkloadIdentityPool : TerraformResource
{
    public GoogleIamWorkloadIdentityPool(string name) : base("google_iam_workload_identity_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// A description of the pool. Cannot exceed 256 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A display name for the pool. Cannot exceed 32 characters.
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the pool, which becomes the final component of the resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    public string? WorkloadIdentityPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_identity_pool_id")?.Value;
        set => this.WithProperty("workload_identity_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the pool as
    /// &#39;projects/{project_number}/locations/global/workloadIdentityPools/{workload_identity_pool_id}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the pool.
    /// * &#39;STATE_UNSPECIFIED&#39;: State unspecified.
    /// * &#39;ACTIVE&#39;: The pool is active, and may be used in Google Cloud policies.
    /// * &#39;DELETED&#39;: The pool is soft-deleted. Soft-deleted pools are permanently deleted after
    ///   approximately 30 days. You can restore a soft-deleted pool using
    ///   &#39;UndeleteWorkloadIdentityPool&#39;. You cannot reuse the ID of a soft-deleted pool until it is
    ///   permanently deleted. While a pool is deleted, you cannot use it to exchange tokens, or
    ///   use existing tokens to access resources. If the pool is undeleted, existing tokens grant
    ///   access again.
    /// </summary>
    public TerraformExpression State => this["state"];

}
