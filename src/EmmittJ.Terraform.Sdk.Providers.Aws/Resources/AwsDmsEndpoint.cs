using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_endpoint resource.
/// </summary>
public class AwsDmsEndpoint : TerraformResource
{
    public AwsDmsEndpoint(string name) : base("aws_dms_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint_arn");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_id");
        set => this.WithProperty("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_name");
        set => this.WithProperty("engine_name", value);
    }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExtraConnectionAttributes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extra_connection_attributes");
        set => this.WithProperty("extra_connection_attributes", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PauseReplicationTasks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("pause_replication_tasks");
        set => this.WithProperty("pause_replication_tasks", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
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
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretsManagerAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secrets_manager_access_role_arn");
        set => this.WithProperty("secrets_manager_access_role_arn", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretsManagerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secrets_manager_arn");
        set => this.WithProperty("secrets_manager_arn", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceAccessRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_access_role");
        set => this.WithProperty("service_access_role", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SslMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_mode");
        set => this.WithProperty("ssl_mode", value);
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
    /// The username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformExpression EndpointArn => this["endpoint_arn"];

}
