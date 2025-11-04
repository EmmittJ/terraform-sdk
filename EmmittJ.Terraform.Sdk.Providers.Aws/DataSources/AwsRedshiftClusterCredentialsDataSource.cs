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
    public bool? AutoCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_create")?.Value;
        set => this.WithProperty("auto_create", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The db_groups attribute.
    /// </summary>
    public HashSet<string>? DbGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("db_groups")?.Value;
        set => this.WithProperty("db_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public string? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name")?.Value;
        set => this.WithProperty("db_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The duration_seconds attribute.
    /// </summary>
    public double? DurationSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_seconds")?.Value;
        set => this.WithProperty("duration_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The db_password attribute.
    /// </summary>
    public TerraformExpression DbPassword => this["db_password"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

}
