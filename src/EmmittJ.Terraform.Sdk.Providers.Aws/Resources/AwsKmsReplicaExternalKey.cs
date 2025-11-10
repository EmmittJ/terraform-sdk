using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_replica_external_key resource.
/// </summary>
public class AwsKmsReplicaExternalKey : TerraformResource
{
    public AwsKmsReplicaExternalKey(string name) : base("aws_kms_replica_external_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("expiration_model");
        this.DeclareOutput("key_id");
        this.DeclareOutput("key_state");
        this.DeclareOutput("key_usage");
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
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The key_material_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? KeyMaterialBase64
    {
        get => GetProperty<TerraformProperty<string>>("key_material_base64");
        set => this.WithProperty("key_material_base64", value);
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
    /// The primary_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKeyArn is required")]
    public required TerraformProperty<string> PrimaryKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("primary_key_arn");
        set => this.WithProperty("primary_key_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    public TerraformProperty<string>? ValidTo
    {
        get => GetProperty<TerraformProperty<string>>("valid_to");
        set => this.WithProperty("valid_to", value);
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
    /// The key_id attribute.
    /// </summary>
    public TerraformExpression KeyId => this["key_id"];

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformExpression KeyState => this["key_state"];

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformExpression KeyUsage => this["key_usage"];

}
