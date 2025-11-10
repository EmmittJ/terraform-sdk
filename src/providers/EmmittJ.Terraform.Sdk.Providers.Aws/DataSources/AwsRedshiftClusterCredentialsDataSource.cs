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
        SetOutput("db_password");
        SetOutput("expiration");
        SetOutput("auto_create");
        SetOutput("cluster_identifier");
        SetOutput("db_groups");
        SetOutput("db_name");
        SetOutput("db_user");
        SetOutput("duration_seconds");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformProperty<bool> AutoCreate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_create");
        set => SetProperty("auto_create", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The db_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DbGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("db_groups");
        set => SetProperty("db_groups", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformProperty<string> DbName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_name");
        set => SetProperty("db_name", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbUser is required")]
    public required TerraformProperty<string> DbUser
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_user");
        set => SetProperty("db_user", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DurationSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration_seconds");
        set => SetProperty("duration_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
