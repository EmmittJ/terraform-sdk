using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_users.
/// </summary>
public class AwsIamUsersDataSource : TerraformDataSource
{
    public AwsIamUsersDataSource(string name) : base("aws_iam_users", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arns");
        SetOutput("names");
        SetOutput("id");
        SetOutput("name_regex");
        SetOutput("path_prefix");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string> NameRegex
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_regex");
        set => SetProperty("name_regex", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformProperty<string> PathPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_prefix");
        set => SetProperty("path_prefix", value);
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
