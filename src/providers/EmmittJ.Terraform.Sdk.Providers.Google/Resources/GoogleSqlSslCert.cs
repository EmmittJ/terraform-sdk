using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSqlSslCert.
/// Nesting mode: single
/// </summary>
public class GoogleSqlSslCertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_sql_ssl_cert Terraform resource.
/// Manages a google_sql_ssl_cert resource.
/// </summary>
public partial class GoogleSqlSslCert(string name) : TerraformResource("google_sql_ssl_cert", name)
{
    /// <summary>
    /// The common name to be used in the certificate to identify the client. Constrained to [a-zA-Z.-_ ]+. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    public required TerraformValue<string> CommonName
    {
        get => GetRequiredArgument<TerraformValue<string>>("common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The actual certificate data for this client certificate.
    /// </summary>
    public TerraformValue<string> Cert
        => AsReference("cert");

    /// <summary>
    /// The serial number extracted from the certificate data.
    /// </summary>
    public TerraformValue<string> CertSerialNumber
        => AsReference("cert_serial_number");

    /// <summary>
    /// The time when the certificate was created in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The time when the certificate expires in RFC 3339 format, for example 2012-11-15T16:19:00.094Z.
    /// </summary>
    public TerraformValue<string> ExpirationTime
        => AsReference("expiration_time");

    /// <summary>
    /// The private key associated with the client certificate.
    /// </summary>
    public TerraformValue<string> PrivateKey
        => AsReference("private_key");

    /// <summary>
    /// The CA cert of the server this client cert was generated from.
    /// </summary>
    public TerraformValue<string> ServerCaCert
        => AsReference("server_ca_cert");

    /// <summary>
    /// The SHA1 Fingerprint of the certificate.
    /// </summary>
    public TerraformValue<string> Sha1Fingerprint
        => AsReference("sha1_fingerprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSqlSslCertTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSqlSslCertTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
