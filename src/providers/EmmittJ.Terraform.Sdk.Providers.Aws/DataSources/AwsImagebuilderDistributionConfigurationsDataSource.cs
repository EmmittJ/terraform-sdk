using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsImagebuilderDistributionConfigurationsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderDistributionConfigurationsDataSourceFilterBlock : TerraformBlock
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
/// Represents a aws_imagebuilder_distribution_configurations Terraform data source.
/// Retrieves information about a aws_imagebuilder_distribution_configurations.
/// </summary>
public partial class AwsImagebuilderDistributionConfigurationsDataSource(string name) : TerraformDataSource("aws_imagebuilder_distribution_configurations", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformSet<string> Arns
        => CreateReference("arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformSet<string> Names
        => CreateReference("names");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderDistributionConfigurationsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsImagebuilderDistributionConfigurationsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
