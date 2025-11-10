using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkloadIdentityPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("name");
        SetOutput("state");
        SetOutput("description");
        SetOutput("disabled");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("project");
        SetOutput("workload_identity_pool_id");
    }

    /// <summary>
    /// A description of the pool. Cannot exceed 256 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// A display name for the pool. Cannot exceed 32 characters.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The ID to use for the pool, which becomes the final component of the resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolId is required")]
    public required TerraformProperty<string> WorkloadIdentityPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload_identity_pool_id");
        set => SetProperty("workload_identity_pool_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamWorkloadIdentityPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
