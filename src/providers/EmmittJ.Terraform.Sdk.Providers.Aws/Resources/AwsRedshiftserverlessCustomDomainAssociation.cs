using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_custom_domain_association Terraform resource.
/// Manages a aws_redshiftserverless_custom_domain_association resource.
/// </summary>
public partial class AwsRedshiftserverlessCustomDomainAssociation(string name) : TerraformResource("aws_redshiftserverless_custom_domain_association", name)
{
    /// <summary>
    /// The custom_domain_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainCertificateArn is required")]
    public required TerraformValue<string> CustomDomainCertificateArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_domain_certificate_arn");
        set => SetArgument("custom_domain_certificate_arn", value);
    }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainName is required")]
    public required TerraformValue<string> CustomDomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_domain_name");
        set => SetArgument("custom_domain_name", value);
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
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The custom_domain_certificate_expiry_time attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainCertificateExpiryTime
        => AsReference("custom_domain_certificate_expiry_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
