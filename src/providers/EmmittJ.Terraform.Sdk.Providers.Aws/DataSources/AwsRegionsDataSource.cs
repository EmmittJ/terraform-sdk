using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsRegionsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_regions.
/// </summary>
public class AwsRegionsDataSource : TerraformDataSource
{
    public AwsRegionsDataSource(string name) : base("aws_regions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("names");
        SetOutput("all_regions");
        SetOutput("id");
    }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformProperty<bool> AllRegions
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("all_regions");
        set => SetProperty("all_regions", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRegionsDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
