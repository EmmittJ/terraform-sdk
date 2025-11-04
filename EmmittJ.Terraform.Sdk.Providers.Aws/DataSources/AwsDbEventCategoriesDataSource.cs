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
        this.DeclareOutput("event_categories");
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
    /// The source_type attribute.
    /// </summary>
    public string? SourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_type")?.Value;
        set => this.WithProperty("source_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    public TerraformExpression EventCategories => this["event_categories"];

}
