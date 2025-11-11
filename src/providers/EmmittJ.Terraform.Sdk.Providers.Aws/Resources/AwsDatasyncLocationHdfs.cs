using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for name_node in .
/// Nesting mode: set
/// </summary>
public class AwsDatasyncLocationHdfsNameNodeBlock
{
    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Port { get; set; }

}

/// <summary>
/// Block type for qop_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationHdfsQopConfigurationBlock
{
    /// <summary>
    /// The data_transfer_protection attribute.
    /// </summary>
    [TerraformPropertyName("data_transfer_protection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DataTransferProtection { get; set; } = default!;

    /// <summary>
    /// The rpc_protection attribute.
    /// </summary>
    [TerraformPropertyName("rpc_protection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RpcProtection { get; set; } = default!;

}

/// <summary>
/// Manages a aws_datasync_location_hdfs resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncLocationHdfs : TerraformResource
{
    public AwsDatasyncLocationHdfs(string name) : base("aws_datasync_location_hdfs", name)
    {
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    [TerraformPropertyName("agent_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AgentArns { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    [TerraformPropertyName("block_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BlockSize { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_keytab")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KerberosKeytab { get; set; }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_keytab_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KerberosKeytabBase64 { get; set; }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_krb5_conf")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KerberosKrb5Conf { get; set; }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_krb5_conf_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KerberosKrb5ConfBase64 { get; set; }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_principal")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KerberosPrincipal { get; set; }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_provider_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyProviderUri { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    [TerraformPropertyName("replication_factor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReplicationFactor { get; set; }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    [TerraformPropertyName("simple_user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SimpleUser { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformPropertyName("subdirectory")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subdirectory { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for name_node.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NameNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NameNode block(s) required")]
    [TerraformPropertyName("name_node")]
    public TerraformSet<TerraformBlock<AwsDatasyncLocationHdfsNameNodeBlock>>? NameNode { get; set; }

    /// <summary>
    /// Block for qop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QopConfiguration block(s) allowed")]
    [TerraformPropertyName("qop_configuration")]
    public TerraformList<TerraformBlock<AwsDatasyncLocationHdfsQopConfigurationBlock>>? QopConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uri => new TerraformReference(this, "uri");

}
