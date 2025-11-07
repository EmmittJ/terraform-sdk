using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_analysis.
/// </summary>
public class AwsQuicksightAnalysisDataSource : TerraformDataSource
{
    public AwsQuicksightAnalysisDataSource(string name) : base("aws_quicksight_analysis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("definition");
        this.DeclareOutput("last_published_time");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("name");
        this.DeclareOutput("permissions");
        this.DeclareOutput("status");
        this.DeclareOutput("theme_arn");
    }

    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    public TerraformProperty<string>? AnalysisId
    {
        get => GetProperty<TerraformProperty<string>>("analysis_id");
        set => this.WithProperty("analysis_id", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
    /// The definition attribute.
    /// </summary>
    public TerraformExpression Definition => this["definition"];

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    public TerraformExpression LastPublishedTime => this["last_published_time"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The theme_arn attribute.
    /// </summary>
    public TerraformExpression ThemeArn => this["theme_arn"];

}
