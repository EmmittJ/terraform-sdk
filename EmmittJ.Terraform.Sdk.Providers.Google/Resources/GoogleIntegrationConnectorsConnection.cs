using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_integration_connectors_connection resource.
/// </summary>
public class GoogleIntegrationConnectorsConnection : TerraformResource
{
    public GoogleIntegrationConnectorsConnection(string name) : base("google_integration_connectors_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_revision");
        this.DeclareOutput("connector_version_infra_config");
        this.DeclareOutput("connector_version_launch_stage");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("eventing_runtime_data");
        this.DeclareOutput("service_directory");
        this.DeclareOutput("status");
        this.DeclareOutput("subscription_type");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// connectorVersion of the Connector.
    /// </summary>
    public string? ConnectorVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connector_version")?.Value;
        set => this.WithProperty("connector_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An arbitrary description for the Connection.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Eventing enablement type. Will be nil if eventing is not enabled. Possible values: [&amp;quot;EVENTING_AND_CONNECTION&amp;quot;, &amp;quot;ONLY_EVENTING&amp;quot;]
    /// </summary>
    public string? EventingEnablementType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventing_enablement_type")?.Value;
        set => this.WithProperty("eventing_enablement_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Location in which Connection needs to be created.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of Connection needs to be created.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Service account needed for runtime plane to access Google Cloud resources.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Suspended indicates if a user has suspended a connection or not.
    /// </summary>
    public bool? Suspended
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("suspended")?.Value;
        set => this.WithProperty("suspended", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
