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
        SetOutput("bypass_policy_lockout_safety_check");
        SetOutput("id");
        SetOutput("key_id");
        SetOutput("policy");
        SetOutput("region");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_id");
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
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

}
