using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_athena_named_query.
/// </summary>
public class AwsAthenaNamedQueryDataSource : TerraformDataSource
{
    public AwsAthenaNamedQueryDataSource(string name) : base("aws_athena_named_query", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("database");
        SetOutput("description");
        SetOutput("querystring");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("workgroup");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The workgroup attribute.
    /// </summary>
    public TerraformProperty<string> Workgroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workgroup");
        set => SetProperty("workgroup", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformExpression Database => this["database"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The querystring attribute.
    /// </summary>
    public TerraformExpression Querystring => this["querystring"];

}
