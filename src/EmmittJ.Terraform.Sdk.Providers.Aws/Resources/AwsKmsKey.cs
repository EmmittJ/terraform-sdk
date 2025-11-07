using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("key_id");
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    public TerraformProperty<bool>? BypassPolicyLockoutSafetyCheck
    {
        get => GetProperty<TerraformProperty<bool>>("bypass_policy_lockout_safety_check");
        set => this.WithProperty("bypass_policy_lockout_safety_check", value);
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomKeyStoreId
    {
        get => GetProperty<TerraformProperty<string>>("custom_key_store_id");
        set => this.WithProperty("custom_key_store_id", value);
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerMasterKeySpec
    {
        get => GetProperty<TerraformProperty<string>>("customer_master_key_spec");
        set => this.WithProperty("customer_master_key_spec", value);
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? DeletionWindowInDays
    {
        get => GetProperty<TerraformProperty<double>>("deletion_window_in_days");
        set => this.WithProperty("deletion_window_in_days", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableKeyRotation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_key_rotation");
        set => this.WithProperty("enable_key_rotation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_enabled");
        set => this.WithProperty("is_enabled", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformProperty<string>? KeyUsage
    {
        get => GetProperty<TerraformProperty<string>>("key_usage");
        set => this.WithProperty("key_usage", value);
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiRegion
    {
        get => GetProperty<TerraformProperty<bool>>("multi_region");
        set => this.WithProperty("multi_region", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rotation_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RotationPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("rotation_period_in_days");
        set => this.WithProperty("rotation_period_in_days", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The xks_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? XksKeyId
    {
        get => GetProperty<TerraformProperty<string>>("xks_key_id");
        set => this.WithProperty("xks_key_id", value);
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
