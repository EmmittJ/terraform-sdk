using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_endpoint.
/// </summary>
public class AwsDmsEndpointDataSource : TerraformDataSource
{
    public AwsDmsEndpointDataSource(string name) : base("aws_dms_endpoint", name)
    {
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformPropertyName("endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateArn => new TerraformReference(this, "certificate_arn");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseName => new TerraformReference(this, "database_name");

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ElasticsearchSettings => new TerraformReference(this, "elasticsearch_settings");

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointArn => new TerraformReference(this, "endpoint_arn");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointType => new TerraformReference(this, "endpoint_type");

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [TerraformPropertyName("engine_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineName => new TerraformReference(this, "engine_name");

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    [TerraformPropertyName("extra_connection_attributes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExtraConnectionAttributes => new TerraformReference(this, "extra_connection_attributes");

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    [TerraformPropertyName("kafka_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KafkaSettings => new TerraformReference(this, "kafka_settings");

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    [TerraformPropertyName("kinesis_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KinesisSettings => new TerraformReference(this, "kinesis_settings");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyArn => new TerraformReference(this, "kms_key_arn");

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    [TerraformPropertyName("mongodb_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MongodbSettings => new TerraformReference(this, "mongodb_settings");

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    [TerraformPropertyName("mysql_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MysqlSettings => new TerraformReference(this, "mysql_settings");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Password => new TerraformReference(this, "password");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    [TerraformPropertyName("postgres_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PostgresSettings => new TerraformReference(this, "postgres_settings");

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    [TerraformPropertyName("redis_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RedisSettings => new TerraformReference(this, "redis_settings");

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    [TerraformPropertyName("redshift_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RedshiftSettings => new TerraformReference(this, "redshift_settings");

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    [TerraformPropertyName("s3_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> S3Settings => new TerraformReference(this, "s3_settings");

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_access_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretsManagerAccessRoleArn => new TerraformReference(this, "secrets_manager_access_role_arn");

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretsManagerArn => new TerraformReference(this, "secrets_manager_arn");

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [TerraformPropertyName("server_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServerName => new TerraformReference(this, "server_name");

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceAccessRole => new TerraformReference(this, "service_access_role");

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformPropertyName("ssl_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SslMode => new TerraformReference(this, "ssl_mode");

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Username => new TerraformReference(this, "username");

}
