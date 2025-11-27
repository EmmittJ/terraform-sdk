using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_user_ssh_key Terraform data source.
/// Retrieves information about a aws_iam_user_ssh_key.
/// </summary>
public partial class AwsIamUserSshKeyDataSource(string name) : TerraformDataSource("aws_iam_user_ssh_key", name)
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    public required TerraformValue<string> Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ssh_public_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeyId is required")]
    public required TerraformValue<string> SshPublicKeyId
    {
        get => new TerraformReference<string>(this, "ssh_public_key_id");
        set => SetArgument("ssh_public_key_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
