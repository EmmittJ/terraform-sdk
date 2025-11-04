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
    /// The public_key attribute.
    /// </summary>
    public string? PublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key")?.Value;
        set => this.WithProperty("public_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ssh_public_key_id attribute.
    /// </summary>
    public TerraformExpression SshPublicKeyId => this["ssh_public_key_id"];

}
