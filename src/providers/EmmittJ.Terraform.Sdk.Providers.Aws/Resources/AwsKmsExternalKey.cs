using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_external_key Terraform resource.
/// Manages a aws_kms_external_key resource.
/// </summary>
public partial class AwsKmsExternalKey(string name) : TerraformResource("aws_kms_external_key", name)
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
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? AsReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_material_base64 attribute.
    /// </summary>
    public TerraformValue<string>? KeyMaterialBase64
    {
        get => GetArgument<TerraformValue<string>>("key_material_base64");
        set => SetArgument("key_material_base64", value);
    }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    public TerraformValue<string> KeySpec
    {
        get => GetArgument<TerraformValue<string>>("key_spec") ?? AsReference("key_spec");
        set => SetArgument("key_spec", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
    {
        get => GetArgument<TerraformValue<string>>("key_usage") ?? AsReference("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformValue<bool> MultiRegion
    {
        get => GetArgument<TerraformValue<bool>>("multi_region") ?? AsReference("multi_region");
        set => SetArgument("multi_region", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    public TerraformValue<string>? ValidTo
    {
        get => GetArgument<TerraformValue<string>>("valid_to");
        set => SetArgument("valid_to", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    public TerraformValue<string> ExpirationModel
        => AsReference("expiration_model");

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformValue<string> KeyState
        => AsReference("key_state");

}
