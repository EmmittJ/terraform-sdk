using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_cluster_credentials.
/// </summary>
public class AwsRedshiftClusterCredentialsDataSource : TerraformDataSource
{
    public AwsRedshiftClusterCredentialsDataSource(string name) : base("aws_redshift_cluster_credentials", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_password");
        this.DeclareOutput("expiration");
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_create");
        set => this.WithProperty("auto_create", value);
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
    /// The db_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DbGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("db_groups");
        set => this.WithProperty("db_groups", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name");
        set => this.WithProperty("db_name", value);
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
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DurationSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_seconds");
        set => this.WithProperty("duration_seconds", value);
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
    /// The db_password attribute.
    /// </summary>
    public TerraformExpression DbPassword => this["db_password"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

}
