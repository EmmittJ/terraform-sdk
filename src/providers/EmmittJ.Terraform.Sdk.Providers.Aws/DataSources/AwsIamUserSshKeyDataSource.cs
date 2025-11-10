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
        SetOutput("fingerprint");
        SetOutput("public_key");
        SetOutput("status");
        SetOutput("encoding");
        SetOutput("id");
        SetOutput("ssh_public_key_id");
        SetOutput("username");
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformProperty<string> Encoding
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encoding");
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ssh_public_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeyId is required")]
    public required TerraformProperty<string> SshPublicKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssh_public_key_id");
        set => SetProperty("ssh_public_key_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
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
