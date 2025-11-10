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
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
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
        set => SetProperty("data_transfer_protection", value);
    }

    /// <summary>
    /// The rpc_protection attribute.
    /// </summary>
    public TerraformProperty<string>? RpcProtection
    {
        set => SetProperty("rpc_protection", value);
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
        SetOutput("arn");
        SetOutput("uri");
        SetOutput("agent_arns");
        SetOutput("authentication_type");
        SetOutput("block_size");
        SetOutput("id");
        SetOutput("kerberos_keytab");
        SetOutput("kerberos_keytab_base64");
        SetOutput("kerberos_krb5_conf");
        SetOutput("kerberos_krb5_conf_base64");
        SetOutput("kerberos_principal");
        SetOutput("kms_key_provider_uri");
        SetOutput("region");
        SetOutput("replication_factor");
        SetOutput("simple_user");
        SetOutput("subdirectory");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public HashSet<TerraformProperty<string>> AgentArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("agent_arns");
        set => SetProperty("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    public TerraformProperty<double> BlockSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("block_size");
        set => SetProperty("block_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    public TerraformProperty<string> KerberosKeytab
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kerberos_keytab");
        set => SetProperty("kerberos_keytab", value);
    }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    public TerraformProperty<string> KerberosKeytabBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kerberos_keytab_base64");
        set => SetProperty("kerberos_keytab_base64", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    public TerraformProperty<string> KerberosKrb5Conf
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kerberos_krb5_conf");
        set => SetProperty("kerberos_krb5_conf", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    public TerraformProperty<string> KerberosKrb5ConfBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kerberos_krb5_conf_base64");
        set => SetProperty("kerberos_krb5_conf_base64", value);
    }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    public TerraformProperty<string> KerberosPrincipal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kerberos_principal");
        set => SetProperty("kerberos_principal", value);
    }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyProviderUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_provider_uri");
        set => SetProperty("kms_key_provider_uri", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public TerraformProperty<double> ReplicationFactor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replication_factor");
        set => SetProperty("replication_factor", value);
    }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    public TerraformProperty<string> SimpleUser
    {
        get => GetRequiredOutput<TerraformProperty<string>>("simple_user");
        set => SetProperty("simple_user", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformProperty<string> Subdirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subdirectory");
        set => SetProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for name_node.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NameNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NameNode block(s) required")]
    public HashSet<AwsDatasyncLocationHdfsNameNodeBlock>? NameNode
    {
        set => SetProperty("name_node", value);
    }

    /// <summary>
    /// Block for qop_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QopConfiguration block(s) allowed")]
    public List<AwsDatasyncLocationHdfsQopConfigurationBlock>? QopConfiguration
    {
        set => SetProperty("qop_configuration", value);
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
