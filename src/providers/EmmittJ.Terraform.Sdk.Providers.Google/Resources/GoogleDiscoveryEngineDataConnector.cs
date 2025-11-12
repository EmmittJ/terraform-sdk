using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineDataConnectorEntitiesBlock() : TerraformBlock("entities")
{

    /// <summary>
    /// The name of the entity. Supported values by data source:
    /// * Salesforce: &#39;Lead&#39;, &#39;Opportunity&#39;, &#39;Contact&#39;, &#39;Account&#39;, &#39;Case&#39;, &#39;Contract&#39;, &#39;Campaign&#39;
    /// * Jira: project, issue, attachment, comment, worklog
    /// * Confluence: &#39;Content&#39;, &#39;Space&#39;
    /// </summary>
    [TerraformProperty("entity_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EntityName { get; set; }

    /// <summary>
    /// Attributes for indexing.
    /// Key: Field name.
    /// Value: The key property to map a field to, such as &#39;title&#39;, and
    /// &#39;description&#39;. Supported key properties:
    /// * &#39;title&#39;: The title for data record. This would be displayed on search
    ///   results.
    /// * &#39;description&#39;: The description for data record. This would be displayed
    ///   on search results.
    /// </summary>
    [TerraformProperty("key_property_mappings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? KeyPropertyMappings { get; set; }

    /// <summary>
    /// The parameters for the entity to facilitate data ingestion.
    /// </summary>
    [TerraformProperty("params")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Params { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineDataConnectorTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_discovery_engine_data_connector resource.
/// </summary>
public partial class GoogleDiscoveryEngineDataConnector : TerraformResource
{
    public GoogleDiscoveryEngineDataConnector(string name) : base("google_discovery_engine_data_connector", name)
    {
    }

    /// <summary>
    /// Indicates whether full syncs are paused for this connector
    /// </summary>
    [TerraformProperty("auto_run_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoRunDisabled { get; set; }

    /// <summary>
    /// The display name of the Collection.
    /// Should be human readable, used to display collections in the Console
    /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionDisplayName is required")]
    [TerraformProperty("collection_display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollectionDisplayName { get; set; }

    /// <summary>
    /// The ID to use for the Collection, which will become the final component
    /// of the Collection&#39;s resource name. A new Collection is created as
    /// part of the DataConnector setup. DataConnector is a singleton
    /// resource under Collection, managing all DataStores of the Collection.
    /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
    /// standard with a length limit of 63 characters. Otherwise, an
    /// INVALID_ARGUMENT error is returned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformProperty("collection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// The modes enabled for this connector. The possible value can be:
    /// &#39;DATA_INGESTION&#39;, &#39;ACTIONS&#39;, &#39;FEDERATED&#39;
    /// &#39;EUA&#39;, &#39;FEDERATED_AND_EUA&#39;.
    /// </summary>
    [TerraformProperty("connector_modes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ConnectorModes { get; set; }

    /// <summary>
    /// The name of the data source.
    /// Supported values: &#39;salesforce&#39;, &#39;jira&#39;, &#39;confluence&#39;, &#39;bigquery&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    [TerraformProperty("data_source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSource { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The refresh interval specifically for incremental data syncs. If unset,
    /// incremental syncs will use the default from env, set to 3hrs.
    /// The minimum is 30 minutes and maximum is 7 days. Applicable to only 3P
    /// connectors. When the refresh interval is
    /// set to the same value as the incremental refresh interval, incremental
    /// sync will be disabled.
    /// </summary>
    [TerraformProperty("incremental_refresh_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IncrementalRefreshInterval { get; set; }

    /// <summary>
    /// Indicates whether incremental syncs are paused for this connector.
    /// </summary>
    [TerraformProperty("incremental_sync_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncrementalSyncDisabled { get; set; }

    /// <summary>
    /// Params needed to access the source in the format of json string.
    /// </summary>
    [TerraformProperty("json_params")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JsonParams { get; set; }

    /// <summary>
    /// The KMS key to be used to protect the DataStores managed by this connector.
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// If this field is set and processed successfully, the DataStores created by
    /// this connector will be protected by the KMS key.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Params needed to access the source in the format of String-to-String (Key, Value) pairs.
    /// </summary>
    [TerraformProperty("params")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Params { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The refresh interval for data sync. If duration is set to 0, the data will
    /// be synced in real time. The streaming feature is not supported yet. The
    /// minimum is 30 minutes and maximum is 7 days. When the refresh interval is
    /// set to the same value as the incremental refresh interval, incremental
    /// sync will be disabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshInterval is required")]
    [TerraformProperty("refresh_interval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RefreshInterval { get; set; }

    /// <summary>
    /// Whether customer has enabled static IP addresses for this connector.
    /// </summary>
    [TerraformProperty("static_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StaticIpEnabled { get; set; }

    /// <summary>
    /// The data synchronization mode supported by the data connector. The possible value can be:
    /// &#39;PERIODIC&#39;, &#39;STREAMING&#39;.
    /// </summary>
    [TerraformProperty("sync_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SyncMode { get; set; }

    /// <summary>
    /// Block for entities.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("entities")]
    public TerraformList<GoogleDiscoveryEngineDataConnectorEntitiesBlock> Entities { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDiscoveryEngineDataConnectorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// State of the action connector. This reflects whether the action connector
    /// is initializing, active or has encountered errors. The possible value can be:
    /// &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;FAILED&#39;, &#39;RUNNING&#39;, &#39;WARNING&#39;,
    /// &#39;INITIALIZATION_FAILED&#39;, &#39;UPDATING&#39;.
    /// </summary>
    [TerraformProperty("action_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ActionState { get; }

    /// <summary>
    /// User actions that must be completed before the connector can start syncing data.
    /// The possible values can be: &#39;ALLOWLIST_STATIC_IP&#39;, &#39;ALLOWLIST_IN_SERVICE_ATTACHMENT&#39;.
    /// </summary>
    [TerraformProperty("blocking_reasons")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> BlockingReasons { get; }

    /// <summary>
    /// The type of connector. Each source can only map to one type.
    /// For example, salesforce, confluence and jira have THIRD_PARTY connector
    /// type. It is not mutable once set by system. The possible value can be:
    /// &#39;CONNECTOR_TYPE_UNSPECIFIED&#39;, &#39;THIRD_PARTY&#39;, &#39;GCP_FHIR&#39;, &#39;BIG_QUERY&#39;,
    /// &#39;GCS&#39;, &#39;GOOGLE_MAIL&#39;, &#39;GOOGLE_CALENDAR&#39;, &#39;GOOGLE_DRIVE&#39;,
    /// &#39;NATIVE_CLOUD_IDENTITY&#39;, &#39;THIRD_PARTY_FEDERATED&#39;, &#39;THIRD_PARTY_EUA&#39;, &#39;GCNV&#39;.
    /// </summary>
    [TerraformProperty("connector_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectorType { get; }

    /// <summary>
    /// Timestamp when the DataConnector was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The errors from initialization or from the latest connector run.
    /// </summary>
    [TerraformProperty("errors")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Errors { get; }

    /// <summary>
    /// For periodic connectors only, the last time a data sync was completed.
    /// </summary>
    [TerraformProperty("last_sync_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastSyncTime { get; }

    /// <summary>
    /// The most recent timestamp when this [DataConnector][] was paused,
    /// affecting all functionalities such as data synchronization.
    /// Pausing a connector has the following effects:
    ///   - All functionalities, including data synchronization, are halted.
    ///   - Any ongoing data synchronization job will be canceled.
    ///   - No future data synchronization runs will be scheduled nor can be
    /// triggered.
    /// </summary>
    [TerraformProperty("latest_pause_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestPauseTime { get; }

    /// <summary>
    /// The full resource name of the Data Connector.
    /// Format: &#39;projects/*/locations/*/collections/*/dataConnector&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The tenant project ID associated with private connectivity connectors.
    /// This project must be allowlisted by in order for the connector to function.
    /// </summary>
    [TerraformProperty("private_connectivity_project_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateConnectivityProjectId { get; }

    /// <summary>
    /// The real-time sync state. The possible values can be:
    /// &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;FAILED&#39;, &#39;RUNNING&#39;, &#39;WARNING&#39;,
    /// &#39;INITIALIZATION_FAILED&#39;, &#39;UPDATING&#39;.
    /// </summary>
    [TerraformProperty("realtime_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RealtimeState { get; }

    /// <summary>
    /// The state of connector. The possible value can be:
    /// &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;FAILED&#39;, &#39;RUNNING&#39;, &#39;WARNING&#39;,
    /// &#39;INITIALIZATION_FAILED&#39;, &#39;UPDATING&#39;.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The static IP addresses used by this connector.
    /// </summary>
    [TerraformProperty("static_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> StaticIpAddresses { get; }

    /// <summary>
    /// Timestamp when the DataConnector was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
