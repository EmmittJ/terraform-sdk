using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for auth_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionAuthConfigBlock() : TerraformBlock("auth_config")
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    [TerraformProperty("auth_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthKey { get; set; }

    /// <summary>
    /// authType of the Connection Possible values: [&amp;quot;AUTH_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;USER_PASSWORD&amp;quot;, &amp;quot;OAUTH2_JWT_BEARER&amp;quot;, &amp;quot;OAUTH2_CLIENT_CREDENTIALS&amp;quot;, &amp;quot;SSH_PUBLIC_KEY&amp;quot;, &amp;quot;OAUTH2_AUTH_CODE_FLOW&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformProperty("auth_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Block type for config_variable in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionConfigVariableBlock() : TerraformBlock("config_variable")
{
    /// <summary>
    /// Boolean Value of configVariable
    /// </summary>
    [TerraformProperty("boolean_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BooleanValue { get; set; }

    /// <summary>
    /// Integer Value of configVariable
    /// </summary>
    [TerraformProperty("integer_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IntegerValue { get; set; }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// String Value of configVariabley
    /// </summary>
    [TerraformProperty("string_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StringValue { get; set; }

}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionDestinationConfigBlock() : TerraformBlock("destination_config")
{
    /// <summary>
    /// The key is the destination identifier that is supported by the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for eventing_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionEventingConfigBlock() : TerraformBlock("eventing_config")
{
    /// <summary>
    /// Enrichment Enabled.
    /// </summary>
    [TerraformProperty("enrichment_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnrichmentEnabled { get; set; }

}

/// <summary>
/// Block type for lock_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionLockConfigBlock() : TerraformBlock("lock_config")
{
    /// <summary>
    /// Indicates whether or not the connection is locked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locked is required")]
    [TerraformProperty("locked")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Locked { get; set; }

    /// <summary>
    /// Describes why a connection is locked.
    /// </summary>
    [TerraformProperty("reason")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Reason { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionLogConfigBlock() : TerraformBlock("log_config")
{
    /// <summary>
    /// Enabled represents whether logging is enabled or not for a connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Log configuration level. Possible values: [&amp;quot;LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;DEBUG&amp;quot;]
    /// </summary>
    [TerraformProperty("level")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Level { get; set; }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionNodeConfigBlock() : TerraformBlock("node_config")
{
    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    [TerraformProperty("max_node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    [TerraformProperty("min_node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MinNodeCount { get; set; }

}

/// <summary>
/// Block type for ssl_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionSslConfigBlock() : TerraformBlock("ssl_config")
{
    /// <summary>
    /// Type of Client Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    [TerraformProperty("client_cert_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertType { get; set; }

    /// <summary>
    /// Type of Server Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    [TerraformProperty("server_cert_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerCertType { get; set; }

    /// <summary>
    /// Enum for Trust Model Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;, &amp;quot;INSECURE&amp;quot;]
    /// </summary>
    [TerraformProperty("trust_model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrustModel { get; set; }

    /// <summary>
    /// Enum for controlling the SSL Type (TLS/MTLS) Possible values: [&amp;quot;TLS&amp;quot;, &amp;quot;MTLS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Bool for enabling SSL
    /// </summary>
    [TerraformProperty("use_ssl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseSsl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIntegrationConnectorsConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_integration_connectors_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIntegrationConnectorsConnection : TerraformResource
{
    public GoogleIntegrationConnectorsConnection(string name) : base("google_integration_connectors_connection", name)
    {
    }

    /// <summary>
    /// connectorVersion of the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorVersion is required")]
    [TerraformProperty("connector_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectorVersion { get; set; }

    /// <summary>
    /// An arbitrary description for the Connection.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Eventing enablement type. Will be nil if eventing is not enabled. Possible values: [&amp;quot;EVENTING_AND_CONNECTION&amp;quot;, &amp;quot;ONLY_EVENTING&amp;quot;]
    /// </summary>
    [TerraformProperty("eventing_enablement_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventingEnablementType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location in which Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Service account needed for runtime plane to access Google Cloud resources.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Suspended indicates if a user has suspended a connection or not.
    /// </summary>
    [TerraformProperty("suspended")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Suspended { get; set; }

    /// <summary>
    /// Block for auth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    [TerraformProperty("auth_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionAuthConfigBlock> AuthConfig { get; set; } = new();

    /// <summary>
    /// Block for config_variable.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("config_variable")]
    public TerraformList<GoogleIntegrationConnectorsConnectionConfigVariableBlock> ConfigVariable { get; set; } = new();

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("destination_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionDestinationConfigBlock> DestinationConfig { get; set; } = new();

    /// <summary>
    /// Block for eventing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventingConfig block(s) allowed")]
    [TerraformProperty("eventing_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionEventingConfigBlock> EventingConfig { get; set; } = new();

    /// <summary>
    /// Block for lock_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfig block(s) allowed")]
    [TerraformProperty("lock_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionLockConfigBlock> LockConfig { get; set; } = new();

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformProperty("log_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionLogConfigBlock> LogConfig { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformProperty("node_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionNodeConfigBlock> NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for ssl_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    [TerraformProperty("ssl_config")]
    public TerraformList<GoogleIntegrationConnectorsConnectionSslConfigBlock> SslConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIntegrationConnectorsConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Connection revision. This field is only updated when the connection is created or updated by User.
    /// </summary>
    [TerraformProperty("connection_revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionRevision { get; }

    /// <summary>
    /// This configuration provides infra configs like rate limit threshold which need to be configurable for every connector version.
    /// </summary>
    [TerraformProperty("connector_version_infra_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConnectorVersionInfraConfig { get; }

    /// <summary>
    /// Flag to mark the version indicating the launch stage.
    /// </summary>
    [TerraformProperty("connector_version_launch_stage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectorVersionLaunchStage { get; }

    /// <summary>
    /// Time the Namespace was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Eventing Runtime Data.
    /// </summary>
    [TerraformProperty("eventing_runtime_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EventingRuntimeData { get; }

    /// <summary>
    /// The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB address.
    /// e.g. &amp;quot;projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors&amp;quot;
    /// </summary>
    [TerraformProperty("service_directory")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceDirectory { get; }

    /// <summary>
    /// Status of the Integration Connector.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

    /// <summary>
    /// This subscription type enum states the subscription type of the project.
    /// </summary>
    [TerraformProperty("subscription_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubscriptionType { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Time the Namespace was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
