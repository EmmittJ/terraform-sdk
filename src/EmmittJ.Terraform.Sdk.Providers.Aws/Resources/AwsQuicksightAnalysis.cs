using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_analysis resource.
/// </summary>
public class AwsQuicksightAnalysis : TerraformResource
{
    public AwsQuicksightAnalysis(string name) : base("aws_quicksight_analysis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("last_published_time");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    public string? AnalysisId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("analysis_id")?.Value;
        set => this.WithProperty("analysis_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_window_in_days attribute.
    /// </summary>
    public double? RecoveryWindowInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("recovery_window_in_days")?.Value;
        set => this.WithProperty("recovery_window_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The theme_arn attribute.
    /// </summary>
    public string? ThemeArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("theme_arn")?.Value;
        set => this.WithProperty("theme_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    public TerraformExpression LastPublishedTime => this["last_published_time"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
