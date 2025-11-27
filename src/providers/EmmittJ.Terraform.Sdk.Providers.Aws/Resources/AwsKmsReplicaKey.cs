using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_replica_key Terraform resource.
/// Manages a aws_kms_replica_key resource.
/// </summary>
public partial class AwsKmsReplicaKey(string name) : TerraformResource("aws_kms_replica_key", name)
{
    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    public TerraformValue<bool>? BypassPolicyLockoutSafetyCheck
    {
        get => new TerraformReference<bool>(this, "bypass_policy_lockout_safety_check");
        set => SetArgument("bypass_policy_lockout_safety_check", value);
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public TerraformValue<double>? DeletionWindowInDays
    {
        get => new TerraformReference<double>(this, "deletion_window_in_days");
        set => SetArgument("deletion_window_in_days", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
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
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The primary_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKeyArn is required")]
    public required TerraformValue<string> PrimaryKeyArn
    {
        get => new TerraformReference<string>(this, "primary_key_arn");
        set => SetArgument("primary_key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
    }

    /// <summary>
    /// The key_rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> KeyRotationEnabled
    {
        get => new TerraformReference<bool>(this, "key_rotation_enabled");
    }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    public TerraformValue<string> KeySpec
    {
        get => new TerraformReference<string>(this, "key_spec");
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
    {
        get => new TerraformReference<string>(this, "key_usage");
    }

}
