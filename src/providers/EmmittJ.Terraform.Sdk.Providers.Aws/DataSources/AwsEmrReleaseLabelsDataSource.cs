using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsEmrReleaseLabelsDataSourceFiltersBlock : TerraformBlock
{
    /// <summary>
    /// The application attribute.
    /// </summary>
    public TerraformProperty<string>? Application
    {
        set => SetProperty("application", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
    }

}

/// <summary>
/// Retrieves information about a aws_emr_release_labels.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrReleaseLabelsDataSource : TerraformDataSource
{
    public AwsEmrReleaseLabelsDataSource(string name) : base("aws_emr_release_labels", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("release_labels");
        SetOutput("id");
        SetOutput("region");
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
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filters block(s) allowed")]
    public List<AwsEmrReleaseLabelsDataSourceFiltersBlock>? Filters
    {
        set => SetProperty("filters", value);
    }

    /// <summary>
    /// The release_labels attribute.
    /// </summary>
    public TerraformExpression ReleaseLabels => this["release_labels"];

}
