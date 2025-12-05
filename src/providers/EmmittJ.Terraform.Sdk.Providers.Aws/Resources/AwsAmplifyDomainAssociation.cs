using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_settings in AwsAmplifyDomainAssociation.
/// Nesting mode: list
/// </summary>
public class AwsAmplifyDomainAssociationCertificateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_settings";

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    public TerraformValue<string> CertificateVerificationDnsRecord
        => CreateReference("certificate_verification_dns_record");

    /// <summary>
    /// The custom_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? CustomCertificateArn
    {
        get => GetArgument<TerraformValue<string>>("custom_certificate_arn");
        set => SetArgument("custom_certificate_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for sub_domain in AwsAmplifyDomainAssociation.
/// Nesting mode: set
/// </summary>
public class AwsAmplifyDomainAssociationSubDomainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sub_domain";

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformValue<string> BranchName
    {
        get => GetRequiredArgument<TerraformValue<string>>("branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// The dns_record attribute.
    /// </summary>
    public TerraformValue<string> DnsRecord
        => CreateReference("dns_record");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The verified attribute.
    /// </summary>
    public TerraformValue<bool> Verified
        => CreateReference("verified");

}


/// <summary>
/// Represents a aws_amplify_domain_association Terraform resource.
/// Manages a aws_amplify_domain_association resource.
/// </summary>
public partial class AwsAmplifyDomainAssociation(string name) : TerraformResource("aws_amplify_domain_association", name)
{
    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAutoSubDomain
    {
        get => GetArgument<TerraformValue<bool>>("enable_auto_sub_domain");
        set => SetArgument("enable_auto_sub_domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForVerification
    {
        get => GetArgument<TerraformValue<bool>>("wait_for_verification");
        set => SetArgument("wait_for_verification", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    public TerraformValue<string> CertificateVerificationDnsRecord
        => CreateReference("certificate_verification_dns_record");

    /// <summary>
    /// CertificateSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateSettings block(s) allowed")]
    public TerraformList<AwsAmplifyDomainAssociationCertificateSettingsBlock>? CertificateSettings
    {
        get => GetArgument<TerraformList<AwsAmplifyDomainAssociationCertificateSettingsBlock>>("certificate_settings");
        set => SetArgument("certificate_settings", value);
    }

    /// <summary>
    /// SubDomain block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubDomain is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubDomain block(s) required")]
    public required TerraformSet<AwsAmplifyDomainAssociationSubDomainBlock> SubDomain
    {
        get => GetRequiredArgument<TerraformSet<AwsAmplifyDomainAssociationSubDomainBlock>>("sub_domain");
        set => SetArgument("sub_domain", value);
    }

}
