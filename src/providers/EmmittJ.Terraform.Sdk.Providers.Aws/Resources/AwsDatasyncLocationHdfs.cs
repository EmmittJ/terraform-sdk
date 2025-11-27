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
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
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
    public TerraformValue<string> DataTransferProtection
    {
        get => new TerraformReference<string>(this, "data_transfer_protection");
        set => SetArgument("data_transfer_protection", value);
    }

    /// <summary>
    /// The rpc_protection attribute.
    /// </summary>
    public TerraformValue<string> RpcProtection
    {
        get => new TerraformReference<string>(this, "rpc_protection");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "agent_arns").ResolveNodes(ctx));
        set => SetArgument("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    public TerraformValue<double>? BlockSize
    {
        get => new TerraformReference<double>(this, "block_size");
        set => SetArgument("block_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKeytab
    {
        get => new TerraformReference<string>(this, "kerberos_keytab");
        set => SetArgument("kerberos_keytab", value);
    }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKeytabBase64
    {
        get => new TerraformReference<string>(this, "kerberos_keytab_base64");
        set => SetArgument("kerberos_keytab_base64", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKrb5Conf
    {
        get => new TerraformReference<string>(this, "kerberos_krb5_conf");
        set => SetArgument("kerberos_krb5_conf", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    public TerraformValue<string>? KerberosKrb5ConfBase64
    {
        get => new TerraformReference<string>(this, "kerberos_krb5_conf_base64");
        set => SetArgument("kerberos_krb5_conf_base64", value);
    }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    public TerraformValue<string>? KerberosPrincipal
    {
        get => new TerraformReference<string>(this, "kerberos_principal");
        set => SetArgument("kerberos_principal", value);
    }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyProviderUri
    {
        get => new TerraformReference<string>(this, "kms_key_provider_uri");
        set => SetArgument("kms_key_provider_uri", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public TerraformValue<double>? ReplicationFactor
    {
        get => new TerraformReference<double>(this, "replication_factor");
        set => SetArgument("replication_factor", value);
    }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    public TerraformValue<string>? SimpleUser
    {
        get => new TerraformReference<string>(this, "simple_user");
        set => SetArgument("simple_user", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => new TerraformReference<string>(this, "subdirectory");
        set => SetArgument("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

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
