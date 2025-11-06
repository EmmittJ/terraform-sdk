using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_app_engine_standard_app_version resource.
/// </summary>
public class GoogleAppEngineStandardAppVersion : TerraformResource
{
    public GoogleAppEngineStandardAppVersion(string name) : base("google_app_engine_standard_app_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Allows App Engine second generation runtimes to access the legacy bundled services.
    /// </summary>
    public bool? AppEngineApis
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("app_engine_apis")?.Value;
        set => this.WithProperty("app_engine_apis", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public bool? DeleteServiceOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_service_on_destroy")?.Value;
        set => this.WithProperty("delete_service_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Environment variables available to the application.
    /// </summary>
    public Dictionary<string, string>? EnvVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("env_variables")?.Value;
        set => this.WithProperty("env_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public HashSet<string>? InboundServices
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("inbound_services")?.Value;
        set => this.WithProperty("inbound_services", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    public string? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class")?.Value;
        set => this.WithProperty("instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public bool? NoopOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("noop_on_destroy")?.Value;
        set => this.WithProperty("noop_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Desired runtime. Example python27.
    /// </summary>
    public string? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime")?.Value;
        set => this.WithProperty("runtime", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public string? RuntimeApiVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_api_version")?.Value;
        set => this.WithProperty("runtime_api_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// AppEngine service resource
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    public bool? Threadsafe
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("threadsafe")?.Value;
        set => this.WithProperty("threadsafe", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public string? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id")?.Value;
        set => this.WithProperty("version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
