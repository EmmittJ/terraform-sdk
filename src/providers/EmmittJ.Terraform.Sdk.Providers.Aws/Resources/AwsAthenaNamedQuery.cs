using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_athena_named_query resource.
/// </summary>
public class AwsAthenaNamedQuery : TerraformResource
{
    public AwsAthenaNamedQuery(string name) : base("aws_athena_named_query", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("database");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("query");
        SetOutput("region");
        SetOutput("workgroup");
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query");
        set => SetProperty("query", value);
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

}
