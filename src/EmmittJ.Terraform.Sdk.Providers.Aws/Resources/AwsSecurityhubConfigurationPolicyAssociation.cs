using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_configuration_policy_association resource.
/// </summary>
public class AwsSecurityhubConfigurationPolicyAssociation : TerraformResource
{
    public AwsSecurityhubConfigurationPolicyAssociation(string name) : base("aws_securityhub_configuration_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The universally unique identifier (UUID) of the configuration policy.
    /// </summary>
    public TerraformProperty<string>? PolicyId
    {
        get => GetProperty<TerraformProperty<string>>("policy_id");
        set => this.WithProperty("policy_id", value);
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
    /// The identifier of the target account, organizational unit, or the root to associate with the specified configuration.
    /// </summary>
    public TerraformProperty<string>? TargetId
    {
        get => GetProperty<TerraformProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

}
