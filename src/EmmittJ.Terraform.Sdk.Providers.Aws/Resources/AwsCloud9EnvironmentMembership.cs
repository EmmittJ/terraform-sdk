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
    public TerraformLiteralProperty<string>? EnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
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
    /// The permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permissions");
        set => this.WithProperty("permissions", value);
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
    /// The user_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_arn");
        set => this.WithProperty("user_arn", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
