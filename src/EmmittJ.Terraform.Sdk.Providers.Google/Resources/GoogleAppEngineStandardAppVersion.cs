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
    public TerraformLiteralProperty<bool>? AppEngineApis
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("app_engine_apis");
        set => this.WithProperty("app_engine_apis", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeleteServiceOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_service_on_destroy");
        set => this.WithProperty("delete_service_on_destroy", value);
    }

    /// <summary>
    /// Environment variables available to the application.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? EnvVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("env_variables");
        set => this.WithProperty("env_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? InboundServices
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("inbound_services");
        set => this.WithProperty("inbound_services", value);
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public TerraformLiteralProperty<bool>? NoopOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("noop_on_destroy");
        set => this.WithProperty("noop_on_destroy", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Desired runtime. Example python27.
    /// </summary>
    public TerraformLiteralProperty<string>? Runtime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? RuntimeApiVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_api_version");
        set => this.WithProperty("runtime_api_version", value);
    }

    /// <summary>
    /// AppEngine service resource
    /// </summary>
    public TerraformLiteralProperty<string>? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    public TerraformLiteralProperty<bool>? Threadsafe
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("threadsafe");
        set => this.WithProperty("threadsafe", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
