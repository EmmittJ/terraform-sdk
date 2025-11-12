using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for acl_entries in .
/// Nesting mode: set
/// </summary>
public partial class GoogleManagedKafkaAclAclEntriesBlock() : TerraformBlock("acl_entries")
{
    /// <summary>
    /// The host. Must be set to &amp;quot;*&amp;quot; for Managed Service for Apache Kafka.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// The operation type. Allowed values are (case insensitive): ALL, READ,
    /// WRITE, CREATE, DELETE, ALTER, DESCRIBE, CLUSTER_ACTION, DESCRIBE_CONFIGS,
    /// ALTER_CONFIGS, and IDEMPOTENT_WRITE. See https://kafka.apache.org/documentation/#operations_resources_and_protocols
    /// for valid combinations of resource_type and operation for different Kafka API requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operation is required")]
    [TerraformProperty("operation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Operation { get; set; }

    /// <summary>
    /// The permission type. Accepted values are (case insensitive): ALLOW, DENY.
    /// </summary>
    [TerraformProperty("permission_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PermissionType { get; set; }

    /// <summary>
    /// The principal. Specified as Google Cloud account, with the Kafka StandardAuthorizer prefix User:&amp;quot;. For example: &amp;quot;User:test-kafka-client@test-project.iam.gserviceaccount.com&amp;quot;. Can be the wildcard &amp;quot;User:*&amp;quot; to refer to all users.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleManagedKafkaAclTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_managed_kafka_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleManagedKafkaAcl : TerraformResource
{
    public GoogleManagedKafkaAcl(string name) : base("google_managed_kafka_acl", name)
    {
    }

    /// <summary>
    /// The ID to use for the acl, which will become the final component of the acl&#39;s name. The structure of &#39;aclId&#39; defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl. &#39;aclId&#39; is structured like one of the following:
    /// For acls on the cluster: &#39;cluster&#39;
    /// For acls on a single resource within the cluster: &#39;topic/{resource_name}&#39; &#39;consumerGroup/{resource_name}&#39; &#39;transactionalId/{resource_name}&#39;
    /// For acls on all resources that match a prefix: &#39;topicPrefixed/{resource_name}&#39; &#39;consumerGroupPrefixed/{resource_name}&#39; &#39;transactionalIdPrefixed/{resource_name}&#39;
    /// For acls on all resources of a given type (i.e. the wildcard literal &#39;*&#39;&#39;): &#39;allTopics&#39; (represents &#39;topic/*&#39;) &#39;allConsumerGroups&#39; (represents &#39;consumerGroup/*&#39;) &#39;allTransactionalIds&#39; (represents &#39;transactionalId/*&#39;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclId is required")]
    [TerraformProperty("acl_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AclId { get; set; }

    /// <summary>
    /// The cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for acl_entries.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclEntries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AclEntries block(s) required")]
    [TerraformProperty("acl_entries")]
    public required TerraformSet<GoogleManagedKafkaAclAclEntriesBlock> AclEntries { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleManagedKafkaAclTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// &#39;etag&#39; is used for concurrency control. An &#39;etag&#39; is returned in the
    /// response to &#39;GetAcl&#39; and &#39;CreateAcl&#39;. Callers are required to put that etag
    /// in the request to &#39;UpdateAcl&#39; to ensure that their change will be applied
    /// to the same version of the acl that exists in the Kafka Cluster.
    /// 
    /// A terminal &#39;T&#39; character in the etag indicates that the AclEntries were
    /// truncated due to repeated field limits.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The name of the acl. The &#39;ACL_ID&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/acls/ACL_ID&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The acl pattern type derived from the name. One of: LITERAL, PREFIXED.
    /// </summary>
    [TerraformProperty("pattern_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PatternType { get; }

    /// <summary>
    /// The acl resource name derived from the name. For cluster resource_type, this is always &amp;quot;kafka-cluster&amp;quot;. Can be the wildcard literal &amp;quot;*&amp;quot;.
    /// </summary>
    [TerraformProperty("resource_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceName { get; }

    /// <summary>
    /// The acl resource type derived from the name. One of: CLUSTER, TOPIC, GROUP, TRANSACTIONAL_ID.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceType { get; }

}
