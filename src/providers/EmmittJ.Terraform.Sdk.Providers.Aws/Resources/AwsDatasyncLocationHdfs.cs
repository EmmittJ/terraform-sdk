using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for name_node in .
/// Nesting mode: set
/// </summary>
public partial class AwsDatasyncLocationHdfsNameNodeBlock : TerraformBlockBase
{
    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

}

/// <summary>
/// Block type for qop_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncLocationHdfsQopConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The data_transfer_protection attribute.
    /// </summary>
    [TerraformProperty("data_transfer_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DataTransferProtection { get; set; }

    /// <summary>
    /// The rpc_protection attribute.
    /// </summary>
    [TerraformProperty("rpc_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RpcProtection { get; set; }

}

/// <summary>
/// Manages a aws_datasync_location_hdfs resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatasyncLocationHdfs : TerraformResource
{
    public AwsDatasyncLocationHdfs(string name) : base("aws_datasync_location_hdfs", name)
    {
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    [TerraformProperty("agent_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AgentArns { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    [TerraformProperty("block_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BlockSize { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    [TerraformProperty("kerberos_keytab")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KerberosKeytab { get; set; }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    [TerraformProperty("kerberos_keytab_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KerberosKeytabBase64 { get; set; }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    [TerraformProperty("kerberos_krb5_conf")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KerberosKrb5Conf { get; set; }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    [TerraformProperty("kerberos_krb5_conf_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KerberosKrb5ConfBase64 { get; set; }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    [TerraformProperty("kerberos_principal")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KerberosPrincipal { get; set; }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    [TerraformProperty("kms_key_provider_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyProviderUri { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    [TerraformProperty("replication_factor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReplicationFactor { get; set; }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    [TerraformProperty("simple_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SimpleUser { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformProperty("subdirectory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subdirectory { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for name_node.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NameNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NameNode block(s) required")]
    [TerraformProperty("name_node")]
    public partial TerraformSet<TerraformBlock<AwsDatasyncLocationHdfsNameNodeBlock>>? NameNode { get; set; }

    /// <summary>
    /// Block for qop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QopConfiguration block(s) allowed")]
    [TerraformProperty("qop_configuration")]
    public partial TerraformList<TerraformBlock<AwsDatasyncLocationHdfsQopConfigurationBlock>>? QopConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uri { get; }

}
