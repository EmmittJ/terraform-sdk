using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlSslCertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_sql_ssl_cert resource.
/// </summary>
public class GoogleSqlSslCert : TerraformResource
{
    public GoogleSqlSslCert(string name) : base("google_sql_ssl_cert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("cert");
        this.WithOutput("cert_serial_number");
        this.WithOutput("create_time");
        this.WithOutput("expiration_time");
        this.WithOutput("private_key");
        this.WithOutput("server_ca_cert");
        this.WithOutput("sha1_fingerprint");
    }

    /// <summary>
    /// The common name to be used in the certificate to identify the client. Constrained to [a-zA-Z.-_ ]+. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    public required TerraformProperty<string> CommonName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("common_name");
        set => this.WithProperty("common_name", value);
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
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSqlSslCertTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSqlSslCertTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The actual certificate data for this client certificate.
    /// </summary>
    public TerraformExpression Cert => this["cert"];

    /// <summary>
    /// The serial number extracted from the certificate data.
    /// </summary>
    public TerraformExpression CertSerialNumber => this["cert_serial_number"];

    /// <summary>
    /// The time when the certificate was created in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time when the certificate expires in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    public TerraformExpression ExpirationTime => this["expiration_time"];

    /// <summary>
    /// The private key associated with the client certificate.
    /// </summary>
    public TerraformExpression PrivateKey => this["private_key"];

    /// <summary>
    /// The CA cert of the server this client cert was generated from.
    /// </summary>
    public TerraformExpression ServerCaCert => this["server_ca_cert"];

    /// <summary>
    /// The SHA1 Fingerprint of the certificate.
    /// </summary>
    public TerraformExpression Sha1Fingerprint => this["sha1_fingerprint"];

}
