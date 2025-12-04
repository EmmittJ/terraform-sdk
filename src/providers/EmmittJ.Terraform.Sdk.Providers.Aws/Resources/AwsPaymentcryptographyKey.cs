using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_attributes in AwsPaymentcryptographyKey.
/// Nesting mode: list
/// </summary>
public class AwsPaymentcryptographyKeyKeyAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_attributes";

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    public required TerraformValue<string> KeyAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// The key_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyClass is required")]
    public required TerraformValue<string> KeyClass
    {
        get => GetArgument<TerraformValue<string>>("key_class");
        set => SetArgument("key_class", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUsage is required")]
    public required TerraformValue<string> KeyUsage
    {
        get => GetArgument<TerraformValue<string>>("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// KeyModesOfUse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPaymentcryptographyKeyKeyAttributesBlockKeyModesOfUseBlock>? KeyModesOfUse
    {
        get => GetArgument<TerraformList<AwsPaymentcryptographyKeyKeyAttributesBlockKeyModesOfUseBlock>>("key_modes_of_use");
        set => SetArgument("key_modes_of_use", value);
    }

}

/// <summary>
/// Block type for key_modes_of_use in AwsPaymentcryptographyKeyKeyAttributesBlock.
/// Nesting mode: list
/// </summary>
public class AwsPaymentcryptographyKeyKeyAttributesBlockKeyModesOfUseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_modes_of_use";

    /// <summary>
    /// The decrypt attribute.
    /// </summary>
    public TerraformValue<bool>? Decrypt
    {
        get => GetArgument<TerraformValue<bool>>("decrypt");
        set => SetArgument("decrypt", value);
    }

    /// <summary>
    /// The derive_key attribute.
    /// </summary>
    public TerraformValue<bool>? DeriveKey
    {
        get => GetArgument<TerraformValue<bool>>("derive_key");
        set => SetArgument("derive_key", value);
    }

    /// <summary>
    /// The encrypt attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypt
    {
        get => GetArgument<TerraformValue<bool>>("encrypt");
        set => SetArgument("encrypt", value);
    }

    /// <summary>
    /// The generate attribute.
    /// </summary>
    public TerraformValue<bool>? Generate
    {
        get => GetArgument<TerraformValue<bool>>("generate");
        set => SetArgument("generate", value);
    }

    /// <summary>
    /// The no_restrictions attribute.
    /// </summary>
    public TerraformValue<bool>? NoRestrictions
    {
        get => GetArgument<TerraformValue<bool>>("no_restrictions");
        set => SetArgument("no_restrictions", value);
    }

    /// <summary>
    /// The sign attribute.
    /// </summary>
    public TerraformValue<bool>? Sign
    {
        get => GetArgument<TerraformValue<bool>>("sign");
        set => SetArgument("sign", value);
    }

    /// <summary>
    /// The unwrap attribute.
    /// </summary>
    public TerraformValue<bool>? Unwrap
    {
        get => GetArgument<TerraformValue<bool>>("unwrap");
        set => SetArgument("unwrap", value);
    }

    /// <summary>
    /// The verify attribute.
    /// </summary>
    public TerraformValue<bool>? Verify
    {
        get => GetArgument<TerraformValue<bool>>("verify");
        set => SetArgument("verify", value);
    }

    /// <summary>
    /// The wrap attribute.
    /// </summary>
    public TerraformValue<bool>? Wrap
    {
        get => GetArgument<TerraformValue<bool>>("wrap");
        set => SetArgument("wrap", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsPaymentcryptographyKey.
/// Nesting mode: single
/// </summary>
public class AwsPaymentcryptographyKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_paymentcryptography_key Terraform resource.
/// Manages a aws_paymentcryptography_key resource.
/// </summary>
public partial class AwsPaymentcryptographyKey(string name) : TerraformResource("aws_paymentcryptography_key", name)
{
    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public TerraformValue<double>? DeletionWindowInDays
    {
        get => GetArgument<TerraformValue<double>>("deletion_window_in_days");
        set => SetArgument("deletion_window_in_days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The exportable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exportable is required")]
    public required TerraformValue<bool> Exportable
    {
        get => GetArgument<TerraformValue<bool>>("exportable");
        set => SetArgument("exportable", value);
    }

    /// <summary>
    /// The key_check_value_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? KeyCheckValueAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("key_check_value_algorithm");
        set => SetArgument("key_check_value_algorithm", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The key_check_value attribute.
    /// </summary>
    public TerraformValue<string> KeyCheckValue
        => AsReference("key_check_value");

    /// <summary>
    /// The key_origin attribute.
    /// </summary>
    public TerraformValue<string> KeyOrigin
        => AsReference("key_origin");

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformValue<string> KeyState
        => AsReference("key_state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// KeyAttributes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPaymentcryptographyKeyKeyAttributesBlock>? KeyAttributes
    {
        get => GetArgument<TerraformList<AwsPaymentcryptographyKeyKeyAttributesBlock>>("key_attributes");
        set => SetArgument("key_attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsPaymentcryptographyKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsPaymentcryptographyKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
