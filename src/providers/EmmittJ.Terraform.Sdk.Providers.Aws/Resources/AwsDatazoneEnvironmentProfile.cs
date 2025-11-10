using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsDatazoneEnvironmentProfileUserParametersBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_datazone_environment_profile resource.
/// </summary>
public class AwsDatazoneEnvironmentProfile : TerraformResource
{
    public AwsDatazoneEnvironmentProfile(string name) : base("aws_datazone_environment_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("created_at");
        this.WithOutput("created_by");
        this.WithOutput("id");
        this.WithOutput("updated_at");
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
    /// The aws_account_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsAccountRegion is required")]
    public required TerraformProperty<string> AwsAccountRegion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("aws_account_region");
        set => this.WithProperty("aws_account_region", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformProperty<string> DomainIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_identifier");
        set => this.WithProperty("domain_identifier", value);
    }

    /// <summary>
    /// The environment_blueprint_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintIdentifier is required")]
    public required TerraformProperty<string> EnvironmentBlueprintIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("environment_blueprint_identifier");
        set => this.WithProperty("environment_blueprint_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectIdentifier is required")]
    public required TerraformProperty<string> ProjectIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("project_identifier");
        set => this.WithProperty("project_identifier", value);
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
    /// Block for user_parameters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDatazoneEnvironmentProfileUserParametersBlock>? UserParameters
    {
        get => GetProperty<List<AwsDatazoneEnvironmentProfileUserParametersBlock>>("user_parameters");
        set => this.WithProperty("user_parameters", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
