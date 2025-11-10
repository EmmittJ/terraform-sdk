using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_boost_isolation_read_only in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock : TerraformBlock
{
    /// <summary>
    /// The Compute Billing Owner for this Data Boost App Profile. Possible values: [&amp;quot;HOST_PAYS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeBillingOwner is required")]
    public required TerraformProperty<string> ComputeBillingOwner
    {
        set => SetProperty("compute_billing_owner", value);
    }

}

/// <summary>
/// Block type for single_cluster_routing in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileSingleClusterRoutingBlock : TerraformBlock
{
    /// <summary>
    /// If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile.
    /// It is unsafe to send these requests to the same table/row/column in multiple clusters.
    /// </summary>
    public TerraformProperty<bool>? AllowTransactionalWrites
    {
        set => SetProperty("allow_transactional_writes", value);
    }

    /// <summary>
    /// The cluster to which read/write requests should be routed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        set => SetProperty("cluster_id", value);
    }

}

/// <summary>
/// Block type for standard_isolation in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileStandardIsolationBlock : TerraformBlock
{
    /// <summary>
    /// The priority of requests sent using this app profile. Possible values: [&amp;quot;PRIORITY_LOW&amp;quot;, &amp;quot;PRIORITY_MEDIUM&amp;quot;, &amp;quot;PRIORITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<string> Priority
    {
        set => SetProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableAppProfileTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigtable_app_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableAppProfile : TerraformResource
{
    public GoogleBigtableAppProfile(string name) : base("google_bigtable_app_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("app_profile_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("ignore_warnings");
        SetOutput("instance");
        SetOutput("multi_cluster_routing_cluster_ids");
        SetOutput("multi_cluster_routing_use_any");
        SetOutput("project");
        SetOutput("row_affinity");
    }

    /// <summary>
    /// The unique name of the app profile in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppProfileId is required")]
    public required TerraformProperty<string> AppProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_profile_id");
        set => SetProperty("app_profile_id", value);
    }

    /// <summary>
    /// Long form description of the use case for this app profile.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// If true, ignore safety checks when deleting/updating the app profile.
    /// </summary>
    public TerraformProperty<bool> IgnoreWarnings
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_warnings");
        set => SetProperty("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the instance to create the app profile within.
    /// </summary>
    public TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.
    /// </summary>
    public List<TerraformProperty<string>> MultiClusterRoutingClusterIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("multi_cluster_routing_cluster_ids");
        set => SetProperty("multi_cluster_routing_cluster_ids", value);
    }

    /// <summary>
    /// If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available
    /// in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes
    /// consistency to improve availability.
    /// </summary>
    public TerraformProperty<bool> MultiClusterRoutingUseAny
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_cluster_routing_use_any");
        set => SetProperty("multi_cluster_routing_use_any", value);
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
    /// Must be used with multi-cluster routing. If true, then this app profile will use row affinity sticky routing. With row affinity, Bigtable will route single row key requests based on the row key, rather than randomly. Instead, each row key will be assigned to a cluster by Cloud Bigtable, and will stick to that cluster. Choosing this option improves read-your-writes consistency for most requests under most circumstances, without sacrificing availability. Consistency is not guaranteed, as requests may still fail over between clusters in the event of errors or latency.
    /// </summary>
    public TerraformProperty<bool> RowAffinity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("row_affinity");
        set => SetProperty("row_affinity", value);
    }

    /// <summary>
    /// Block for data_boost_isolation_read_only.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataBoostIsolationReadOnly block(s) allowed")]
    public List<GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock>? DataBoostIsolationReadOnly
    {
        set => SetProperty("data_boost_isolation_read_only", value);
    }

    /// <summary>
    /// Block for single_cluster_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleClusterRouting block(s) allowed")]
    public List<GoogleBigtableAppProfileSingleClusterRoutingBlock>? SingleClusterRouting
    {
        set => SetProperty("single_cluster_routing", value);
    }

    /// <summary>
    /// Block for standard_isolation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardIsolation block(s) allowed")]
    public List<GoogleBigtableAppProfileStandardIsolationBlock>? StandardIsolation
    {
        set => SetProperty("standard_isolation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableAppProfileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique name of the requested app profile. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/appProfiles/&amp;lt;appProfileId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
