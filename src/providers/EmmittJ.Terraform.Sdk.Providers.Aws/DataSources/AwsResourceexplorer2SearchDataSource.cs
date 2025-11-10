using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_resourceexplorer2_search.
/// </summary>
public class AwsResourceexplorer2SearchDataSource : TerraformDataSource
{
    public AwsResourceexplorer2SearchDataSource(string name) : base("aws_resourceexplorer2_search", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("resource_count");
        SetOutput("resources");
        SetOutput("query_string");
        SetOutput("region");
        SetOutput("view_arn");
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformProperty<string> QueryString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_string");
        set => SetProperty("query_string", value);
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
    /// The view_arn attribute.
    /// </summary>
    public TerraformProperty<string> ViewArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("view_arn");
        set => SetProperty("view_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformExpression ResourceCount => this["resource_count"];

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

}
