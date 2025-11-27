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
        get => new TerraformReference<string>(this, "endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
    }

    /// <summary>
    /// The elasticsearch_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ElasticsearchSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "elasticsearch_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> EndpointArn
    {
        get => new TerraformReference<string>(this, "endpoint_arn");
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    public TerraformValue<string> EngineName
    {
        get => new TerraformReference<string>(this, "engine_name");
    }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformValue<string> ExtraConnectionAttributes
    {
        get => new TerraformReference<string>(this, "extra_connection_attributes");
    }

    /// <summary>
    /// The kafka_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KafkaSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kafka_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kinesis_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KinesisSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kinesis_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

    /// <summary>
    /// The mongodb_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MongodbSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mongodb_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The mysql_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MysqlSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mysql_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The postgres_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PostgresSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "postgres_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The redis_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedisSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "redis_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The redshift_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedshiftSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "redshift_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The s3_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> S3Settings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "s3_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretsManagerAccessRoleArn
    {
        get => new TerraformReference<string>(this, "secrets_manager_access_role_arn");
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretsManagerArn
    {
        get => new TerraformReference<string>(this, "secrets_manager_arn");
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformValue<string> ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
    }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccessRole
    {
        get => new TerraformReference<string>(this, "service_access_role");
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformValue<string> SslMode
    {
        get => new TerraformReference<string>(this, "ssl_mode");
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
    }

}
