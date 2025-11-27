using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleStorageHmacKey.
/// Nesting mode: single
/// </summary>
public class GoogleStorageHmacKeyTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_hmac_key Terraform resource.
/// Manages a google_storage_hmac_key resource.
/// </summary>
public partial class GoogleStorageHmacKey(string name) : TerraformResource("google_storage_hmac_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The email address of the key&#39;s associated service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => new TerraformReference<string>(this, "service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// The state of the key. Can be set to one of ACTIVE, INACTIVE. Default value: &amp;quot;ACTIVE&amp;quot; Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;INACTIVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The access ID of the HMAC Key.
    /// </summary>
    public TerraformValue<string> AccessId
    {
        get => new TerraformReference<string>(this, "access_id");
    }

    /// <summary>
    /// HMAC secret key material.
    /// </summary>
    public TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
    }

    /// <summary>
    /// &#39;The creation time of the HMAC key in RFC 3339 format. &#39;
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// &#39;The last modification time of the HMAC key metadata in RFC 3339 format.&#39;
    /// </summary>
    public TerraformValue<string> Updated
    {
        get => new TerraformReference<string>(this, "updated");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageHmacKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageHmacKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
