using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_key_policy resource.
/// </summary>
public class AwsKmsKeyPolicy : TerraformResource
{
    public AwsKmsKeyPolicy(string name) : base("aws_kms_key_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
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

}
