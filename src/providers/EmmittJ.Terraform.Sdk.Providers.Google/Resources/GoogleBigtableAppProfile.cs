using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_boost_isolation_read_only in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock : TerraformBlockBase
{
    /// <summary>
    /// The Compute Billing Owner for this Data Boost App Profile. Possible values: [&amp;quot;HOST_PAYS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeBillingOwner is required")]
    [TerraformProperty("compute_billing_owner")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComputeBillingOwner { get; set; }

}

/// <summary>
/// Block type for single_cluster_routing in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableAppProfileSingleClusterRoutingBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile.
    /// It is unsafe to send these requests to the same table/row/column in multiple clusters.
    /// </summary>
    [TerraformProperty("allow_transactional_writes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowTransactionalWrites { get; set; }

    /// <summary>
    /// The cluster to which read/write requests should be routed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

}

/// <summary>
/// Block type for standard_isolation in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableAppProfileStandardIsolationBlock : TerraformBlockBase
{
    /// <summary>
    /// The priority of requests sent using this app profile. Possible values: [&amp;quot;PRIORITY_LOW&amp;quot;, &amp;quot;PRIORITY_MEDIUM&amp;quot;, &amp;quot;PRIORITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigtableAppProfileTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_app_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigtableAppProfile : TerraformResource
{
    public GoogleBigtableAppProfile(string name) : base("google_bigtable_app_profile", name)
    {
    }

    /// <summary>
    /// The unique name of the app profile in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppProfileId is required")]
    [TerraformProperty("app_profile_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppProfileId { get; set; }

    /// <summary>
    /// Long form description of the use case for this app profile.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If true, ignore safety checks when deleting/updating the app profile.
    /// </summary>
    [TerraformProperty("ignore_warnings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreWarnings { get; set; }

    /// <summary>
    /// The name of the instance to create the app profile within.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.
    /// </summary>
    [TerraformProperty("multi_cluster_routing_cluster_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>
    /// If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available
    /// in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes
    /// consistency to improve availability.
    /// </summary>
    [TerraformProperty("multi_cluster_routing_use_any")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MultiClusterRoutingUseAny { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Must be used with multi-cluster routing. If true, then this app profile will use row affinity sticky routing. With row affinity, Bigtable will route single row key requests based on the row key, rather than randomly. Instead, each row key will be assigned to a cluster by Cloud Bigtable, and will stick to that cluster. Choosing this option improves read-your-writes consistency for most requests under most circumstances, without sacrificing availability. Consistency is not guaranteed, as requests may still fail over between clusters in the event of errors or latency.
    /// </summary>
    [TerraformProperty("row_affinity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RowAffinity { get; set; }

    /// <summary>
    /// Block for data_boost_isolation_read_only.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataBoostIsolationReadOnly block(s) allowed")]
    [TerraformProperty("data_boost_isolation_read_only")]
    public TerraformList<TerraformBlock<GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock>>? DataBoostIsolationReadOnly { get; set; }

    /// <summary>
    /// Block for single_cluster_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleClusterRouting block(s) allowed")]
    [TerraformProperty("single_cluster_routing")]
    public TerraformList<TerraformBlock<GoogleBigtableAppProfileSingleClusterRoutingBlock>>? SingleClusterRouting { get; set; }

    /// <summary>
    /// Block for standard_isolation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardIsolation block(s) allowed")]
    [TerraformProperty("standard_isolation")]
    public TerraformList<TerraformBlock<GoogleBigtableAppProfileStandardIsolationBlock>>? StandardIsolation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBigtableAppProfileTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique name of the requested app profile. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/appProfiles/&amp;lt;appProfileId&amp;gt;&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
