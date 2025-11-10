using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_boost_isolation_read_only in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock : ITerraformBlock
{
    /// <summary>
    /// The Compute Billing Owner for this Data Boost App Profile. Possible values: [&amp;quot;HOST_PAYS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeBillingOwner is required")]
    [TerraformPropertyName("compute_billing_owner")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComputeBillingOwner { get; set; }

}

/// <summary>
/// Block type for single_cluster_routing in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileSingleClusterRoutingBlock : ITerraformBlock
{
    /// <summary>
    /// If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile.
    /// It is unsafe to send these requests to the same table/row/column in multiple clusters.
    /// </summary>
    [TerraformPropertyName("allow_transactional_writes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowTransactionalWrites { get; set; }

    /// <summary>
    /// The cluster to which read/write requests should be routed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

}

/// <summary>
/// Block type for standard_isolation in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileStandardIsolationBlock : ITerraformBlock
{
    /// <summary>
    /// The priority of requests sent using this app profile. Possible values: [&amp;quot;PRIORITY_LOW&amp;quot;, &amp;quot;PRIORITY_MEDIUM&amp;quot;, &amp;quot;PRIORITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableAppProfileTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_app_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableAppProfile : TerraformResource
{
    public GoogleBigtableAppProfile(string name) : base("google_bigtable_app_profile", name)
    {
    }

    /// <summary>
    /// The unique name of the app profile in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppProfileId is required")]
    [TerraformPropertyName("app_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppProfileId { get; set; }

    /// <summary>
    /// Long form description of the use case for this app profile.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// If true, ignore safety checks when deleting/updating the app profile.
    /// </summary>
    [TerraformPropertyName("ignore_warnings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreWarnings { get; set; }

    /// <summary>
    /// The name of the instance to create the app profile within.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Instance { get; set; }

    /// <summary>
    /// The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.
    /// </summary>
    [TerraformPropertyName("multi_cluster_routing_cluster_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>
    /// If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available
    /// in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes
    /// consistency to improve availability.
    /// </summary>
    [TerraformPropertyName("multi_cluster_routing_use_any")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultiClusterRoutingUseAny { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Must be used with multi-cluster routing. If true, then this app profile will use row affinity sticky routing. With row affinity, Bigtable will route single row key requests based on the row key, rather than randomly. Instead, each row key will be assigned to a cluster by Cloud Bigtable, and will stick to that cluster. Choosing this option improves read-your-writes consistency for most requests under most circumstances, without sacrificing availability. Consistency is not guaranteed, as requests may still fail over between clusters in the event of errors or latency.
    /// </summary>
    [TerraformPropertyName("row_affinity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RowAffinity { get; set; }

    /// <summary>
    /// Block for data_boost_isolation_read_only.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataBoostIsolationReadOnly block(s) allowed")]
    [TerraformPropertyName("data_boost_isolation_read_only")]
    public TerraformList<TerraformBlock<GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock>>? DataBoostIsolationReadOnly { get; set; } = new();

    /// <summary>
    /// Block for single_cluster_routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleClusterRouting block(s) allowed")]
    [TerraformPropertyName("single_cluster_routing")]
    public TerraformList<TerraformBlock<GoogleBigtableAppProfileSingleClusterRoutingBlock>>? SingleClusterRouting { get; set; } = new();

    /// <summary>
    /// Block for standard_isolation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardIsolation block(s) allowed")]
    [TerraformPropertyName("standard_isolation")]
    public TerraformList<TerraformBlock<GoogleBigtableAppProfileStandardIsolationBlock>>? StandardIsolation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigtableAppProfileTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique name of the requested app profile. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/appProfiles/&amp;lt;appProfileId&amp;gt;&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
