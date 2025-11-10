using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_web_pubsub.
/// </summary>
public class AzurermWebPubsubDataSource : TerraformDataSource
{
    public AzurermWebPubsubDataSource(string name) : base("azurerm_web_pubsub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aad_auth_enabled");
        this.DeclareOutput("capacity");
        this.DeclareOutput("external_ip");
        this.DeclareOutput("hostname");
        this.DeclareOutput("local_auth_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("public_port");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("server_port");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("tls_client_cert_enabled");
        this.DeclareOutput("version");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWebPubsubDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    public TerraformExpression AadAuthEnabled => this["aad_auth_enabled"];

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformExpression Capacity => this["capacity"];

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    public TerraformExpression ExternalIp => this["external_ip"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformExpression LocalAuthEnabled => this["local_auth_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

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
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    public TerraformExpression TlsClientCertEnabled => this["tls_client_cert_enabled"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
