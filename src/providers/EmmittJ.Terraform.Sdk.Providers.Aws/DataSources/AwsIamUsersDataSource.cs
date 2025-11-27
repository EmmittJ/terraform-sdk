using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_users Terraform data source.
/// Retrieves information about a aws_iam_users.
/// </summary>
public partial class AwsIamUsersDataSource(string name) : TerraformDataSource("aws_iam_users", name)
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
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => new TerraformReference<string>(this, "name_regex");
        set => SetArgument("name_regex", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformValue<string>? PathPrefix
    {
        get => new TerraformReference<string>(this, "path_prefix");
        set => SetArgument("path_prefix", value);
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

}
