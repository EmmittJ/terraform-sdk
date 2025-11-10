using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_theme.
/// </summary>
public class AwsQuicksightThemeDataSource : TerraformDataSource
{
    public AwsQuicksightThemeDataSource(string name) : base("aws_quicksight_theme", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("base_theme_id");
        this.WithOutput("configuration");
        this.WithOutput("created_time");
        this.WithOutput("last_updated_time");
        this.WithOutput("name");
        this.WithOutput("permissions");
        this.WithOutput("status");
        this.WithOutput("version_description");
        this.WithOutput("version_number");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The theme_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThemeId is required")]
    public required TerraformProperty<string> ThemeId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("theme_id");
        set => this.WithProperty("theme_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The base_theme_id attribute.
    /// </summary>
    public TerraformExpression BaseThemeId => this["base_theme_id"];

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformExpression Configuration => this["configuration"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

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
    /// The version_description attribute.
    /// </summary>
    public TerraformExpression VersionDescription => this["version_description"];

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    public TerraformExpression VersionNumber => this["version_number"];

}
