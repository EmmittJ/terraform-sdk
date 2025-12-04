using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_verifiedaccess_instance_trust_provider_attachment Terraform resource.
/// Manages a aws_verifiedaccess_instance_trust_provider_attachment resource.
/// </summary>
public partial class AwsVerifiedaccessInstanceTrustProviderAttachment(string name) : TerraformResource("aws_verifiedaccess_instance_trust_provider_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformValue<string> VerifiedaccessInstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("verifiedaccess_instance_id");
        set => SetArgument("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// The verifiedaccess_trust_provider_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessTrustProviderId is required")]
    public required TerraformValue<string> VerifiedaccessTrustProviderId
    {
        get => GetRequiredArgument<TerraformValue<string>>("verifiedaccess_trust_provider_id");
        set => SetArgument("verifiedaccess_trust_provider_id", value);
    }

}
