using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_event_categories.
/// </summary>
public class AwsDbEventCategoriesDataSource : TerraformDataSource
{
    public AwsDbEventCategoriesDataSource(string name) : base("aws_db_event_categories", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("event_categories");
        SetOutput("id");
        SetOutput("region");
        SetOutput("source_type");
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
    /// The source_type attribute.
    /// </summary>
    public TerraformProperty<string> SourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_type");
        set => SetProperty("source_type", value);
    }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    public TerraformExpression EventCategories => this["event_categories"];

}
