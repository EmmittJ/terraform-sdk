using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_os_login_ssh_public_key resource.
/// </summary>
public class GoogleOsLoginSshPublicKey : TerraformResource
{
    public GoogleOsLoginSshPublicKey(string name) : base("google_os_login_ssh_public_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fingerprint");
    }

    /// <summary>
    /// An expiration time in microseconds since epoch.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpirationTimeUsec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_time_usec");
        set => this.WithProperty("expiration_time_usec", value);
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
    /// Public key text in SSH format, defined by RFC4253 section 6.6.
    /// </summary>
    public TerraformLiteralProperty<string>? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The project ID of the Google Cloud Platform project.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The user email.
    /// </summary>
    public TerraformLiteralProperty<string>? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

    /// <summary>
    /// The SHA-256 fingerprint of the SSH public key.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

}
