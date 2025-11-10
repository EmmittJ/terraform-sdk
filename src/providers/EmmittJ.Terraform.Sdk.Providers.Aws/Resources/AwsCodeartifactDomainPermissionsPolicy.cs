using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_domain_permissions_policy resource.
/// </summary>
public class AwsCodeartifactDomainPermissionsPolicy : TerraformResource
{
    public AwsCodeartifactDomainPermissionsPolicy(string name) : base("aws_codeartifact_domain_permissions_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("resource_arn");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformProperty<string>? DomainOwner
    {
        get => GetProperty<TerraformProperty<string>>("domain_owner");
        set => this.WithProperty("domain_owner", value);
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
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
    }

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyRevision
    {
        get => GetProperty<TerraformProperty<string>>("policy_revision");
        set => this.WithProperty("policy_revision", value);
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
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

}
