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
    public TerraformLiteralProperty<string>? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name");
        set => this.WithProperty("db_name", value);
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
    /// The workgroup_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkgroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workgroup_name");
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
