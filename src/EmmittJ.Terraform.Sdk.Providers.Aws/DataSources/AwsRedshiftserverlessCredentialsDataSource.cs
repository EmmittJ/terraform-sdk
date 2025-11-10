using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_credentials.
/// </summary>
public class AwsRedshiftserverlessCredentialsDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessCredentialsDataSource(string name) : base("aws_redshiftserverless_credentials", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_password");
        this.DeclareOutput("db_user");
        this.DeclareOutput("expiration");
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
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetProperty<TerraformProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
    }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    public TerraformExpression DbPassword => this["db_password"];

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformExpression DbUser => this["db_user"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

}
