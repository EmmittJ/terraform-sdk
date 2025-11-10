using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_workload_identity_pool.
/// </summary>
public class GoogleIamWorkloadIdentityPoolDataSource : TerraformDataSource
{
    public GoogleIamWorkloadIdentityPoolDataSource(string name) : base("google_iam_workload_identity_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("description");
        this.WithOutput("disabled");
        this.WithOutput("display_name");
        this.WithOutput("name");
        this.WithOutput("state");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ID to use for the pool, which becomes the final component of the resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolId is required")]
    public required TerraformProperty<string> WorkloadIdentityPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workload_identity_pool_id");
        set => this.WithProperty("workload_identity_pool_id", value);
    }

    /// <summary>
    /// A description of the pool. Cannot exceed 256 characters.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    public TerraformExpression Disabled => this["disabled"];

    /// <summary>
    /// A display name for the pool. Cannot exceed 32 characters.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

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
