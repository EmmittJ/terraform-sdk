using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloud9_environment_membership resource.
/// </summary>
public class AwsCloud9EnvironmentMembership : TerraformResource
{
    public AwsCloud9EnvironmentMembership(string name) : base("aws_cloud9_environment_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("user_id");
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public string? EnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_id")?.Value;
        set => this.WithProperty("environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The permissions attribute.
    /// </summary>
    public string? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permissions")?.Value;
        set => this.WithProperty("permissions", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_arn attribute.
    /// </summary>
    public string? UserArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_arn")?.Value;
        set => this.WithProperty("user_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
