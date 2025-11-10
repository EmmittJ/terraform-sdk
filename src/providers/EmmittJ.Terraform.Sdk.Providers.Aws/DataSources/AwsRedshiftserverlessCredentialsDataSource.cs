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
        SetOutput("db_password");
        SetOutput("db_user");
        SetOutput("expiration");
        SetOutput("db_name");
        SetOutput("duration_seconds");
        SetOutput("id");
        SetOutput("region");
        SetOutput("workgroup_name");
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
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workgroup_name");
        set => SetProperty("workgroup_name", value);
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
