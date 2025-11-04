using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_user_ssh_key.
/// </summary>
public class AwsIamUserSshKeyDataSource : TerraformDataSource
{
    public AwsIamUserSshKeyDataSource(string name) : base("aws_iam_user_ssh_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("public_key");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public string? Encoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding")?.Value;
        set => this.WithProperty("encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ssh_public_key_id attribute.
    /// </summary>
    public string? SshPublicKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssh_public_key_id")?.Value;
        set => this.WithProperty("ssh_public_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
