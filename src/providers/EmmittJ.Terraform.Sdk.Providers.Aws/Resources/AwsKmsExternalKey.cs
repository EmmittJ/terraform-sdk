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
        SetOutput("arn");
        SetOutput("expiration_model");
        SetOutput("key_state");
        SetOutput("bypass_policy_lockout_safety_check");
        SetOutput("deletion_window_in_days");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("key_material_base64");
        SetOutput("key_spec");
        SetOutput("key_usage");
        SetOutput("multi_region");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("valid_to");
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
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The key_material_base64 attribute.
    /// </summary>
    public TerraformProperty<string> KeyMaterialBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_material_base64");
        set => SetProperty("key_material_base64", value);
    }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    public TerraformProperty<string> KeySpec
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_spec");
        set => SetProperty("key_spec", value);
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
    /// The valid_to attribute.
    /// </summary>
    public TerraformProperty<string> ValidTo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("valid_to");
        set => SetProperty("valid_to", value);
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

}
