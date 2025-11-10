using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_application_access_scope resource.
/// </summary>
public class AwsSsoadminApplicationAccessScope : TerraformResource
{
    public AwsSsoadminApplicationAccessScope(string name) : base("aws_ssoadmin_application_access_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("application_arn");
        SetOutput("authorized_targets");
        SetOutput("region");
        SetOutput("scope");
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformProperty<string> ApplicationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_arn");
        set => SetProperty("application_arn", value);
    }

    /// <summary>
    /// The authorized_targets attribute.
    /// </summary>
    public List<TerraformProperty<string>> AuthorizedTargets
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("authorized_targets");
        set => SetProperty("authorized_targets", value);
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
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
