using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codeartifact_domain_permissions_policy Terraform resource.
/// Manages a aws_codeartifact_domain_permissions_policy resource.
/// </summary>
public partial class AwsCodeartifactDomainPermissionsPolicy(string name) : TerraformResource("aws_codeartifact_domain_permissions_policy", name)
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformValue<string> DomainOwner
    {
        get => GetArgument<TerraformValue<string>>("domain_owner") ?? AsReference("domain_owner");
        set => SetArgument("domain_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public TerraformValue<string> PolicyDocument
    {
        get => GetArgument<TerraformValue<string>>("policy_document") ?? AsReference("policy_document");
        set => SetArgument("policy_document", value);
    }

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    public TerraformValue<string> PolicyRevision
    {
        get => GetArgument<TerraformValue<string>>("policy_revision") ?? AsReference("policy_revision");
        set => SetArgument("policy_revision", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
        => AsReference("resource_arn");

}
