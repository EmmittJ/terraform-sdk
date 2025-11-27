using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSecretManagerSecretVersion.
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerSecretVersionTimeoutsBlock : TerraformBlock
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
/// Represents a google_secret_manager_secret_version Terraform resource.
/// Manages a google_secret_manager_secret_version resource.
/// </summary>
public partial class GoogleSecretManagerSecretVersion(string name) : TerraformResource("google_secret_manager_secret_version", name)
{
    /// <summary>
    /// The deletion policy for the secret version. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned rather than deleted. Setting &#39;DISABLE&#39; allows the resource to be
    /// disabled rather than deleted. Default is &#39;DELETE&#39;. Possible values are:
    ///   * DELETE
    ///   * DISABLE
    ///   * ABANDON
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The current state of the SecretVersion.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    public TerraformValue<bool>? IsSecretDataBase64
    {
        get => new TerraformReference<bool>(this, "is_secret_data_base64");
        set => SetArgument("is_secret_data_base64", value);
    }

    /// <summary>
    /// Secret Manager secret resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    public TerraformValue<string>? SecretData
    {
        get => new TerraformReference<string>(this, "secret_data");
        set => SetArgument("secret_data", value);
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformValue<string>? SecretDataWo
    {
        get => new TerraformReference<string>(this, "secret_data_wo");
        set => SetArgument("secret_data_wo", value);
    }

    /// <summary>
    /// Triggers update of secret data write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformValue<double>? SecretDataWoVersion
    {
        get => new TerraformReference<double>(this, "secret_data_wo_version");
        set => SetArgument("secret_data_wo_version", value);
    }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The time at which the Secret was destroyed. Only present if state is DESTROYED.
    /// </summary>
    public TerraformValue<string> DestroyTime
    {
        get => new TerraformReference<string>(this, "destroy_time");
    }

    /// <summary>
    /// The resource name of the SecretVersion. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The version of the Secret.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecretManagerSecretVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecretManagerSecretVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
