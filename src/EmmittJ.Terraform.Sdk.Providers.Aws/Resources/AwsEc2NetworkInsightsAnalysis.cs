using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_network_insights_analysis resource.
/// </summary>
public class AwsEc2NetworkInsightsAnalysis : TerraformResource
{
    public AwsEc2NetworkInsightsAnalysis(string name) : base("aws_ec2_network_insights_analysis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alternate_path_hints");
        this.DeclareOutput("arn");
        this.DeclareOutput("explanations");
        this.DeclareOutput("forward_path_components");
        this.DeclareOutput("path_found");
        this.DeclareOutput("return_path_components");
        this.DeclareOutput("start_date");
        this.DeclareOutput("status");
        this.DeclareOutput("status_message");
        this.DeclareOutput("warning_message");
    }

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    public HashSet<string>? FilterInArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("filter_in_arns")?.Value;
        set => this.WithProperty("filter_in_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The network_insights_path_id attribute.
    /// </summary>
    public string? NetworkInsightsPathId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_insights_path_id")?.Value;
        set => this.WithProperty("network_insights_path_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The wait_for_completion attribute.
    /// </summary>
    public bool? WaitForCompletion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_completion")?.Value;
        set => this.WithProperty("wait_for_completion", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The forward_path_components attribute.
    /// </summary>
    public TerraformExpression ForwardPathComponents => this["forward_path_components"];

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
