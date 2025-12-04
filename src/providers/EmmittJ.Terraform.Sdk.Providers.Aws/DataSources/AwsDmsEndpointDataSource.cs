using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dms_endpoint Terraform data source.
/// Retrieves information about a aws_dms_endpoint.
/// </summary>
public partial class AwsDmsEndpointDataSource(string name) : TerraformDataSource("aws_dms_endpoint", name)
{
    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    public required TerraformValue<string> EndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => AsReference("certificate_arn");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
        => AsReference("database_name");

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ElasticsearchSettings
        => AsReference("elasticsearch_settings");

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> EndpointArn
        => AsReference("endpoint_arn");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointType
        => AsReference("endpoint_type");

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    public TerraformValue<string> EngineName
        => AsReference("engine_name");

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformValue<string> ExtraConnectionAttributes
        => AsReference("extra_connection_attributes");

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KafkaSettings
        => AsReference("kafka_settings");

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KinesisSettings
        => AsReference("kinesis_settings");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MongodbSettings
        => AsReference("mongodb_settings");

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MysqlSettings
        => AsReference("mysql_settings");

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
        => AsReference("password");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PostgresSettings
        => AsReference("postgres_settings");

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedisSettings
        => AsReference("redis_settings");

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedshiftSettings
        => AsReference("redshift_settings");

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> S3Settings
        => AsReference("s3_settings");

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretsManagerAccessRoleArn
        => AsReference("secrets_manager_access_role_arn");

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretsManagerArn
        => AsReference("secrets_manager_arn");

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformValue<string> ServerName
        => AsReference("server_name");

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccessRole
        => AsReference("service_access_role");

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformValue<string> SslMode
        => AsReference("ssl_mode");

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}
