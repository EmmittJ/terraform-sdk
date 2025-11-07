using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_endpoint.
/// </summary>
public class AwsDmsEndpointDataSource : TerraformDataSource
{
    public AwsDmsEndpointDataSource(string name) : base("aws_dms_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_arn");
        this.DeclareOutput("database_name");
        this.DeclareOutput("elasticsearch_settings");
        this.DeclareOutput("endpoint_arn");
        this.DeclareOutput("endpoint_type");
        this.DeclareOutput("engine_name");
        this.DeclareOutput("extra_connection_attributes");
        this.DeclareOutput("kafka_settings");
        this.DeclareOutput("kinesis_settings");
        this.DeclareOutput("kms_key_arn");
        this.DeclareOutput("mongodb_settings");
        this.DeclareOutput("mysql_settings");
        this.DeclareOutput("password");
        this.DeclareOutput("port");
        this.DeclareOutput("postgres_settings");
        this.DeclareOutput("redis_settings");
        this.DeclareOutput("redshift_settings");
        this.DeclareOutput("s3_settings");
        this.DeclareOutput("secrets_manager_access_role_arn");
        this.DeclareOutput("secrets_manager_arn");
        this.DeclareOutput("server_name");
        this.DeclareOutput("service_access_role");
        this.DeclareOutput("ssl_mode");
        this.DeclareOutput("username");
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformExpression DatabaseName => this["database_name"];

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    public TerraformExpression ElasticsearchSettings => this["elasticsearch_settings"];

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformExpression EndpointArn => this["endpoint_arn"];

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformExpression EndpointType => this["endpoint_type"];

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    public TerraformExpression EngineName => this["engine_name"];

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformExpression ExtraConnectionAttributes => this["extra_connection_attributes"];

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    public TerraformExpression KafkaSettings => this["kafka_settings"];

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    public TerraformExpression KinesisSettings => this["kinesis_settings"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    public TerraformExpression MongodbSettings => this["mongodb_settings"];

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    public TerraformExpression MysqlSettings => this["mysql_settings"];

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformExpression Password => this["password"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    public TerraformExpression PostgresSettings => this["postgres_settings"];

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    public TerraformExpression RedisSettings => this["redis_settings"];

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    public TerraformExpression RedshiftSettings => this["redshift_settings"];

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    public TerraformExpression S3Settings => this["s3_settings"];

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformExpression SecretsManagerAccessRoleArn => this["secrets_manager_access_role_arn"];

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformExpression SecretsManagerArn => this["secrets_manager_arn"];

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformExpression ServerName => this["server_name"];

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformExpression ServiceAccessRole => this["service_access_role"];

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformExpression SslMode => this["ssl_mode"];

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformExpression Username => this["username"];

}
