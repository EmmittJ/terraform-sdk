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
    public HashSet<string>? AgentArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("agent_arns")?.Value;
        set => this.WithProperty("agent_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public string? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type")?.Value;
        set => this.WithProperty("authentication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The block_size attribute.
    /// </summary>
    public double? BlockSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("block_size")?.Value;
        set => this.WithProperty("block_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kerberos_keytab attribute.
    /// </summary>
    public string? KerberosKeytab
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_keytab")?.Value;
        set => this.WithProperty("kerberos_keytab", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kerberos_keytab_base64 attribute.
    /// </summary>
    public string? KerberosKeytabBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_keytab_base64")?.Value;
        set => this.WithProperty("kerberos_keytab_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kerberos_krb5_conf attribute.
    /// </summary>
    public string? KerberosKrb5Conf
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_krb5_conf")?.Value;
        set => this.WithProperty("kerberos_krb5_conf", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kerberos_krb5_conf_base64 attribute.
    /// </summary>
    public string? KerberosKrb5ConfBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_krb5_conf_base64")?.Value;
        set => this.WithProperty("kerberos_krb5_conf_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kerberos_principal attribute.
    /// </summary>
    public string? KerberosPrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kerberos_principal")?.Value;
        set => this.WithProperty("kerberos_principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_provider_uri attribute.
    /// </summary>
    public string? KmsKeyProviderUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_provider_uri")?.Value;
        set => this.WithProperty("kms_key_provider_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    public double? ReplicationFactor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replication_factor")?.Value;
        set => this.WithProperty("replication_factor", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The simple_user attribute.
    /// </summary>
    public string? SimpleUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("simple_user")?.Value;
        set => this.WithProperty("simple_user", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public string? Subdirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subdirectory")?.Value;
        set => this.WithProperty("subdirectory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
