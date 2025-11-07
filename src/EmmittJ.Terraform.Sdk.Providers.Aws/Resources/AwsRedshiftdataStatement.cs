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
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformProperty<string>? DbUser
    {
        get => GetProperty<TerraformProperty<string>>("db_user");
        set => this.WithProperty("db_user", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretArn
    {
        get => GetProperty<TerraformProperty<string>>("secret_arn");
        set => this.WithProperty("secret_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    public TerraformProperty<string>? Sql
    {
        get => GetProperty<TerraformProperty<string>>("sql");
        set => this.WithProperty("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformProperty<string>? StatementName
    {
        get => GetProperty<TerraformProperty<string>>("statement_name");
        set => this.WithProperty("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformProperty<bool>? WithEvent
    {
        get => GetProperty<TerraformProperty<bool>>("with_event");
        set => this.WithProperty("with_event", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkgroupName
    {
        get => GetProperty<TerraformProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
    }

}
