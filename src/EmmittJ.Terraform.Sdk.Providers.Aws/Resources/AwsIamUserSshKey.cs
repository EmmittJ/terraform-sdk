using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_ssh_key resource.
/// </summary>
public class AwsIamUserSshKey : TerraformResource
{
    public AwsIamUserSshKey(string name) : base("aws_iam_user_ssh_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("ssh_public_key_id");
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Encoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
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
    /// The public_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key");
        set => this.WithProperty("public_key", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The ssh_public_key_id attribute.
    /// </summary>
    public TerraformExpression SshPublicKeyId => this["ssh_public_key_id"];

}
