using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_app_engine_application resource.
/// </summary>
public class GoogleAppEngineApplication : TerraformResource
{
    public GoogleAppEngineApplication(string name) : base("google_app_engine_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_id");
        this.DeclareOutput("code_bucket");
        this.DeclareOutput("default_bucket");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("gcr_domain");
        this.DeclareOutput("name");
        this.DeclareOutput("url_dispatch_rule");
    }

    /// <summary>
    /// The domain to authenticate users with when using App Engine&#39;s User API.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_domain");
        set => this.WithProperty("auth_domain", value);
    }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_type");
        set => this.WithProperty("database_type", value);
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
    /// The location to serve the app from.
    /// </summary>
    public TerraformLiteralProperty<string>? LocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_id");
        set => this.WithProperty("location_id", value);
    }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    public TerraformLiteralProperty<string>? ServingStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("serving_status");
        set => this.WithProperty("serving_status", value);
    }

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    public TerraformLiteralProperty<string>? SslPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_policy");
        set => this.WithProperty("ssl_policy", value);
    }

    /// <summary>
    /// Identifier of the app.
    /// </summary>
    public TerraformExpression AppId => this["app_id"];

    /// <summary>
    /// The GCS bucket code is being stored in for this app.
    /// </summary>
    public TerraformExpression CodeBucket => this["code_bucket"];

    /// <summary>
    /// The GCS bucket content is being stored in for this app.
    /// </summary>
    public TerraformExpression DefaultBucket => this["default_bucket"];

    /// <summary>
    /// The default hostname for this app.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The GCR domain used for storing managed Docker images for this app.
    /// </summary>
    public TerraformExpression GcrDomain => this["gcr_domain"];

    /// <summary>
    /// Unique name of the app.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// A list of dispatch rule blocks. Each block has a domain, path, and service field.
    /// </summary>
    public TerraformExpression UrlDispatchRule => this["url_dispatch_rule"];

}
