using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_instance_profiles.
/// </summary>
public class AwsIamInstanceProfilesDataSource : TerraformDataSource
{
    public AwsIamInstanceProfilesDataSource(string name) : base("aws_iam_instance_profiles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arns");
        this.DeclareOutput("names");
        this.DeclareOutput("paths");
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
    /// The role_name attribute.
    /// </summary>
    public string? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name")?.Value;
        set => this.WithProperty("role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

    /// <summary>
    /// The paths attribute.
    /// </summary>
    public TerraformExpression Paths => this["paths"];

}
