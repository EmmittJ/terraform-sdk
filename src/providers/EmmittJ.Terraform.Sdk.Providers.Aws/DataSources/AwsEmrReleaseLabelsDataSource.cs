using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in AwsEmrReleaseLabelsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsEmrReleaseLabelsDataSourceFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The application attribute.
    /// </summary>
    public TerraformValue<string>? Application
    {
        get => GetArgument<TerraformValue<string>>("application");
        set => SetArgument("application", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Represents a aws_emr_release_labels Terraform data source.
/// Retrieves information about a aws_emr_release_labels.
/// </summary>
public partial class AwsEmrReleaseLabelsDataSource(string name) : TerraformDataSource("aws_emr_release_labels", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The release_labels attribute.
    /// </summary>
    public TerraformList<string> ReleaseLabels
        => AsReference("release_labels");

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filters block(s) allowed")]
    public TerraformList<AwsEmrReleaseLabelsDataSourceFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsEmrReleaseLabelsDataSourceFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}
