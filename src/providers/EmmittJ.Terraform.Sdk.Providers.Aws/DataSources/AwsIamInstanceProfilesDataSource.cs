using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_instance_profiles Terraform data source.
/// Retrieves information about a aws_iam_instance_profiles.
/// </summary>
public partial class AwsIamInstanceProfilesDataSource(string name) : TerraformDataSource("aws_iam_instance_profiles", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformSet<string> Arns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformSet<string> Names
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    public TerraformSet<string> Paths
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "paths").ResolveNodes(ctx));
    }

}
