using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftdata_statement resource.
/// </summary>
public class AwsRedshiftdataStatement : TerraformResource
{
    public AwsRedshiftdataStatement(string name) : base("aws_redshiftdata_statement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public string? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database")?.Value;
        set => this.WithProperty("database", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public string? DbUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_user")?.Value;
        set => this.WithProperty("db_user", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The secret_arn attribute.
    /// </summary>
    public string? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn")?.Value;
        set => this.WithProperty("secret_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    public string? Sql
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql")?.Value;
        set => this.WithProperty("sql", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public string? StatementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_name")?.Value;
        set => this.WithProperty("statement_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public bool? WithEvent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("with_event")?.Value;
        set => this.WithProperty("with_event", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    public string? WorkgroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workgroup_name")?.Value;
        set => this.WithProperty("workgroup_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
