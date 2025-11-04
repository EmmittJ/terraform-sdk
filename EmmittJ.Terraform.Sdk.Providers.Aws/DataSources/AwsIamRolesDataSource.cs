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
        this.DeclareOutput("arns");
        this.DeclareOutput("names");
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
    /// The name_regex attribute.
    /// </summary>
    public string? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex")?.Value;
        set => this.WithProperty("name_regex", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public string? PathPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path_prefix")?.Value;
        set => this.WithProperty("path_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
