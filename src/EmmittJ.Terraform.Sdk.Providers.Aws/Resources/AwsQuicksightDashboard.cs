using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_dashboard resource.
/// </summary>
public class AwsQuicksightDashboard : TerraformResource
{
    public AwsQuicksightDashboard(string name) : base("aws_quicksight_dashboard", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("last_published_time");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("source_entity_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("version_number");
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
    /// The dashboard_id attribute.
    /// </summary>
    public TerraformProperty<string>? DashboardId
    {
        get => GetProperty<TerraformProperty<string>>("dashboard_id");
        set => this.WithProperty("dashboard_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The theme_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ThemeArn
    {
        get => GetProperty<TerraformProperty<string>>("theme_arn");
        set => this.WithProperty("theme_arn", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformProperty<string>? VersionDescription
    {
        get => GetProperty<TerraformProperty<string>>("version_description");
        set => this.WithProperty("version_description", value);
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
    /// The source_entity_arn attribute.
    /// </summary>
    public TerraformExpression SourceEntityArn => this["source_entity_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    public TerraformExpression VersionNumber => this["version_number"];

}
