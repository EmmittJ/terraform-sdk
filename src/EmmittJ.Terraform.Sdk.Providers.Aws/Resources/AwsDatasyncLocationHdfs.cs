using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_hdfs resource.
/// </summary>
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
    public TerraformLiteralProperty<HashSet<string>>? AgentArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BlockSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("block_size");
        set => this.WithProperty("block_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KerberosKeytab
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_keytab");
        set => this.WithProperty("kerberos_keytab", value);
    }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KerberosKeytabBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_keytab_base64");
        set => this.WithProperty("kerberos_keytab_base64", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KerberosKrb5Conf
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_krb5_conf");
        set => this.WithProperty("kerberos_krb5_conf", value);
    }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KerberosKrb5ConfBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_krb5_conf_base64");
        set => this.WithProperty("kerberos_krb5_conf_base64", value);
    }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KerberosPrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_principal");
        set => this.WithProperty("kerberos_principal", value);
    }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyProviderUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_provider_uri");
        set => this.WithProperty("kms_key_provider_uri", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReplicationFactor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replication_factor");
        set => this.WithProperty("replication_factor", value);
    }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SimpleUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("simple_user");
        set => this.WithProperty("simple_user", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Subdirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subdirectory");
        set => this.WithProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
