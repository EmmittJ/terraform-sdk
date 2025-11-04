using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ami_ids.
/// </summary>
public class AwsAmiIdsDataSource : TerraformDataSource
{
    public AwsAmiIdsDataSource(string name) : base("aws_ami_ids", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("ids");
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public List&lt;string&gt;? ExecutableUsers
    {
        get => GetProperty<TerraformLiteralProperty&lt;List&lt;string&gt;&gt;>("executable_users")?.Value;
        set => WithPropertyInternal("executable_users", value == null ? null : new TerraformLiteralProperty&lt;List&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    public bool? IncludeDeprecated
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("include_deprecated")?.Value;
        set => WithPropertyInternal("include_deprecated", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public string? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("name_regex")?.Value;
        set => WithPropertyInternal("name_regex", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public List&lt;string&gt;? Owners
    {
        get => GetProperty<TerraformLiteralProperty&lt;List&lt;string&gt;&gt;>("owners")?.Value;
        set => WithPropertyInternal("owners", value == null ? null : new TerraformLiteralProperty&lt;List&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The sort_ascending attribute.
    /// </summary>
    public bool? SortAscending
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("sort_ascending")?.Value;
        set => WithPropertyInternal("sort_ascending", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
