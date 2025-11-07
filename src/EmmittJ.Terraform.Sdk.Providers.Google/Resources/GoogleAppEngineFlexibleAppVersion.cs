using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_app_engine_flexible_app_version resource.
/// </summary>
public class GoogleAppEngineFlexibleAppVersion : TerraformResource
{
    public GoogleAppEngineFlexibleAppVersion(string name) : base("google_app_engine_flexible_app_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Metadata settings that are supplied to this version to enable beta runtime features.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? BetaSettings
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("beta_settings");
        set => this.WithProperty("beta_settings", value);
    }

    /// <summary>
    /// Duration that static files should be cached by web proxies and browsers.
    /// Only applicable if the corresponding StaticFilesHandler does not specify its own expiration time.
    /// </summary>
    public TerraformProperty<string>? DefaultExpiration
    {
        get => GetProperty<TerraformProperty<string>>("default_expiration");
        set => this.WithProperty("default_expiration", value);
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
    /// Environment variables available to the application.  As these are not returned in the API request, Terraform will not detect any changes made outside of the Terraform config.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? EnvVariables
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("env_variables");
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
    /// ManualScaling: B1, B2, B4, B8, B4_1G
    /// Defaults to F1 for AutomaticScaling and B1 for ManualScaling.
    /// </summary>
    public TerraformProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.
    /// </summary>
    public TerraformProperty<string>? NobuildFilesRegex
    {
        get => GetProperty<TerraformProperty<string>>("nobuild_files_regex");
        set => this.WithProperty("nobuild_files_regex", value);
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
    /// The channel of the runtime to use. Only available for some runtimes.
    /// </summary>
    public TerraformProperty<string>? RuntimeChannel
    {
        get => GetProperty<TerraformProperty<string>>("runtime_channel");
        set => this.WithProperty("runtime_channel", value);
    }

    /// <summary>
    /// The path or name of the app&#39;s main executable.
    /// </summary>
    public TerraformProperty<string>? RuntimeMainExecutablePath
    {
        get => GetProperty<TerraformProperty<string>>("runtime_main_executable_path");
        set => this.WithProperty("runtime_main_executable_path", value);
    }

    /// <summary>
    /// AppEngine service resource. Can contain numbers, letters, and hyphens.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as
    /// default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Current serving status of this version. Only the versions with a SERVING status create instances and can be billed. Default value: &amp;quot;SERVING&amp;quot; Possible values: [&amp;quot;SERVING&amp;quot;, &amp;quot;STOPPED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ServingStatus
    {
        get => GetProperty<TerraformProperty<string>>("serving_status");
        set => this.WithProperty("serving_status", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens.
    /// Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
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
