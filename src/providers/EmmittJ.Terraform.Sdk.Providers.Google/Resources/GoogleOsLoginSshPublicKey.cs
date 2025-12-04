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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("expiration_time_usec");
        set => SetArgument("expiration_time_usec", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Public key text in SSH format, defined by RFC4253 section 6.6.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The project ID of the Google Cloud Platform project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user email.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => GetArgument<TerraformValue<string>>("user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The SHA-256 fingerprint of the SSH public key.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOsLoginSshPublicKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOsLoginSshPublicKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
