using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsRegionsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRegionsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_regions Terraform data source.
/// Retrieves information about a aws_regions.
/// </summary>
public partial class AwsRegionsDataSource(string name) : TerraformDataSource("aws_regions", name)
{
    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformValue<bool>? AllRegions
    {
        get => GetArgument<TerraformValue<bool>>("all_regions");
        set => SetArgument("all_regions", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformSet<string> Names
        => CreateReference("names");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRegionsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRegionsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
