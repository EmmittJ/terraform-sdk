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
    public bool? BypassPolicyLockoutSafetyCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_policy_lockout_safety_check")?.Value;
        set => this.WithProperty("bypass_policy_lockout_safety_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public string? CustomKeyStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_id")?.Value;
        set => this.WithProperty("custom_key_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public string? CustomerMasterKeySpec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_master_key_spec")?.Value;
        set => this.WithProperty("customer_master_key_spec", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    public double? DeletionWindowInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("deletion_window_in_days")?.Value;
        set => this.WithProperty("deletion_window_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    public bool? EnableKeyRotation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_key_rotation")?.Value;
        set => this.WithProperty("enable_key_rotation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    public bool? IsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_enabled")?.Value;
        set => this.WithProperty("is_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public string? KeyUsage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_usage")?.Value;
        set => this.WithProperty("key_usage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public bool? MultiRegion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_region")?.Value;
        set => this.WithProperty("multi_region", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rotation_period_in_days attribute.
    /// </summary>
    public double? RotationPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rotation_period_in_days")?.Value;
        set => this.WithProperty("rotation_period_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The xks_key_id attribute.
    /// </summary>
    public string? XksKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_key_id")?.Value;
        set => this.WithProperty("xks_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
