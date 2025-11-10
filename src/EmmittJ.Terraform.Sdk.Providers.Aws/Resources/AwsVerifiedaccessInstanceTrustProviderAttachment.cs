using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_instance_trust_provider_attachment resource.
/// </summary>
public class AwsVerifiedaccessInstanceTrustProviderAttachment : TerraformResource
{
    public AwsVerifiedaccessInstanceTrustProviderAttachment(string name) : base("aws_verifiedaccess_instance_trust_provider_attachment", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformProperty<string> VerifiedaccessInstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => this.WithProperty("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// The verifiedaccess_trust_provider_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessTrustProviderId is required")]
    public required TerraformProperty<string> VerifiedaccessTrustProviderId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("verifiedaccess_trust_provider_id");
        set => this.WithProperty("verifiedaccess_trust_provider_id", value);
    }

}
