using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_signalr_service.
/// </summary>
public class AzurermSignalrServiceDataSource : TerraformDataSource
{
    public AzurermSignalrServiceDataSource(string name) : base("azurerm_signalr_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSignalrServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The aad_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aad_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AadAuthEnabled => new TerraformReference(this, "aad_auth_enabled");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LocalAuthEnabled => new TerraformReference(this, "local_auth_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionString => new TerraformReference(this, "primary_connection_string");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The public_port attribute.
    /// </summary>
    [TerraformPropertyName("public_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PublicPort => new TerraformReference(this, "public_port");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionString => new TerraformReference(this, "secondary_connection_string");

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformPropertyName("server_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ServerPort => new TerraformReference(this, "server_port");

    /// <summary>
    /// The serverless_connection_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("serverless_connection_timeout_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ServerlessConnectionTimeoutInSeconds => new TerraformReference(this, "serverless_connection_timeout_in_seconds");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The tls_client_cert_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_client_cert_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TlsClientCertEnabled => new TerraformReference(this, "tls_client_cert_enabled");

}
