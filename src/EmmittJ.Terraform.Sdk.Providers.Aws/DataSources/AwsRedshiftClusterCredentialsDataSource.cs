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
    public TerraformProperty<bool>? AutoCreate
    {
        get => GetProperty<TerraformProperty<bool>>("auto_create");
        set => this.WithProperty("auto_create", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The db_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DbGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("db_groups");
        set => this.WithProperty("db_groups", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbName
    {
        get => GetProperty<TerraformProperty<string>>("db_name");
        set => this.WithProperty("db_name", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbUser is required")]
    public required TerraformProperty<string> DbUser
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_user");
        set => this.WithProperty("db_user", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DurationSeconds
    {
        get => GetProperty<TerraformProperty<double>>("duration_seconds");
        set => this.WithProperty("duration_seconds", value);
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
    /// The db_password attribute.
    /// </summary>
    public TerraformExpression DbPassword => this["db_password"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

}
