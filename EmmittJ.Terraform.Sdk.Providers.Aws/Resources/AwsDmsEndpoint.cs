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
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public string? EndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_id")?.Value;
        set => this.WithProperty("endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public string? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type")?.Value;
        set => this.WithProperty("endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    public string? EngineName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_name")?.Value;
        set => this.WithProperty("engine_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public string? ExtraConnectionAttributes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extra_connection_attributes")?.Value;
        set => this.WithProperty("extra_connection_attributes", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    public bool? PauseReplicationTasks
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("pause_replication_tasks")?.Value;
        set => this.WithProperty("pause_replication_tasks", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public string? SecretsManagerAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secrets_manager_access_role_arn")?.Value;
        set => this.WithProperty("secrets_manager_access_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public string? SecretsManagerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secrets_manager_arn")?.Value;
        set => this.WithProperty("secrets_manager_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public string? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name")?.Value;
        set => this.WithProperty("server_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public string? ServiceAccessRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_access_role")?.Value;
        set => this.WithProperty("service_access_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public string? SslMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_mode")?.Value;
        set => this.WithProperty("ssl_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformExpression EndpointArn => this["endpoint_arn"];

}
