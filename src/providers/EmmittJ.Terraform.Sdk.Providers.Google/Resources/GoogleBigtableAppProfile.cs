using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_boost_isolation_read_only in GoogleBigtableAppProfile.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_boost_isolation_read_only";

    /// <summary>
    /// The Compute Billing Owner for this Data Boost App Profile. Possible values: [&amp;quot;HOST_PAYS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeBillingOwner is required")]
    public required TerraformValue<string> ComputeBillingOwner
    {
        get => new TerraformReference<string>(this, "compute_billing_owner");
        set => SetArgument("compute_billing_owner", value);
    }

}


/// <summary>
/// Block type for single_cluster_routing in GoogleBigtableAppProfile.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileSingleClusterRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_cluster_routing";

    /// <summary>
    /// If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile.
    /// It is unsafe to send these requests to the same table/row/column in multiple clusters.
    /// </summary>
    public TerraformValue<bool>? AllowTransactionalWrites
    {
        get => new TerraformReference<bool>(this, "allow_transactional_writes");
        set => SetArgument("allow_transactional_writes", value);
    }

    /// <summary>
    /// The cluster to which read/write requests should be routed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

}


/// <summary>
/// Block type for standard_isolation in GoogleBigtableAppProfile.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableAppProfileStandardIsolationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_isolation";

    /// <summary>
    /// The priority of requests sent using this app profile. Possible values: [&amp;quot;PRIORITY_LOW&amp;quot;, &amp;quot;PRIORITY_MEDIUM&amp;quot;, &amp;quot;PRIORITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<string> Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigtableAppProfile.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableAppProfileTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigtable_app_profile Terraform resource.
/// Manages a google_bigtable_app_profile resource.
/// </summary>
public partial class GoogleBigtableAppProfile(string name) : TerraformResource("google_bigtable_app_profile", name)
{
    /// <summary>
    /// The unique name of the app profile in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppProfileId is required")]
    public required TerraformValue<string> AppProfileId
    {
        get => new TerraformReference<string>(this, "app_profile_id");
        set => SetArgument("app_profile_id", value);
    }

    /// <summary>
    /// Long form description of the use case for this app profile.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// If true, ignore safety checks when deleting/updating the app profile.
    /// </summary>
    public TerraformValue<bool>? IgnoreWarnings
    {
        get => new TerraformReference<bool>(this, "ignore_warnings");
        set => SetArgument("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the instance to create the app profile within.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.
    /// </summary>
    public TerraformList<string>? MultiClusterRoutingClusterIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "multi_cluster_routing_cluster_ids").ResolveNodes(ctx));
        set => SetArgument("multi_cluster_routing_cluster_ids", value);
    }

    /// <summary>
    /// If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available
    /// in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes
    /// consistency to improve availability.
    /// </summary>
    public TerraformValue<bool>? MultiClusterRoutingUseAny
    {
        get => new TerraformReference<bool>(this, "multi_cluster_routing_use_any");
        set => SetArgument("multi_cluster_routing_use_any", value);
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
    /// Must be used with multi-cluster routing. If true, then this app profile will use row affinity sticky routing. With row affinity, Bigtable will route single row key requests based on the row key, rather than randomly. Instead, each row key will be assigned to a cluster by Cloud Bigtable, and will stick to that cluster. Choosing this option improves read-your-writes consistency for most requests under most circumstances, without sacrificing availability. Consistency is not guaranteed, as requests may still fail over between clusters in the event of errors or latency.
    /// </summary>
    public TerraformValue<bool>? RowAffinity
    {
        get => new TerraformReference<bool>(this, "row_affinity");
        set => SetArgument("row_affinity", value);
    }

    /// <summary>
    /// The unique name of the requested app profile. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/appProfiles/&amp;lt;appProfileId&amp;gt;&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// DataBoostIsolationReadOnly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataBoostIsolationReadOnly block(s) allowed")]
    public TerraformList<GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock>? DataBoostIsolationReadOnly
    {
        get => GetArgument<TerraformList<GoogleBigtableAppProfileDataBoostIsolationReadOnlyBlock>>("data_boost_isolation_read_only");
        set => SetArgument("data_boost_isolation_read_only", value);
    }

    /// <summary>
    /// SingleClusterRouting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleClusterRouting block(s) allowed")]
    public TerraformList<GoogleBigtableAppProfileSingleClusterRoutingBlock>? SingleClusterRouting
    {
        get => GetArgument<TerraformList<GoogleBigtableAppProfileSingleClusterRoutingBlock>>("single_cluster_routing");
        set => SetArgument("single_cluster_routing", value);
    }

    /// <summary>
    /// StandardIsolation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardIsolation block(s) allowed")]
    public TerraformList<GoogleBigtableAppProfileStandardIsolationBlock>? StandardIsolation
    {
        get => GetArgument<TerraformList<GoogleBigtableAppProfileStandardIsolationBlock>>("standard_isolation");
        set => SetArgument("standard_isolation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableAppProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableAppProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
