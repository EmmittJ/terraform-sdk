using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSqlSourceRepresentationInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_sql_source_representation_instance resource.
/// </summary>
public partial class GoogleSqlSourceRepresentationInstance : TerraformResource
{
    public GoogleSqlSourceRepresentationInstance(string name) : base("google_sql_source_representation_instance", name)
    {
    }

    /// <summary>
    /// The CA certificate on the external server. Include only if SSL/TLS is used on the external server.
    /// </summary>
    [TerraformProperty("ca_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CaCertificate { get; set; }

    /// <summary>
    /// The client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    [TerraformProperty("client_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientCertificate { get; set; }

    /// <summary>
    /// The private key file for the client certificate on the external server. Required only for server-client authentication. Include only if SSL/TLS is used on the external server.
    /// </summary>
    [TerraformProperty("client_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientKey { get; set; }

    /// <summary>
    /// The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, MYSQL_8_4, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, POSTGRES_16, POSTGRES_17. Database Version Policies includes an up-to-date reference of supported versions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    [TerraformProperty("database_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseVersion { get; set; }

    /// <summary>
    /// A file in the bucket that contains the data from the external server.
    /// </summary>
    [TerraformProperty("dump_file_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DumpFilePath { get; set; }

    /// <summary>
    /// The IPv4 address and port for the external server, or the the DNS address for the external server. If the external server is hosted on Cloud SQL, the port is 5432.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformProperty("host")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Host { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the source representation instance. Use any valid Cloud SQL instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password for the replication user account.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The externally accessible port for the source database server.
    /// Defaults to 3306.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Region in which the created instance should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication user account on the external server.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Username { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSqlSourceRepresentationInstanceTimeoutsBlock>? Timeouts { get; set; }

}
