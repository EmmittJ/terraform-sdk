using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock : TerraformBlock
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

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ec2_network_insights_analysis.
/// </summary>
public class AwsEc2NetworkInsightsAnalysisDataSource : TerraformDataSource
{
    public AwsEc2NetworkInsightsAnalysisDataSource(string name) : base("aws_ec2_network_insights_analysis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alternate_path_hints");
        this.DeclareOutput("arn");
        this.DeclareOutput("explanations");
        this.DeclareOutput("filter_in_arns");
        this.DeclareOutput("forward_path_components");
        this.DeclareOutput("network_insights_path_id");
        this.DeclareOutput("path_found");
        this.DeclareOutput("return_path_components");
        this.DeclareOutput("start_date");
        this.DeclareOutput("status");
        this.DeclareOutput("status_message");
        this.DeclareOutput("warning_message");
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
    /// The network_insights_analysis_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInsightsAnalysisId
    {
        get => GetProperty<TerraformProperty<string>>("network_insights_analysis_id");
        set => this.WithProperty("network_insights_analysis_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The alternate_path_hints attribute.
    /// </summary>
    public TerraformExpression AlternatePathHints => this["alternate_path_hints"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The explanations attribute.
    /// </summary>
    public TerraformExpression Explanations => this["explanations"];

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    public TerraformExpression FilterInArns => this["filter_in_arns"];

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    public TerraformExpression ForwardPathComponents => this["forward_path_components"];

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    public TerraformExpression NetworkInsightsPathId => this["network_insights_path_id"];

    /// <summary>
    /// The path_found attribute.
    /// </summary>
    public TerraformExpression PathFound => this["path_found"];

    /// <summary>
    /// The return_path_components attribute.
    /// </summary>
    public TerraformExpression ReturnPathComponents => this["return_path_components"];

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformExpression StartDate => this["start_date"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformExpression StatusMessage => this["status_message"];

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    public TerraformExpression WarningMessage => this["warning_message"];

}
