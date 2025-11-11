using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlSslCertTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_sql_ssl_cert resource.
/// </summary>
public class GoogleSqlSslCert : TerraformResource
{
    public GoogleSqlSslCert(string name) : base("google_sql_ssl_cert", name)
    {
    }

    /// <summary>
    /// The common name to be used in the certificate to identify the client. Constrained to [a-zA-Z.-_ ]+. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    [TerraformPropertyName("common_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CommonName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSqlSslCertTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The actual certificate data for this client certificate.
    /// </summary>
    [TerraformPropertyName("cert")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Cert => new TerraformReference(this, "cert");

    /// <summary>
    /// The serial number extracted from the certificate data.
    /// </summary>
    [TerraformPropertyName("cert_serial_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertSerialNumber => new TerraformReference(this, "cert_serial_number");

    /// <summary>
    /// The time when the certificate was created in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The time when the certificate expires in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationTime => new TerraformReference(this, "expiration_time");

    /// <summary>
    /// The private key associated with the client certificate.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateKey => new TerraformReference(this, "private_key");

    /// <summary>
    /// The CA cert of the server this client cert was generated from.
    /// </summary>
    [TerraformPropertyName("server_ca_cert")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServerCaCert => new TerraformReference(this, "server_ca_cert");

    /// <summary>
    /// The SHA1 Fingerprint of the certificate.
    /// </summary>
    [TerraformPropertyName("sha1_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sha1Fingerprint => new TerraformReference(this, "sha1_fingerprint");

}
