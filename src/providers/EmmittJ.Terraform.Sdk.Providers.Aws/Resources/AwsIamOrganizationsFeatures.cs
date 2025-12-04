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
        get => GetArgument<TerraformSet<string>>("enabled_features");
        set => SetArgument("enabled_features", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
