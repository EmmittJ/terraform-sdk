using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_pubsub resource.
/// </summary>
public class AzurermWebPubsub : TerraformResource
{
    public AzurermWebPubsub(string name) : base("azurerm_web_pubsub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("external_ip");
        this.DeclareOutput("hostname");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("public_port");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("server_port");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AadAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("aad_auth_enabled");
        set => this.WithProperty("aad_auth_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => this.WithProperty("capacity", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsClientCertEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_client_cert_enabled");
        set => this.WithProperty("tls_client_cert_enabled", value);
    }

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    public TerraformExpression ExternalIp => this["external_ip"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    public TerraformExpression PublicPort => this["public_port"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    public TerraformExpression ServerPort => this["server_port"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
