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
    /// The ssh_public_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeyId is required")]
    public required TerraformProperty<string> SshPublicKeyId
    {
        get => GetProperty<TerraformProperty<string>>("ssh_public_key_id");
        set => this.WithProperty("ssh_public_key_id", value);
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
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
