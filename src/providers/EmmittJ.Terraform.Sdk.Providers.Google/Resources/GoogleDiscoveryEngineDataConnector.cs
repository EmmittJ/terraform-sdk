using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entities in GoogleDiscoveryEngineDataConnector.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataConnectorEntitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entities";

    /// <summary>
    /// The full resource name of the associated data store for the source
    /// entity.
    /// Format: &#39;projects/*/locations/*/collections/*/dataStores/*&#39;.
    /// When the connector is initialized by the DataConnectorService.SetUpDataConnector
    /// method, a DataStore is automatically created for each source entity.
    /// </summary>
    public TerraformValue<string> DataStore
    {
        get => new TerraformReference<string>(this, "data_store");
    }

    /// <summary>
    /// The name of the entity. Supported values by data source:
    /// * Salesforce: &#39;Lead&#39;, &#39;Opportunity&#39;, &#39;Contact&#39;, &#39;Account&#39;, &#39;Case&#39;, &#39;Contract&#39;, &#39;Campaign&#39;
    /// * Jira: project, issue, attachment, comment, worklog
    /// * Confluence: &#39;Content&#39;, &#39;Space&#39;
    /// </summary>
    public TerraformValue<string>? EntityName
    {
        get => new TerraformReference<string>(this, "entity_name");
        set => SetArgument("entity_name", value);
    }

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
    public TerraformMap<string>? KeyPropertyMappings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "key_property_mappings").ResolveNodes(ctx));
        set => SetArgument("key_property_mappings", value);
    }

    /// <summary>
    /// The parameters for the entity to facilitate data ingestion.
    /// </summary>
    public TerraformValue<string>? ParamsAttribute
    {
        get => new TerraformReference<string>(this, "params");
        set => SetArgument("params", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineDataConnector.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineDataConnectorTimeoutsBlock : TerraformBlock
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
/// Represents a google_discovery_engine_data_connector Terraform resource.
/// Manages a google_discovery_engine_data_connector resource.
/// </summary>
public partial class GoogleDiscoveryEngineDataConnector(string name) : TerraformResource("google_discovery_engine_data_connector", name)
{
    /// <summary>
    /// Indicates whether full syncs are paused for this connector
    /// </summary>
    public TerraformValue<bool>? AutoRunDisabled
    {
        get => new TerraformReference<bool>(this, "auto_run_disabled");
        set => SetArgument("auto_run_disabled", value);
    }

    /// <summary>
    /// The display name of the Collection.
    /// Should be human readable, used to display collections in the Console
    /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionDisplayName is required")]
    public required TerraformValue<string> CollectionDisplayName
    {
        get => new TerraformReference<string>(this, "collection_display_name");
        set => SetArgument("collection_display_name", value);
    }

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
    public required TerraformValue<string> CollectionId
    {
        get => new TerraformReference<string>(this, "collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// The modes enabled for this connector. The possible value can be:
    /// &#39;DATA_INGESTION&#39;, &#39;ACTIONS&#39;, &#39;FEDERATED&#39;
    /// &#39;EUA&#39;, &#39;FEDERATED_AND_EUA&#39;.
    /// </summary>
    public TerraformList<string>? ConnectorModes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connector_modes").ResolveNodes(ctx));
        set => SetArgument("connector_modes", value);
    }

    /// <summary>
    /// The name of the data source.
    /// Supported values: &#39;salesforce&#39;, &#39;jira&#39;, &#39;confluence&#39;, &#39;bigquery&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    public required TerraformValue<string> DataSource
    {
        get => new TerraformReference<string>(this, "data_source");
        set => SetArgument("data_source", value);
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
    /// The refresh interval specifically for incremental data syncs. If unset,
    /// incremental syncs will use the default from env, set to 3hrs.
    /// The minimum is 30 minutes and maximum is 7 days. Applicable to only 3P
    /// connectors. When the refresh interval is
    /// set to the same value as the incremental refresh interval, incremental
    /// sync will be disabled.
    /// </summary>
    public TerraformValue<string>? IncrementalRefreshInterval
    {
        get => new TerraformReference<string>(this, "incremental_refresh_interval");
        set => SetArgument("incremental_refresh_interval", value);
    }

    /// <summary>
    /// Indicates whether incremental syncs are paused for this connector.
    /// </summary>
    public TerraformValue<bool>? IncrementalSyncDisabled
    {
        get => new TerraformReference<bool>(this, "incremental_sync_disabled");
        set => SetArgument("incremental_sync_disabled", value);
    }

    /// <summary>
    /// Params needed to access the source in the format of json string.
    /// </summary>
    public TerraformValue<string>? JsonParams
    {
        get => new TerraformReference<string>(this, "json_params");
        set => SetArgument("json_params", value);
    }

    /// <summary>
    /// The KMS key to be used to protect the DataStores managed by this connector.
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// If this field is set and processed successfully, the DataStores created by
    /// this connector will be protected by the KMS key.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Params needed to access the source in the format of String-to-String (Key, Value) pairs.
    /// </summary>
    public TerraformMap<string>? ParamsAttribute
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "params").ResolveNodes(ctx));
        set => SetArgument("params", value);
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
    /// The refresh interval for data sync. If duration is set to 0, the data will
    /// be synced in real time. The streaming feature is not supported yet. The
    /// minimum is 30 minutes and maximum is 7 days. When the refresh interval is
    /// set to the same value as the incremental refresh interval, incremental
    /// sync will be disabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshInterval is required")]
    public required TerraformValue<string> RefreshInterval
    {
        get => new TerraformReference<string>(this, "refresh_interval");
        set => SetArgument("refresh_interval", value);
    }

    /// <summary>
    /// Whether customer has enabled static IP addresses for this connector.
    /// </summary>
    public TerraformValue<bool>? StaticIpEnabled
    {
        get => new TerraformReference<bool>(this, "static_ip_enabled");
        set => SetArgument("static_ip_enabled", value);
    }

    /// <summary>
    /// The data synchronization mode supported by the data connector. The possible value can be:
    /// &#39;PERIODIC&#39;, &#39;STREAMING&#39;.
    /// </summary>
    public TerraformValue<string>? SyncMode
    {
        get => new TerraformReference<string>(this, "sync_mode");
        set => SetArgument("sync_mode", value);
    }

    /// <summary>
    /// State of the action connector. This reflects whether the action connector
    /// is initializing, active or has encountered errors. The possible value can be:
    /// &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;FAILED&#39;, &#39;RUNNING&#39;, &#39;WARNING&#39;,
    /// &#39;INITIALIZATION_FAILED&#39;, &#39;UPDATING&#39;.
    /// </summary>
    public TerraformValue<string> ActionState
    {
        get => new TerraformReference<string>(this, "action_state");
    }

    /// <summary>
    /// User actions that must be completed before the connector can start syncing data.
    /// The possible values can be: &#39;ALLOWLIST_STATIC_IP&#39;, &#39;ALLOWLIST_IN_SERVICE_ATTACHMENT&#39;.
    /// </summary>
    public TerraformList<string> BlockingReasons
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "blocking_reasons").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type of connector. Each source can only map to one type.
    /// For example, salesforce, confluence and jira have THIRD_PARTY connector
    /// type. It is not mutable once set by system. The possible value can be:
    /// &#39;CONNECTOR_TYPE_UNSPECIFIED&#39;, &#39;THIRD_PARTY&#39;, &#39;GCP_FHIR&#39;, &#39;BIG_QUERY&#39;,
    /// &#39;GCS&#39;, &#39;GOOGLE_MAIL&#39;, &#39;GOOGLE_CALENDAR&#39;, &#39;GOOGLE_DRIVE&#39;,
    /// &#39;NATIVE_CLOUD_IDENTITY&#39;, &#39;THIRD_PARTY_FEDERATED&#39;, &#39;THIRD_PARTY_EUA&#39;, &#39;GCNV&#39;.
    /// </summary>
    public TerraformValue<string> ConnectorType
    {
        get => new TerraformReference<string>(this, "connector_type");
    }

    /// <summary>
    /// Timestamp when the DataConnector was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The errors from initialization or from the latest connector run.
    /// </summary>
    public TerraformList<TerraformMap<object>> Errors
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "errors").ResolveNodes(ctx));
    }

    /// <summary>
    /// For periodic connectors only, the last time a data sync was completed.
    /// </summary>
    public TerraformValue<string> LastSyncTime
    {
        get => new TerraformReference<string>(this, "last_sync_time");
    }

    /// <summary>
    /// The most recent timestamp when this [DataConnector][] was paused,
    /// affecting all functionalities such as data synchronization.
    /// Pausing a connector has the following effects:
    ///   - All functionalities, including data synchronization, are halted.
    ///   - Any ongoing data synchronization job will be canceled.
    ///   - No future data synchronization runs will be scheduled nor can be
    /// triggered.
    /// </summary>
    public TerraformValue<string> LatestPauseTime
    {
        get => new TerraformReference<string>(this, "latest_pause_time");
    }

    /// <summary>
    /// The full resource name of the Data Connector.
    /// Format: &#39;projects/*/locations/*/collections/*/dataConnector&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The tenant project ID associated with private connectivity connectors.
    /// This project must be allowlisted by in order for the connector to function.
    /// </summary>
    public TerraformValue<string> PrivateConnectivityProjectId
    {
        get => new TerraformReference<string>(this, "private_connectivity_project_id");
    }

    /// <summary>
    /// The real-time sync state. The possible values can be:
    /// &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;FAILED&#39;, &#39;RUNNING&#39;, &#39;WARNING&#39;,
    /// &#39;INITIALIZATION_FAILED&#39;, &#39;UPDATING&#39;.
    /// </summary>
    public TerraformValue<string> RealtimeState
    {
        get => new TerraformReference<string>(this, "realtime_state");
    }

    /// <summary>
    /// The state of connector. The possible value can be:
    /// &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;FAILED&#39;, &#39;RUNNING&#39;, &#39;WARNING&#39;,
    /// &#39;INITIALIZATION_FAILED&#39;, &#39;UPDATING&#39;.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The static IP addresses used by this connector.
    /// </summary>
    public TerraformList<string> StaticIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "static_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timestamp when the DataConnector was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Entities block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDiscoveryEngineDataConnectorEntitiesBlock>? Entities
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataConnectorEntitiesBlock>>("entities");
        set => SetArgument("entities", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineDataConnectorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineDataConnectorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
