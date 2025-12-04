using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for acl_entries in GoogleManagedKafkaAcl.
/// Nesting mode: set
/// </summary>
public class GoogleManagedKafkaAclAclEntriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acl_entries";

    /// <summary>
    /// The host. Must be set to &amp;quot;*&amp;quot; for Managed Service for Apache Kafka.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The operation type. Allowed values are (case insensitive): ALL, READ,
    /// WRITE, CREATE, DELETE, ALTER, DESCRIBE, CLUSTER_ACTION, DESCRIBE_CONFIGS,
    /// ALTER_CONFIGS, and IDEMPOTENT_WRITE. See https://kafka.apache.org/documentation/#operations_resources_and_protocols
    /// for valid combinations of resource_type and operation for different Kafka API requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operation is required")]
    public required TerraformValue<string> Operation
    {
        get => GetArgument<TerraformValue<string>>("operation");
        set => SetArgument("operation", value);
    }

    /// <summary>
    /// The permission type. Accepted values are (case insensitive): ALLOW, DENY.
    /// </summary>
    public TerraformValue<string>? PermissionType
    {
        get => GetArgument<TerraformValue<string>>("permission_type");
        set => SetArgument("permission_type", value);
    }

    /// <summary>
    /// The principal. Specified as Google Cloud account, with the Kafka StandardAuthorizer prefix User:&amp;quot;. For example: &amp;quot;User:test-kafka-client@test-project.iam.gserviceaccount.com&amp;quot;. Can be the wildcard &amp;quot;User:*&amp;quot; to refer to all users.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleManagedKafkaAcl.
/// Nesting mode: single
/// </summary>
public class GoogleManagedKafkaAclTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_managed_kafka_acl Terraform resource.
/// Manages a google_managed_kafka_acl resource.
/// </summary>
public partial class GoogleManagedKafkaAcl(string name) : TerraformResource("google_managed_kafka_acl", name)
{
    /// <summary>
    /// The ID to use for the acl, which will become the final component of the acl&#39;s name. The structure of &#39;aclId&#39; defines the Resource Pattern (resource_type, resource_name, pattern_type) of the acl. &#39;aclId&#39; is structured like one of the following:
    /// For acls on the cluster: &#39;cluster&#39;
    /// For acls on a single resource within the cluster: &#39;topic/{resource_name}&#39; &#39;consumerGroup/{resource_name}&#39; &#39;transactionalId/{resource_name}&#39;
    /// For acls on all resources that match a prefix: &#39;topicPrefixed/{resource_name}&#39; &#39;consumerGroupPrefixed/{resource_name}&#39; &#39;transactionalIdPrefixed/{resource_name}&#39;
    /// For acls on all resources of a given type (i.e. the wildcard literal &#39;*&#39;&#39;): &#39;allTopics&#39; (represents &#39;topic/*&#39;) &#39;allConsumerGroups&#39; (represents &#39;consumerGroup/*&#39;) &#39;allTransactionalIds&#39; (represents &#39;transactionalId/*&#39;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclId is required")]
    public required TerraformValue<string> AclId
    {
        get => GetArgument<TerraformValue<string>>("acl_id");
        set => SetArgument("acl_id", value);
    }

    /// <summary>
    /// The cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
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
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The name of the acl. The &#39;ACL_ID&#39; segment is used when connecting directly to the cluster. Must be in the format &#39;projects/PROJECT_ID/locations/LOCATION/clusters/CLUSTER_ID/acls/ACL_ID&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The acl pattern type derived from the name. One of: LITERAL, PREFIXED.
    /// </summary>
    public TerraformValue<string> PatternType
        => AsReference("pattern_type");

    /// <summary>
    /// The acl resource name derived from the name. For cluster resource_type, this is always &amp;quot;kafka-cluster&amp;quot;. Can be the wildcard literal &amp;quot;*&amp;quot;.
    /// </summary>
    public TerraformValue<string> ResourceNameAttribute
        => AsReference("resource_name");

    /// <summary>
    /// The acl resource type derived from the name. One of: CLUSTER, TOPIC, GROUP, TRANSACTIONAL_ID.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
        => AsReference("resource_type");

    /// <summary>
    /// AclEntries block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclEntries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AclEntries block(s) required")]
    public required TerraformSet<GoogleManagedKafkaAclAclEntriesBlock> AclEntries
    {
        get => GetRequiredArgument<TerraformSet<GoogleManagedKafkaAclAclEntriesBlock>>("acl_entries");
        set => SetArgument("acl_entries", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleManagedKafkaAclTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleManagedKafkaAclTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
