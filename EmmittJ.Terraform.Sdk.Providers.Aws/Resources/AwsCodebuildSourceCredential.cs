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
    public string? AuthType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_type")?.Value;
        set => this.WithProperty("auth_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The server_type attribute.
    /// </summary>
    public string? ServerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_type")?.Value;
        set => this.WithProperty("server_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public string? Token
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token")?.Value;
        set => this.WithProperty("token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
