using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_prometheus_workspaces Terraform data source.
/// Retrieves information about a aws_prometheus_workspaces.
/// </summary>
public partial class AwsPrometheusWorkspacesDataSource(string name) : TerraformDataSource("aws_prometheus_workspaces", name)
{
    /// <summary>
    /// The alias_prefix attribute.
    /// </summary>
    public TerraformValue<string>? AliasPrefix
    {
        get => new TerraformReference<string>(this, "alias_prefix");
        set => SetArgument("alias_prefix", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformList<string> Aliases
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "aliases").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformList<string> Arns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workspace_ids attribute.
    /// </summary>
    public TerraformList<string> WorkspaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "workspace_ids").ResolveNodes(ctx));
    }

}
