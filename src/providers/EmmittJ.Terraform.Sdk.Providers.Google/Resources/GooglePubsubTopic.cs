using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ingestion_data_source_settings in GooglePubsubTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingestion_data_source_settings";

    /// <summary>
    /// AwsKinesis block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsKinesis block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockAwsKinesisBlock>? AwsKinesis
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockAwsKinesisBlock>>("aws_kinesis");
        set => SetArgument("aws_kinesis", value);
    }

    /// <summary>
    /// AwsMsk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsMsk block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockAwsMskBlock>? AwsMsk
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockAwsMskBlock>>("aws_msk");
        set => SetArgument("aws_msk", value);
    }

    /// <summary>
    /// AzureEventHubs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureEventHubs block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockAzureEventHubsBlock>? AzureEventHubs
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockAzureEventHubsBlock>>("azure_event_hubs");
        set => SetArgument("azure_event_hubs", value);
    }

    /// <summary>
    /// CloudStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorage block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlock>? CloudStorage
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlock>>("cloud_storage");
        set => SetArgument("cloud_storage", value);
    }

    /// <summary>
    /// ConfluentCloud block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfluentCloud block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockConfluentCloudBlock>? ConfluentCloud
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockConfluentCloudBlock>>("confluent_cloud");
        set => SetArgument("confluent_cloud", value);
    }

    /// <summary>
    /// PlatformLogsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlatformLogsSettings block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockPlatformLogsSettingsBlock>? PlatformLogsSettings
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockPlatformLogsSettingsBlock>>("platform_logs_settings");
        set => SetArgument("platform_logs_settings", value);
    }

}

/// <summary>
/// Block type for aws_kinesis in GooglePubsubTopicIngestionDataSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockAwsKinesisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_kinesis";

    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// Kinesis. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRoleArn is required")]
    public required TerraformValue<string> AwsRoleArn
    {
        get => new TerraformReference<string>(this, "aws_role_arn");
        set => SetArgument("aws_role_arn", value);
    }

    /// <summary>
    /// The Kinesis consumer ARN to used for ingestion in
    /// Enhanced Fan-Out mode. The consumer must be already
    /// created and ready to be used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerArn is required")]
    public required TerraformValue<string> ConsumerArn
    {
        get => new TerraformReference<string>(this, "consumer_arn");
        set => SetArgument("consumer_arn", value);
    }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Kinesis (via a &#39;AssumeRoleWithWebIdentity&#39; call for the provided
    /// role). The &#39;awsRoleArn&#39; must be set up with &#39;accounts.google.com:sub&#39;
    /// equals to this service account number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpServiceAccount is required")]
    public required TerraformValue<string> GcpServiceAccount
    {
        get => new TerraformReference<string>(this, "gcp_service_account");
        set => SetArgument("gcp_service_account", value);
    }

    /// <summary>
    /// The Kinesis stream ARN to ingest data from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
        set => SetArgument("stream_arn", value);
    }

}

/// <summary>
/// Block type for aws_msk in GooglePubsubTopicIngestionDataSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockAwsMskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_msk";

    /// <summary>
    /// AWS role ARN to be used for Federated Identity authentication with
    /// MSK. Check the Pub/Sub docs for how to set up this role and the
    /// required permissions that need to be attached to it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRoleArn is required")]
    public required TerraformValue<string> AwsRoleArn
    {
        get => new TerraformReference<string>(this, "aws_role_arn");
        set => SetArgument("aws_role_arn", value);
    }

    /// <summary>
    /// ARN that uniquely identifies the MSK cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformValue<string> ClusterArn
    {
        get => new TerraformReference<string>(this, "cluster_arn");
        set => SetArgument("cluster_arn", value);
    }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with MSK (via a &#39;AssumeRoleWithWebIdentity&#39; call for the provided
    /// role). The &#39;awsRoleArn&#39; must be set up with &#39;accounts.google.com:sub&#39;
    /// equals to this service account number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpServiceAccount is required")]
    public required TerraformValue<string> GcpServiceAccount
    {
        get => new TerraformReference<string>(this, "gcp_service_account");
        set => SetArgument("gcp_service_account", value);
    }

    /// <summary>
    /// The name of the MSK topic that Pub/Sub will import from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}

/// <summary>
/// Block type for azure_event_hubs in GooglePubsubTopicIngestionDataSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockAzureEventHubsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_event_hubs";

    /// <summary>
    /// The Azure event hub client ID to use for ingestion.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The Azure event hub to ingest data from.
    /// </summary>
    public TerraformValue<string>? EventHub
    {
        get => new TerraformReference<string>(this, "event_hub");
        set => SetArgument("event_hub", value);
    }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Azure (via a &#39;AssumeRoleWithWebIdentity&#39; call for the provided
    /// role).
    /// </summary>
    public TerraformValue<string>? GcpServiceAccount
    {
        get => new TerraformReference<string>(this, "gcp_service_account");
        set => SetArgument("gcp_service_account", value);
    }

    /// <summary>
    /// The Azure event hub namespace to ingest data from.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The name of the resource group within an Azure subscription.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// The Azure event hub subscription ID to use for ingestion.
    /// </summary>
    public TerraformValue<string>? SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// The Azure event hub tenant ID to use for ingestion.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for cloud_storage in GooglePubsubTopicIngestionDataSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage";

    /// <summary>
    /// Cloud Storage bucket. The bucket name must be without any
    /// prefix like &amp;quot;gs://&amp;quot;. See the bucket naming requirements:
    /// https://cloud.google.com/storage/docs/buckets#naming.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Glob pattern used to match objects that will be ingested. If unset, all
    /// objects will be ingested. See the supported patterns:
    /// https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob
    /// </summary>
    public TerraformValue<string>? MatchGlob
    {
        get => new TerraformReference<string>(this, "match_glob");
        set => SetArgument("match_glob", value);
    }

    /// <summary>
    /// The timestamp set in RFC3339 text format. If set, only objects with a
    /// larger or equal timestamp will be ingested. Unset by default, meaning
    /// all objects will be ingested.
    /// </summary>
    public TerraformValue<string>? MinimumObjectCreateTime
    {
        get => new TerraformReference<string>(this, "minimum_object_create_time");
        set => SetArgument("minimum_object_create_time", value);
    }

    /// <summary>
    /// AvroFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvroFormat block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockAvroFormatBlock>? AvroFormat
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockAvroFormatBlock>>("avro_format");
        set => SetArgument("avro_format", value);
    }

    /// <summary>
    /// PubsubAvroFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubAvroFormat block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockPubsubAvroFormatBlock>? PubsubAvroFormat
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockPubsubAvroFormatBlock>>("pubsub_avro_format");
        set => SetArgument("pubsub_avro_format", value);
    }

    /// <summary>
    /// TextFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TextFormat block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockTextFormatBlock>? TextFormat
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockTextFormatBlock>>("text_format");
        set => SetArgument("text_format", value);
    }

}

/// <summary>
/// Block type for avro_format in GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockAvroFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avro_format";

}

/// <summary>
/// Block type for pubsub_avro_format in GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockPubsubAvroFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_avro_format";

}

/// <summary>
/// Block type for text_format in GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockCloudStorageBlockTextFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_format";

    /// <summary>
    /// The delimiter to use when using the &#39;text&#39; format. Each line of text as
    /// specified by the delimiter will be set to the &#39;data&#39; field of a Pub/Sub
    /// message. When unset, &#39;\n&#39; is used.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => new TerraformReference<string>(this, "delimiter");
        set => SetArgument("delimiter", value);
    }

}

/// <summary>
/// Block type for confluent_cloud in GooglePubsubTopicIngestionDataSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockConfluentCloudBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confluent_cloud";

    /// <summary>
    /// The Confluent Cloud bootstrap server. The format is url:port.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootstrapServer is required")]
    public required TerraformValue<string> BootstrapServer
    {
        get => new TerraformReference<string>(this, "bootstrap_server");
        set => SetArgument("bootstrap_server", value);
    }

    /// <summary>
    /// The Confluent Cloud cluster ID.
    /// </summary>
    public TerraformValue<string>? ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The GCP service account to be used for Federated Identity authentication
    /// with Confluent Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpServiceAccount is required")]
    public required TerraformValue<string> GcpServiceAccount
    {
        get => new TerraformReference<string>(this, "gcp_service_account");
        set => SetArgument("gcp_service_account", value);
    }

    /// <summary>
    /// Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformValue<string> IdentityPoolId
    {
        get => new TerraformReference<string>(this, "identity_pool_id");
        set => SetArgument("identity_pool_id", value);
    }

    /// <summary>
    /// Name of the Confluent Cloud topic that Pub/Sub will import from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}

/// <summary>
/// Block type for platform_logs_settings in GooglePubsubTopicIngestionDataSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlockPlatformLogsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "platform_logs_settings";

    /// <summary>
    /// The minimum severity level of Platform Logs that will be written. If unspecified,
    /// no Platform Logs will be written. Default value: &amp;quot;SEVERITY_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;SEVERITY_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;DEBUG&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;WARNING&amp;quot;, &amp;quot;ERROR&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

}


/// <summary>
/// Block type for message_storage_policy in GooglePubsubTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicMessageStoragePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_storage_policy";

    /// <summary>
    /// A list of IDs of GCP regions where messages that are published to
    /// the topic may be persisted in storage. Messages published by
    /// publishers running in non-allowed GCP regions (or running outside
    /// of GCP altogether) will be routed for storage in one of the
    /// allowed regions. An empty list means that no regions are allowed,
    /// and is not a valid configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPersistenceRegions is required")]
    public required TerraformSet<string> AllowedPersistenceRegions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_persistence_regions").ResolveNodes(ctx));
        set => SetArgument("allowed_persistence_regions", value);
    }

    /// <summary>
    /// If true, &#39;allowedPersistenceRegions&#39; is also used to enforce in-transit
    /// guarantees for messages. That is, Pub/Sub will fail topics.publish
    /// operations on this topic and subscribe operations on any subscription
    /// attached to this topic in any region that is not in &#39;allowedPersistenceRegions&#39;.
    /// </summary>
    public TerraformValue<bool>? EnforceInTransit
    {
        get => new TerraformReference<bool>(this, "enforce_in_transit");
        set => SetArgument("enforce_in_transit", value);
    }

}


/// <summary>
/// Block type for message_transforms in GooglePubsubTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicMessageTransformsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_transforms";

    /// <summary>
    /// Controls whether or not to use this transform. If not set or &#39;false&#39;,
    /// the transform will be applied to messages. Default: &#39;true&#39;.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// JavascriptUdf block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JavascriptUdf block(s) allowed")]
    public TerraformList<GooglePubsubTopicMessageTransformsBlockJavascriptUdfBlock>? JavascriptUdf
    {
        get => GetArgument<TerraformList<GooglePubsubTopicMessageTransformsBlockJavascriptUdfBlock>>("javascript_udf");
        set => SetArgument("javascript_udf", value);
    }

}

/// <summary>
/// Block type for javascript_udf in GooglePubsubTopicMessageTransformsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicMessageTransformsBlockJavascriptUdfBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "javascript_udf";

    /// <summary>
    /// JavaScript code that contains a function &#39;function_name&#39; with the
    /// following signature:
    /// &#39;&#39;&#39;
    ///   /**
    ///   * Transforms a Pub/Sub message.
    ///   *
    ///   * @return {(Object&amp;lt;string, (string | Object&amp;lt;string, string&amp;gt;)&amp;gt;|null)} - To
    ///   * filter a message, return &#39;null&#39;. To transform a message return a map
    ///   * with the following keys:
    ///   *   - (required) &#39;data&#39; : {string}
    ///   *   - (optional) &#39;attributes&#39; : {Object&amp;lt;string, string&amp;gt;}
    ///   * Returning empty &#39;attributes&#39; will remove all attributes from the
    ///   * message.
    ///   *
    ///   * @param  {(Object&amp;lt;string, (string | Object&amp;lt;string, string&amp;gt;)&amp;gt;} Pub/Sub
    ///   * message. Keys:
    ///   *   - (required) &#39;data&#39; : {string}
    ///   *   - (required) &#39;attributes&#39; : {Object&amp;lt;string, string&amp;gt;}
    ///   *
    ///   * @param  {Object&amp;lt;string, any&amp;gt;} metadata - Pub/Sub message metadata.
    ///   * Keys:
    ///   *   - (required) &#39;message_id&#39;  : {string}
    ///   *   - (optional) &#39;publish_time&#39;: {string} YYYY-MM-DDTHH:MM:SSZ format
    ///   *   - (optional) &#39;ordering_key&#39;: {string}
    ///   */
    ///   function &amp;lt;function_name&amp;gt;(message, metadata) {
    ///   }
    /// &#39;&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<string> Code
    {
        get => new TerraformReference<string>(this, "code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// Name of the JavaScript function that should be applied to Pub/Sub messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => new TerraformReference<string>(this, "function_name");
        set => SetArgument("function_name", value);
    }

}


/// <summary>
/// Block type for schema_settings in GooglePubsubTopic.
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicSchemaSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_settings";

    /// <summary>
    /// The encoding of messages validated against schema. Default value: &amp;quot;ENCODING_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;BINARY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The name of the schema that messages published should be
    /// validated against. Format is projects/{project}/schemas/{schema}.
    /// The value of this field will be _deleted-schema_
    /// if the schema has been deleted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

}


/// <summary>
/// Block type for timeouts in GooglePubsubTopic.
/// Nesting mode: single
/// </summary>
public class GooglePubsubTopicTimeoutsBlock : TerraformBlock
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
/// Represents a google_pubsub_topic Terraform resource.
/// Manages a google_pubsub_topic resource.
/// </summary>
public partial class GooglePubsubTopic(string name) : TerraformResource("google_pubsub_topic", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&#39;s PubSub service account
    /// (&#39;service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// The expected format is &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this Topic.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Indicates the minimum duration to retain a message after it is published
    /// to the topic. If this field is set, messages published to the topic in
    /// the last messageRetentionDuration are always available to subscribers.
    /// For instance, it allows any attached subscription to seek to a timestamp
    /// that is up to messageRetentionDuration in the past. If this field is not
    /// set, message retention is controlled by settings on individual subscriptions.
    /// The rotation period has the format of a decimal number, followed by the
    /// letter &#39;s&#39; (seconds). Cannot be more than 31 days or less than 10 minutes.
    /// </summary>
    public TerraformValue<string>? MessageRetentionDuration
    {
        get => new TerraformReference<string>(this, "message_retention_duration");
        set => SetArgument("message_retention_duration", value);
    }

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// Input only. Resource manager tags to be bound to the topic. Tag keys and
    /// values have the same definition as resource manager tags. Keys must be in
    /// the format tagKeys/{tag_key_id}, and values are in the format
    /// tagValues/456. The field is ignored when empty. The field is immutable and
    /// causes resource replacement when mutated. This field is only set at create
    /// time and modifying this field after creation will trigger recreation. To
    /// apply tags to an existing resource, see the &#39;google_tags_tag_value&#39;
    /// resource.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// IngestionDataSourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngestionDataSourceSettings block(s) allowed")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlock>? IngestionDataSourceSettings
    {
        get => GetArgument<TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlock>>("ingestion_data_source_settings");
        set => SetArgument("ingestion_data_source_settings", value);
    }

    /// <summary>
    /// MessageStoragePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageStoragePolicy block(s) allowed")]
    public TerraformList<GooglePubsubTopicMessageStoragePolicyBlock>? MessageStoragePolicy
    {
        get => GetArgument<TerraformList<GooglePubsubTopicMessageStoragePolicyBlock>>("message_storage_policy");
        set => SetArgument("message_storage_policy", value);
    }

    /// <summary>
    /// MessageTransforms block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePubsubTopicMessageTransformsBlock>? MessageTransforms
    {
        get => GetArgument<TerraformList<GooglePubsubTopicMessageTransformsBlock>>("message_transforms");
        set => SetArgument("message_transforms", value);
    }

    /// <summary>
    /// SchemaSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaSettings block(s) allowed")]
    public TerraformList<GooglePubsubTopicSchemaSettingsBlock>? SchemaSettings
    {
        get => GetArgument<TerraformList<GooglePubsubTopicSchemaSettingsBlock>>("schema_settings");
        set => SetArgument("schema_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePubsubTopicTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePubsubTopicTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
