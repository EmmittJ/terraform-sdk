using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsKmsKey.
/// Nesting mode: single
/// </summary>
public class AwsKmsKeyTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_kms_key Terraform resource.
/// Manages a aws_kms_key resource.
/// </summary>
public partial class AwsKmsKey(string name) : TerraformResource("aws_kms_key", name)
{
    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    public TerraformValue<bool>? BypassPolicyLockoutSafetyCheck
    {
        get => GetArgument<TerraformValue<bool>>("bypass_policy_lockout_safety_check");
        set => SetArgument("bypass_policy_lockout_safety_check", value);
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomKeyStoreId
    {
        get => GetArgument<TerraformValue<string>>("custom_key_store_id");
        set => SetArgument("custom_key_store_id", value);
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformValue<string>? CustomerMasterKeySpec
    {
        get => GetArgument<TerraformValue<string>>("customer_master_key_spec");
        set => SetArgument("customer_master_key_spec", value);
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public TerraformValue<double>? DeletionWindowInDays
    {
        get => GetArgument<TerraformValue<double>>("deletion_window_in_days");
        set => SetArgument("deletion_window_in_days", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    public TerraformValue<bool>? EnableKeyRotation
    {
        get => GetArgument<TerraformValue<bool>>("enable_key_rotation");
        set => SetArgument("enable_key_rotation", value);
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
    /// The is_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_enabled");
        set => SetArgument("is_enabled", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string>? KeyUsage
    {
        get => GetArgument<TerraformValue<string>>("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformValue<bool>? MultiRegion
    {
        get => GetArgument<TerraformValue<bool>>("multi_region");
        set => SetArgument("multi_region", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
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
    /// The rotation_period_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RotationPeriodInDays
    {
        get => GetArgument<TerraformValue<double>>("rotation_period_in_days");
        set => SetArgument("rotation_period_in_days", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The xks_key_id attribute.
    /// </summary>
    public TerraformValue<string>? XksKeyId
    {
        get => GetArgument<TerraformValue<string>>("xks_key_id");
        set => SetArgument("xks_key_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformValue<string> KeyId
        => AsReference("key_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKmsKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKmsKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
