using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for auth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlock
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    [TerraformPropertyName("auth_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthKey { get; set; }

    /// <summary>
    /// authType of the Connection Possible values: [&amp;quot;AUTH_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;USER_PASSWORD&amp;quot;, &amp;quot;OAUTH2_JWT_BEARER&amp;quot;, &amp;quot;OAUTH2_CLIENT_CREDENTIALS&amp;quot;, &amp;quot;SSH_PUBLIC_KEY&amp;quot;, &amp;quot;OAUTH2_AUTH_CODE_FLOW&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformPropertyName("auth_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Block type for config_variable in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionConfigVariableBlock
{
    /// <summary>
    /// Boolean Value of configVariable
    /// </summary>
    [TerraformPropertyName("boolean_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BooleanValue { get; set; }

    /// <summary>
    /// Integer Value of configVariable
    /// </summary>
    [TerraformPropertyName("integer_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IntegerValue { get; set; }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// String Value of configVariabley
    /// </summary>
    [TerraformPropertyName("string_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StringValue { get; set; }

}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionDestinationConfigBlock
{
    /// <summary>
    /// The key is the destination identifier that is supported by the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for eventing_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlock
{
    /// <summary>
    /// Enrichment Enabled.
    /// </summary>
    [TerraformPropertyName("enrichment_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnrichmentEnabled { get; set; }

}

/// <summary>
/// Block type for lock_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionLockConfigBlock
{
    /// <summary>
    /// Indicates whether or not the connection is locked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locked is required")]
    [TerraformPropertyName("locked")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Locked { get; set; }

    /// <summary>
    /// Describes why a connection is locked.
    /// </summary>
    [TerraformPropertyName("reason")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Reason { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionLogConfigBlock
{
    /// <summary>
    /// Enabled represents whether logging is enabled or not for a connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Log configuration level. Possible values: [&amp;quot;LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;DEBUG&amp;quot;]
    /// </summary>
    [TerraformPropertyName("level")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Level { get; set; } = default!;

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionNodeConfigBlock
{
    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    [TerraformPropertyName("max_node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxNodeCount { get; set; } = default!;

    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    [TerraformPropertyName("min_node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MinNodeCount { get; set; } = default!;

}

/// <summary>
/// Block type for ssl_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlock
{
    /// <summary>
    /// Type of Client Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("client_cert_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientCertType { get; set; }

    /// <summary>
    /// Type of Server Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("server_cert_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerCertType { get; set; }

    /// <summary>
    /// Enum for Trust Model Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;, &amp;quot;INSECURE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("trust_model")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrustModel { get; set; }

    /// <summary>
    /// Enum for controlling the SSL Type (TLS/MTLS) Possible values: [&amp;quot;TLS&amp;quot;, &amp;quot;MTLS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Bool for enabling SSL
    /// </summary>
    [TerraformPropertyName("use_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseSsl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationConnectorsConnectionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_integration_connectors_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIntegrationConnectorsConnection : TerraformResource
{
    public GoogleIntegrationConnectorsConnection(string name) : base("google_integration_connectors_connection", name)
    {
    }

    /// <summary>
    /// connectorVersion of the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorVersion is required")]
    [TerraformPropertyName("connector_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectorVersion { get; set; }

    /// <summary>
    /// An arbitrary description for the Connection.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Eventing enablement type. Will be nil if eventing is not enabled. Possible values: [&amp;quot;EVENTING_AND_CONNECTION&amp;quot;, &amp;quot;ONLY_EVENTING&amp;quot;]
    /// </summary>
    [TerraformPropertyName("eventing_enablement_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventingEnablementType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Location in which Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Service account needed for runtime plane to access Google Cloud resources.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccount { get; set; } = default!;

    /// <summary>
    /// Suspended indicates if a user has suspended a connection or not.
    /// </summary>
    [TerraformPropertyName("suspended")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Suspended { get; set; }

    /// <summary>
    /// Block for auth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    [TerraformPropertyName("auth_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionAuthConfigBlock>>? AuthConfig { get; set; }

    /// <summary>
    /// Block for config_variable.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("config_variable")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionConfigVariableBlock>>? ConfigVariable { get; set; }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("destination_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionDestinationConfigBlock>>? DestinationConfig { get; set; }

    /// <summary>
    /// Block for eventing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventingConfig block(s) allowed")]
    [TerraformPropertyName("eventing_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionEventingConfigBlock>>? EventingConfig { get; set; }

    /// <summary>
    /// Block for lock_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfig block(s) allowed")]
    [TerraformPropertyName("lock_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionLockConfigBlock>>? LockConfig { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionLogConfigBlock>>? LogConfig { get; set; }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionNodeConfigBlock>>? NodeConfig { get; set; }

    /// <summary>
    /// Block for ssl_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    [TerraformPropertyName("ssl_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationConnectorsConnectionSslConfigBlock>>? SslConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIntegrationConnectorsConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Connection revision. This field is only updated when the connection is created or updated by User.
    /// </summary>
    [TerraformPropertyName("connection_revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionRevision => new TerraformReference(this, "connection_revision");

    /// <summary>
    /// This configuration provides infra configs like rate limit threshold which need to be configurable for every connector version.
    /// </summary>
    [TerraformPropertyName("connector_version_infra_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConnectorVersionInfraConfig => new TerraformReference(this, "connector_version_infra_config");

    /// <summary>
    /// Flag to mark the version indicating the launch stage.
    /// </summary>
    [TerraformPropertyName("connector_version_launch_stage")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectorVersionLaunchStage => new TerraformReference(this, "connector_version_launch_stage");

    /// <summary>
    /// Time the Namespace was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Eventing Runtime Data.
    /// </summary>
    [TerraformPropertyName("eventing_runtime_data")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EventingRuntimeData => new TerraformReference(this, "eventing_runtime_data");

    /// <summary>
    /// The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB address.
    /// e.g. &amp;quot;projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors&amp;quot;
    /// </summary>
    [TerraformPropertyName("service_directory")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceDirectory => new TerraformReference(this, "service_directory");

    /// <summary>
    /// Status of the Integration Connector.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Status => new TerraformReference(this, "status");

    /// <summary>
    /// This subscription type enum states the subscription type of the project.
    /// </summary>
    [TerraformPropertyName("subscription_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubscriptionType => new TerraformReference(this, "subscription_type");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Time the Namespace was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
