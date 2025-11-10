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
    public required TerraformProperty<TerraformProperty<string>> EndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_name");

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ElasticsearchSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "elasticsearch_settings");

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_arn");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_type");

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [TerraformPropertyName("engine_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_name");

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    [TerraformPropertyName("extra_connection_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExtraConnectionAttributes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "extra_connection_attributes");

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    [TerraformPropertyName("kafka_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KafkaSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kafka_settings");

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    [TerraformPropertyName("kinesis_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KinesisSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kinesis_settings");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    [TerraformPropertyName("mongodb_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MongodbSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "mongodb_settings");

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    [TerraformPropertyName("mysql_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MysqlSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "mysql_settings");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Password => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "password");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    [TerraformPropertyName("postgres_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PostgresSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "postgres_settings");

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    [TerraformPropertyName("redis_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RedisSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "redis_settings");

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    [TerraformPropertyName("redshift_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RedshiftSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "redshift_settings");

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    [TerraformPropertyName("s3_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> S3Settings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "s3_settings");

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_access_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretsManagerAccessRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secrets_manager_access_role_arn");

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretsManagerArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secrets_manager_arn");

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [TerraformPropertyName("server_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_name");

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAccessRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_access_role");

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformPropertyName("ssl_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SslMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssl_mode");

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Username => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "username");

}
