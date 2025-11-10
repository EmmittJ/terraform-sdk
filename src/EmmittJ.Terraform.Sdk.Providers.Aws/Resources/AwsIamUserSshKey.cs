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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformProperty<string> Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformProperty<string> PublicKey
    {
        get => GetProperty<TerraformProperty<string>>("public_key");
        set => this.WithProperty("public_key", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
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
