using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_organizations_features Terraform resource.
/// Manages a aws_iam_organizations_features resource.
/// </summary>
public partial class AwsIamOrganizationsFeatures(string name) : TerraformResource("aws_iam_organizations_features", name)
{
    /// <summary>
    /// The enabled_features attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledFeatures is required")]
    public required TerraformSet<string> EnabledFeatures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_features").ResolveNodes(ctx));
        set => SetArgument("enabled_features", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
