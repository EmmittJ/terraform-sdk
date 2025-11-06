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
    public string? ExpirationTimeUsec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_time_usec")?.Value;
        set => this.WithProperty("expiration_time_usec", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Public key text in SSH format, defined by RFC4253 section 6.6.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project ID of the Google Cloud Platform project.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user email.
    /// </summary>
    public string? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user")?.Value;
        set => this.WithProperty("user", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The SHA-256 fingerprint of the SSH public key.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

}
