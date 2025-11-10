using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for name_node in .
/// Nesting mode: set
/// </summary>
public class AwsDatasyncLocationHdfsNameNodeBlock : TerraformBlock
{
    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

}

/// <summary>
/// Block type for qop_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationHdfsQopConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The data_transfer_protection attribute.
    /// </summary>
    public TerraformProperty<string>? DataTransferProtection
    {
        get => GetProperty<TerraformProperty<string>>("data_transfer_protection");
        set => WithProperty("data_transfer_protection", value);
    }

    /// <summary>
    /// The rpc_protection attribute.
    /// </summary>
    public TerraformProperty<string>? RpcProtection
    {
        get => GetProperty<TerraformProperty<string>>("rpc_protection");
        set => WithProperty("rpc_protection", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_hdfs resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncLocationHdfs : TerraformResource
{
    public AwsDatasyncLocationHdfs(string name) : base("aws_datasync_location_hdfs", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public HashSet<TerraformProperty<string>>? AgentArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    public TerraformProperty<double>? BlockSize
    {
        get => GetProperty<TerraformProperty<double>>("block_size");
        set => this.WithProperty("block_size", value);
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
    /// The kerberos_keytab attribute.
    /// </summary>
    public TerraformProperty<string>? KerberosKeytab
    {
        get => GetProperty<TerraformProperty<string>>("kerberos_keytab");
        set => this.WithProperty("kerberos_keytab", value);
    }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? KerberosKeytabBase64
    {
        get => GetProperty<TerraformProperty<string>>("kerberos_keytab_base64");
        set => this.WithProperty("kerberos_keytab_base64", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    public TerraformProperty<string>? KerberosKrb5Conf
    {
        get => GetProperty<TerraformProperty<string>>("kerberos_krb5_conf");
        set => this.WithProperty("kerberos_krb5_conf", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? KerberosKrb5ConfBase64
    {
        get => GetProperty<TerraformProperty<string>>("kerberos_krb5_conf_base64");
        set => this.WithProperty("kerberos_krb5_conf_base64", value);
    }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    public TerraformProperty<string>? KerberosPrincipal
    {
        get => GetProperty<TerraformProperty<string>>("kerberos_principal");
        set => this.WithProperty("kerberos_principal", value);
    }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyProviderUri
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_provider_uri");
        set => this.WithProperty("kms_key_provider_uri", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicationFactor
    {
        get => GetProperty<TerraformProperty<double>>("replication_factor");
        set => this.WithProperty("replication_factor", value);
    }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    public TerraformProperty<string>? SimpleUser
    {
        get => GetProperty<TerraformProperty<string>>("simple_user");
        set => this.WithProperty("simple_user", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformProperty<string>? Subdirectory
    {
        get => GetProperty<TerraformProperty<string>>("subdirectory");
        set => this.WithProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for name_node.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NameNode block(s) required")]
    public HashSet<AwsDatasyncLocationHdfsNameNodeBlock>? NameNode
    {
        get => GetProperty<HashSet<AwsDatasyncLocationHdfsNameNodeBlock>>("name_node");
        set => this.WithProperty("name_node", value);
    }

    /// <summary>
    /// Block for qop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QopConfiguration block(s) allowed")]
    public List<AwsDatasyncLocationHdfsQopConfigurationBlock>? QopConfiguration
    {
        get => GetProperty<List<AwsDatasyncLocationHdfsQopConfigurationBlock>>("qop_configuration");
        set => this.WithProperty("qop_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
