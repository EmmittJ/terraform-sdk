using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKmsKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_kms_key resource.
/// </summary>
public class AwsKmsKey : TerraformResource
{
    public AwsKmsKey(string name) : base("aws_kms_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("key_id");
        SetOutput("bypass_policy_lockout_safety_check");
        SetOutput("custom_key_store_id");
        SetOutput("customer_master_key_spec");
        SetOutput("deletion_window_in_days");
        SetOutput("description");
        SetOutput("enable_key_rotation");
        SetOutput("id");
        SetOutput("is_enabled");
        SetOutput("key_usage");
        SetOutput("multi_region");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("rotation_period_in_days");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("xks_key_id");
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    public TerraformProperty<bool> BypassPolicyLockoutSafetyCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bypass_policy_lockout_safety_check");
        set => SetProperty("bypass_policy_lockout_safety_check", value);
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomKeyStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_key_store_id");
        set => SetProperty("custom_key_store_id", value);
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformProperty<string> CustomerMasterKeySpec
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_master_key_spec");
        set => SetProperty("customer_master_key_spec", value);
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public TerraformProperty<double> DeletionWindowInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("deletion_window_in_days");
        set => SetProperty("deletion_window_in_days", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    public TerraformProperty<bool> EnableKeyRotation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_key_rotation");
        set => SetProperty("enable_key_rotation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_enabled");
        set => SetProperty("is_enabled", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformProperty<string> KeyUsage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_usage");
        set => SetProperty("key_usage", value);
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformProperty<bool> MultiRegion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_region");
        set => SetProperty("multi_region", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rotation_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RotationPeriodInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rotation_period_in_days");
        set => SetProperty("rotation_period_in_days", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The xks_key_id attribute.
    /// </summary>
    public TerraformProperty<string> XksKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xks_key_id");
        set => SetProperty("xks_key_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKmsKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformExpression KeyId => this["key_id"];

}
