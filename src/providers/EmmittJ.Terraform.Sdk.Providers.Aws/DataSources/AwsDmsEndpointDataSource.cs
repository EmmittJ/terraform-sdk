using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_endpoint.
/// </summary>
public partial class AwsDmsEndpointDataSource : TerraformDataSource
{
    public AwsDmsEndpointDataSource(string name) : base("aws_dms_endpoint", name)
    {
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformProperty("endpoint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EndpointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseName { get; }

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    [TerraformProperty("elasticsearch_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ElasticsearchSettings { get; }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformProperty("endpoint_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointArn { get; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointType { get; }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [TerraformProperty("engine_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineName { get; }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    [TerraformProperty("extra_connection_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExtraConnectionAttributes { get; }

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    [TerraformProperty("kafka_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KafkaSettings { get; }

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    [TerraformProperty("kinesis_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KinesisSettings { get; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyArn { get; }

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    [TerraformProperty("mongodb_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MongodbSettings { get; }

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    [TerraformProperty("mysql_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MysqlSettings { get; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Password { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    [TerraformProperty("postgres_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PostgresSettings { get; }

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    [TerraformProperty("redis_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RedisSettings { get; }

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    [TerraformProperty("redshift_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RedshiftSettings { get; }

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    [TerraformProperty("s3_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> S3Settings { get; }

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("secrets_manager_access_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretsManagerAccessRoleArn { get; }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformProperty("secrets_manager_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretsManagerArn { get; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [TerraformProperty("server_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServerName { get; }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    [TerraformProperty("service_access_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceAccessRole { get; }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformProperty("ssl_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SslMode { get; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Username { get; }

}
