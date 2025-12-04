using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for name_node in AwsDatasyncLocationHdfs.
/// Nesting mode: set
/// </summary>
public class AwsDatasyncLocationHdfsNameNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "name_node";

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for qop_configuration in AwsDatasyncLocationHdfs.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationHdfsQopConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "qop_configuration";

    /// <summary>
    /// The data_transfer_protection attribute.
    /// </summary>
    public TerraformValue<string>? DataTransferProtection
    {
        get => GetArgument<TerraformValue<string>>("data_transfer_protection");
        set => SetArgument("data_transfer_protection", value);
    }

    /// <summary>
    /// The rpc_protection attribute.
    /// </summary>
    public TerraformValue<string>? RpcProtection
    {
        get => GetArgument<TerraformValue<string>>("rpc_protection");
        set => SetArgument("rpc_protection", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_hdfs Terraform resource.
/// Manages a aws_datasync_location_hdfs resource.
/// </summary>
public partial class AwsDatasyncLocationHdfs(string name) : TerraformResource("aws_datasync_location_hdfs", name)
{
    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public required TerraformSet<string> AgentArns
    {
        get => GetArgument<TerraformSet<string>>("agent_arns");
        set => SetArgument("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    public TerraformValue<double>? BlockSize
    {
        get => GetArgument<TerraformValue<double>>("block_size");
        set => SetArgument("block_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKeytab
    {
        get => GetArgument<TerraformValue<string>>("kerberos_keytab");
        set => SetArgument("kerberos_keytab", value);
    }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKeytabBase64
    {
        get => GetArgument<TerraformValue<string>>("kerberos_keytab_base64");
        set => SetArgument("kerberos_keytab_base64", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKrb5Conf
    {
        get => GetArgument<TerraformValue<string>>("kerberos_krb5_conf");
        set => SetArgument("kerberos_krb5_conf", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKrb5ConfBase64
    {
        get => GetArgument<TerraformValue<string>>("kerberos_krb5_conf_base64");
        set => SetArgument("kerberos_krb5_conf_base64", value);
    }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    public TerraformValue<string>? KerberosPrincipal
    {
        get => GetArgument<TerraformValue<string>>("kerberos_principal");
        set => SetArgument("kerberos_principal", value);
    }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyProviderUri
    {
        get => GetArgument<TerraformValue<string>>("kms_key_provider_uri");
        set => SetArgument("kms_key_provider_uri", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public TerraformValue<double>? ReplicationFactor
    {
        get => GetArgument<TerraformValue<double>>("replication_factor");
        set => SetArgument("replication_factor", value);
    }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    public TerraformValue<string>? SimpleUser
    {
        get => GetArgument<TerraformValue<string>>("simple_user");
        set => SetArgument("simple_user", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => GetArgument<TerraformValue<string>>("subdirectory");
        set => SetArgument("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
        => AsReference("uri");

    /// <summary>
    /// NameNode block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NameNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NameNode block(s) required")]
    public required TerraformSet<AwsDatasyncLocationHdfsNameNodeBlock> NameNode
    {
        get => GetRequiredArgument<TerraformSet<AwsDatasyncLocationHdfsNameNodeBlock>>("name_node");
        set => SetArgument("name_node", value);
    }

    /// <summary>
    /// QopConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QopConfiguration block(s) allowed")]
    public TerraformList<AwsDatasyncLocationHdfsQopConfigurationBlock>? QopConfiguration
    {
        get => GetArgument<TerraformList<AwsDatasyncLocationHdfsQopConfigurationBlock>>("qop_configuration");
        set => SetArgument("qop_configuration", value);
    }

}
