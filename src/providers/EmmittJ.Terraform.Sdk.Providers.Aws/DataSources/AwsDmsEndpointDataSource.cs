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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => CreateReference("certificate_arn");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
        => CreateReference("database_name");

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ElasticsearchSettings
        => CreateReference("elasticsearch_settings");

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> EndpointArn
        => CreateReference("endpoint_arn");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointType
        => CreateReference("endpoint_type");

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    public TerraformValue<string> EngineName
        => CreateReference("engine_name");

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformValue<string> ExtraConnectionAttributes
        => CreateReference("extra_connection_attributes");

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KafkaSettings
        => CreateReference("kafka_settings");

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KinesisSettings
        => CreateReference("kinesis_settings");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => CreateReference("kms_key_arn");

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MongodbSettings
        => CreateReference("mongodb_settings");

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MysqlSettings
        => CreateReference("mysql_settings");

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
        => CreateReference("password");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PostgresSettings
        => CreateReference("postgres_settings");

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedisSettings
        => CreateReference("redis_settings");

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedshiftSettings
        => CreateReference("redshift_settings");

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> S3Settings
        => CreateReference("s3_settings");

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretsManagerAccessRoleArn
        => CreateReference("secrets_manager_access_role_arn");

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretsManagerArn
        => CreateReference("secrets_manager_arn");

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformValue<string> ServerName
        => CreateReference("server_name");

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccessRole
        => CreateReference("service_access_role");

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformValue<string> SslMode
        => CreateReference("ssl_mode");

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
        => CreateReference("username");

}
