using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_roles.
/// </summary>
public class AwsIamRolesDataSource : TerraformDataSource
{
    public AwsIamRolesDataSource(string name) : base("aws_iam_roles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arns");
        this.WithOutput("names");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string>? NameRegex
    {
        get => GetProperty<TerraformProperty<string>>("name_regex");
        set => this.WithProperty("name_regex", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? PathPrefix
    {
        get => GetProperty<TerraformProperty<string>>("path_prefix");
        set => this.WithProperty("path_prefix", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
