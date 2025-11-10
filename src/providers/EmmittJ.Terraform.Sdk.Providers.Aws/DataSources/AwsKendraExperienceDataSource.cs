using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_experience.
/// </summary>
public class AwsKendraExperienceDataSource : TerraformDataSource
{
    public AwsKendraExperienceDataSource(string name) : base("aws_kendra_experience", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("configuration");
        this.WithOutput("created_at");
        this.WithOutput("description");
        this.WithOutput("endpoints");
        this.WithOutput("error_message");
        this.WithOutput("name");
        this.WithOutput("role_arn");
        this.WithOutput("status");
        this.WithOutput("updated_at");
    }

    /// <summary>
    /// The experience_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExperienceId is required")]
    public required TerraformProperty<string> ExperienceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("experience_id");
        set => this.WithProperty("experience_id", value);
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
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformProperty<string> IndexId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("index_id");
        set => this.WithProperty("index_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformExpression Configuration => this["configuration"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
