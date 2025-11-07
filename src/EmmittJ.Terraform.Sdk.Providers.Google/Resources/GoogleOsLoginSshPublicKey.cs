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
    public TerraformProperty<string>? ExpirationTimeUsec
    {
        get => GetProperty<TerraformProperty<string>>("expiration_time_usec");
        set => this.WithProperty("expiration_time_usec", value);
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
    /// Public key text in SSH format, defined by RFC4253 section 6.6.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The project ID of the Google Cloud Platform project.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The user email.
    /// </summary>
    public TerraformProperty<string>? User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

    /// <summary>
    /// The SHA-256 fingerprint of the SSH public key.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

}
