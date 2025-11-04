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
    public List<string>? ExecutableUsers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("executable_users")?.Value;
        set => this.WithProperty("executable_users", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    public bool? IncludeDeprecated
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_deprecated")?.Value;
        set => this.WithProperty("include_deprecated", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public string? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex")?.Value;
        set => this.WithProperty("name_regex", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public List<string>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("owners")?.Value;
        set => this.WithProperty("owners", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sort_ascending attribute.
    /// </summary>
    public bool? SortAscending
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sort_ascending")?.Value;
        set => this.WithProperty("sort_ascending", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
