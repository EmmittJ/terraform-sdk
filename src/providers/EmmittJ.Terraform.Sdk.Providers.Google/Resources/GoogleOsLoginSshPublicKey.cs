using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleOsLoginSshPublicKey.
/// Nesting mode: single
/// </summary>
public class GoogleOsLoginSshPublicKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_os_login_ssh_public_key Terraform resource.
/// Manages a google_os_login_ssh_public_key resource.
/// </summary>
public partial class GoogleOsLoginSshPublicKey(string name) : TerraformResource("google_os_login_ssh_public_key", name)
{
    /// <summary>
    /// An expiration time in microseconds since epoch.
    /// </summary>
    public TerraformValue<string>? ExpirationTimeUsec
    {
        get => new TerraformReference<string>(this, "expiration_time_usec");
        set => SetArgument("expiration_time_usec", value);
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
    /// Public key text in SSH format, defined by RFC4253 section 6.6.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The project ID of the Google Cloud Platform project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user email.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The SHA-256 fingerprint of the SSH public key.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOsLoginSshPublicKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOsLoginSshPublicKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
