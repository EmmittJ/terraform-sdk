using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for key_data in GoogleIamWorkforcePoolProviderKey.
/// Nesting mode: list
/// </summary>
public class GoogleIamWorkforcePoolProviderKeyKeyDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_data";

    /// <summary>
    /// The format of the key.
    /// </summary>
    public TerraformValue<string> Format
        => CreateReference("format");

    /// <summary>
    /// The key data. The format of the key is represented by the format field.
    /// </summary>
    public TerraformValue<string> Key
        => CreateReference("key");

    /// <summary>
    /// The specifications for the key. Possible values: [&amp;quot;RSA_2048&amp;quot;, &amp;quot;RSA_3072&amp;quot;, &amp;quot;RSA_4096&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeySpec is required")]
    public required TerraformValue<string> KeySpec
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_spec");
        set => SetArgument("key_spec", value);
    }

    /// <summary>
    /// Latest timestamp when this key is valid. Attempts to use this key after this time will fail.
    /// Only present if the key data represents a X.509 certificate.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string> NotAfterTime
        => CreateReference("not_after_time");

    /// <summary>
    /// Earliest timestamp when this key is valid. Attempts to use this key before this time will fail.
    /// Only present if the key data represents a X.509 certificate.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string> NotBeforeTime
        => CreateReference("not_before_time");

}


/// <summary>
/// Block type for timeouts in GoogleIamWorkforcePoolProviderKey.
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolProviderKeyTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_iam_workforce_pool_provider_key Terraform resource.
/// Manages a google_iam_workforce_pool_provider_key resource.
/// </summary>
public partial class GoogleIamWorkforcePoolProviderKey(string name) : TerraformResource("google_iam_workforce_pool_provider_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID to use for the key, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    public required TerraformValue<string> ProviderId
    {
        get => GetRequiredArgument<TerraformValue<string>>("provider_id");
        set => SetArgument("provider_id", value);
    }

    /// <summary>
    /// The purpose of the key. Possible values: [&amp;quot;ENCRYPTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Use is required")]
    public required TerraformValue<string> Use
    {
        get => GetRequiredArgument<TerraformValue<string>>("use");
        set => SetArgument("use", value);
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformValue<string> WorkforcePoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workforce_pool_id");
        set => SetArgument("workforce_pool_id", value);
    }

    /// <summary>
    /// The time after which the key will be permanently deleted and cannot be recovered.
    /// Note that the key may get purged before this time if the total limit of keys per provider is exceeded.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => CreateReference("expire_time");

    /// <summary>
    /// Identifier. The resource name of the key.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}/providers/{providerId}/keys/{keyId}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The state of the key.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// KeyData block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyData block(s) allowed")]
    public required TerraformList<GoogleIamWorkforcePoolProviderKeyKeyDataBlock> KeyData
    {
        get => GetRequiredArgument<TerraformList<GoogleIamWorkforcePoolProviderKeyKeyDataBlock>>("key_data");
        set => SetArgument("key_data", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamWorkforcePoolProviderKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamWorkforcePoolProviderKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
