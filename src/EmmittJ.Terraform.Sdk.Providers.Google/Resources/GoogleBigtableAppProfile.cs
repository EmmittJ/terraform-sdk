using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigtable_app_profile resource.
/// </summary>
public class GoogleBigtableAppProfile : TerraformResource
{
    public GoogleBigtableAppProfile(string name) : base("google_bigtable_app_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The unique name of the app profile in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    public TerraformProperty<string>? AppProfileId
    {
        get => GetProperty<TerraformProperty<string>>("app_profile_id");
        set => this.WithProperty("app_profile_id", value);
    }

    /// <summary>
    /// Long form description of the use case for this app profile.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// If true, ignore safety checks when deleting/updating the app profile.
    /// </summary>
    public TerraformProperty<bool>? IgnoreWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_warnings");
        set => this.WithProperty("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the instance to create the app profile within.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.
    /// </summary>
    public TerraformProperty<List<string>>? MultiClusterRoutingClusterIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("multi_cluster_routing_cluster_ids");
        set => this.WithProperty("multi_cluster_routing_cluster_ids", value);
    }

    /// <summary>
    /// If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available
    /// in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes
    /// consistency to improve availability.
    /// </summary>
    public TerraformProperty<bool>? MultiClusterRoutingUseAny
    {
        get => GetProperty<TerraformProperty<bool>>("multi_cluster_routing_use_any");
        set => this.WithProperty("multi_cluster_routing_use_any", value);
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
    /// Must be used with multi-cluster routing. If true, then this app profile will use row affinity sticky routing. With row affinity, Bigtable will route single row key requests based on the row key, rather than randomly. Instead, each row key will be assigned to a cluster by Cloud Bigtable, and will stick to that cluster. Choosing this option improves read-your-writes consistency for most requests under most circumstances, without sacrificing availability. Consistency is not guaranteed, as requests may still fail over between clusters in the event of errors or latency.
    /// </summary>
    public TerraformProperty<bool>? RowAffinity
    {
        get => GetProperty<TerraformProperty<bool>>("row_affinity");
        set => this.WithProperty("row_affinity", value);
    }

    /// <summary>
    /// The unique name of the requested app profile. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/appProfiles/&amp;lt;appProfileId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
