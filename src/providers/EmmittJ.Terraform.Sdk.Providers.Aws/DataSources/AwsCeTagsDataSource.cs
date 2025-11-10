using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for sort_by in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceSortByBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    public TerraformProperty<string>? SortOrder
    {
        set => SetProperty("sort_order", value);
    }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceTimePeriodBlock : TerraformBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformProperty<string> End
    {
        set => SetProperty("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformProperty<string> Start
    {
        set => SetProperty("start", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ce_tags.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCeTagsDataSource : TerraformDataSource
{
    public AwsCeTagsDataSource(string name) : base("aws_ce_tags", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("tags");
        SetOutput("id");
        SetOutput("search_string");
        SetOutput("tag_key");
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
    /// The search_string attribute.
    /// </summary>
    public TerraformProperty<string> SearchString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("search_string");
        set => SetProperty("search_string", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformProperty<string> TagKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tag_key");
        set => SetProperty("tag_key", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AwsCeTagsDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for sort_by.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCeTagsDataSourceSortByBlock>? SortBy
    {
        set => SetProperty("sort_by", value);
    }

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public List<AwsCeTagsDataSourceTimePeriodBlock>? TimePeriod
    {
        set => SetProperty("time_period", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
