using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in GoogleDataFusionInstance.
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;CDC&amp;quot;, &amp;quot;HEALTHCARE&amp;quot;, &amp;quot;CCAI_INSIGHTS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    public required TerraformValue<string> AcceleratorType
    {
        get => new TerraformReference<string>(this, "accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for crypto_key_config in GoogleDataFusionInstance.
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceCryptoKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key_config";

    /// <summary>
    /// The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key should be in the format of projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    public required TerraformValue<string> KeyReference
    {
        get => new TerraformReference<string>(this, "key_reference");
        set => SetArgument("key_reference", value);
    }

}


/// <summary>
/// Block type for event_publish_config in GoogleDataFusionInstance.
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceEventPublishConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_publish_config";

    /// <summary>
    /// Option to enable Event Publishing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The resource name of the Pub/Sub topic. Format: projects/{projectId}/topics/{topic_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleDataFusionInstance.
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Optional. Type of connection for establishing private IP connectivity between the Data Fusion customer project VPC and
    /// the corresponding tenant project from a predefined list of available connection modes.
    /// If this field is unspecified for a private instance, VPC peering is used. Possible values: [&amp;quot;VPC_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT_INTERFACES&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ConnectionType
    {
        get => new TerraformReference<string>(this, "connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// The IP range in CIDR notation to use for the managed Data Fusion instance
    /// nodes. This range must not overlap with any other ranges used in the Data Fusion instance network.
    /// </summary>
    public TerraformValue<string>? IpAllocation
    {
        get => new TerraformReference<string>(this, "ip_allocation");
        set => SetArgument("ip_allocation", value);
    }

    /// <summary>
    /// Name of the network in the project with which the tenant project
    /// will be peered for executing pipelines. In case of shared VPC where the network resides in another host
    /// project the network should specified in the form of projects/{host-project-id}/global/networks/{network}
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// PrivateServiceConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    public TerraformList<GoogleDataFusionInstanceNetworkConfigBlockPrivateServiceConnectConfigBlock>? PrivateServiceConnectConfig
    {
        get => GetArgument<TerraformList<GoogleDataFusionInstanceNetworkConfigBlockPrivateServiceConnectConfigBlock>>("private_service_connect_config");
        set => SetArgument("private_service_connect_config", value);
    }

}

/// <summary>
/// Block type for private_service_connect_config in GoogleDataFusionInstanceNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceNetworkConfigBlockPrivateServiceConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_service_connect_config";

    /// <summary>
    /// Output only. The CIDR block to which the CDF instance can&#39;t route traffic to in the consumer project VPC.
    /// The size of this block is /25. The format of this field is governed by RFC 4632.
    /// </summary>
    public TerraformValue<string> EffectiveUnreachableCidrBlock
    {
        get => new TerraformReference<string>(this, "effective_unreachable_cidr_block");
    }

    /// <summary>
    /// Optional. The reference to the network attachment used to establish private connectivity.
    /// It will be of the form projects/{project-id}/regions/{region}/networkAttachments/{network-attachment-id}.
    /// This is required only when using connection type PRIVATE_SERVICE_CONNECT_INTERFACES.
    /// </summary>
    public TerraformValue<string>? NetworkAttachment
    {
        get => new TerraformReference<string>(this, "network_attachment");
        set => SetArgument("network_attachment", value);
    }

    /// <summary>
    /// Optional. Input only. The CIDR block to which the CDF instance can&#39;t route traffic to in the consumer project VPC.
    /// The size of this block should be at least /25. This range should not overlap with the primary address range of any subnetwork used by the network attachment.
    /// This range can be used for other purposes in the consumer VPC as long as there is no requirement for CDF to reach destinations using these addresses.
    /// If this value is not provided, the server chooses a non RFC 1918 address range. The format of this field is governed by RFC 4632.
    /// </summary>
    public TerraformValue<string>? UnreachableCidrBlock
    {
        get => new TerraformReference<string>(this, "unreachable_cidr_block");
        set => SetArgument("unreachable_cidr_block", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataFusionInstance.
/// Nesting mode: single
/// </summary>
public class GoogleDataFusionInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a google_data_fusion_instance Terraform resource.
/// Manages a google_data_fusion_instance resource.
/// </summary>
public partial class GoogleDataFusionInstance(string name) : TerraformResource("google_data_fusion_instance", name)
{
    /// <summary>
    /// User-managed service account to set on Dataproc when Cloud Data Fusion creates Dataproc to run data processing pipelines.
    /// </summary>
    public TerraformValue<string>? DataprocServiceAccount
    {
        get => new TerraformReference<string>(this, "dataproc_service_account");
        set => SetArgument("dataproc_service_account", value);
    }

    /// <summary>
    /// An optional description of the instance.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name for an instance.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Option to enable granular role-based access control.
    /// </summary>
    public TerraformValue<bool>? EnableRbac
    {
        get => new TerraformReference<bool>(this, "enable_rbac");
        set => SetArgument("enable_rbac", value);
    }

    /// <summary>
    /// Option to enable Stackdriver Logging.
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverLogging
    {
        get => new TerraformReference<bool>(this, "enable_stackdriver_logging");
        set => SetArgument("enable_stackdriver_logging", value);
    }

    /// <summary>
    /// Option to enable Stackdriver Monitoring.
    /// </summary>
    public TerraformValue<bool>? EnableStackdriverMonitoring
    {
        get => new TerraformReference<bool>(this, "enable_stackdriver_monitoring");
        set => SetArgument("enable_stackdriver_monitoring", value);
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
    /// The resource labels for instance to use to annotate any related underlying resources,
    /// such as Compute Engine VMs.
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
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Map of additional options used to configure the behavior of Data Fusion instance.
    /// </summary>
    public TerraformMap<string> Options
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "options").ResolveNodes(ctx));
        set => SetArgument("options", value);
    }

    /// <summary>
    /// Specifies whether the Data Fusion instance should be private. If set to
    /// true, all Data Fusion nodes will have private IP addresses and will not be
    /// able to access the public internet.
    /// </summary>
    public TerraformValue<bool>? PrivateInstance
    {
        get => new TerraformReference<bool>(this, "private_instance");
        set => SetArgument("private_instance", value);
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
    /// The region of the Data Fusion instance.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Represents the type of Data Fusion instance. Each type is configured with
    /// the default settings for processing and memory.
    /// - BASIC: Basic Data Fusion instance. In Basic type, the user will be able to create data pipelines
    /// using point and click UI. However, there are certain limitations, such as fewer number
    /// of concurrent pipelines, no support for streaming pipelines, etc.
    /// - ENTERPRISE: Enterprise Data Fusion instance. In Enterprise type, the user will have more features
    /// available, such as support for streaming pipelines, higher number of concurrent pipelines, etc.
    /// - DEVELOPER: Developer Data Fusion instance. In Developer type, the user will have all features available but
    /// with restrictive capabilities. This is to help enterprises design and develop their data ingestion and integration
    /// pipelines at low cost. Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;, &amp;quot;DEVELOPER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Current version of the Data Fusion.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Name of the zone in which the Data Fusion instance will be created. Only DEVELOPER instances use this field.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Endpoint on which the REST APIs is accessible.
    /// </summary>
    public TerraformValue<string> ApiEndpoint
    {
        get => new TerraformReference<string>(this, "api_endpoint");
    }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cloud Storage bucket generated by Data Fusion in the customer project.
    /// </summary>
    public TerraformValue<string> GcsBucket
    {
        get => new TerraformReference<string>(this, "gcs_bucket");
    }

    /// <summary>
    /// P4 service account for the customer project.
    /// </summary>
    public TerraformValue<string> P4ServiceAccount
    {
        get => new TerraformReference<string>(this, "p4_service_account");
    }

    /// <summary>
    /// Endpoint on which the Data Fusion UI and REST APIs are accessible.
    /// </summary>
    public TerraformValue<string> ServiceEndpoint
    {
        get => new TerraformReference<string>(this, "service_endpoint");
    }

    /// <summary>
    /// The current state of this Data Fusion instance.
    /// - CREATING: Instance is being created
    /// - RUNNING: Instance is running and ready for requests
    /// - FAILED: Instance creation failed
    /// - DELETING: Instance is being deleted
    /// - UPGRADING: Instance is being upgraded
    /// - RESTARTING: Instance is being restarted
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Additional information about the current state of this Data Fusion instance if available.
    /// </summary>
    public TerraformValue<string> StateMessage
    {
        get => new TerraformReference<string>(this, "state_message");
    }

    /// <summary>
    /// The name of the tenant project.
    /// </summary>
    public TerraformValue<string> TenantProjectId
    {
        get => new TerraformReference<string>(this, "tenant_project_id");
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
    /// The time the instance was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Accelerators block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataFusionInstanceAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformList<GoogleDataFusionInstanceAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// CryptoKeyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    public TerraformList<GoogleDataFusionInstanceCryptoKeyConfigBlock>? CryptoKeyConfig
    {
        get => GetArgument<TerraformList<GoogleDataFusionInstanceCryptoKeyConfigBlock>>("crypto_key_config");
        set => SetArgument("crypto_key_config", value);
    }

    /// <summary>
    /// EventPublishConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventPublishConfig block(s) allowed")]
    public TerraformList<GoogleDataFusionInstanceEventPublishConfigBlock>? EventPublishConfig
    {
        get => GetArgument<TerraformList<GoogleDataFusionInstanceEventPublishConfigBlock>>("event_publish_config");
        set => SetArgument("event_publish_config", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleDataFusionInstanceNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleDataFusionInstanceNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataFusionInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataFusionInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
