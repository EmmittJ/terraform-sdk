using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for auth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public TerraformProperty<string>? AuthKey
    {
        set => SetProperty("auth_key", value);
    }

    /// <summary>
    /// authType of the Connection Possible values: [&amp;quot;AUTH_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;USER_PASSWORD&amp;quot;, &amp;quot;OAUTH2_JWT_BEARER&amp;quot;, &amp;quot;OAUTH2_CLIENT_CREDENTIALS&amp;quot;, &amp;quot;SSH_PUBLIC_KEY&amp;quot;, &amp;quot;OAUTH2_AUTH_CODE_FLOW&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        set => SetProperty("auth_type", value);
    }

}

/// <summary>
/// Block type for config_variable in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionConfigVariableBlock : TerraformBlock
{
    /// <summary>
    /// Boolean Value of configVariable
    /// </summary>
    public TerraformProperty<bool>? BooleanValue
    {
        set => SetProperty("boolean_value", value);
    }

    /// <summary>
    /// Integer Value of configVariable
    /// </summary>
    public TerraformProperty<double>? IntegerValue
    {
        set => SetProperty("integer_value", value);
    }

    /// <summary>
    /// Key for the configVariable
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// String Value of configVariabley
    /// </summary>
    public TerraformProperty<string>? StringValue
    {
        set => SetProperty("string_value", value);
    }

}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The key is the destination identifier that is supported by the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

}

/// <summary>
/// Block type for eventing_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionEventingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Enrichment Enabled.
    /// </summary>
    public TerraformProperty<bool>? EnrichmentEnabled
    {
        set => SetProperty("enrichment_enabled", value);
    }

}

/// <summary>
/// Block type for lock_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionLockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Indicates whether or not the connection is locked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locked is required")]
    public required TerraformProperty<bool> Locked
    {
        set => SetProperty("locked", value);
    }

    /// <summary>
    /// Describes why a connection is locked.
    /// </summary>
    public TerraformProperty<string>? Reason
    {
        set => SetProperty("reason", value);
    }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Enabled represents whether logging is enabled or not for a connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Log configuration level. Possible values: [&amp;quot;LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;DEBUG&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Level
    {
        set => SetProperty("level", value);
    }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    public TerraformProperty<double>? MaxNodeCount
    {
        set => SetProperty("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the runtime nodes.
    /// </summary>
    public TerraformProperty<double>? MinNodeCount
    {
        set => SetProperty("min_node_count", value);
    }

}

/// <summary>
/// Block type for ssl_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationConnectorsConnectionSslConfigBlock : TerraformBlock
{
    /// <summary>
    /// Type of Client Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ClientCertType
    {
        set => SetProperty("client_cert_type", value);
    }

    /// <summary>
    /// Type of Server Cert (PEM/JKS/.. etc.) Possible values: [&amp;quot;PEM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ServerCertType
    {
        set => SetProperty("server_cert_type", value);
    }

    /// <summary>
    /// Enum for Trust Model Possible values: [&amp;quot;PUBLIC&amp;quot;, &amp;quot;PRIVATE&amp;quot;, &amp;quot;INSECURE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TrustModel
    {
        set => SetProperty("trust_model", value);
    }

    /// <summary>
    /// Enum for controlling the SSL Type (TLS/MTLS) Possible values: [&amp;quot;TLS&amp;quot;, &amp;quot;MTLS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Bool for enabling SSL
    /// </summary>
    public TerraformProperty<bool>? UseSsl
    {
        set => SetProperty("use_ssl", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationConnectorsConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_integration_connectors_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIntegrationConnectorsConnection : TerraformResource
{
    public GoogleIntegrationConnectorsConnection(string name) : base("google_integration_connectors_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("connection_revision");
        SetOutput("connector_version_infra_config");
        SetOutput("connector_version_launch_stage");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("eventing_runtime_data");
        SetOutput("service_directory");
        SetOutput("status");
        SetOutput("subscription_type");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("connector_version");
        SetOutput("description");
        SetOutput("eventing_enablement_type");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("service_account");
        SetOutput("suspended");
    }

    /// <summary>
    /// connectorVersion of the Connector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorVersion is required")]
    public required TerraformProperty<string> ConnectorVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connector_version");
        set => SetProperty("connector_version", value);
    }

    /// <summary>
    /// An arbitrary description for the Connection.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Eventing enablement type. Will be nil if eventing is not enabled. Possible values: [&amp;quot;EVENTING_AND_CONNECTION&amp;quot;, &amp;quot;ONLY_EVENTING&amp;quot;]
    /// </summary>
    public TerraformProperty<string> EventingEnablementType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventing_enablement_type");
        set => SetProperty("eventing_enablement_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location in which Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Name of Connection needs to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Service account needed for runtime plane to access Google Cloud resources.
    /// </summary>
    public TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Suspended indicates if a user has suspended a connection or not.
    /// </summary>
    public TerraformProperty<bool> Suspended
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("suspended");
        set => SetProperty("suspended", value);
    }

    /// <summary>
    /// Block for auth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    public List<GoogleIntegrationConnectorsConnectionAuthConfigBlock>? AuthConfig
    {
        set => SetProperty("auth_config", value);
    }

    /// <summary>
    /// Block for config_variable.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleIntegrationConnectorsConnectionConfigVariableBlock>? ConfigVariable
    {
        set => SetProperty("config_variable", value);
    }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleIntegrationConnectorsConnectionDestinationConfigBlock>? DestinationConfig
    {
        set => SetProperty("destination_config", value);
    }

    /// <summary>
    /// Block for eventing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventingConfig block(s) allowed")]
    public List<GoogleIntegrationConnectorsConnectionEventingConfigBlock>? EventingConfig
    {
        set => SetProperty("eventing_config", value);
    }

    /// <summary>
    /// Block for lock_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LockConfig block(s) allowed")]
    public List<GoogleIntegrationConnectorsConnectionLockConfigBlock>? LockConfig
    {
        set => SetProperty("lock_config", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<GoogleIntegrationConnectorsConnectionLogConfigBlock>? LogConfig
    {
        set => SetProperty("log_config", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleIntegrationConnectorsConnectionNodeConfigBlock>? NodeConfig
    {
        set => SetProperty("node_config", value);
    }

    /// <summary>
    /// Block for ssl_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    public List<GoogleIntegrationConnectorsConnectionSslConfigBlock>? SslConfig
    {
        set => SetProperty("ssl_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIntegrationConnectorsConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Connection revision. This field is only updated when the connection is created or updated by User.
    /// </summary>
    public TerraformExpression ConnectionRevision => this["connection_revision"];

    /// <summary>
    /// This configuration provides infra configs like rate limit threshold which need to be configurable for every connector version.
    /// </summary>
    public TerraformExpression ConnectorVersionInfraConfig => this["connector_version_infra_config"];

    /// <summary>
    /// Flag to mark the version indicating the launch stage.
    /// </summary>
    public TerraformExpression ConnectorVersionLaunchStage => this["connector_version_launch_stage"];

    /// <summary>
    /// Time the Namespace was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Eventing Runtime Data.
    /// </summary>
    public TerraformExpression EventingRuntimeData => this["eventing_runtime_data"];

    /// <summary>
    /// The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB address.
    /// e.g. &amp;quot;projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors&amp;quot;
    /// </summary>
    public TerraformExpression ServiceDirectory => this["service_directory"];

    /// <summary>
    /// Status of the Integration Connector.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// This subscription type enum states the subscription type of the project.
    /// </summary>
    public TerraformExpression SubscriptionType => this["subscription_type"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the Namespace was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
