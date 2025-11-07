using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_managed_kafka_acl resource.
/// </summary>
public class GoogleManagedKafkaAcl : TerraformResource
{
    public GoogleManagedKafkaAcl(string name) : base("google_managed_kafka_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("pattern_type");
        this.DeclareOutput("resource_name");
        this.DeclareOutput("resource_type");
    }

    /// <summary>
    /// The ID to use for the acl, which will become the final component of the acl&#39;s name. The structure of &#39;aclId&#39; defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl. &#39;aclId&#39; is structured like one of the following:
    /// For acls on the cluster: &#39;cluster&#39;
    /// For acls on a single resource within the cluster: &#39;topic/{resource_name}&#39; &#39;consumerGroup/{resource_name}&#39; &#39;transactionalId/{resource_name}&#39;
    /// For acls on all resources that match a prefix: &#39;topicPrefixed/{resource_name}&#39; &#39;consumerGroupPrefixed/{resource_name}&#39; &#39;transactionalIdPrefixed/{resource_name}&#39;
    /// For acls on all resources of a given type (i.e. the wildcard literal &#39;*&#39;&#39;): &#39;allTopics&#39; (represents &#39;topic/*&#39;) &#39;allConsumerGroups&#39; (represents &#39;consumerGroup/*&#39;) &#39;allTransactionalIds&#39; (represents &#39;transactionalId/*&#39;).
    /// </summary>
    public TerraformProperty<string>? AclId
    {
        get => GetProperty<TerraformProperty<string>>("acl_id");
        set => this.WithProperty("acl_id", value);
    }

    /// <summary>
    /// The cluster name.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
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
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// &#39;etag&#39; is used for concurrency control. An &#39;etag&#39; is returned in the
    /// response to &#39;GetAcl&#39; and &#39;CreateAcl&#39;. Callers are required to put that etag
    /// in the request to &#39;UpdateAcl&#39; to ensure that their change will be applied
    /// to the same version of the acl that exists in the Kafka Cluster.
    /// 
    /// A terminal &#39;T&#39; character in the etag indicates that the AclEntries were
    /// truncated due to repeated field limits.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The name of the acl. The &#39;ACL_ID&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/acls/ACL_ID&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The acl pattern type derived from the name. One of: LITERAL, PREFIXED.
    /// </summary>
    public TerraformExpression PatternType => this["pattern_type"];

    /// <summary>
    /// The acl resource name derived from the name. For cluster resource_type, this is always &amp;quot;kafka-cluster&amp;quot;. Can be the wildcard literal &amp;quot;*&amp;quot;.
    /// </summary>
    public TerraformExpression ResourceName => this["resource_name"];

    /// <summary>
    /// The acl resource type derived from the name. One of: CLUSTER, TOPIC, GROUP, TRANSACTIONAL_ID.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

}
