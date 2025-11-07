using EmmittJ.Terraform.Sdk;

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
        this.DeclareOutput("ids");
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ExecutableUsers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("executable_users");
        set => this.WithProperty("executable_users", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeDeprecated
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_deprecated");
        set => this.WithProperty("include_deprecated", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex");
        set => this.WithProperty("name_regex", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("owners");
        set => this.WithProperty("owners", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sort_ascending attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SortAscending
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sort_ascending");
        set => this.WithProperty("sort_ascending", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
