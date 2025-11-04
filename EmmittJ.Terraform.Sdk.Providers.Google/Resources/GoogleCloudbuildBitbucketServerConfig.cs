using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloudbuild_bitbucket_server_config resource.
/// </summary>
public class GoogleCloudbuildBitbucketServerConfig : TerraformResource
{
    public GoogleCloudbuildBitbucketServerConfig(string name) : base("google_cloudbuild_bitbucket_server_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("webhook_key");
    }

    /// <summary>
    /// Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be changed.
    /// Changing this field will result in deleting/ recreating the resource.
    /// </summary>
    public string? ApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key")?.Value;
        set => this.WithProperty("api_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the BitbucketServerConfig, which will become the final component of the BitbucketServerConfig&#39;s resource name.
    /// </summary>
    public string? ConfigId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_id")?.Value;
        set => this.WithProperty("config_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be changed.
    /// If you need to change it, please create another BitbucketServerConfig.
    /// </summary>
    public string? HostUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_uri")?.Value;
        set => this.WithProperty("host_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location of this bitbucket server config.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be enabled for private service connection.
    /// This should be set if the Bitbucket Server instance is hosted on-premises and not reachable by public internet. If this field is left empty,
    /// no network peering will occur and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
    /// projects/{project}/global/networks/{network}, where {project} is a project number or id and {network} is the name of a VPC network in the project.
    /// </summary>
    public string? PeeredNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peered_network")?.Value;
        set => this.WithProperty("peered_network", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the extension can be one of .pem, .cer, or .crt.
    /// </summary>
    public string? SslCa
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_ca")?.Value;
        set => this.WithProperty("ssl_ca", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Username of the account Cloud Build will use on Bitbucket Server.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name for the config.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
    /// </summary>
    public TerraformExpression WebhookKey => this["webhook_key"];

}
