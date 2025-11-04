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
    public Dictionary<string, string>? BetaSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("beta_settings")?.Value;
        set => this.WithProperty("beta_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Duration that static files should be cached by web proxies and browsers.
    /// Only applicable if the corresponding StaticFilesHandler does not specify its own expiration time.
    /// </summary>
    public string? DefaultExpiration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_expiration")?.Value;
        set => this.WithProperty("default_expiration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Environment variables available to the application.  As these are not returned in the API request, Terraform will not detect any changes made outside of the Terraform config.
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
    /// ManualScaling: B1, B2, B4, B8, B4_1G
    /// Defaults to F1 for AutomaticScaling and B1 for ManualScaling.
    /// </summary>
    public string? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class")?.Value;
        set => this.WithProperty("instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.
    /// </summary>
    public string? NobuildFilesRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nobuild_files_regex")?.Value;
        set => this.WithProperty("nobuild_files_regex", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The channel of the runtime to use. Only available for some runtimes.
    /// </summary>
    public string? RuntimeChannel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_channel")?.Value;
        set => this.WithProperty("runtime_channel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path or name of the app&#39;s main executable.
    /// </summary>
    public string? RuntimeMainExecutablePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_main_executable_path")?.Value;
        set => this.WithProperty("runtime_main_executable_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// AppEngine service resource. Can contain numbers, letters, and hyphens.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as
    /// default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Current serving status of this version. Only the versions with a SERVING status create instances and can be billed. Default value: &amp;quot;SERVING&amp;quot; Possible values: [&amp;quot;SERVING&amp;quot;, &amp;quot;STOPPED&amp;quot;]
    /// </summary>
    public string? ServingStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("serving_status")?.Value;
        set => this.WithProperty("serving_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens.
    /// Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
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
