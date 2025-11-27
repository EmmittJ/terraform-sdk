using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssoadmin_application_access_scope Terraform resource.
/// Manages a aws_ssoadmin_application_access_scope resource.
/// </summary>
public partial class AwsSsoadminApplicationAccessScope(string name) : TerraformResource("aws_ssoadmin_application_access_scope", name)
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformValue<string> ApplicationArn
    {
        get => new TerraformReference<string>(this, "application_arn");
        set => SetArgument("application_arn", value);
    }

    /// <summary>
    /// The authorized_targets attribute.
    /// </summary>
    public TerraformList<string>? AuthorizedTargets
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "authorized_targets").ResolveNodes(ctx));
        set => SetArgument("authorized_targets", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
