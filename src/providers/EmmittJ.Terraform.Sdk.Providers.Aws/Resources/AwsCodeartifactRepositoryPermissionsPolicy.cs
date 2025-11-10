using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_repository_permissions_policy resource.
/// </summary>
public class AwsCodeartifactRepositoryPermissionsPolicy : TerraformResource
{
    public AwsCodeartifactRepositoryPermissionsPolicy(string name) : base("aws_codeartifact_repository_permissions_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("resource_arn");
        SetOutput("domain");
        SetOutput("domain_owner");
        SetOutput("id");
        SetOutput("policy_document");
        SetOutput("policy_revision");
        SetOutput("region");
        SetOutput("repository");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformProperty<string> DomainOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_owner");
        set => SetProperty("domain_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformProperty<string> PolicyDocument
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_document");
        set => SetProperty("policy_document", value);
    }

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    public TerraformProperty<string> PolicyRevision
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_revision");
        set => SetProperty("policy_revision", value);
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
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformProperty<string> Repository
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository");
        set => SetProperty("repository", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

}
