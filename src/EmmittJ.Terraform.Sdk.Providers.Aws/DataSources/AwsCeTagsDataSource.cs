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
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    public TerraformProperty<string>? SortOrder
    {
        get => GetProperty<TerraformProperty<string>>("sort_order");
        set => WithProperty("sort_order", value);
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
        get => GetProperty<TerraformProperty<string>>("end");
        set => WithProperty("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformProperty<string> Start
    {
        get => GetProperty<TerraformProperty<string>>("start");
        set => WithProperty("start", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ce_tags.
/// </summary>
public class AwsCeTagsDataSource : TerraformDataSource
{
    public AwsCeTagsDataSource(string name) : base("aws_ce_tags", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("tags");
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
    /// The search_string attribute.
    /// </summary>
    public TerraformProperty<string>? SearchString
    {
        get => GetProperty<TerraformProperty<string>>("search_string");
        set => this.WithProperty("search_string", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformProperty<string>? TagKey
    {
        get => GetProperty<TerraformProperty<string>>("tag_key");
        set => this.WithProperty("tag_key", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AwsCeTagsDataSourceFilterBlock>? Filter
    {
        get => GetProperty<List<AwsCeTagsDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for sort_by.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCeTagsDataSourceSortByBlock>? SortBy
    {
        get => GetProperty<List<AwsCeTagsDataSourceSortByBlock>>("sort_by");
        set => this.WithProperty("sort_by", value);
    }

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public List<AwsCeTagsDataSourceTimePeriodBlock>? TimePeriod
    {
        get => GetProperty<List<AwsCeTagsDataSourceTimePeriodBlock>>("time_period");
        set => this.WithProperty("time_period", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
