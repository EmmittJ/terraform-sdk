using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_eks_addon_version Terraform data source.
/// Retrieves information about a aws_eks_addon_version.
/// </summary>
public partial class AwsEksAddonVersionDataSource(string name) : TerraformDataSource("aws_eks_addon_version", name)
{
    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    public required TerraformValue<string> AddonName
    {
        get => new TerraformReference<string>(this, "addon_name");
        set => SetArgument("addon_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesVersion is required")]
    public required TerraformValue<string> KubernetesVersion
    {
        get => new TerraformReference<string>(this, "kubernetes_version");
        set => SetArgument("kubernetes_version", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
