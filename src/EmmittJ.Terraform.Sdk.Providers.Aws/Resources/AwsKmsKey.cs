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
    public TerraformLiteralProperty<bool>? BypassPolicyLockoutSafetyCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_policy_lockout_safety_check");
        set => this.WithProperty("bypass_policy_lockout_safety_check", value);
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomKeyStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_id");
        set => this.WithProperty("custom_key_store_id", value);
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerMasterKeySpec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_master_key_spec");
        set => this.WithProperty("customer_master_key_spec", value);
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DeletionWindowInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deletion_window_in_days");
        set => this.WithProperty("deletion_window_in_days", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableKeyRotation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_key_rotation");
        set => this.WithProperty("enable_key_rotation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_enabled");
        set => this.WithProperty("is_enabled", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyUsage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_usage");
        set => this.WithProperty("key_usage", value);
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultiRegion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_region");
        set => this.WithProperty("multi_region", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rotation_period_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RotationPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rotation_period_in_days");
        set => this.WithProperty("rotation_period_in_days", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The xks_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XksKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_key_id");
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
