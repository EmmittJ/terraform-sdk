using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_external_key resource.
/// </summary>
public class AwsKmsExternalKey : TerraformResource
{
    public AwsKmsExternalKey(string name) : base("aws_kms_external_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("expiration_model");
        this.DeclareOutput("key_state");
        this.DeclareOutput("key_usage");
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
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The key_material_base64 attribute.
    /// </summary>
    public string? KeyMaterialBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_material_base64")?.Value;
        set => this.WithProperty("key_material_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The valid_to attribute.
    /// </summary>
    public string? ValidTo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("valid_to")?.Value;
        set => this.WithProperty("valid_to", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    public TerraformExpression ExpirationModel => this["expiration_model"];

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformExpression KeyState => this["key_state"];

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformExpression KeyUsage => this["key_usage"];

}
