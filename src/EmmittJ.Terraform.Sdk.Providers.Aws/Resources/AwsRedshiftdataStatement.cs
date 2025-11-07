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
    public TerraformLiteralProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DbUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_user");
        set => this.WithProperty("db_user", value);
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
    /// The secret_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn");
        set => this.WithProperty("secret_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sql
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql");
        set => this.WithProperty("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StatementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_name");
        set => this.WithProperty("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WithEvent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("with_event");
        set => this.WithProperty("with_event", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkgroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
    }

}
