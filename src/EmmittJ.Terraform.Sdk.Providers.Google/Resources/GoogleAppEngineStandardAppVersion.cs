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
    public TerraformProperty<bool>? AppEngineApis
    {
        get => GetProperty<TerraformProperty<bool>>("app_engine_apis");
        set => this.WithProperty("app_engine_apis", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public TerraformProperty<bool>? DeleteServiceOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("delete_service_on_destroy");
        set => this.WithProperty("delete_service_on_destroy", value);
    }

    /// <summary>
    /// Environment variables available to the application.
    /// </summary>
    public TerraformMapProperty<string>? EnvVariables
    {
        get => GetProperty<TerraformMapProperty<string>>("env_variables");
        set => this.WithProperty("env_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public TerraformProperty<HashSet<string>>? InboundServices
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("inbound_services");
        set => this.WithProperty("inbound_services", value);
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    public TerraformProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public TerraformProperty<bool>? NoopOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("noop_on_destroy");
        set => this.WithProperty("noop_on_destroy", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Desired runtime. Example python27.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        get => GetProperty<TerraformProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public TerraformProperty<string>? RuntimeApiVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_api_version");
        set => this.WithProperty("runtime_api_version", value);
    }

    /// <summary>
    /// AppEngine service resource
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    public TerraformProperty<bool>? Threadsafe
    {
        get => GetProperty<TerraformProperty<bool>>("threadsafe");
        set => this.WithProperty("threadsafe", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
