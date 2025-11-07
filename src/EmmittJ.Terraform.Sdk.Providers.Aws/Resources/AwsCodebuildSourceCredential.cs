using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codebuild_source_credential resource.
/// </summary>
public class AwsCodebuildSourceCredential : TerraformResource
{
    public AwsCodebuildSourceCredential(string name) : base("aws_codebuild_source_credential", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_type");
        set => this.WithProperty("auth_type", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The server_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_type");
        set => this.WithProperty("server_type", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Token
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token");
        set => this.WithProperty("token", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
