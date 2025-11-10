using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsResourceexplorer2ViewFiltersBlock : TerraformBlock
{
    /// <summary>
    /// The filter_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterString is required")]
    public required TerraformProperty<string> FilterString
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filter_string");
        set => WithProperty("filter_string", value);
    }

}

/// <summary>
/// Block type for included_property in .
/// Nesting mode: list
/// </summary>
public class AwsResourceexplorer2ViewIncludedPropertyBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a aws_resourceexplorer2_view resource.
/// </summary>
public class AwsResourceexplorer2View : TerraformResource
{
    public AwsResourceexplorer2View(string name) : base("aws_resourceexplorer2_view", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The default_view attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultView
    {
        get => GetProperty<TerraformProperty<bool>>("default_view");
        set => this.WithProperty("default_view", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsResourceexplorer2ViewFiltersBlock>? Filters
    {
        get => GetProperty<List<AwsResourceexplorer2ViewFiltersBlock>>("filters");
        set => this.WithProperty("filters", value);
    }

    /// <summary>
    /// Block for included_property.
    /// Nesting mode: list
    /// </summary>
    public List<AwsResourceexplorer2ViewIncludedPropertyBlock>? IncludedProperty
    {
        get => GetProperty<List<AwsResourceexplorer2ViewIncludedPropertyBlock>>("included_property");
        set => this.WithProperty("included_property", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
