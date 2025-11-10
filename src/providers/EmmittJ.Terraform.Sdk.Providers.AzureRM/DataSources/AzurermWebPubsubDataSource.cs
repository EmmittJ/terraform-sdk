using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_web_pubsub.
/// </summary>
public class AzurermWebPubsubDataSource : TerraformDataSource
{
    public AzurermWebPubsubDataSource(string name) : base("azurerm_web_pubsub", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWebPubsubDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aad_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AadAuthEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "aad_auth_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Capacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "capacity");

    /// <summary>
    /// The external_ip attribute.
    /// </summary>
    [TerraformPropertyName("external_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_ip");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalAuthEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_auth_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PublicNetworkAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_network_access_enabled");

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformPropertyName("public_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PublicPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "public_port");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string");

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformPropertyName("server_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ServerPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "server_port");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_client_cert_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TlsClientCertEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "tls_client_cert_enabled");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
