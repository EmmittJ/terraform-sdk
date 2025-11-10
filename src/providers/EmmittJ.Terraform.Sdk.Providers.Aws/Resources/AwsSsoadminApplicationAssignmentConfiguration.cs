using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_application_assignment_configuration resource.
/// </summary>
public class AwsSsoadminApplicationAssignmentConfiguration : TerraformResource
{
    public AwsSsoadminApplicationAssignmentConfiguration(string name) : base("aws_ssoadmin_application_assignment_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformProperty<string> ApplicationArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_arn");
        set => this.WithProperty("application_arn", value);
    }

    /// <summary>
    /// The assignment_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentRequired is required")]
    public required TerraformProperty<bool> AssignmentRequired
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("assignment_required");
        set => this.WithProperty("assignment_required", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
